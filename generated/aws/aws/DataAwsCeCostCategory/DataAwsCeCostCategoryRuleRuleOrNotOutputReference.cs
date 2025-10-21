using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotOutputReference), fullyQualifiedName: "aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCeCostCategoryRuleRuleOrNotOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCeCostCategoryRuleRuleOrNotOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsCeCostCategoryRuleRuleOrNotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeCostCategoryRuleRuleOrNotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotCostCategoryList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotCostCategoryList CostCategory
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotCostCategoryList>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotDimensionList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotDimensionList Dimension
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotDimensionList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotTagsList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotTagsList Tags
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNotTagsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleOrNot\"}", isOptional: true)]
        public virtual aws.DataAwsCeCostCategory.IDataAwsCeCostCategoryRuleRuleOrNot? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.IDataAwsCeCostCategoryRuleRuleOrNot?>();
            set => SetInstanceProperty(value);
        }
    }
}
