using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementExport
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export azurerm_subscription_cost_management_export}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportConfig\"}}]")]
    public class SubscriptionCostManagementExport : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export azurerm_subscription_cost_management_export} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SubscriptionCostManagementExport(Constructs.Construct scope, string id, azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionCostManagementExport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionCostManagementExport(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SubscriptionCostManagementExport resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SubscriptionCostManagementExport to import.</param>
        /// <param name="importFromId">The id of the existing SubscriptionCostManagementExport that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SubscriptionCostManagementExport to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SubscriptionCostManagementExport to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SubscriptionCostManagementExport that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SubscriptionCostManagementExport to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExportDataOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions\"}}]")]
        public virtual void PutExportDataOptions(azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExportDataStorageLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation\"}}]")]
        public virtual void PutExportDataStorageLocation(azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport))!;

        [JsiiProperty(name: "exportDataOptions", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptionsOutputReference\"}")]
        public virtual azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptionsOutputReference ExportDataOptions
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "exportDataStorageLocation", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocationOutputReference\"}")]
        public virtual azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocationOutputReference ExportDataStorageLocation
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportTimeoutsOutputReference\"}")]
        public virtual azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportDataOptionsInput", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions\"}", isOptional: true)]
        public virtual azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions? ExportDataOptionsInput
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportDataStorageLocationInput", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation\"}", isOptional: true)]
        public virtual azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation? ExportDataStorageLocationInput
        {
            get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation?>();
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
        [JsiiProperty(name: "recurrencePeriodEndDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecurrencePeriodEndDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrencePeriodStartDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecurrencePeriodStartDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrenceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecurrenceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Active
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

        [JsiiProperty(name: "recurrencePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecurrencePeriodEndDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recurrencePeriodStartDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecurrencePeriodStartDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecurrenceType
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
    }
}
