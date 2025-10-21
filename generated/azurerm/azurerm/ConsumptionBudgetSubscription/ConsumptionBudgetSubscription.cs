using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetSubscription
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription azurerm_consumption_budget_subscription}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription), fullyQualifiedName: "azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscription", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionConfig\"}}]")]
    public class ConsumptionBudgetSubscription : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription azurerm_consumption_budget_subscription} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConsumptionBudgetSubscription(Constructs.Construct scope, string id, azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConsumptionBudgetSubscription(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConsumptionBudgetSubscription(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ConsumptionBudgetSubscription resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ConsumptionBudgetSubscription to import.</param>
        /// <param name="importFromId">The id of the existing ConsumptionBudgetSubscription that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ConsumptionBudgetSubscription to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ConsumptionBudgetSubscription to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ConsumptionBudgetSubscription that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ConsumptionBudgetSubscription to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilter\"}}]")]
        public virtual void PutFilter(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionNotification\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNotification(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionNotification[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionNotification).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionNotification).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimePeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriod\"}}]")]
        public virtual void PutTimePeriod(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimePeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimePeriod)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterOutputReference\"}")]
        public virtual azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterOutputReference Filter
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilterOutputReference>()!;
        }

        [JsiiProperty(name: "notification", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionNotificationList\"}")]
        public virtual azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionNotificationList Notification
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionNotificationList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimeoutsOutputReference\"}")]
        public virtual azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timePeriod", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriodOutputReference\"}")]
        public virtual azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriodOutputReference TimePeriod
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriodOutputReference>()!;
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
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilter\"}", isOptional: true)]
        public virtual azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter? FilterInput
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionFilter?>();
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
        [JsiiProperty(name: "notificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionNotification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodInput", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriod\"}", isOptional: true)]
        public virtual azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimePeriod? TimePeriodInput
        {
            get => GetInstanceProperty<azurerm.ConsumptionBudgetSubscription.IConsumptionBudgetSubscriptionTimePeriod?>();
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

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
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
