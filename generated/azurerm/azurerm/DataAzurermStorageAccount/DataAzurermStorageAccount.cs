using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccount
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account azurerm_storage_account}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount), fullyQualifiedName: "azurerm.dataAzurermStorageAccount.DataAzurermStorageAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountConfig\"}}]")]
    public class DataAzurermStorageAccount : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account azurerm_storage_account} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermStorageAccount(Constructs.Construct scope, string id, azurerm.DataAzurermStorageAccount.IDataAzurermStorageAccountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermStorageAccount.IDataAzurermStorageAccountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStorageAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStorageAccount(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermStorageAccount resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermStorageAccount to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermStorageAccount that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermStorageAccount to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermStorageAccount to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermStorageAccount that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermStorageAccount to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermStorageAccount.IDataAzurermStorageAccountTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermStorageAccount.IDataAzurermStorageAccountTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinTlsVersion")]
        public virtual void ResetMinTlsVersion()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount))!;

        [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessTier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountKind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountReplicationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountReplicationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "allowNestedItemsToBePublic", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AllowNestedItemsToBePublic
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "azureFilesAuthentication", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountAzureFilesAuthenticationList\"}")]
        public virtual azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountAzureFilesAuthenticationList AzureFilesAuthentication
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountAzureFilesAuthenticationList>()!;
        }

        [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountCustomDomainList\"}")]
        public virtual azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountCustomDomainList CustomDomain
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountCustomDomainList>()!;
        }

        [JsiiProperty(name: "dnsEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsEndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpsTrafficOnlyEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HttpsTrafficOnlyEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountIdentityList\"}")]
        public virtual azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountIdentityList>()!;
        }

        [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable InfrastructureEncryptionEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "isHnsEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IsHnsEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Nfsv3Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "primaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryBlobMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryBlobMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryDfsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryDfsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryDfsHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryDfsHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryDfsInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryDfsInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryDfsInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryDfsInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryDfsMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryDfsMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryDfsMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryDfsMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFileMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFileMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryQueueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryQueueEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryQueueHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryQueueHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryQueueMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryQueueMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryQueueMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryQueueMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryTableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryTableEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryTableHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryTableHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryTableMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryTableMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryTableMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryTableMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryWebEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryWebEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryWebHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryWebHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryWebInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryWebInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryWebInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryWebInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryWebMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryWebMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryWebMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryWebMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queueEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueEncryptionKeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryBlobMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryBlobMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryDfsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryDfsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryDfsHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryDfsHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryDfsInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryDfsInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryDfsInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryDfsInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryDfsMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryDfsMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryDfsMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryDfsMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryFileEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryFileEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryFileHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryFileHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryFileInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryFileInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryFileInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryFileInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryFileMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryFileMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryFileMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryFileMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryQueueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryQueueEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryQueueHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryQueueHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryQueueMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryQueueMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryQueueMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryQueueMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryTableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryTableEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryTableHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryTableHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryTableMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryTableMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryTableMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryTableMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryWebEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryWebEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryWebHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryWebHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryWebInternetEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryWebInternetEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryWebInternetHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryWebInternetHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryWebMicrosoftEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryWebMicrosoftEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryWebMicrosoftHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryWebMicrosoftHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableEncryptionKeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minTlsVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinTlsVersionInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermStorageAccount.DataAzurermStorageAccountTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinTlsVersion
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
