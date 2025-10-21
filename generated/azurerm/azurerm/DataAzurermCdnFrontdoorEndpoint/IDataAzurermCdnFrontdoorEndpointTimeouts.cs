using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnFrontdoorEndpointTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpointTimeouts")]
    public interface IDataAzurermCdnFrontdoorEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#read DataAzurermCdnFrontdoorEndpoint#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnFrontdoorEndpointTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpointTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnFrontdoorEndpoint.IDataAzurermCdnFrontdoorEndpointTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#read DataAzurermCdnFrontdoorEndpoint#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
