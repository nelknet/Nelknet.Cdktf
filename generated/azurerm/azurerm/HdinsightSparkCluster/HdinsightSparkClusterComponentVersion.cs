using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterComponentVersion")]
    public class HdinsightSparkClusterComponentVersion : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#spark HdinsightSparkCluster#spark}.</summary>
        [JsiiProperty(name: "spark", typeJson: "{\"primitive\":\"string\"}")]
        public string Spark
        {
            get;
            set;
        }
    }
}
