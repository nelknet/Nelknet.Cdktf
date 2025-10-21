using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingPolicy
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationOutputReference), fullyQualifiedName: "aws.autoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingPolicyPredictiveScalingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingPolicyPredictiveScalingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingPolicyPredictiveScalingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyPredictiveScalingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}}]")]
        public virtual void PutMetricSpecification(aws.AutoscalingPolicy.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingPolicy.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaxCapacityBreachBehavior")]
        public virtual void ResetMaxCapacityBreachBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCapacityBuffer")]
        public virtual void ResetMaxCapacityBuffer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulingBufferTime")]
        public virtual void ResetSchedulingBufferTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "metricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference\"}")]
        public virtual aws.AutoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference MetricSpecification
        {
            get => GetInstanceProperty<aws.AutoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityBreachBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxCapacityBreachBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityBufferInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxCapacityBufferInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscalingPolicy.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}", isOptional: true)]
        public virtual aws.AutoscalingPolicy.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification? MetricSpecificationInput
        {
            get => GetInstanceProperty<aws.AutoscalingPolicy.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingBufferTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulingBufferTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxCapacityBreachBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxCapacityBuffer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingBufferTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingPolicy.AutoscalingPolicyPredictiveScalingConfiguration\"}", isOptional: true)]
        public virtual aws.AutoscalingPolicy.IAutoscalingPolicyPredictiveScalingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingPolicy.IAutoscalingPolicyPredictiveScalingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
