using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciLogicalNetwork
{
    [JsiiInterface(nativeType: typeof(IStackHciLogicalNetworkSubnetIpPool), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool")]
    public interface IStackHciLogicalNetworkSubnetIpPool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#end StackHciLogicalNetwork#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        string End
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#start StackHciLogicalNetwork#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        string Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStackHciLogicalNetworkSubnetIpPool), fullyQualifiedName: "azurerm.stackHciLogicalNetwork.StackHciLogicalNetworkSubnetIpPool")]
        internal sealed class _Proxy : DeputyBase, azurerm.StackHciLogicalNetwork.IStackHciLogicalNetworkSubnetIpPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#end StackHciLogicalNetwork#end}.</summary>
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
            public string End
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#start StackHciLogicalNetwork#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
            public string Start
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
