﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicsPromotionLine.cs" company="">
//   
// </copyright>
// <summary>
//   The dynamics promotion line.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.Commerce.Dynamics.Promotions.Endpoint.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The dynamics promotion line.
    /// </summary>
    public class DynamicsPromotionLine
    {
        /// <summary>
        /// Gets or sets the item rec id.
        /// </summary>
        public string ItemRecId { get; set; }

        /// <summary>
        /// Gets or sets the promotion name.
        /// </summary>
        public string PromotionName { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value { get; set; }
    }
}
