using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorCustomDomain
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnFrontdoorCustomDomainTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomainTimeouts")]
    public interface IDataAzurermCdnFrontdoorCustomDomainTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#read DataAzurermCdnFrontdoorCustomDomain#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnFrontdoorCustomDomainTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorCustomDomain.DataAzurermCdnFrontdoorCustomDomainTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnFrontdoorCustomDomain.IDataAzurermCdnFrontdoorCustomDomainTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_custom_domain#read DataAzurermCdnFrontdoorCustomDomain#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
