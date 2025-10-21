using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleScheduled
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleScheduledEventGrouping), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEventGrouping")]
    public interface ISentinelAlertRuleScheduledEventGrouping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#aggregation_method SentinelAlertRuleScheduled#aggregation_method}.</summary>
        [JsiiProperty(name: "aggregationMethod", typeJson: "{\"primitive\":\"string\"}")]
        string AggregationMethod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleScheduledEventGrouping), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledEventGrouping")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledEventGrouping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#aggregation_method SentinelAlertRuleScheduled#aggregation_method}.</summary>
            [JsiiProperty(name: "aggregationMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string AggregationMethod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
