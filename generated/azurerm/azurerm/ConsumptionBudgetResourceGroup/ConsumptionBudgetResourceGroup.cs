using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetResourceGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group azurerm_consumption_budget_resource_group}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup), fullyQualifiedName: "azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupConfig\"}}]")]
    public class ConsumptionBudgetResourceGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group azurerm_consumption_budget_resource_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConsumptionBudgetResourceGroup(Constructs.Construct scope, string id, azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConsumptionBudgetResourceGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConsumptionBudgetResourceGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ConsumptionBudgetResourceGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ConsumptionBudgetResourceGroup to import.</param>
        /// <param name="importFromId">The id of the existing ConsumptionBudgetResourceGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ConsumptionBudgetResourceGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ConsumptionBudgetResourceGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ConsumptionBudgetResourceGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ConsumptionBudgetResourceGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter\"}}]")]
        public virtual void PutFilter(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotification\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNotification(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupNotification[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupNotification).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupNotification).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimePeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriod\"}}]")]
        public virtual void PutTimePeriod(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEtag")]
        public virtual void ResetEtag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeGrain")]
        public virtual void ResetTimeGrain()
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
        = GetStaticProperty<string>(typeof(azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterOutputReference\"}")]
        public virtual azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterOutputReference Filter
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilterOutputReference>()!;
        }

        [JsiiProperty(name: "notification", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotificationList\"}")]
        public virtual azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotificationList Notification
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotificationList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeoutsOutputReference\"}")]
        public virtual azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timePeriod", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriodOutputReference\"}")]
        public virtual azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriodOutputReference TimePeriod
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriodOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "etagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EtagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter\"}", isOptional: true)]
        public virtual azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter? FilterInput
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeGrainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeGrainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodInput", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriod\"}", isOptional: true)]
        public virtual azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod? TimePeriodInput
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
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

        [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeGrain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeGrain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
