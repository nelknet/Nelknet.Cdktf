using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiClass(nativeType: typeof(aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotOutputReference), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CeAnomalySubscriptionThresholdExpressionNotOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CeAnomalySubscriptionThresholdExpressionNotOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CeAnomalySubscriptionThresholdExpressionNotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeAnomalySubscriptionThresholdExpressionNotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotDimension\"}}]")]
        public virtual void PutDimension(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotTags\"}}]")]
        public virtual void PutTags(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotCostCategoryOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotDimensionOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotTagsOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotCostCategory\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotDimension\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotTags\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNotTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNot\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot? InternalValue
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot?>();
            set => SetInstanceProperty(value);
        }
    }
}
