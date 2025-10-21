using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetSubscription
{
    [JsiiClass(nativeType: typeof(azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterOutputReference), fullyQualifiedName: "azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConsumptionBudgetSubscriptionFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConsumptionBudgetSubscriptionFilterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConsumptionBudgetSubscriptionFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConsumptionBudgetSubscriptionFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterDimension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDimension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterDimension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterDimension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterDimension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilterTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDimension")]
        public virtual void ResetDimension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterDimensionList\"}")]
        public virtual azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterDimensionList Dimension
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterDimensionList>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterTagList\"}")]
        public virtual azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterTagList Tag
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterTagList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DimensionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilter\"}", isOptional: true)]
        public virtual azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter? InternalValue
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
