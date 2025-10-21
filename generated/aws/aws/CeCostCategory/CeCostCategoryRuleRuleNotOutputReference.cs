using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.CeCostCategory.CeCostCategoryRuleRuleNotOutputReference), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleNotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CeCostCategoryRuleRuleNotOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CeCostCategoryRuleRuleNotOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CeCostCategoryRuleRuleNotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleRuleNotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CeCostCategory.ICeCostCategoryRuleRuleNotAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeCostCategory.ICeCostCategoryRuleRuleNotCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotDimension\"}}]")]
        public virtual void PutDimension(aws.CeCostCategory.ICeCostCategoryRuleRuleNotDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotNot\"}}]")]
        public virtual void PutNot(aws.CeCostCategory.ICeCostCategoryRuleRuleNotNot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotNot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CeCostCategory.ICeCostCategoryRuleRuleNotOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotTags\"}}]")]
        public virtual void PutTags(aws.CeCostCategory.ICeCostCategoryRuleRuleNotTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleNotTags)}, new object[]{@value});
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

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotAndList\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotAndList And
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotAndList>()!;
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotCostCategoryOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotDimensionOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotNotOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotNotOutputReference Not
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotNotOutputReference>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOrList\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotOrList Or
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotTagsOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleNotTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleNotTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotCostCategory\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleNotCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotDimension\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleNotDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotNot\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleNotNot? NotInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotNot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNotTags\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleNotTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNotTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleNot\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleNot? InternalValue
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleNot?>();
            set => SetInstanceProperty(value);
        }
    }
}
