using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceSipRule
{
    [JsiiClass(nativeType: typeof(aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplicationsList), fullyQualifiedName: "aws.chimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplicationsList", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"wrapsSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ChimesdkvoiceSipRuleTargetApplicationsList : HashiCorp.Cdktf.ComplexList
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="wrapsSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ChimesdkvoiceSipRuleTargetApplicationsList(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, wrapsSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, wrapsSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimesdkvoiceSipRuleTargetApplicationsList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimesdkvoiceSipRuleTargetApplicationsList(DeputyProps props): base(props)
        {
        }

        /// <param name="index">the index of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"aws.chimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplicationsOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the index of the item to return.\"},\"name\":\"index\",\"type\":{\"primitive\":\"number\"}}]")]
        public virtual aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplicationsOutputReference Get(double index)
        {
            return InvokeInstanceMethod<aws.ChimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplicationsOutputReference>(new System.Type[]{typeof(double)}, new object[]{index})!;
        }

        /// <summary>The attribute on the parent resource this class is referencing.</summary>
        [JsiiProperty(name: "terraformAttribute", typeJson: "{\"primitive\":\"string\"}")]
        protected override string TerraformAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <summary>The parent resource.</summary>
        [JsiiProperty(name: "terraformResource", typeJson: "{\"fqn\":\"cdktf.IInterpolatingParent\"}")]
        protected override HashiCorp.Cdktf.IInterpolatingParent TerraformResource
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IInterpolatingParent>()!;
            set => SetInstanceProperty(value);
        }

        /// <summary>whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</summary>
        [JsiiProperty(name: "wrapsSet", typeJson: "{\"primitive\":\"boolean\"}")]
        protected override bool WrapsSet
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.ChimesdkvoiceSipRule.IChimesdkvoiceSipRuleTargetApplications[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ChimesdkvoiceSipRule.IChimesdkvoiceSipRuleTargetApplications).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
