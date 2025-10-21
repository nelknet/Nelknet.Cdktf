using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SearchService
{
    [JsiiInterface(nativeType: typeof(ISearchServiceIdentity), fullyQualifiedName: "azurerm.searchService.SearchServiceIdentity")]
    public interface ISearchServiceIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#type SearchService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISearchServiceIdentity), fullyQualifiedName: "azurerm.searchService.SearchServiceIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.SearchService.ISearchServiceIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#type SearchService#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
