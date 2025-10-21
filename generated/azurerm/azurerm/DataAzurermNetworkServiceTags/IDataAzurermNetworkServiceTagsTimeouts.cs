using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkServiceTags
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetworkServiceTagsTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkServiceTags.DataAzurermNetworkServiceTagsTimeouts")]
    public interface IDataAzurermNetworkServiceTagsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#read DataAzurermNetworkServiceTags#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetworkServiceTagsTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetworkServiceTags.DataAzurermNetworkServiceTagsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetworkServiceTags.IDataAzurermNetworkServiceTagsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_service_tags#read DataAzurermNetworkServiceTags#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
