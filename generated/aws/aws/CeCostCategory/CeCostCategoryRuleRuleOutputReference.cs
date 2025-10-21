using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.CeCostCategory.CeCostCategoryRuleRuleOutputReference), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CeCostCategoryRuleRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CeCostCategoryRuleRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CeCostCategoryRuleRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CeCostCategory.ICeCostCategoryRuleRuleAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleDimension\"}}]")]
        public virtual void PutDimension(aws.CeCostCategory.ICeCostCategoryRuleRuleDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNot\"}}]")]
        public virtual void PutNot(aws.CeCostCategory.ICeCostCategoryRuleRuleNot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CeCostCategory.ICeCostCategoryRuleRuleOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleTags\"}}]")]
        public virtual void PutTags(aws.CeCostCategory.ICeCostCategoryRuleRuleTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostCategory")]
        public virtual void ResetCostCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDimension")]
        public virtual void ResetDimension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNot")]
        public virtual void ResetNot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOr")]
        public virtual void ResetOr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndList\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndList And
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndList>()!;
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleCostCategoryOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleDimensionOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotOutputReference Not
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotOutputReference>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrList\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleOrList Or
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleTagsOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleCostCategory\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleDimension\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNot\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleNot? NotInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleTags\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRule\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRule? InternalValue
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
