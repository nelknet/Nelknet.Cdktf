using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayUrlPathMap), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayUrlPathMap")]
    public interface IApplicationGatewayUrlPathMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>path_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#path_rule ApplicationGateway#path_rule}
        /// </remarks>
        [JsiiProperty(name: "pathRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayUrlPathMapPathRule\"},\"kind\":\"array\"}}]}}")]
        object PathRule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_backend_address_pool_name ApplicationGateway#default_backend_address_pool_name}.</summary>
        [JsiiProperty(name: "defaultBackendAddressPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultBackendAddressPoolName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_backend_http_settings_name ApplicationGateway#default_backend_http_settings_name}.</summary>
        [JsiiProperty(name: "defaultBackendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultBackendHttpSettingsName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_redirect_configuration_name ApplicationGateway#default_redirect_configuration_name}.</summary>
        [JsiiProperty(name: "defaultRedirectConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRedirectConfigurationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_rewrite_rule_set_name ApplicationGateway#default_rewrite_rule_set_name}.</summary>
        [JsiiProperty(name: "defaultRewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRewriteRuleSetName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayUrlPathMap), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayUrlPathMap")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>path_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#path_rule ApplicationGateway#path_rule}
            /// </remarks>
            [JsiiProperty(name: "pathRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayUrlPathMapPathRule\"},\"kind\":\"array\"}}]}}")]
            public object PathRule
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_backend_address_pool_name ApplicationGateway#default_backend_address_pool_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultBackendAddressPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultBackendAddressPoolName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_backend_http_settings_name ApplicationGateway#default_backend_http_settings_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultBackendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultBackendHttpSettingsName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_redirect_configuration_name ApplicationGateway#default_redirect_configuration_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRedirectConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRedirectConfigurationName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_rewrite_rule_set_name ApplicationGateway#default_rewrite_rule_set_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRewriteRuleSetName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
