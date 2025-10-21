using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2FindingsFilter
{
    [JsiiClass(nativeType: typeof(aws.Macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaOutputReference), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Macie2FindingsFilterFindingCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Macie2FindingsFilterFindingCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Macie2FindingsFilterFindingCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2FindingsFilterFindingCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCriterion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCriterion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteriaCriterion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteriaCriterion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteriaCriterion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCriterion")]
        public virtual void ResetCriterion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "criterion", typeJson: "{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterionList\"}")]
        public virtual aws.Macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterionList Criterion
        {
            get => GetInstanceProperty<aws.Macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "criterionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CriterionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteria\"}", isOptional: true)]
        public virtual aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
