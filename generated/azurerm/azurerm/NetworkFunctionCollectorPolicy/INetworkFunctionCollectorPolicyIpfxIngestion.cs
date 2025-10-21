using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkFunctionCollectorPolicy
{
    [JsiiInterface(nativeType: typeof(INetworkFunctionCollectorPolicyIpfxIngestion), fullyQualifiedName: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestion")]
    public interface INetworkFunctionCollectorPolicyIpfxIngestion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#source_resource_ids NetworkFunctionCollectorPolicy#source_resource_ids}.</summary>
        [JsiiProperty(name: "sourceResourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SourceResourceIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkFunctionCollectorPolicyIpfxIngestion), fullyQualifiedName: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestion")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxIngestion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#source_resource_ids NetworkFunctionCollectorPolicy#source_resource_ids}.</summary>
            [JsiiProperty(name: "sourceResourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SourceResourceIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
