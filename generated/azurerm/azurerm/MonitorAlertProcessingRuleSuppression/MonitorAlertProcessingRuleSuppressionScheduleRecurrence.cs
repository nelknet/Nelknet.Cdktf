using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleSuppression
{
    [JsiiByValue(fqn: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrence")]
    public class MonitorAlertProcessingRuleSuppressionScheduleRecurrence : azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrence
    {
        private object? _daily;

        /// <summary>daily block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#daily MonitorAlertProcessingRuleSuppression#daily}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "daily", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Daily
        {
            get => _daily;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceDaily).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _daily = value;
            }
        }

        private object? _monthly;

        /// <summary>monthly block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monthly MonitorAlertProcessingRuleSuppression#monthly}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monthly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Monthly
        {
            get => _monthly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceMonthly).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _monthly = value;
            }
        }

        private object? _weekly;

        /// <summary>weekly block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#weekly MonitorAlertProcessingRuleSuppression#weekly}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weekly", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Weekly
        {
            get => _weekly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionScheduleRecurrenceWeekly).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _weekly = value;
            }
        }
    }
}
