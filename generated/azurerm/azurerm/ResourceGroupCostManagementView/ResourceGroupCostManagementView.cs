using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view azurerm_resource_group_cost_management_view}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementView", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewConfig\"}}]")]
    public class ResourceGroupCostManagementView : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view azurerm_resource_group_cost_management_view} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ResourceGroupCostManagementView(Constructs.Construct scope, string id, azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResourceGroupCostManagementView(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResourceGroupCostManagementView(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ResourceGroupCostManagementView resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ResourceGroupCostManagementView to import.</param>
        /// <param name="importFromId">The id of the existing ResourceGroupCostManagementView that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ResourceGroupCostManagementView to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ResourceGroupCostManagementView to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ResourceGroupCostManagementView that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ResourceGroupCostManagementView to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset\"}}]")]
        public virtual void PutDataset(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpi\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKpi(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewKpi[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewKpi).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewKpi).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPivot", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewPivot\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPivot(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewPivot[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewPivot).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewPivot).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKpi")]
        public virtual void ResetKpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPivot")]
        public virtual void ResetPivot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView))!;

        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetOutputReference\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetOutputReference Dataset
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "kpi", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpiList\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewKpiList Kpi
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewKpiList>()!;
        }

        [JsiiProperty(name: "pivot", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewPivotList\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewPivotList Pivot
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewPivotList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewTimeoutsOutputReference\"}")]
        public virtual azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accumulatedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AccumulatedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "chartTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChartTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetInput", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset\"}", isOptional: true)]
        public virtual azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset? DatasetInput
        {
            get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpi\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pivotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewPivot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PivotInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeframeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeframeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accumulated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Accumulated
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "chartType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChartType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeframe", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timeframe
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
