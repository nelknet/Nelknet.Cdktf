using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    [JsiiClass(nativeType: typeof(azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetOutputReference), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ResourceGroupCostManagementViewDatasetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ResourceGroupCostManagementViewDatasetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ResourceGroupCostManagementViewDatasetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResourceGroupCostManagementViewDatasetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAggregation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAggregation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetAggregation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrouping", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGrouping(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetGrouping[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetGrouping).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetGrouping).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSorting", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSorting(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetSorting[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetSorting).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDatasetSorting).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiProperty(name: "aggregation", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregationList\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregationList Aggregation
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregationList>()!;
        }

        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGroupingList\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGroupingList Grouping
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGroupingList>()!;
        }

        [JsiiProperty(name: "sorting", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSortingList\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSortingList Sorting
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSortingList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aggregationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetAggregation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "groupingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetGrouping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GroupingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetSorting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset\"}", isOptional: true)]
        public virtual azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset? InternalValue
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset?>();
            set => SetInstanceProperty(value);
        }
    }
}
