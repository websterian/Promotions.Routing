// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicsPromotion.cs" company="">
//   
// </copyright>
// <summary>
//   The dynamics promotion.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Sitecore.Commerce.Dynamics.Promotions.Endpoint.Models
{
    /// <summary>
    /// The dynamics promotion.
    /// </summary>
    public class DynamicsPromotion
    {
        /// <summary>
        /// Gets or sets the concurrency.
        /// </summary>
        public string Concurrency { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the disclaimer.
        /// </summary>
        public string Disclaimer { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        ///     Gets or sets the item name.
        /// </summary>
        public string PromotionName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price discount.
        /// </summary>
        public string PriceDiscount { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        ///     Gets or sets the template id.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }
    }
}