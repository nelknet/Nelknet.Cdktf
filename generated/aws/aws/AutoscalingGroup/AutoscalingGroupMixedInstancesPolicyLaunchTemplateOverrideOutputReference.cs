using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceRequirements", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements\"}}]")]
        public virtual void PutInstanceRequirements(aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchTemplateSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification\"}}]")]
        public virtual void PutLaunchTemplateSpecification(aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstanceRequirements")]
        public virtual void ResetInstanceRequirements()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplateSpecification")]
        public virtual void ResetLaunchTemplateSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeightedCapacity")]
        public virtual void ResetWeightedCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsOutputReference\"}")]
        public virtual aws.AutoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsOutputReference InstanceRequirements
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsOutputReference>()!;
        }

        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationOutputReference\"}")]
        public virtual aws.AutoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationOutputReference LaunchTemplateSpecification
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRequirementsInput", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements? InstanceRequirementsInput
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecificationInput
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeightedCapacityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeightedCapacity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride\"}]}}", isOptional: true)]
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
                        case aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
