using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManager
{
    [JsiiByValue(fqn: "azurerm.networkManager.NetworkManagerScope")]
    public class NetworkManagerScope : azurerm.NetworkManager.INetworkManagerScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#management_group_ids NetworkManager#management_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managementGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ManagementGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#subscription_ids NetworkManager#subscription_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubscriptionIds
        {
            get;
            set;
        }
    }
}
