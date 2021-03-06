// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="">
//   
// </copyright>
// <summary>
//   GlobalSuppressions.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Scope = "type", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Managers.DynamicsCrtManager")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Endpoints.EndpointDynamicsCrt.#_channelManager")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Endpoints.EndpointDynamicsCrt.#_commerceRuntime")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Endpoints.EndpointDynamicsCrt.#_orderManager")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Endpoints.EndpointDynamicsCrt.#_productManager")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Endpoints.EndpointDynamicsCrt.#CommerceRuntime")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Providers.EndpointDynamicsCrtProvider.#Load(System.Object)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Extensions.#DynamicsContext(Sitecore.Commerce.Routing.Contexts.RouteContext)"
        )]
[assembly:
    SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChangedProducts.#Process(Sitecore.Commerce.Routing.Contexts.RouteContext)"
        )]
[assembly:
    SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChangedProducts.#ProcessProduct(Sitecore.Commerce.Routing.Contexts.RouteContext,System.Int64,Microsoft.Dynamics.Commerce.Runtime.DataModel.Product)"
        )]
[assembly:
    SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChangedProducts.#ProcessProduct(Sitecore.Commerce.Routing.Contexts.RouteContext,System.Int64,Microsoft.Dynamics.Commerce.Runtime.DataModel.Product)"
        )]
[assembly:
    SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChangedProducts.#ProcessProduct(Sitecore.Commerce.Routing.Contexts.RouteContext,System.Int64,Microsoft.Dynamics.Commerce.Runtime.DataModel.Product)"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PreExisting", 
        Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChannelProductAttributes.#AddPreExistingAttribute(Sitecore.Commerce.Routing.Contexts.RouteContext,System.String,System.String,System.String)"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PreExisting", 
        Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChannelProductAttributes.#AddPreExistingAttribute(Sitecore.Commerce.Routing.Contexts.RouteContext,System.String,System.String)"
        )]
[assembly:
    SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChannelProductAttributes.#Process(Sitecore.Commerce.Routing.Contexts.RouteContext)"
        )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", 
        MessageId = "Microsoft.Dynamics.Commerce.Runtime.QueryResultSettings", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChannelProductAttributes.#Process(Sitecore.Commerce.Routing.Contexts.RouteContext)"
        )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Contexts.RouteContextDynamics.#Catalogs")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Contexts.RouteContextDynamics.#CatalogProducts")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Contexts.RouteContextDynamics.#Categories")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Contexts.RouteContextDynamics.#ExtractedProducts")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", 
        Target = "Sitecore.Commerce.Endpoint.DynamicsCrt.Contexts.RouteContextDynamics.#ChannelAttributes")]
[assembly:
    SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", 
        Target =
            "Sitecore.Commerce.Endpoint.DynamicsCrt.Processors.ExtractChangedProducts.#GetVariantTranslatedProperties(Sitecore.Commerce.Routing.Models.CommerceProduct,Microsoft.Dynamics.Commerce.Runtime.DataModel.ProductVariant,Sitecore.Commerce.Routing.Models.CommerceProductVariant,Sitecore.Commerce.Routing.Contexts.RouteContext)"
        )]