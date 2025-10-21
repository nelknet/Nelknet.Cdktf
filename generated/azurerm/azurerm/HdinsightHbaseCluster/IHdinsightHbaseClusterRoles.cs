using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterRoles), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRoles")]
    public interface IHdinsightHbaseClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#head_node HdinsightHbaseCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNode\"}")]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode HeadNode
        {
            get;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#worker_node HdinsightHbaseCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNode\"}")]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode WorkerNode
        {
            get;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#zookeeper_node HdinsightHbaseCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNode\"}")]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode ZookeeperNode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterRoles), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRoles")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>head_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#head_node HdinsightHbaseCluster#head_node}
            /// </remarks>
            [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNode\"}")]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode HeadNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode>()!;
            }

            /// <summary>worker_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#worker_node HdinsightHbaseCluster#worker_node}
            /// </remarks>
            [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNode\"}")]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode WorkerNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode>()!;
            }

            /// <summary>zookeeper_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#zookeeper_node HdinsightHbaseCluster#zookeeper_node}
            /// </remarks>
            [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNode\"}")]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode ZookeeperNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode>()!;
            }
        }
    }
}
