// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicsCommerceChannel.cs" company="">
//   
// </copyright>
// <summary>
//   Extends the CommerceChannel with SyncToken and OrganizationalUnit
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.Commerce.Dynamics.Promotions.Endpoint.Models
{
    using System.Diagnostics.CodeAnalysis;

    using Sitecore.Commerce.Routing.Models;

    /// <summary>
    ///     Extends the CommerceChannel with SyncToken and OrganizationalUnit
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class DynamicsCommerceChannel : CommerceChannel
    {
        /// <summary>
        ///     Gets or sets the organizational unit from AX
        /// </summary>
        public string OrganizationalUnit { get; set; }
    }
}