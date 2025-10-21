using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkFunctionCollectorPolicy
{
    [JsiiInterface(nativeType: typeof(INetworkFunctionCollectorPolicyIpfxEmission), fullyQualifiedName: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmission")]
    public interface INetworkFunctionCollectorPolicyIpfxEmission
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#destination_types NetworkFunctionCollectorPolicy#destination_types}.</summary>
        [JsiiProperty(name: "destinationTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DestinationTypes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFunctionCollectorPolicyIpfxEmission), fullyQualifiedName: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmission")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxEmission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#destination_types NetworkFunctionCollectorPolicy#destination_types}.</summary>
            [JsiiProperty(name: "destinationTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DestinationTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
