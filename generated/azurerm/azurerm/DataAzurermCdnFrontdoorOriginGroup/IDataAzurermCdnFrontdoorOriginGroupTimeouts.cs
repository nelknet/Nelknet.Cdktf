using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorOriginGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnFrontdoorOriginGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroupTimeouts")]
    public interface IDataAzurermCdnFrontdoorOriginGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#read DataAzurermCdnFrontdoorOriginGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnFrontdoorOriginGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorOriginGroup.DataAzurermCdnFrontdoorOriginGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnFrontdoorOriginGroup.IDataAzurermCdnFrontdoorOriginGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_origin_group#read DataAzurermCdnFrontdoorOriginGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
