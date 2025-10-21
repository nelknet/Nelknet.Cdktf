using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRoles")]
    public class HdinsightHbaseClusterRoles : azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRoles
    {
        /// <summary>head_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#head_node HdinsightHbaseCluster#head_node}
        /// </remarks>
        [JsiiProperty(name: "headNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesHeadNode\"}")]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesHeadNode HeadNode
        {
            get;
            set;
        }

        /// <summary>worker_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#worker_node HdinsightHbaseCluster#worker_node}
        /// </remarks>
        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNode\"}")]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNode WorkerNode
        {
            get;
            set;
        }

        /// <summary>zookeeper_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#zookeeper_node HdinsightHbaseCluster#zookeeper_node}
        /// </remarks>
        [JsiiProperty(name: "zookeeperNode", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesZookeeperNode\"}")]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesZookeeperNode ZookeeperNode
        {
            get;
            set;
        }
    }
}
