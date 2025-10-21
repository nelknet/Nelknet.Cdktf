using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesNodePoolSnapshot
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshotTimeouts")]
    public class DataAzurermKubernetesNodePoolSnapshotTimeouts : azurerm.DataAzurermKubernetesNodePoolSnapshot.IDataAzurermKubernetesNodePoolSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_node_pool_snapshot#read DataAzurermKubernetesNodePoolSnapshot#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
