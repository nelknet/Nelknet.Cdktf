using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupWarmPoolOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupWarmPoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupWarmPoolOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupWarmPoolOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingGroupWarmPoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupWarmPoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceReusePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicy\"}}]")]
        public virtual void PutInstanceReusePolicy(aws.AutoscalingGroup.IAutoscalingGroupWarmPoolInstanceReusePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingGroup.IAutoscalingGroupWarmPoolInstanceReusePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstanceReusePolicy")]
        public virtual void ResetInstanceReusePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxGroupPreparedCapacity")]
        public virtual void ResetMaxGroupPreparedCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinSize")]
        public virtual void ResetMinSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolState")]
        public virtual void ResetPoolState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instanceReusePolicy", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicyOutputReference\"}")]
        public virtual aws.AutoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicyOutputReference InstanceReusePolicy
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceReusePolicyInput", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicy\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupWarmPoolInstanceReusePolicy? InstanceReusePolicyInput
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupWarmPoolInstanceReusePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxGroupPreparedCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxGroupPreparedCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxGroupPreparedCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxGroupPreparedCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupWarmPool\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupWarmPool? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupWarmPool?>();
            set => SetInstanceProperty(value);
        }
    }
}
