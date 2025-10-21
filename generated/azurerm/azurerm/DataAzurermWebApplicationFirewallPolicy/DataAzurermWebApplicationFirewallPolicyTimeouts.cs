using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWebApplicationFirewallPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicyTimeouts")]
    public class DataAzurermWebApplicationFirewallPolicyTimeouts : azurerm.DataAzurermWebApplicationFirewallPolicy.IDataAzurermWebApplicationFirewallPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy#read DataAzurermWebApplicationFirewallPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
