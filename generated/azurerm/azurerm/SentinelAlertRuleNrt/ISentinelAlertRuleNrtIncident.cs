using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleNrt
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleNrtIncident), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncident")]
    public interface ISentinelAlertRuleNrtIncident
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#create_incident_enabled SentinelAlertRuleNrt#create_incident_enabled}.</summary>
        [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object CreateIncidentEnabled
        {
            get;
        }

        /// <summary>grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#grouping SentinelAlertRuleNrt#grouping}
        /// </remarks>
        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGrouping\"}")]
        azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping Grouping
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleNrtIncident), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncident")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncident
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#create_incident_enabled SentinelAlertRuleNrt#create_incident_enabled}.</summary>
            [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object CreateIncidentEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>grouping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_nrt#grouping SentinelAlertRuleNrt#grouping}
            /// </remarks>
            [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGrouping\"}")]
            public azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping Grouping
            {
                get => GetInstanceProperty<azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping>()!;
            }
        }
    }
}
