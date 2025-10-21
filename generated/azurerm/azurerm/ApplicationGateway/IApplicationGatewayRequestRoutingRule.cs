using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayRequestRoutingRule), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRequestRoutingRule")]
    public interface IApplicationGatewayRequestRoutingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#http_listener_name ApplicationGateway#http_listener_name}.</summary>
        [JsiiProperty(name: "httpListenerName", typeJson: "{\"primitive\":\"string\"}")]
        string HttpListenerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_type ApplicationGateway#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        string RuleType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_address_pool_name ApplicationGateway#backend_address_pool_name}.</summary>
        [JsiiProperty(name: "backendAddressPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackendAddressPoolName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_http_settings_name ApplicationGateway#backend_http_settings_name}.</summary>
        [JsiiProperty(name: "backendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackendHttpSettingsName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#priority ApplicationGateway#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#redirect_configuration_name ApplicationGateway#redirect_configuration_name}.</summary>
        [JsiiProperty(name: "redirectConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectConfigurationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rewrite_rule_set_name ApplicationGateway#rewrite_rule_set_name}.</summary>
        [JsiiProperty(name: "rewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RewriteRuleSetName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url_path_map_name ApplicationGateway#url_path_map_name}.</summary>
        [JsiiProperty(name: "urlPathMapName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UrlPathMapName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayRequestRoutingRule), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRequestRoutingRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#http_listener_name ApplicationGateway#http_listener_name}.</summary>
            [JsiiProperty(name: "httpListenerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpListenerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_type ApplicationGateway#rule_type}.</summary>
            [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_address_pool_name ApplicationGateway#backend_address_pool_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendAddressPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendAddressPoolName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_http_settings_name ApplicationGateway#backend_http_settings_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendHttpSettingsName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#priority ApplicationGateway#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#redirect_configuration_name ApplicationGateway#redirect_configuration_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectConfigurationName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rewrite_rule_set_name ApplicationGateway#rewrite_rule_set_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RewriteRuleSetName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url_path_map_name ApplicationGateway#url_path_map_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "urlPathMapName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UrlPathMapName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
