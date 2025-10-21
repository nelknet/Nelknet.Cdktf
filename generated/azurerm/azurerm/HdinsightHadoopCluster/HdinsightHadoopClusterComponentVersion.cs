using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion")]
    public class HdinsightHadoopClusterComponentVersion : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#hadoop HdinsightHadoopCluster#hadoop}.</summary>
        [JsiiProperty(name: "hadoop", typeJson: "{\"primitive\":\"string\"}")]
        public string Hadoop
        {
            get;
            set;
        }
    }
}
