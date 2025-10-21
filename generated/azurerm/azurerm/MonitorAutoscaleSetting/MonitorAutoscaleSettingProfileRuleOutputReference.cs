using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleOutputReference), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MonitorAutoscaleSettingProfileRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MonitorAutoscaleSettingProfileRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSettingProfileRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSettingProfileRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMetricTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTrigger\"}}]")]
        public virtual void PutMetricTrigger(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleAction\"}}]")]
        public virtual void PutScaleAction(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction)}, new object[]{@value});
        }

        [JsiiProperty(name: "metricTrigger", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTriggerOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTriggerOutputReference MetricTrigger
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "scaleAction", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleActionOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleActionOutputReference ScaleAction
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTriggerInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTrigger\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger? MetricTriggerInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleActionInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleAction\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction? ScaleActionInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
