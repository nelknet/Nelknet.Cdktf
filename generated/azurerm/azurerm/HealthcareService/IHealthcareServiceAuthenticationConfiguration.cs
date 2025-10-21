using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareService
{
    [JsiiInterface(nativeType: typeof(IHealthcareServiceAuthenticationConfiguration), fullyQualifiedName: "azurerm.healthcareService.HealthcareServiceAuthenticationConfiguration")]
    public interface IHealthcareServiceAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#audience HealthcareService#audience}.</summary>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audience
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#authority HealthcareService#authority}.</summary>
        [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Authority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#smart_proxy_enabled HealthcareService#smart_proxy_enabled}.</summary>
        [JsiiProperty(name: "smartProxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SmartProxyEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHealthcareServiceAuthenticationConfiguration), fullyQualifiedName: "azurerm.healthcareService.HealthcareServiceAuthenticationConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.HealthcareService.IHealthcareServiceAuthenticationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#audience HealthcareService#audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Audience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#authority HealthcareService#authority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Authority
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#smart_proxy_enabled HealthcareService#smart_proxy_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smartProxyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SmartProxyEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
