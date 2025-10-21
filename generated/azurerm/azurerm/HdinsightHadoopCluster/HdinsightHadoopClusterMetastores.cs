using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastores")]
    public class HdinsightHadoopClusterMetastores : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#ambari HdinsightHadoopCluster#ambari}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresAmbari\"}", isOptional: true)]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresAmbari? Ambari
        {
            get;
            set;
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#hive HdinsightHadoopCluster#hive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresHive\"}", isOptional: true)]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresHive? Hive
        {
            get;
            set;
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#oozie HdinsightHadoopCluster#oozie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresOozie\"}", isOptional: true)]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresOozie? Oozie
        {
            get;
            set;
        }
    }
}
