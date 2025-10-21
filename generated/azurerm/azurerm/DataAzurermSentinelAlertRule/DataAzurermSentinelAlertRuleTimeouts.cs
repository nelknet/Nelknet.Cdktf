using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSentinelAlertRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSentinelAlertRule.DataAzurermSentinelAlertRuleTimeouts")]
    public class DataAzurermSentinelAlertRuleTimeouts : azurerm.DataAzurermSentinelAlertRule.IDataAzurermSentinelAlertRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/sentinel_alert_rule#read DataAzurermSentinelAlertRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
