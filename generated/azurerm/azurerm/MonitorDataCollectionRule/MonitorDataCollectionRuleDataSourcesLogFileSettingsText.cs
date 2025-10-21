using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileSettingsText")]
    public class MonitorDataCollectionRuleDataSourcesLogFileSettingsText : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFileSettingsText
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#record_start_timestamp_format MonitorDataCollectionRule#record_start_timestamp_format}.</summary>
        [JsiiProperty(name: "recordStartTimestampFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string RecordStartTimestampFormat
        {
            get;
            set;
        }
    }
}
