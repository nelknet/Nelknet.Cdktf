using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatadogMonitorTagRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.datadogMonitorTagRule.DatadogMonitorTagRuleLogFilter")]
    public class DatadogMonitorTagRuleLogFilter : azurerm.DatadogMonitorTagRule.IDatadogMonitorTagRuleLogFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#action DatadogMonitorTagRule#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#name DatadogMonitorTagRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_tag_rule#value DatadogMonitorTagRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
