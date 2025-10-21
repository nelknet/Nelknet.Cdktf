using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMonitor")]
    public class HdinsightHadoopClusterMonitor : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMonitor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#log_analytics_workspace_id HdinsightHadoopCluster#log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogAnalyticsWorkspaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#primary_key HdinsightHadoopCluster#primary_key}.</summary>
        [JsiiProperty(name: "primaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PrimaryKey
        {
            get;
            set;
        }
    }
}
