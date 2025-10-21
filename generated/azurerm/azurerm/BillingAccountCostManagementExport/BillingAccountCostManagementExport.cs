using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BillingAccountCostManagementExport
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export azurerm_billing_account_cost_management_export}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport), fullyQualifiedName: "azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportConfig\"}}]")]
    public class BillingAccountCostManagementExport : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export azurerm_billing_account_cost_management_export} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BillingAccountCostManagementExport(Constructs.Construct scope, string id, azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingAccountCostManagementExport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingAccountCostManagementExport(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a BillingAccountCostManagementExport resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BillingAccountCostManagementExport to import.</param>
        /// <param name="importFromId">The id of the existing BillingAccountCostManagementExport that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BillingAccountCostManagementExport to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BillingAccountCostManagementExport to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BillingAccountCostManagementExport that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BillingAccountCostManagementExport to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExportDataOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptions\"}}]")]
        public virtual void PutExportDataOptions(azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExportDataStorageLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation\"}}]")]
        public virtual void PutExportDataStorageLocation(azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport))!;

        [JsiiProperty(name: "exportDataOptions", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptionsOutputReference\"}")]
        public virtual azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptionsOutputReference ExportDataOptions
        {
            get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "exportDataStorageLocation", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocationOutputReference\"}")]
        public virtual azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocationOutputReference ExportDataStorageLocation
        {
            get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportTimeoutsOutputReference\"}")]
        public virtual azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportDataOptionsInput", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptions\"}", isOptional: true)]
        public virtual azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions? ExportDataOptionsInput
        {
            get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exportDataStorageLocationInput", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation\"}", isOptional: true)]
        public virtual azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation? ExportDataStorageLocationInput
        {
            get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "billingAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingAccountId
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
    }
}
