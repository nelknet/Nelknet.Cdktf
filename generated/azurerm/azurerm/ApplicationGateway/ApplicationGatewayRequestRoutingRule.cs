using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayRequestRoutingRule")]
    public class ApplicationGatewayRequestRoutingRule : azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#http_listener_name ApplicationGateway#http_listener_name}.</summary>
        [JsiiProperty(name: "httpListenerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpListenerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_type ApplicationGateway#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_address_pool_name ApplicationGateway#backend_address_pool_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendAddressPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackendAddressPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#backend_http_settings_name ApplicationGateway#backend_http_settings_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackendHttpSettingsName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#priority ApplicationGateway#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#redirect_configuration_name ApplicationGateway#redirect_configuration_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectConfigurationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rewrite_rule_set_name ApplicationGateway#rewrite_rule_set_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RewriteRuleSetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url_path_map_name ApplicationGateway#url_path_map_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "urlPathMapName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UrlPathMapName
        {
            get;
            set;
        }
    }
}
