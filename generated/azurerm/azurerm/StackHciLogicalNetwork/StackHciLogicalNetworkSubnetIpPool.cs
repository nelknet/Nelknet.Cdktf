using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool")]
    public class StackHciLogicalNetworkSubnetIpPool : azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#end StackHciLogicalNetwork#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        public string End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#start StackHciLogicalNetwork#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public string Start
        {
            get;
            set;
        }
    }
}
