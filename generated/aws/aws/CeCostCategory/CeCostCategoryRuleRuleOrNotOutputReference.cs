using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.CeCostCategory.CeCostCategoryRuleRuleOrNotOutputReference), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleOrNotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CeCostCategoryRuleRuleOrNotOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CeCostCategoryRuleRuleOrNotOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CeCostCategoryRuleRuleOrNotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleRuleOrNotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotDimension\"}}]")]
        public virtual void PutDimension(aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotTags\"}}]")]
        public virtual void PutTags(aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotCostCategoryOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleOrNotCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleOrNotCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotDimensionOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleOrNotDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleOrNotDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotTagsOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleOrNotTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleOrNotTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotCostCategory\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotDimension\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNotTags\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNotTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOrNot\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleOrNot? InternalValue
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleOrNot?>();
            set => SetInstanceProperty(value);
        }
    }
}
