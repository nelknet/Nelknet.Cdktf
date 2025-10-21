using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles")]
    public class HdinsightKafkaClusterRoles : azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#head_node HdinsightKafkaCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNode\"}")]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode HeadNode
        {
            get;
            set;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#worker_node HdinsightKafkaCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNode\"}")]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode WorkerNode
        {
            get;
            set;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#zookeeper_node HdinsightKafkaCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNode\"}")]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode ZookeeperNode
        {
            get;
            set;
        }

        /// <summary>kafka_management_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#kafka_management_node HdinsightKafkaCluster#kafka_management_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafkaManagementNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNode\"}", isOptional: true)]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode? KafkaManagementNode
        {
            get;
            set;
        }
    }
}
