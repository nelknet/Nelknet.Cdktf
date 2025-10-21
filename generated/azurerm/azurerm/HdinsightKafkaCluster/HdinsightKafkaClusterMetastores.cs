using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores")]
    public class HdinsightKafkaClusterMetastores : azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ambari HdinsightKafkaCluster#ambari}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbari\"}", isOptional: true)]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari? Ambari
        {
            get;
            set;
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#hive HdinsightKafkaCluster#hive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHive\"}", isOptional: true)]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive? Hive
        {
            get;
            set;
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#oozie HdinsightKafkaCluster#oozie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozie\"}", isOptional: true)]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie? Oozie
        {
            get;
            set;
        }
    }
}
