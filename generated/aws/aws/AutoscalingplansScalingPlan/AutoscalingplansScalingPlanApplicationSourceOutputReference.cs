using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingplansScalingPlan
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceOutputReference), fullyQualifiedName: "aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingplansScalingPlanApplicationSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingplansScalingPlanApplicationSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingplansScalingPlanApplicationSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlanApplicationSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTagFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTagFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSourceTagFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSourceTagFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSourceTagFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudformationStackArn")]
        public virtual void ResetCloudformationStackArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagFilter")]
        public virtual void ResetTagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "tagFilter", typeJson: "{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilterList\"}")]
        public virtual aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilterList TagFilter
        {
            get => GetInstanceProperty<aws.AutoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudformationStackArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudformationStackArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudformationStackArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSource\"}", isOptional: true)]
        public virtual aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSource? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
