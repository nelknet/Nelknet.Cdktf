using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertProcessingRuleSuppression
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionOutputReference), fullyQualifiedName: "azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorAlertProcessingRuleSuppressionConditionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorAlertProcessingRuleSuppressionConditionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAlertProcessingRuleSuppressionConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAlertProcessingRuleSuppressionConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlertContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContext\"}}]")]
        public virtual void PutAlertContext(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlertRuleId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleId\"}}]")]
        public virtual void PutAlertRuleId(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlertRuleName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleName\"}}]")]
        public virtual void PutAlertRuleName(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDescription", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescription\"}}]")]
        public virtual void PutDescription(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitorCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorCondition\"}}]")]
        public virtual void PutMonitorCondition(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitorService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorService\"}}]")]
        public virtual void PutMonitorService(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSeverity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverity\"}}]")]
        public virtual void PutSeverity(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSignalType", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalType\"}}]")]
        public virtual void PutSignalType(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResource\"}}]")]
        public virtual void PutTargetResource(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetResourceGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup\"}}]")]
        public virtual void PutTargetResourceGroup(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetResourceType", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceType\"}}]")]
        public virtual void PutTargetResourceType(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlertContext")]
        public virtual void ResetAlertContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlertRuleId")]
        public virtual void ResetAlertRuleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlertRuleName")]
        public virtual void ResetAlertRuleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitorCondition")]
        public virtual void ResetMonitorCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitorService")]
        public virtual void ResetMonitorService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSeverity")]
        public virtual void ResetSeverity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignalType")]
        public virtual void ResetSignalType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResource")]
        public virtual void ResetTargetResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourceGroup")]
        public virtual void ResetTargetResourceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourceType")]
        public virtual void ResetTargetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "alertContext", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContextOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContextOutputReference AlertContext
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContextOutputReference>()!;
        }

        [JsiiProperty(name: "alertRuleId", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleIdOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleIdOutputReference AlertRuleId
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleIdOutputReference>()!;
        }

        [JsiiProperty(name: "alertRuleName", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleNameOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleNameOutputReference AlertRuleName
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleNameOutputReference>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescriptionOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescriptionOutputReference Description
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescriptionOutputReference>()!;
        }

        [JsiiProperty(name: "monitorCondition", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorConditionOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorConditionOutputReference MonitorCondition
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorConditionOutputReference>()!;
        }

        [JsiiProperty(name: "monitorService", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorServiceOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorServiceOutputReference MonitorService
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorServiceOutputReference>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverityOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverityOutputReference Severity
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverityOutputReference>()!;
        }

        [JsiiProperty(name: "signalType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalTypeOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalTypeOutputReference SignalType
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalTypeOutputReference>()!;
        }

        [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceOutputReference TargetResource
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceOutputReference>()!;
        }

        [JsiiProperty(name: "targetResourceGroup", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroupOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroupOutputReference TargetResourceGroup
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroupOutputReference>()!;
        }

        [JsiiProperty(name: "targetResourceType", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceTypeOutputReference\"}")]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceTypeOutputReference TargetResourceType
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceTypeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertContextInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertContext\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext? AlertContextInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertContext?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertRuleIdInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleId\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId? AlertRuleIdInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleId?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertRuleNameInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionAlertRuleName\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName? AlertRuleNameInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionAlertRuleName?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionDescription\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription? DescriptionInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionDescription?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorConditionInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorCondition\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition? MonitorConditionInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorServiceInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionMonitorService\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService? MonitorServiceInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionMonitorService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "severityInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSeverity\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity? SeverityInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSeverity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signalTypeInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionSignalType\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType? SignalTypeInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionSignalType?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceGroupInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup? TargetResourceGroupInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResource\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource? TargetResourceInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceTypeInput", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionConditionTargetResourceType\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType? TargetResourceTypeInput
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionConditionTargetResourceType?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorAlertProcessingRuleSuppression.MonitorAlertProcessingRuleSuppressionCondition\"}", isOptional: true)]
        public virtual azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionCondition? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorAlertProcessingRuleSuppression.IMonitorAlertProcessingRuleSuppressionCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
