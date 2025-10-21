using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores")]
    public class HdinsightSparkClusterMetastores : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#ambari HdinsightSparkCluster#ambari}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbari\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari? Ambari
        {
            get;
            set;
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#hive HdinsightSparkCluster#hive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresHive\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive? Hive
        {
            get;
            set;
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#oozie HdinsightSparkCluster#oozie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOozie\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie? Oozie
        {
            get;
            set;
        }
    }
}
