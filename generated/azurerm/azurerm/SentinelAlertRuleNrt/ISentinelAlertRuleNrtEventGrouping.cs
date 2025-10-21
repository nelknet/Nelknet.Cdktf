using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleNrt
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleNrtEventGrouping), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtEventGrouping")]
    public interface ISentinelAlertRuleNrtEventGrouping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#aggregation_method SentinelAlertRuleNrt#aggregation_method}.</summary>
        [JsiiProperty(name: "aggregationMethod", typeJson: "{\"primitive\":\"string\"}")]
        string AggregationMethod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleNrtEventGrouping), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtEventGrouping")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtEventGrouping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#aggregation_method SentinelAlertRuleNrt#aggregation_method}.</summary>
            [JsiiProperty(name: "aggregationMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string AggregationMethod
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
