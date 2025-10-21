using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoor.FrontdoorBackendPoolSettings")]
    public class FrontdoorBackendPoolSettings : azurerm.Frontdoor.IFrontdoorBackendPoolSettings
    {
        private object _enforceBackendPoolsCertificateNameCheck;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#enforce_backend_pools_certificate_name_check Frontdoor#enforce_backend_pools_certificate_name_check}.</summary>
        [JsiiProperty(name: "enforceBackendPoolsCertificateNameCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EnforceBackendPoolsCertificateNameCheck
        {
            get => _enforceBackendPoolsCertificateNameCheck;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enforceBackendPoolsCertificateNameCheck = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pools_send_receive_timeout_seconds Frontdoor#backend_pools_send_receive_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendPoolsSendReceiveTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackendPoolsSendReceiveTimeoutSeconds
        {
            get;
            set;
        }
    }
}
