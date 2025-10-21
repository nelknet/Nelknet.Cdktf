using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettings")]
    public class MonitorDataCollectionRuleDataSourcesLogFileSettings : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettings
    {
        /// <summary>text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#text MonitorDataCollectionRule#text}
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsText\"}")]
        public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText Text
        {
            get;
            set;
        }
    }
}
