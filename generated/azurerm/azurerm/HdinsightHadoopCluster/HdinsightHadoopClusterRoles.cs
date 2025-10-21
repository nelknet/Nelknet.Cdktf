using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRoles")]
    public class HdinsightHadoopClusterRoles : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#head_node HdinsightHadoopCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesHeadNode\"}")]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesHeadNode HeadNode
        {
            get;
            set;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#worker_node HdinsightHadoopCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNode\"}")]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNode WorkerNode
        {
            get;
            set;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#zookeeper_node HdinsightHadoopCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesZookeeperNode\"}")]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesZookeeperNode ZookeeperNode
        {
            get;
            set;
        }

        /// <summary>edge_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#edge_node HdinsightHadoopCluster#edge_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNode\"}", isOptional: true)]
        public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNode? EdgeNode
        {
            get;
            set;
        }
    }
}
