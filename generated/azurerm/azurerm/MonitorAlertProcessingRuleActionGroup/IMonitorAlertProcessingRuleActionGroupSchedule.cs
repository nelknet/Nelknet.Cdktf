using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleActionGroup
{
    [JsiiInterface(nativeType: typeof(IMonitorAlertProcessingRuleActionGroupSchedule), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupSchedule")]
    public interface IMonitorAlertProcessingRuleActionGroupSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#effective_from MonitorAlertProcessingRuleActionGroup#effective_from}.</summary>
        [JsiiProperty(name: "effectiveFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EffectiveFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#effective_until MonitorAlertProcessingRuleActionGroup#effective_until}.</summary>
        [JsiiProperty(name: "effectiveUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EffectiveUntil
        {
            get
            {
                return null;
            }
        }

        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#recurrence MonitorAlertProcessingRuleActionGroup#recurrence}
        /// </remarks>
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupScheduleRecurrence\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrence? Recurrence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#time_zone MonitorAlertProcessingRuleActionGroup#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAlertProcessingRuleActionGroupSchedule), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#effective_from MonitorAlertProcessingRuleActionGroup#effective_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "effectiveFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EffectiveFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#effective_until MonitorAlertProcessingRuleActionGroup#effective_until}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "effectiveUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EffectiveUntil
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>recurrence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#recurrence MonitorAlertProcessingRuleActionGroup#recurrence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupScheduleRecurrence\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrence? Recurrence
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupScheduleRecurrence?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#time_zone MonitorAlertProcessingRuleActionGroup#time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
