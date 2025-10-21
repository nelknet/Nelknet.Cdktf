using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightKafkaClusterRoles), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles")]
    public interface IHdinsightKafkaClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#head_node HdinsightKafkaCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNode\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode HeadNode
        {
            get;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#worker_node HdinsightKafkaCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNode\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode WorkerNode
        {
            get;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#zookeeper_node HdinsightKafkaCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNode\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode ZookeeperNode
        {
            get;
        }

        /// <summary>kafka_management_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#kafka_management_node HdinsightKafkaCluster#kafka_management_node}
        /// </remarks>
        [JsiiProperty(name: "kafkaManagementNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode? KafkaManagementNode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightKafkaClusterRoles), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRoles")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>head_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#head_node HdinsightKafkaCluster#head_node}
            /// </remarks>
            [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesHeadNode\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode HeadNode
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesHeadNode>()!;
            }

            /// <summary>worker_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#worker_node HdinsightKafkaCluster#worker_node}
            /// </remarks>
            [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesWorkerNode\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode WorkerNode
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesWorkerNode>()!;
            }

            /// <summary>zookeeper_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#zookeeper_node HdinsightKafkaCluster#zookeeper_node}
            /// </remarks>
            [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesZookeeperNode\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode ZookeeperNode
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesZookeeperNode>()!;
            }

            /// <summary>kafka_management_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#kafka_management_node HdinsightKafkaCluster#kafka_management_node}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafkaManagementNode", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRolesKafkaManagementNode\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode? KafkaManagementNode
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRolesKafkaManagementNode?>();
            }
        }
    }
}
