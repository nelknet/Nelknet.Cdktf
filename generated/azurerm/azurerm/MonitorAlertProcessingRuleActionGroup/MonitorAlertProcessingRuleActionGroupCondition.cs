using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleActionGroup
{
    [JsiiByValue(fqn: "azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupCondition")]
    public class MonitorAlertProcessingRuleActionGroupCondition : azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupCondition
    {
        /// <summary>alert_context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#alert_context MonitorAlertProcessingRuleActionGroup#alert_context}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertContext", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionAlertContext\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionAlertContext? AlertContext
        {
            get;
            set;
        }

        /// <summary>alert_rule_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#alert_rule_id MonitorAlertProcessingRuleActionGroup#alert_rule_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertRuleId", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionAlertRuleId\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionAlertRuleId? AlertRuleId
        {
            get;
            set;
        }

        /// <summary>alert_rule_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#alert_rule_name MonitorAlertProcessingRuleActionGroup#alert_rule_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertRuleName", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionAlertRuleName\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionAlertRuleName? AlertRuleName
        {
            get;
            set;
        }

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#description MonitorAlertProcessingRuleActionGroup#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionDescription\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionDescription? Description
        {
            get;
            set;
        }

        /// <summary>monitor_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#monitor_condition MonitorAlertProcessingRuleActionGroup#monitor_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorCondition", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionMonitorCondition\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionMonitorCondition? MonitorCondition
        {
            get;
            set;
        }

        /// <summary>monitor_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#monitor_service MonitorAlertProcessingRuleActionGroup#monitor_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorService", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionMonitorService\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionMonitorService? MonitorService
        {
            get;
            set;
        }

        /// <summary>severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#severity MonitorAlertProcessingRuleActionGroup#severity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "severity", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionSeverity\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionSeverity? Severity
        {
            get;
            set;
        }

        /// <summary>signal_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#signal_type MonitorAlertProcessingRuleActionGroup#signal_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signalType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionSignalType\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionSignalType? SignalType
        {
            get;
            set;
        }

        /// <summary>target_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#target_resource MonitorAlertProcessingRuleActionGroup#target_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionTargetResource\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionTargetResource? TargetResource
        {
            get;
            set;
        }

        /// <summary>target_resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#target_resource_group MonitorAlertProcessingRuleActionGroup#target_resource_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceGroup", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionTargetResourceGroup\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionTargetResourceGroup? TargetResourceGroup
        {
            get;
            set;
        }

        /// <summary>target_resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_action_group#target_resource_type MonitorAlertProcessingRuleActionGroup#target_resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleActionGroup.MonitorAlertProcessingRuleActionGroupConditionTargetResourceType\"}", isOptional: true)]
        public azurerm.MonitorAlertProcessingRuleActionGroup.IMonitorAlertProcessingRuleActionGroupConditionTargetResourceType? TargetResourceType
        {
            get;
            set;
        }
    }
}
