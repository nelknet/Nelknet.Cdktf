using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.CeCostCategory.CeCostCategoryRuleRuleAndNotOutputReference), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleRuleAndNotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CeCostCategoryRuleRuleAndNotOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CeCostCategoryRuleRuleAndNotOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CeCostCategoryRuleRuleAndNotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleRuleAndNotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotDimension\"}}]")]
        public virtual void PutDimension(aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotTags\"}}]")]
        public virtual void PutTags(aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotCostCategoryOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndNotCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndNotCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotDimensionOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndNotDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndNotDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotTagsOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleAndNotTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleAndNotTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotCostCategory\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotDimension\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNotTags\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndNotTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleAndNot\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRuleAndNot? InternalValue
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRuleAndNot?>();
            set => SetInstanceProperty(value);
        }
    }
}
