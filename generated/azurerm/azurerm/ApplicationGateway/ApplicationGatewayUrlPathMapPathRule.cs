using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayUrlPathMapPathRule")]
    public class ApplicationGatewayUrlPathMapPathRule : azurerm.ApplicationGateway.IApplicationGatewayUrlPathMapPathRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#paths ApplicationGateway#paths}.</summary>
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Paths
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#firewall_policy_id ApplicationGateway#firewall_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirewallPolicyId
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
    }
}
