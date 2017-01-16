// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tracer.cs" company="">
//   
// </copyright>
// <summary>
//   Provides a tracing diagnostics calss
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Sitecore.Commerce.Dynamcis.Promotions.Endpoint
{
    using System.Diagnostics;

    /// <summary>
    ///     Provides a tracing diagnostics calss
    /// </summary>
    public static class Tracing
    {
        /// <summary>
        /// The _trace source.
        /// </summary>
        private static TraceSource _traceSource;

        /// <summary>
        ///     Gets the instance of the TraceSwitch
        /// </summary>
        public static TraceSource Tracer
        {
            get
            {
                if (_traceSource == null)
                {
                    _traceSource = new TraceSource("DynamicsRetail.Routing");
                }

                return _traceSource;
            }
        }
    }
}