// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>
//   Console program.  Either runs the route passed in as an argument and stops or runs repeatedly by accessing route requests in Sitecore.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PromotionSyncTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.Description;
    using System.Text;
    using System.Threading.Tasks;

    using PromotionSyncTest.SCPromotionsService;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var client = new SCPromotionServiceClient();

            // Set the user’s credentials on the proxy
            if (client.ClientCredentials != null)
            {
                client.ClientCredentials.Windows.ClientCredential.Domain = "contoso.com";
                client.ClientCredentials.Windows.ClientCredential.UserName = "administrator";
                client.ClientCredentials.Windows.ClientCredential.Password = "Dyn@m1csAX";
                client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            }

            var results = client.GetAllDiscounts(
                new CallContext() { Company = "USRT", PartitionKey = "initial" },
                5637144608,
                false);
        }
    }
}
