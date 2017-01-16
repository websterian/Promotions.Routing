// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateSitecorePromotions.cs" company="">
// </copyright>
// <summary>
//   Create Sitecore Promotions class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Sitecore.Commerce.Dynamics.Promotions.Endpoint.Processors
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Sitecore.Commerce.Dynamics.Promotions.Endpoint.Models;
    using Sitecore.Commerce.Dynamics.Promotions.Endpoint.PromotionService;
    using Sitecore.Commerce.Routing.Contexts;
    using Sitecore.Commerce.Routing.Processors;
    using Sitecore.Commerce.Routing.Providers.SitecoreWebApi;
    using Sitecore.Commerce.Routing.Providers.SitecoreWebApi.Endpoints;
    using Sitecore.Services.Core.Model;

    using DateTime = System.DateTime;

    // using Sitecore.Commerce.Common.Telemetry;

    /// <summary>
    ///     Create Sitecore Promotions class
    /// </summary>
    public class CreateSitecorePromotions : BaseProcessor
    {
        private string _campaignGroupId = string.Empty;
        private readonly List<ItemModel> _createdPromotionLines = new List<ItemModel>();
        private readonly List<ItemModel> _createdPromotions = new List<ItemModel>();
        private readonly Stopwatch _masterStopWatch = new Stopwatch();
        private readonly Stopwatch _stopwatch = new Stopwatch();

        private static RouteContext _routeContext;

        private const string EndPointsPath = "/sitecore/Commerce/Dynamics Routing Extensions/Commerce Endpoints";

        private const string CampaignGroupPath = "Campaign group path";
        private const string CampaignPath = "Campaign path";

        private const string CampaignGroupTemplateId = "7CC96707-325D-4024-9F58-B10CE1F950D1";
        private const string CampaignTemplateId = "{94FD1606-139E-46EE-86FF-BC5BF3C79804}";
        private const string PromotionLineTemplateId = "305AA41F-E88C-4D60-8ABF-0C1F4E28B285";
        private const string PromotionTemplateId = "FC275CC8-8DF0-44EE-9CC3-81C61B0E0EBC";
        private const string AnalyticsWorkflowId = "{689E2994-4656-4C58-9112-7826CB46EE69}";
        private const string AnalyticsWorkflowStateId = "{39156DC0-21C6-4F64-B641-31E85C8F5DFE}";
        private const string MarketingsFacetsTemplateId = "{68B0CF3C-9150-4DB7-ACAB-F626E59BCA6D}";

        private const string ChannelId = "Channel id";
        private const string CompanyId = "Company id";
        private const string Concurrency = "Concurrency";
        private const string Currency = "Currency";
        private const string Description = "Description";
        private const string Disclaimer = "Disclaimer";
        private const string DiscountType = "Discount type";
        private const string DiscountValue = "Discount value";
        private const string Domain = "Domain";
        private const string DynamicsPromotionsCampaigns = "Dynamics promotions";
        private const string EndDate = "End date";
        private const string EndpointConfigurationName = "NetTcpBinding_SCPromotionService";
        private const string ItemId = "ItemID";
        private const string ItemName = "ItemName";
        private const string Name = "Name";
        private const string Partition = "Partition";
        private const string Password = "Password";
        private const string PriceDiscount = "Price discount";
        private const string Product = "Product";
        private const string Promotion = "Promotion";
        private const string PromotionLines = "Promotion lines";
        private const string StartDate = "Start date";
        private const string TemplateId = "TemplateID";
        private const string TemplateName = "TemplateName";
        private const string Title = "Title";
        private const string Type = "Type";
        private const string Url = "URL";
        private const string Username = "Username";
        private const string CampaignGroup = "Campaign group";
        private const string MarketingFacetsPath = "Marketing facets path";
        private const string ProductsPath = "Products path";
        private const string PromotionLinesPath = "Promotion lines path";
        private const string PromotionsPath = "Promotions path";

        private const string DynamicsEndPointTemplate = "Commerce Endpoint - Dynamics Promotion service";
        private const string Workflow = "__Workflow";
        private const string WorkflowState = "__Workflow state";
        

        /// <summary>
        /// Processes the specified route context.
        /// </summary>
        /// <param name="routeContext">
        /// The route context.
        /// </param>
        public override void Process(RouteContext routeContext)
        {
            _routeContext = routeContext;
            try
            {
                this._masterStopWatch.Start();

                var endPoints = GetDynamicsPromotionEndPoints();

                foreach (var endPoint in endPoints.FindAll(
                    x => x[TemplateName].ToString().Contains(DynamicsEndPointTemplate)).Select(GetDynamicsEndPoint))
                {
                    this.ProcessEndPoints(endPoint);
                }
            }
            catch(Exception e)
            {
                Log($"The process failed : {e.Message}", ConsoleColor.Red);
                throw;
            }
        }
        
        private void ProcessEndPoints(DynamicsEndPoint endPoint)
        {
            this.ProcessPromotions(endPoint);

            Log($"Finding Sitecore products at path {endPoint.ProductsPath} ...", ConsoleColor.Yellow);
            this._stopwatch.Restart();
            var items = GetItemsFromPath(endPoint.ProductsPath);

            var foundProducts = items.FindAll(x => x[TemplateName].ToString().Contains(Product));

            const int PageSize = 20;
            var itemList = new List<string>();
            var currentCount = 0;

            var itemCount = foundProducts.Count;
            var itemsProcessed = 0;
            Log($"Found {itemCount} products in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);

            foreach (var product in foundProducts)
            {
                itemList.Add(product[ItemName].ToString());
                currentCount++;

                if (currentCount == PageSize || (itemsProcessed + currentCount == itemCount))
                {
                    this.ProcessPromotionLines(itemList, endPoint);
                    itemList = new List<string>();
                    itemsProcessed += currentCount;
                    currentCount = 0;
                }
            }

            // Link the lines to the product
            this.ProcessPromotionLineRelationshipForProduct(foundProducts);

            // Link the lines to the header
            this.ProcessPromotionLineRelationshipForHeader();

            this.ProcessCampaignGroup(endPoint);

            this.ProcessMarketingFacets(endPoint);

            this.ProcessCampaign(endPoint);

            this._masterStopWatch.Stop();

            Log($"Process completed in {GetElapsedTimeAsString(this._masterStopWatch)} seconds");
        }

        private void ProcessPromotionLineRelationshipForProduct(IEnumerable<ItemModel> foundProducts)
        {
            Log("Creating promotion line to product relationships...", ConsoleColor.Yellow);
            this._stopwatch.Restart();
            foreach (var product in foundProducts)
            {
                Log($"Setting relationship to product {product[ItemName]}");

                var productPromotionLines 
                    = this._createdPromotionLines.FindAll(x => x[Product].ToString().ToUpper() == "{" + product[ItemId].ToString().ToUpper() +"}");

                if (productPromotionLines != null)
                {
                    var valueList = productPromotionLines.Aggregate(
                        string.Empty,
                        (current, promotionLine) =>
                        current + ("{" + promotionLine[ItemId].ToString().ToUpper() + "}|"));

                    product[PromotionLines] = valueList;

                    UpdateItemModel(product);
                }
            }

            this._stopwatch.Stop();
            Log($"Creating promotion line to product relationships completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        private void ProcessPromotionLineRelationshipForHeader()
        {
            Log("Creating promotion line to promotion header relationships...", ConsoleColor.Yellow);
            this._stopwatch.Restart();
            foreach (var promotion in this._createdPromotions)
            {
                Log($"Setting relationship to promotion {promotion[ItemName]}");

                var productPromotionLines
                   = this._createdPromotionLines.FindAll(x => x[Promotion].ToString().ToUpper() == "{" + promotion[ItemId].ToString().ToUpper() + "}");

                var valueList = productPromotionLines.Aggregate(string.Empty, (current, promotionLine) => current + ("{" + promotionLine[ItemId].ToString().ToUpper() + "}|"));

                promotion[PromotionLines] = valueList;

                UpdateItemModel(promotion);
                
            }

            this._stopwatch.Stop();
            Log($"Creating promotion line to promotion header relationships completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        private static void Log(string message, ConsoleColor color = ConsoleColor.Green)
        {
            _routeContext.Tracking.LogActivity(message);
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }

        private void ProcessPromotionLines(IEnumerable<string> itemList, DynamicsEndPoint endPoint)
        {
            this._stopwatch.Restart();
            Log($"Retrieving promotions from AX and creating them in Sitecore...", ConsoleColor.Yellow);
            foreach (var dynamicsPromotionLine in GetDynamicsPromotionLines(itemList, endPoint))
            {
                var existing = true;
                var lineName = dynamicsPromotionLine.ItemRecId + "-" + dynamicsPromotionLine.PromotionName;
                var findPath = endPoint.PromotionLinesPath + "/" + lineName;
                var itemId = string.Empty;

                var promotionLine = GetSingleItemFromPath(findPath);

                if (promotionLine == null)
                {
                    existing = false;
                }
                else
                {
                    itemId = promotionLine[ItemId].ToString();
                }

                var foundItem = GetSingleItemFromPath(endPoint.ProductsPath + "/" + dynamicsPromotionLine.ItemRecId);

                var foundItemGuid = string.Empty;

                if (foundItem != null)
                {
                    foundItemGuid = foundItem[ItemId].ToString();
                }

                var foundPromotion = GetSingleItemFromPath(endPoint.PromotionsPath + "/" + dynamicsPromotionLine.PromotionName);

                var foundPromotionGuid = string.Empty;

                if (foundPromotion != null)
                {
                    foundPromotionGuid = foundPromotion[ItemId].ToString();
                }

                // Set the promotion line values
                promotionLine = new ItemModel
                {
                    [TemplateId] = PromotionLineTemplateId, 
                    [ItemName] = lineName, 
                    [DiscountType] = dynamicsPromotionLine.Type, 
                    [DiscountValue] = dynamicsPromotionLine.Value, 
                    [Promotion] = "{" + foundPromotionGuid.ToUpper() + "}", 
                    [Product] = "{" + foundItemGuid.ToUpper() + "}"
                };

                if (existing)
                {
                    Log($"Updating promotion line {promotionLine[ItemName]}");
                    promotionLine[ItemId] = itemId;
                    UpdateItemModel(promotionLine);
                }
                else
                {
                    Log($"Creating promotion line {promotionLine[ItemName]}");
                    CreateItemModel(endPoint.PromotionLinesPath, promotionLine);
                }

                this._createdPromotionLines.Add(promotionLine);
            }

            this._stopwatch.Stop();
            Log($"Retrieving promotions from AX and creating them in Sitecore completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        private void ProcessPromotions(DynamicsEndPoint endPoint)
        {
            Log("Processing Dynamics promotions...", ConsoleColor.Yellow);
            this._stopwatch.Start();
            foreach (var dynamicsPromotion in GetDynamicsPromotions(endPoint))
            {
                var existing = true;
                var itemId = string.Empty;

                var promotion = FindPromotion(dynamicsPromotion.PromotionName, endPoint);

                if (promotion == null)
                {
                    existing = false;
                }
                else
                {
                    itemId = promotion[ItemId].ToString();
                }

                promotion = new ItemModel
                                {
                                    [TemplateId] = PromotionTemplateId, 
                                    [ItemName] = dynamicsPromotion.PromotionName, 
                                    [Name] = dynamicsPromotion.Name, 
                                    [Currency] = dynamicsPromotion.Currency, 
                                    [Concurrency] = dynamicsPromotion.Concurrency, 
                                    [PriceDiscount] = dynamicsPromotion.PriceDiscount, 
                                    [Description] = dynamicsPromotion.Description, 
                                    [Disclaimer] = dynamicsPromotion.Disclaimer, 
                                    [StartDate] = dynamicsPromotion.StartDate, 
                                    [EndDate] = dynamicsPromotion.EndDate, 
                                    [Type] = dynamicsPromotion.Type
                                };

                if (existing)
                {
                    Log($"Updating promotion {promotion[ItemName]}");
                    promotion[ItemId] = itemId;
                    UpdateItemModel(promotion);
                }
                else
                {
                    Log($"Creating promotion {promotion[ItemName]}");
                    CreateItemModel(endPoint.PromotionsPath, promotion);
                }

                this._createdPromotions.Add(promotion);
            }
            Log($"Processing Dynamics promotions completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        #region ApiCalls

        private static void UpdateItemModel(ItemModel promotion)
        {
            EndpointSitecoreWebApi.Instance.ExecuteUpdate(promotion, _routeContext);
        }

        private static void CreateItemModel(string path, ItemModel campaign)
        {
            EndpointSitecoreWebApi.Instance.ExecuteCreate(path, campaign);
        }

        private static ItemModel GetSingleItemFromPath(string findPath)
        {
            return EndpointSitecoreWebApi.Instance.GetSingleItemFromPath(findPath);
        }

        private static List<ItemModel> GetItemsFromPath(string path)
        {
            return EndpointSitecoreWebApi.Instance.GetItemsFromPath(path);
        }

        #endregion

        private void ProcessCampaign(DynamicsEndPoint endPoint)
        {
            this._stopwatch.Restart();
            Log("Creating campaigns from promotions...", ConsoleColor.Yellow);
            foreach (var model in this._createdPromotions)
            {
                var existing = true;
                var itemId = string.Empty;
                var campaign = FindCampaign(model[ItemName].ToString(), endPoint);
                if (campaign == null)
                {
                    existing = false;
                }
                else
                {
                    itemId = campaign[ItemId].ToString();
                }

                campaign = new ItemModel
                {
                    [TemplateId] = CampaignTemplateId, 
                    [ItemName] = model[ItemName].ToString(), 
                    [Title] = model[Description].ToString(), 
                    [StartDate] = model[StartDate], 
                    [EndDate] = model[EndDate], 
                    [CampaignGroup] = "{" + this._campaignGroupId.ToUpper() + "}",
                    [Workflow] = AnalyticsWorkflowId,
                    [WorkflowState] = AnalyticsWorkflowStateId
                };

                if (existing)
                {
                    Log($"Updating campaign {campaign[ItemName]}");
                    campaign[ItemId] = itemId;
                    UpdateItemModel(campaign);
                }
                else
                {
                    Log($"Creating campaign {campaign["ItemName"]}");
                    CreateItemModel(endPoint.CampaignPath, campaign);
                }
            }
            this._stopwatch.Stop();
            Log($"Creating campaigns from promotions completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        private void ProcessMarketingFacets(DynamicsEndPoint endPoint)
        {
            this._stopwatch.Restart();

            var location = FindMarketingFacetsLocation(endPoint);

            Log("Creating facets from promotions...", ConsoleColor.Yellow);

            if (location == null)
                return;

            foreach (var model in this._createdPromotions)
            {
                var existing = true;
                var itemId = string.Empty;
                var facet = FindMarketingFacet(model[ItemName].ToString(), endPoint);
                if (facet == null)
                {
                    existing = false;
                }
                else
                {
                    itemId = facet[ItemId].ToString();
                }

                facet = new ItemModel
                {
                    [TemplateId] = MarketingsFacetsTemplateId,
                    [ItemName] = model[ItemName].ToString(),
                    ["Code"] = model[ItemName].ToString(),
                    ["Description"] = model[Description].ToString()
                };

                if (existing)
                {
                    Log($"Updating facet {facet[ItemName]}");
                    facet[ItemId] = itemId;
                    UpdateItemModel(facet);
                }
                else
                {
                    Log($"Creating facet {facet["ItemName"]}");
                    CreateItemModel(endPoint.MarketingFacetsPath, facet);
                }
            }
            this._stopwatch.Stop();
            Log($"Creating facet from promotions completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        private void ProcessCampaignGroup(DynamicsEndPoint endPoint)
        {
            this._stopwatch.Restart();
            Log("Creating campaign group...", ConsoleColor.Yellow);
            var existing = FindCampaignGroup(DynamicsPromotionsCampaigns, endPoint) != null;

            var model = new ItemModel
            {
                [TemplateId] = CampaignGroupTemplateId, 
                [ItemName] = DynamicsPromotionsCampaigns, 
                [Description] = DynamicsPromotionsCampaigns
            };
            if (!existing)
            {
                Log($"Creating campaign {model[ItemName]}");
                CreateItemModel(endPoint.CampaignGroupPath, model);
            }

            model = FindCampaignGroup(DynamicsPromotionsCampaigns, endPoint);
            this._campaignGroupId = model[ItemId].ToString();
            this._stopwatch.Stop();
            Log($"Creating campaigns group completed in {GetElapsedTimeAsString(this._stopwatch)}", ConsoleColor.Yellow);
        }

        private static ItemModel FindPromotion(string promotionName, DynamicsEndPoint endPoint)
        {
            var findPath = endPoint.PromotionsPath + "/" + promotionName;

            var promotion = GetSingleItemFromPath(findPath);
            return promotion;
        }
        
        private static ItemModel FindMarketingFacetsLocation(DynamicsEndPoint endPoint)
        {
            var findPath = endPoint.MarketingFacetsPath;

            var path = GetSingleItemFromPath(findPath);
            return path;
        }
        private static ItemModel FindMarketingFacet(string facetName, DynamicsEndPoint endPoint)
        {
            var findPath = endPoint.MarketingFacetsPath + "/" + facetName;

            var facet = GetSingleItemFromPath(findPath);
            return facet;
        }

        private static ItemModel FindCampaign(string campaignName, DynamicsEndPoint endPoint)
        {
            var str = endPoint.CampaignPath + "/" + campaignName;
            return GetSingleItemFromPath(str);
        }

        private static ItemModel FindCampaignGroup(string campaignGroupName, DynamicsEndPoint endPoint)
        {
            var str = endPoint.CampaignGroupPath + "/" + campaignGroupName;
            return GetSingleItemFromPath(str);
        }

        private static DynamicsEndPoint GetDynamicsEndPoint(ItemModel endPointItem)
        {
            var endPoint = new DynamicsEndPoint()
                               {
                                    CampaignGroupPath = endPointItem[CampaignGroupPath].ToString(),
                                    CampaignPath = endPointItem[CampaignPath].ToString(),
                                    ChannelId = endPointItem[ChannelId].ToString(),
                                    CompanyId = endPointItem[CompanyId].ToString(),
                                    Username = endPointItem[Username].ToString(),
                                    Password = endPointItem[Password].ToString(),
                                    Domain = endPointItem[Domain].ToString(),
                                    Url = endPointItem[Url].ToString(),
                                    Partition = endPointItem[Partition].ToString(),
                                    MarketingFacetsPath = endPointItem[MarketingFacetsPath].ToString(),
                                    ProductsPath = endPointItem[ProductsPath].ToString(),
                                    PromotionLinesPath = endPointItem[PromotionLinesPath].ToString(),
                                    PromotionsPath = endPointItem[PromotionsPath].ToString(),
                                    Currency = endPointItem[Currency].ToString(),
            };

            return endPoint;
        }

        private static List<ItemModel> GetDynamicsPromotionEndPoints()
        {
            var endPoints = GetItemsFromPath(EndPointsPath);
            return endPoints;
        }

        private static CallContext GetCallContext(DynamicsEndPoint endPoint) =>
            new CallContext
            {
                Company = endPoint.CompanyId, 
                PartitionKey = endPoint.Partition
            };

        private static string GetElapsedTimeAsString(Stopwatch stopwatch)
        {
            var ts = stopwatch.Elapsed;
            var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";

            return elapsedTime;
        }

        private static SCPromotionServiceClient GetPromotionServiceClient(DynamicsEndPoint endPoint)
        {
            var client = new SCPromotionServiceClient(EndpointConfigurationName, endPoint.Url);

            if (client.ClientCredentials == null)
            {
                return client;
            }

            client.ClientCredentials.Windows.ClientCredential.Domain = endPoint.Domain;
            client.ClientCredentials.Windows.ClientCredential.UserName = endPoint.Username;
            client.ClientCredentials.Windows.ClientCredential.Password = endPoint.Password;

            return client;
        }

        private static IEnumerable<DynamicsPromotionLine> GetDynamicsPromotionLines(IEnumerable<string> itemList, DynamicsEndPoint endPoint)
        {
            var list = (from itemId in itemList
                        select new SCPromotionLineQueryContract
                        {
                            parmItemRecId = Convert.ToInt64(itemId), 
                            parmVariantId = string.Empty
                        }).ToList();

            return (from promoLine in GetPromotionServiceClient(endPoint).GetItemDiscounts(GetCallContext(endPoint), Convert.ToInt64(endPoint.ChannelId), endPoint.Currency, list.ToArray())
                    select new DynamicsPromotionLine
                    {
                        ItemRecId = promoLine.parmItemRecId.ToString(), 
                        PromotionName = promoLine.parmId, 
                        Type = promoLine.parmPromotionType, 
                        Value = promoLine.parmPriceDiscount
                    }).ToList();
        }

        private static IEnumerable<DynamicsPromotion> GetDynamicsPromotions(DynamicsEndPoint endPoint)
        {
            return (from promotion in GetPromotionServiceClient(endPoint).GetAllDiscounts(GetCallContext(endPoint), Convert.ToInt64(endPoint.ChannelId))
                    select new DynamicsPromotion
                    {
                        PromotionName = promotion.parmId, 
                        Name = promotion.parmDiscountName, 
                        Currency = promotion.parmCurrency, 
                        Concurrency = promotion.parmConcurrency, 
                        PriceDiscount = promotion.parmPriceDiscount, 
                        Description = promotion.parmDescription, 
                        Disclaimer = promotion.parmDisclaimer, 
                        StartDate = MapLib.MapToSitecoreDate(promotion.parmStartDate), 
                        EndDate = MapLib.MapToSitecoreDate(promotion.parmEndDate), 
                        Type = promotion.parmPromotionType
                    }).ToList();
        }
    }
}