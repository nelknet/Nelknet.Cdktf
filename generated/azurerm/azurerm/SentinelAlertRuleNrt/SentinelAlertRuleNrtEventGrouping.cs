using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleNrt
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtEventGrouping")]
    public class SentinelAlertRuleNrtEventGrouping : azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtEventGrouping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#aggregation_method SentinelAlertRuleNrt#aggregation_method}.</summary>
        [JsiiProperty(name: "aggregationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string AggregationMethod
        {
            get;
            set;
        }
    }
}
