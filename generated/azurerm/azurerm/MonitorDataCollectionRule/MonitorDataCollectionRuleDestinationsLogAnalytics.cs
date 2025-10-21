using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalytics")]
    public class MonitorDataCollectionRuleDestinationsLogAnalytics : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsLogAnalytics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#workspace_resource_id MonitorDataCollectionRule#workspace_resource_id}.</summary>
        [JsiiProperty(name: "workspaceResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkspaceResourceId
        {
            get;
            set;
        }
    }
}
