using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtension")]
    public class MonitorDataCollectionRuleDataSourcesExtension : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#extension_name MonitorDataCollectionRule#extension_name}.</summary>
        [JsiiProperty(name: "extensionName", typeJson: "{\"primitive\":\"string\"}")]
        public string ExtensionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#name MonitorDataCollectionRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#streams MonitorDataCollectionRule#streams}.</summary>
        [JsiiProperty(name: "streams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Streams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#extension_json MonitorDataCollectionRule#extension_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extensionJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExtensionJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#input_data_sources MonitorDataCollectionRule#input_data_sources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputDataSources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InputDataSources
        {
            get;
            set;
        }
    }
}
