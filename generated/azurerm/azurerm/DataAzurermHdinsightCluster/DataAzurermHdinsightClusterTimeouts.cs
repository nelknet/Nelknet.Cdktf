using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHdinsightCluster
{
    [JsiiByValue(fqn: "azurerm.dataAzurermHdinsightCluster.DataAzurermHdinsightClusterTimeouts")]
    public class DataAzurermHdinsightClusterTimeouts : azurerm.DataAzurermHdinsightCluster.IDataAzurermHdinsightClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#read DataAzurermHdinsightCluster#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
