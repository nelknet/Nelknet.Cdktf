using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeAnomalySubscription
{
    [JsiiClass(nativeType: typeof(aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOutputReference), fullyQualifiedName: "aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CeAnomalySubscriptionThresholdExpressionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CeAnomalySubscriptionThresholdExpressionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CeAnomalySubscriptionThresholdExpressionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeAnomalySubscriptionThresholdExpressionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimension\"}}]")]
        public virtual void PutDimension(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNot\"}}]")]
        public virtual void PutNot(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTags\"}}]")]
        public virtual void PutTags(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags)}, new object[]{@value});
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

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndList\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndList And
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAndList>()!;
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategoryOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimensionOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotOutputReference Not
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNotOutputReference>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrList\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrList Or
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTagsOutputReference\"}")]
        public virtual aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionCostCategory\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionDimension\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionNot\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot? NotInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionNot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpressionTags\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags? TagsInput
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpressionTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ceAnomalySubscription.CeAnomalySubscriptionThresholdExpression\"}", isOptional: true)]
        public virtual aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpression? InternalValue
        {
            get => GetInstanceProperty<aws.CeAnomalySubscription.ICeAnomalySubscriptionThresholdExpression?>();
            set => SetInstanceProperty(value);
        }
    }
}
