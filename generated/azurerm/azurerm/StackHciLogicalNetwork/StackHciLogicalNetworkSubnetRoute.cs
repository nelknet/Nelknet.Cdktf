using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetRoute")]
    public class StackHciLogicalNetworkSubnetRoute : azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#address_prefix StackHciLogicalNetwork#address_prefix}.</summary>
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#name StackHciLogicalNetwork#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#next_hop_ip_address StackHciLogicalNetwork#next_hop_ip_address}.</summary>
        [JsiiProperty(name: "nextHopIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string NextHopIpAddress
        {
            get;
            set;
        }
    }
}
