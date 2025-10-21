using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.CeCostCategory.CeCostCategoryRuleRuleAndOrOutputReference), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleAndOrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CeCostCategoryRuleRuleAndOrOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CeCostCategoryRuleRuleAndOrOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CeCostCategoryRuleRuleAndOrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleRuleAndOrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrDimension\"}}]")]
        public virtual void PutDimension(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrTags\"}}]")]
        public virtual void PutTags(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrTags)}, new object[]{@value});
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

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrCostCategoryOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndOrCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndOrCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrDimensionOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndOrDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndOrDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrTagsOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndOrTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndOrTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrCostCategory\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrDimension\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOrTags\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndOrTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndOr\"}]}}", isOptional: true)]
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
                        case aws.CeCostCategory.ICeCostCategoryRuleRuleAndOr cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndOr).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
