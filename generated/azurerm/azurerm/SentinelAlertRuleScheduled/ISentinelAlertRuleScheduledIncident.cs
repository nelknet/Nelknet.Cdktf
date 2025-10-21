using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleScheduled
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleScheduledIncident), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident")]
    public interface ISentinelAlertRuleScheduledIncident
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#create_incident_enabled SentinelAlertRuleScheduled#create_incident_enabled}.</summary>
        [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object CreateIncidentEnabled
        {
            get;
        }

        /// <summary>grouping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#grouping SentinelAlertRuleScheduled#grouping}
        /// </remarks>
        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGrouping\"}")]
        azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping Grouping
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleScheduledIncident), fullyQualifiedName: "azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncident")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncident
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#create_incident_enabled SentinelAlertRuleScheduled#create_incident_enabled}.</summary>
            [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object CreateIncidentEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>grouping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_alert_rule_scheduled#grouping SentinelAlertRuleScheduled#grouping}
            /// </remarks>
            [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleScheduled.SentinelAlertRuleScheduledIncidentGrouping\"}")]
            public azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping Grouping
            {
                get => GetInstanceProperty<azurerm.SentinelAlertRuleScheduled.ISentinelAlertRuleScheduledIncidentGrouping>()!;
            }
        }
    }
}
