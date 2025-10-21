using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerAdminRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkManagerAdminRule.NetworkManagerAdminRuleSource")]
    public class NetworkManagerAdminRuleSource : azurerm.NetworkManagerAdminRule.INetworkManagerAdminRuleSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#address_prefix NetworkManagerAdminRule#address_prefix}.</summary>
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#address_prefix_type NetworkManagerAdminRule#address_prefix_type}.</summary>
        [JsiiProperty(name: "addressPrefixType", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressPrefixType
        {
            get;
            set;
        }
    }
}
