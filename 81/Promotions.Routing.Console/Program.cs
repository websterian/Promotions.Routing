// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>
//   Console program.  Either runs the route passed in as an argument and stops or runs repeatedly by accessing route requests in Sitecore.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Promotions.Routing.Console
{
    using System;
    using System.Configuration;
    using System.Linq;

    using Sitecore.Commerce.Common.Logging;
    using Sitecore.Commerce.Routing.Models;
    using Sitecore.Commerce.Routing.Providers.SitecoreWebApi;
    using Sitecore.Commerce.Routing.Providers.SitecoreWebApi.Endpoints;

    /// <summary>
    ///     Host console app sample to demonstrate doing the Channel Extraction Process
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     Main console method
        /// </summary>
        /// <param name="args">
        ///     The args
        /// </param>
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Synchronization starting...");

                EndpointSitecoreWebApi.Instance.Host = ConfigurationManager.AppSettings["Host"];
                EndpointSitecoreWebApi.Instance.UserName = ConfigurationManager.AppSettings["UserName"];
                EndpointSitecoreWebApi.Instance.SitecoreDatabase = ConfigurationManager.AppSettings["SitecoreDatabase"];
                EndpointSitecoreWebApi.Instance.Password = ConfigurationManager.AppSettings["Password"];
                LogManager.ResetLogSession();

                var routeRequest = ConfigurationSynchronization.GetRouteRequest("DynamicsPromotions");

                var routeContext = routeRequest.RouteContext;
                routeContext.SitecoreContext().SitecoreChannel = new CommerceChannel();
                var route = routeRequest.Routes.First();
                try
                {
                    route.Process(routeContext);
                }
                catch (Exception exception2)
                {
                    routeContext.Tracking.LogException(routeContext.CorrelationId, exception2);
                }
                finally
                {
                    EndpointSitecoreWebApi.Instance.SetRequestLastRun(routeRequest.Id, "Last Run", DateTime.Now);
                    SitecoreWebApiManager.CreateRouteHistory(routeContext, routeRequest.Path, "Request History");
                }

                Console.WriteLine("Synchronization completed");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
    }
}