using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleSuppression
{
    [JsiiByValue(fqn: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionCondition")]
    public class MonitorAlertProcessingRuleSuppressionCondition : azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionCondition
    {
        /// <summary>alert_context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_context MonitorAlertProcessingRuleSuppression#alert_context}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertContext", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContext\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext? AlertContext
        {
            get;
            set;
        }

        /// <summary>alert_rule_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_rule_id MonitorAlertProcessingRuleSuppression#alert_rule_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertRuleId", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleId\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId? AlertRuleId
        {
            get;
            set;
        }

        /// <summary>alert_rule_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_rule_name MonitorAlertProcessingRuleSuppression#alert_rule_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertRuleName", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleName\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName? AlertRuleName
        {
            get;
            set;
        }

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#description MonitorAlertProcessingRuleSuppression#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescription\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription? Description
        {
            get;
            set;
        }

        /// <summary>monitor_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monitor_condition MonitorAlertProcessingRuleSuppression#monitor_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorCondition", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorCondition\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition? MonitorCondition
        {
            get;
            set;
        }

        /// <summary>monitor_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monitor_service MonitorAlertProcessingRuleSuppression#monitor_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorService", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorService\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService? MonitorService
        {
            get;
            set;
        }

        /// <summary>severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#severity MonitorAlertProcessingRuleSuppression#severity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "severity", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverity\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity? Severity
        {
            get;
            set;
        }

        /// <summary>signal_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#signal_type MonitorAlertProcessingRuleSuppression#signal_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signalType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalType\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType? SignalType
        {
            get;
            set;
        }

        /// <summary>target_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource MonitorAlertProcessingRuleSuppression#target_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResource\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource? TargetResource
        {
            get;
            set;
        }

        /// <summary>target_resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource_group MonitorAlertProcessingRuleSuppression#target_resource_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceGroup", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup? TargetResourceGroup
        {
            get;
            set;
        }

        /// <summary>target_resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource_type MonitorAlertProcessingRuleSuppression#target_resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceType\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType? TargetResourceType
        {
            get;
            set;
        }
    }
}
