using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHadoopClusterRoles), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRoles")]
    public interface IHdinsightHadoopClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#head_node HdinsightHadoopCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNode\"}")]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode HeadNode
        {
            get;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#worker_node HdinsightHadoopCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNode\"}")]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode WorkerNode
        {
            get;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#zookeeper_node HdinsightHadoopCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNode\"}")]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode ZookeeperNode
        {
            get;
        }

        /// <summary>edge_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#edge_node HdinsightHadoopCluster#edge_node}
        /// </remarks>
        [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode? EdgeNode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHadoopClusterRoles), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRoles")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>head_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#head_node HdinsightHadoopCluster#head_node}
            /// </remarks>
            [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNode\"}")]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode HeadNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode>()!;
            }

            /// <summary>worker_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#worker_node HdinsightHadoopCluster#worker_node}
            /// </remarks>
            [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNode\"}")]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode WorkerNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode>()!;
            }

            /// <summary>zookeeper_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#zookeeper_node HdinsightHadoopCluster#zookeeper_node}
            /// </remarks>
            [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNode\"}")]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode ZookeeperNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode>()!;
            }

            /// <summary>edge_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#edge_node HdinsightHadoopCluster#edge_node}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNode\"}", isOptional: true)]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode? EdgeNode
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode?>();
            }
        }
    }
}
