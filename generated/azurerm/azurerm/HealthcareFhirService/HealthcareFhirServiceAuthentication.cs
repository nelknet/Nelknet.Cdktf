using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareFhirService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.healthcareFhirService.HealthcareFhirServiceAuthentication")]
    public class HealthcareFhirServiceAuthentication : azurerm.HealthcareFhirService.IHealthcareFhirServiceAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#audience HealthcareFhirService#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public string Audience
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#authority HealthcareFhirService#authority}.</summary>
        [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}")]
        public string Authority
        {
            get;
            set;
        }

        private object? _smartProxyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#smart_proxy_enabled HealthcareFhirService#smart_proxy_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smartProxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SmartProxyEnabled
        {
            get => _smartProxyEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _smartProxyEnabled = value;
            }
        }
    }
}
