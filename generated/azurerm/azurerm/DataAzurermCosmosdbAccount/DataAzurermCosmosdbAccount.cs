using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCosmosdbAccount
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account azurerm_cosmosdb_account}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount), fullyQualifiedName: "azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountConfig\"}}]")]
    public class DataAzurermCosmosdbAccount : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account azurerm_cosmosdb_account} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermCosmosdbAccount(Constructs.Construct scope, string id, azurerm.DataAzurermCosmosdbAccount.IDataAzurermCosmosdbAccountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermCosmosdbAccount.IDataAzurermCosmosdbAccountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCosmosdbAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCosmosdbAccount(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermCosmosdbAccount resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermCosmosdbAccount to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermCosmosdbAccount that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermCosmosdbAccount to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermCosmosdbAccount to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermCosmosdbAccount that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermCosmosdbAccount to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermCosmosdbAccount.IDataAzurermCosmosdbAccountTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermCosmosdbAccount.IDataAzurermCosmosdbAccountTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount))!;

        [JsiiProperty(name: "automaticFailoverEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutomaticFailoverEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountCapabilitiesList\"}")]
        public virtual azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountCapabilitiesList Capabilities
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountCapabilitiesList>()!;
        }

        [JsiiProperty(name: "consistencyPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountConsistencyPolicyList\"}")]
        public virtual azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountConsistencyPolicyList ConsistencyPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountConsistencyPolicyList>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeTierEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable FreeTierEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "geoLocation", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountGeoLocationList\"}")]
        public virtual azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountGeoLocationList GeoLocation
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountGeoLocationList>()!;
        }

        [JsiiProperty(name: "ipRangeFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpRangeFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isVirtualNetworkFilterEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IsVirtualNetworkFilterEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multipleWriteLocationsEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MultipleWriteLocationsEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "offerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfferType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryMongodbConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryMongodbConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryReadonlyKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryReadonlyKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryReadonlyMongodbConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryReadonlyMongodbConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryReadonlySqlConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryReadonlySqlConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primarySqlConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimarySqlConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReadEndpoints
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "secondaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryMongodbConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryMongodbConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryReadonlyKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryReadonlyKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryReadonlyMongodbConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryReadonlyMongodbConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryReadonlySqlConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryReadonlySqlConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondarySqlConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondarySqlConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualNetworkRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountVirtualNetworkRuleList\"}")]
        public virtual azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountVirtualNetworkRuleList VirtualNetworkRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountVirtualNetworkRuleList>()!;
        }

        [JsiiProperty(name: "writeEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WriteEndpoints
        {
            get => GetInstanceProperty<string[]>()!;
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
