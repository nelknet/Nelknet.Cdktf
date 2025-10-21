using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupInstanceRefreshOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupInstanceRefreshOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupInstanceRefreshOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingGroupInstanceRefreshOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences\"}}]")]
        public virtual void PutPreferences(aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPreferences")]
        public virtual void ResetPreferences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggers")]
        public virtual void ResetTriggers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesOutputReference\"}")]
        public virtual aws.AutoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesOutputReference Preferences
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferencesInput", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences? PreferencesInput
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TriggersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Triggers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefresh\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceRefresh? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceRefresh?>();
            set => SetInstanceProperty(value);
        }
    }
}
