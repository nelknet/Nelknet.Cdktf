using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeouts")]
    public class DataAzurermKubernetesClusterTimeouts : azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#read DataAzurermKubernetesCluster#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
