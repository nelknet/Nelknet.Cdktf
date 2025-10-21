using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComponentVersion")]
    public class HdinsightHbaseClusterComponentVersion : azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#hbase HdinsightHbaseCluster#hbase}.</summary>
        [JsiiProperty(name: "hbase", typeJson: "{\"primitive\":\"string\"}")]
        public string Hbase
        {
            get;
            set;
        }
    }
}
