using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecret
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorSecretSecret), fullyQualifiedName: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecret")]
    public interface ICdnFrontdoorSecretSecret
    {
        /// <summary>customer_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#customer_certificate CdnFrontdoorSecret#customer_certificate}
        /// </remarks>
        [JsiiProperty(name: "customerCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate\"},\"kind\":\"array\"}}]}}")]
        object CustomerCertificate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorSecretSecret), fullyQualifiedName: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecret")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>customer_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#customer_certificate CdnFrontdoorSecret#customer_certificate}
            /// </remarks>
            [JsiiProperty(name: "customerCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate\"},\"kind\":\"array\"}}]}}")]
            public object CustomerCertificate
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
