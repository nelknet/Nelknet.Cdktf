using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementView
{
    [JsiiClass(nativeType: typeof(azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetOutputReference), fullyQualifiedName: "azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionCostManagementViewDatasetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionCostManagementViewDatasetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionCostManagementViewDatasetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionCostManagementViewDatasetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAggregation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAggregation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetAggregation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetAggregation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetAggregation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrouping", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGrouping(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetGrouping[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetGrouping).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetGrouping).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSorting", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSorting(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetSorting[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetSorting).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDatasetSorting).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrouping")]
        public virtual void ResetGrouping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSorting")]
        public virtual void ResetSorting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "aggregation", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregationList\"}")]
        public virtual azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregationList Aggregation
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregationList>()!;
        }

        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetGroupingList\"}")]
        public virtual azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetGroupingList Grouping
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetGroupingList>()!;
        }

        [JsiiProperty(name: "sorting", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetSortingList\"}")]
        public virtual azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetSortingList Sorting
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDatasetSortingList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aggregationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AggregationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "granularityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GranularityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GroupingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SortingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "granularity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Granularity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementView.SubscriptionCostManagementViewDataset\"}", isOptional: true)]
        public virtual azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDataset? InternalValue
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementView.ISubscriptionCostManagementViewDataset?>();
            set => SetInstanceProperty(value);
        }
    }
}
