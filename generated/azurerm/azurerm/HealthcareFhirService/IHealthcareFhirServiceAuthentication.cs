using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareFhirService
{
    [JsiiInterface(nativeType: typeof(IHealthcareFhirServiceAuthentication), fullyQualifiedName: "azurerm.healthcareFhirService.HealthcareFhirServiceAuthentication")]
    public interface IHealthcareFhirServiceAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#audience HealthcareFhirService#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        string Audience
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#authority HealthcareFhirService#authority}.</summary>
        [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}")]
        string Authority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#smart_proxy_enabled HealthcareFhirService#smart_proxy_enabled}.</summary>
        [JsiiProperty(name: "smartProxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SmartProxyEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHealthcareFhirServiceAuthentication), fullyQualifiedName: "azurerm.healthcareFhirService.HealthcareFhirServiceAuthentication")]
        internal sealed class _Proxy : DeputyBase, azurerm.HealthcareFhirService.IHealthcareFhirServiceAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#audience HealthcareFhirService#audience}.</summary>
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
            public string Audience
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#authority HealthcareFhirService#authority}.</summary>
            [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}")]
            public string Authority
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#smart_proxy_enabled HealthcareFhirService#smart_proxy_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smartProxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SmartProxyEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
