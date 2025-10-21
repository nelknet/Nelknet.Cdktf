using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeAutoscale")]
    public class HdinsightHbaseClusterRolesWorkerNodeAutoscale : azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNodeAutoscale
    {
        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#recurrence HdinsightHbaseCluster#recurrence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence? Recurrence
        {
            get;
            set;
        }
    }
}
