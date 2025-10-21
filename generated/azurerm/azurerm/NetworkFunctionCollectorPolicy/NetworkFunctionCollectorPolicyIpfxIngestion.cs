using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkFunctionCollectorPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestion")]
    public class NetworkFunctionCollectorPolicyIpfxIngestion : azurerm.NetworkFunctionCollectorPolicy.INetworkFunctionCollectorPolicyIpfxIngestion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#source_resource_ids NetworkFunctionCollectorPolicy#source_resource_ids}.</summary>
        [JsiiProperty(name: "sourceResourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SourceResourceIds
        {
            get;
            set;
        }
    }
}
