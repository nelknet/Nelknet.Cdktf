using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndOutputReference), fullyQualifiedName: "aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCeCostCategoryRuleRuleAndOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCeCostCategoryRuleRuleAndOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsCeCostCategoryRuleRuleAndOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeCostCategoryRuleRuleAndOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndAndList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndAndList And
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndAndList>()!;
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndCostCategoryList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndCostCategoryList CostCategory
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndCostCategoryList>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndDimensionList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndDimensionList Dimension
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndDimensionList>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndNotList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndNotList Not
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndNotList>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndOrList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndOrList Or
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndTagsList\"}")]
        public virtual aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndTagsList Tags
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAndTagsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCeCostCategory.DataAwsCeCostCategoryRuleRuleAnd\"}", isOptional: true)]
        public virtual aws.DataAwsCeCostCategory.IDataAwsCeCostCategoryRuleRuleAnd? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCeCostCategory.IDataAwsCeCostCategoryRuleRuleAnd?>();
            set => SetInstanceProperty(value);
        }
    }
}
