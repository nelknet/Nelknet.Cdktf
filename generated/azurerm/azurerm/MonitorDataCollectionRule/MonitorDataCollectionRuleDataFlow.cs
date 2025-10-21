using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataFlow")]
    public class MonitorDataCollectionRuleDataFlow : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataFlow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#destinations MonitorDataCollectionRule#destinations}.</summary>
        [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Destinations
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#built_in_transform MonitorDataCollectionRule#built_in_transform}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "builtInTransform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BuiltInTransform
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#output_stream MonitorDataCollectionRule#output_stream}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputStream
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#transform_kql MonitorDataCollectionRule#transform_kql}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transformKql", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransformKql
        {
            get;
            set;
        }
    }
}
