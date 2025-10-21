using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscale")]
    public class HdinsightSparkClusterRolesWorkerNodeAutoscale : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscale
    {
        /// <summary>capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#capacity HdinsightSparkCluster#capacity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleCapacity? Capacity
        {
            get;
            set;
        }

        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#recurrence HdinsightSparkCluster#recurrence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRolesWorkerNodeAutoscaleRecurrence? Recurrence
        {
            get;
            set;
        }
    }
}
