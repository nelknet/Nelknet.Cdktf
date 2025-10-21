using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiClass(nativeType: typeof(aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanActionOutputReference), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmincidentsResponsePlanActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmincidentsResponsePlanActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SsmincidentsResponsePlanActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmincidentsResponsePlanActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSsmAutomation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSsmAutomation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanActionSsmAutomation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanActionSsmAutomation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanActionSsmAutomation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSsmAutomation")]
        public virtual void ResetSsmAutomation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ssmAutomation", typeJson: "{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomationList\"}")]
        public virtual aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomationList SsmAutomation
        {
            get => GetInstanceProperty<aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssmAutomationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SsmAutomationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanAction\"}", isOptional: true)]
        public virtual aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanAction? InternalValue
        {
            get => GetInstanceProperty<aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
