using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterRoles), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRoles")]
    public interface IHdinsightSparkClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#head_node HdinsightSparkCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesHeadNode\"}")]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode HeadNode
        {
            get;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#worker_node HdinsightSparkCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNode\"}")]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode WorkerNode
        {
            get;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#zookeeper_node HdinsightSparkCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNode\"}")]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode ZookeeperNode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterRoles), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRoles")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>head_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#head_node HdinsightSparkCluster#head_node}
            /// </remarks>
            [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesHeadNode\"}")]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode HeadNode
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesHeadNode>()!;
            }

            /// <summary>worker_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#worker_node HdinsightSparkCluster#worker_node}
            /// </remarks>
            [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNode\"}")]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode WorkerNode
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNode>()!;
            }

            /// <summary>zookeeper_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#zookeeper_node HdinsightSparkCluster#zookeeper_node}
            /// </remarks>
            [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesZookeeperNode\"}")]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode ZookeeperNode
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesZookeeperNode>()!;
            }
        }
    }
}
