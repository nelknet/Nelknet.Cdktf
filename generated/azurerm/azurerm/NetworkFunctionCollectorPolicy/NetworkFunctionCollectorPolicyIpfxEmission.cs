using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkFunctionCollectorPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmission")]
    public class NetworkFunctionCollectorPolicyIpfxEmission : azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxEmission
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#destination_types NetworkFunctionCollectorPolicy#destination_types}.</summary>
        [JsiiProperty(name: "destinationTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DestinationTypes
        {
            get;
            set;
        }
    }
}
