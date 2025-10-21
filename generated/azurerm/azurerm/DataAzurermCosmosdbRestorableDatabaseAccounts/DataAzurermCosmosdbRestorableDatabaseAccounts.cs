using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts azurerm_cosmosdb_restorable_database_accounts}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts), fullyQualifiedName: "azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsConfig\"}}]")]
    public class DataAzurermCosmosdbRestorableDatabaseAccounts : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts azurerm_cosmosdb_restorable_database_accounts} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermCosmosdbRestorableDatabaseAccounts(Constructs.Construct scope, string id, azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.IDataAzurermCosmosdbRestorableDatabaseAccountsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.IDataAzurermCosmosdbRestorableDatabaseAccountsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCosmosdbRestorableDatabaseAccounts(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCosmosdbRestorableDatabaseAccounts(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermCosmosdbRestorableDatabaseAccounts resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermCosmosdbRestorableDatabaseAccounts to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermCosmosdbRestorableDatabaseAccounts that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermCosmosdbRestorableDatabaseAccounts to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermCosmosdbRestorableDatabaseAccounts to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermCosmosdbRestorableDatabaseAccounts that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermCosmosdbRestorableDatabaseAccounts to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.IDataAzurermCosmosdbRestorableDatabaseAccountsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.IDataAzurermCosmosdbRestorableDatabaseAccountsTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts))!;

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsAccountsList\"}")]
        public virtual azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsAccountsList Accounts
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsAccountsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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
    }
}
