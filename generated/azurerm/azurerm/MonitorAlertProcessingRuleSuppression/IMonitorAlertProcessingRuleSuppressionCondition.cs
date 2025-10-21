using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleSuppression
{
    [JsiiInterface(nativeType: typeof(IMonitorAlertProcessingRuleSuppressionCondition), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionCondition")]
    public interface IMonitorAlertProcessingRuleSuppressionCondition
    {
        /// <summary>alert_context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_context MonitorAlertProcessingRuleSuppression#alert_context}
        /// </remarks>
        [JsiiProperty(name: "alertContext", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext? AlertContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>alert_rule_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_rule_id MonitorAlertProcessingRuleSuppression#alert_rule_id}
        /// </remarks>
        [JsiiProperty(name: "alertRuleId", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId? AlertRuleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>alert_rule_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_rule_name MonitorAlertProcessingRuleSuppression#alert_rule_name}
        /// </remarks>
        [JsiiProperty(name: "alertRuleName", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName? AlertRuleName
        {
            get
            {
                return null;
            }
        }

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#description MonitorAlertProcessingRuleSuppression#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescription\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monitor_condition MonitorAlertProcessingRuleSuppression#monitor_condition}
        /// </remarks>
        [JsiiProperty(name: "monitorCondition", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition? MonitorCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monitor_service MonitorAlertProcessingRuleSuppression#monitor_service}
        /// </remarks>
        [JsiiProperty(name: "monitorService", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService? MonitorService
        {
            get
            {
                return null;
            }
        }

        /// <summary>severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#severity MonitorAlertProcessingRuleSuppression#severity}
        /// </remarks>
        [JsiiProperty(name: "severity", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity? Severity
        {
            get
            {
                return null;
            }
        }

        /// <summary>signal_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#signal_type MonitorAlertProcessingRuleSuppression#signal_type}
        /// </remarks>
        [JsiiProperty(name: "signalType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalType\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType? SignalType
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource MonitorAlertProcessingRuleSuppression#target_resource}
        /// </remarks>
        [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource? TargetResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource_group MonitorAlertProcessingRuleSuppression#target_resource_group}
        /// </remarks>
        [JsiiProperty(name: "targetResourceGroup", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup? TargetResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource_type MonitorAlertProcessingRuleSuppression#target_resource_type}
        /// </remarks>
        [JsiiProperty(name: "targetResourceType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceType\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType? TargetResourceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAlertProcessingRuleSuppressionCondition), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionCondition")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>alert_context block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_context MonitorAlertProcessingRuleSuppression#alert_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alertContext", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContext\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext? AlertContext
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext?>();
            }

            /// <summary>alert_rule_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_rule_id MonitorAlertProcessingRuleSuppression#alert_rule_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alertRuleId", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleId\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId? AlertRuleId
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId?>();
            }

            /// <summary>alert_rule_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#alert_rule_name MonitorAlertProcessingRuleSuppression#alert_rule_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alertRuleName", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleName\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName? AlertRuleName
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName?>();
            }

            /// <summary>description block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#description MonitorAlertProcessingRuleSuppression#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescription\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription? Description
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription?>();
            }

            /// <summary>monitor_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monitor_condition MonitorAlertProcessingRuleSuppression#monitor_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitorCondition", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorCondition\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition? MonitorCondition
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition?>();
            }

            /// <summary>monitor_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#monitor_service MonitorAlertProcessingRuleSuppression#monitor_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitorService", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorService\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService? MonitorService
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService?>();
            }

            /// <summary>severity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#severity MonitorAlertProcessingRuleSuppression#severity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "severity", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverity\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity? Severity
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity?>();
            }

            /// <summary>signal_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#signal_type MonitorAlertProcessingRuleSuppression#signal_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signalType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalType\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType? SignalType
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType?>();
            }

            /// <summary>target_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource MonitorAlertProcessingRuleSuppression#target_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResource\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource? TargetResource
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource?>();
            }

            /// <summary>target_resource_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource_group MonitorAlertProcessingRuleSuppression#target_resource_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourceGroup", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup? TargetResourceGroup
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup?>();
            }

            /// <summary>target_resource_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_processing_rule_suppression#target_resource_type MonitorAlertProcessingRuleSuppression#target_resource_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourceType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceType\"}", isOptional: true)]
            public azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType? TargetResourceType
            {
                get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType?>();
            }
        }
    }
}
