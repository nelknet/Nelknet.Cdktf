using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiClass(nativeType: typeof(aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndOutputReference), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CeAnomalySubscriptionThresholdExpressionAndOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CeAnomalySubscriptionThresholdExpressionAndOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CeAnomalySubscriptionThresholdExpressionAndOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeAnomalySubscriptionThresholdExpressionAndOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndDimension\"}}]")]
        public virtual void PutDimension(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndTags\"}}]")]
        public virtual void PutTags(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndCostCategoryOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndDimensionOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndTagsOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndCostCategory\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndDimension\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndTags\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAndTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAnd\"}]}}", isOptional: true)]
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
                        case aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAnd cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAnd).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
