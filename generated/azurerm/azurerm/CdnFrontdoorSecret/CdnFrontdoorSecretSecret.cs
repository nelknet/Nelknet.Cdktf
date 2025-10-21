using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecret")]
    public class CdnFrontdoorSecretSecret : azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecret
    {
        private object _customerCertificate;

        /// <summary>customer_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#customer_certificate CdnFrontdoorSecret#customer_certificate}
        /// </remarks>
        [JsiiProperty(name: "customerCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate\"},\"kind\":\"array\"}}]}}")]
        public object CustomerCertificate
        {
            get => _customerCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customerCertificate = value;
            }
        }
    }
}
