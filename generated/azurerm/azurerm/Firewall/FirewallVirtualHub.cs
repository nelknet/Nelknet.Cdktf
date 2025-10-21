using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Firewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.firewall.FirewallVirtualHub")]
    public class FirewallVirtualHub : azurerm.Firewall.IFirewallVirtualHub
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#virtual_hub_id Firewall#virtual_hub_id}.</summary>
        [JsiiProperty(name: "virtualHubId", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualHubId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#public_ip_count Firewall#public_ip_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIpCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PublicIpCount
        {
            get;
            set;
        }
    }
}
