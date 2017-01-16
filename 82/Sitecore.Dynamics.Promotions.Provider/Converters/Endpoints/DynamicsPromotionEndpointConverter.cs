// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicsEndpointConverter.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sitecore.Dynamics.Promotions.Provider.Converters.Endpoints
{
    using Sitecore.DataExchange.Converters.Endpoints;
    using Sitecore.DataExchange.Models;
    using Sitecore.DataExchange.Repositories;
    using Sitecore.Services.Core.Model;

    /// <summary>
    ///     Defines the dynamics promotions endpoint converter
    /// </summary>
    /// <seealso cref="DynamicsPromotionEndpointConverter" />
    public class DynamicsPromotionEndpointConverter : BaseEndpointConverter<ItemModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicsPromotionEndpointConverter"/> class. 
        /// </summary>
        /// <param name="repository">
        /// The repository.
        /// </param>
        public DynamicsPromotionEndpointConverter(IItemModelRepository repository)
            : base(repository)
        {
        }

        /// <summary>
        /// The add plugins.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint.
        /// </param>
        protected override void AddPlugins(ItemModel source, Endpoint endpoint)
        {
            
        }
    }
}