using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource")]
    public class MonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImportEventHubDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#stream MonitorDataCollectionRule#stream}.</summary>
        [JsiiProperty(name: "stream", typeJson: "{\"primitive\":\"string\"}")]
        public string Stream
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#consumer_group MonitorDataCollectionRule#consumer_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consumerGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerGroup
        {
            get;
            set;
        }
    }
}
