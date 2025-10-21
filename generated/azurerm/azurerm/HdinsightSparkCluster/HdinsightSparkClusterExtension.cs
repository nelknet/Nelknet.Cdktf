using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterExtension")]
    public class HdinsightSparkClusterExtension : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#log_analytics_workspace_id HdinsightSparkCluster#log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogAnalyticsWorkspaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#primary_key HdinsightSparkCluster#primary_key}.</summary>
        [JsiiProperty(name: "primaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PrimaryKey
        {
            get;
            set;
        }
    }
}
