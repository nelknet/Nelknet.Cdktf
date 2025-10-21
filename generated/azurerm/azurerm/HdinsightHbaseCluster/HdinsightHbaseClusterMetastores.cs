using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastores")]
    public class HdinsightHbaseClusterMetastores : azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#ambari HdinsightHbaseCluster#ambari}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbari\"}", isOptional: true)]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari? Ambari
        {
            get;
            set;
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#hive HdinsightHbaseCluster#hive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHive\"}", isOptional: true)]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive? Hive
        {
            get;
            set;
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#oozie HdinsightHbaseCluster#oozie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozie\"}", isOptional: true)]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie? Oozie
        {
            get;
            set;
        }
    }
}
