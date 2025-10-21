using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesClusterNodePool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePoolTimeouts")]
    public class DataAzurermKubernetesClusterNodePoolTimeouts : azurerm.DataAzurermKubernetesClusterNodePool.IDataAzurermKubernetesClusterNodePoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool#read DataAzurermKubernetesClusterNodePool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
