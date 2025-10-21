using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration azurerm_app_configuration}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration), fullyQualifiedName: "azurerm.dataAzurermAppConfiguration.DataAzurermAppConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationConfig\"}}]")]
    public class DataAzurermAppConfiguration : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration azurerm_app_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermAppConfiguration(Constructs.Construct scope, string id, azurerm.DataAzurermAppConfiguration.IDataAzurermAppConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermAppConfiguration.IDataAzurermAppConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAppConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAppConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermAppConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermAppConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermAppConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermAppConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermAppConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermAppConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermAppConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermAppConfiguration.IDataAzurermAppConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermAppConfiguration.IDataAzurermAppConfigurationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration))!;

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationEncryptionList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationEncryptionList Encryption
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationEncryptionList>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationIdentityList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationIdentityList>()!;
        }

        [JsiiProperty(name: "localAuthEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable LocalAuthEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryReadKey", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationPrimaryReadKeyList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationPrimaryReadKeyList PrimaryReadKey
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationPrimaryReadKeyList>()!;
        }

        [JsiiProperty(name: "primaryWriteKey", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationPrimaryWriteKeyList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationPrimaryWriteKeyList PrimaryWriteKey
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationPrimaryWriteKeyList>()!;
        }

        [JsiiProperty(name: "publicNetworkAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicNetworkAccess
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "purgeProtectionEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PurgeProtectionEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "replica", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationReplicaList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationReplicaList Replica
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationReplicaList>()!;
        }

        [JsiiProperty(name: "secondaryReadKey", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationSecondaryReadKeyList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationSecondaryReadKeyList SecondaryReadKey
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationSecondaryReadKeyList>()!;
        }

        [JsiiProperty(name: "secondaryWriteKey", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationSecondaryWriteKeyList\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationSecondaryWriteKeyList SecondaryWriteKey
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationSecondaryWriteKeyList>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softDeleteRetentionDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SoftDeleteRetentionDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationTimeouts\"}]}}", isOptional: true)]
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
