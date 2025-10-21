using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account azurerm_storage_account}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.StorageAccount.StorageAccount), fullyQualifiedName: "azurerm.storageAccount.StorageAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountConfig\"}}]")]
    public class StorageAccount : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account azurerm_storage_account} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageAccount(Constructs.Construct scope, string id, azurerm.StorageAccount.IStorageAccountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.StorageAccount.IStorageAccountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccount(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a StorageAccount resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StorageAccount to import.</param>
        /// <param name="importFromId">The id of the existing StorageAccount that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StorageAccount to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StorageAccount to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StorageAccount that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StorageAccount to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.StorageAccount.StorageAccount), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureFilesAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthentication\"}}]")]
        public virtual void PutAzureFilesAuthentication(azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlobProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobProperties\"}}]")]
        public virtual void PutBlobProperties(azurerm.StorageAccount.IStorageAccountBlobProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountBlobProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomDomain\"}}]")]
        public virtual void PutCustomDomain(azurerm.StorageAccount.IStorageAccountCustomDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountCustomDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomerManagedKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomerManagedKey\"}}]")]
        public virtual void PutCustomerManagedKey(azurerm.StorageAccount.IStorageAccountCustomerManagedKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountCustomerManagedKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.StorageAccount.IStorageAccountIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImmutabilityPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountImmutabilityPolicy\"}}]")]
        public virtual void PutImmutabilityPolicy(azurerm.StorageAccount.IStorageAccountImmutabilityPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountImmutabilityPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountNetworkRules\"}}]")]
        public virtual void PutNetworkRules(azurerm.StorageAccount.IStorageAccountNetworkRules @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountNetworkRules)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueueProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueueProperties\"}}]")]
        public virtual void PutQueueProperties(azurerm.StorageAccount.IStorageAccountQueueProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountQueueProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRouting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountRouting\"}}]")]
        public virtual void PutRouting(azurerm.StorageAccount.IStorageAccountRouting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountRouting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSasPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSasPolicy\"}}]")]
        public virtual void PutSasPolicy(azurerm.StorageAccount.IStorageAccountSasPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountSasPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShareProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountShareProperties\"}}]")]
        public virtual void PutShareProperties(azurerm.StorageAccount.IStorageAccountShareProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountShareProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStaticWebsite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountStaticWebsite\"}}]")]
        public virtual void PutStaticWebsite(azurerm.StorageAccount.IStorageAccountStaticWebsite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountStaticWebsite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.StorageAccount.IStorageAccountTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessTier")]
        public virtual void ResetAccessTier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKind")]
        public virtual void ResetAccountKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedCopyScope")]
        public virtual void ResetAllowedCopyScope()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowNestedItemsToBePublic")]
        public virtual void ResetAllowNestedItemsToBePublic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureFilesAuthentication")]
        public virtual void ResetAzureFilesAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlobProperties")]
        public virtual void ResetBlobProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrossTenantReplicationEnabled")]
        public virtual void ResetCrossTenantReplicationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomDomain")]
        public virtual void ResetCustomDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerManagedKey")]
        public virtual void ResetCustomerManagedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultToOauthAuthentication")]
        public virtual void ResetDefaultToOauthAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsEndpointType")]
        public virtual void ResetDnsEndpointType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgeZone")]
        public virtual void ResetEdgeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpsTrafficOnlyEnabled")]
        public virtual void ResetHttpsTrafficOnlyEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImmutabilityPolicy")]
        public virtual void ResetImmutabilityPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInfrastructureEncryptionEnabled")]
        public virtual void ResetInfrastructureEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsHnsEnabled")]
        public virtual void ResetIsHnsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLargeFileShareEnabled")]
        public virtual void ResetLargeFileShareEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalUserEnabled")]
        public virtual void ResetLocalUserEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinTlsVersion")]
        public virtual void ResetMinTlsVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkRules")]
        public virtual void ResetNetworkRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsv3Enabled")]
        public virtual void ResetNfsv3Enabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueueEncryptionKeyType")]
        public virtual void ResetQueueEncryptionKeyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueueProperties")]
        public virtual void ResetQueueProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouting")]
        public virtual void ResetRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSasPolicy")]
        public virtual void ResetSasPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSftpEnabled")]
        public virtual void ResetSftpEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharedAccessKeyEnabled")]
        public virtual void ResetSharedAccessKeyEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareProperties")]
        public virtual void ResetShareProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticWebsite")]
        public virtual void ResetStaticWebsite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableEncryptionKeyType")]
        public virtual void ResetTableEncryptionKeyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.StorageAccount.StorageAccount))!;

        [JsiiProperty(name: "azureFilesAuthentication", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthenticationOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountAzureFilesAuthenticationOutputReference AzureFilesAuthentication
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountAzureFilesAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "blobProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountBlobPropertiesOutputReference BlobProperties
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountBlobPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomDomainOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountCustomDomainOutputReference CustomDomain
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountCustomDomainOutputReference>()!;
        }

        [JsiiProperty(name: "customerManagedKey", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomerManagedKeyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountCustomerManagedKeyOutputReference CustomerManagedKey
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountCustomerManagedKeyOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountIdentityOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "immutabilityPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountImmutabilityPolicyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountImmutabilityPolicyOutputReference ImmutabilityPolicy
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountImmutabilityPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "networkRules", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountNetworkRulesOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountNetworkRulesOutputReference NetworkRules
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountNetworkRulesOutputReference>()!;
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

        [JsiiProperty(name: "queueProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountQueuePropertiesOutputReference QueueProperties
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountQueuePropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "routing", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountRoutingOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountRoutingOutputReference Routing
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountRoutingOutputReference>()!;
        }

        [JsiiProperty(name: "sasPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSasPolicyOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountSasPolicyOutputReference SasPolicy
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountSasPolicyOutputReference>()!;
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

        [JsiiProperty(name: "shareProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountSharePropertiesOutputReference ShareProperties
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountSharePropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "staticWebsite", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountStaticWebsiteOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountStaticWebsiteOutputReference StaticWebsite
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountStaticWebsiteOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountTimeoutsOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountReplicationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountReplicationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedCopyScopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllowedCopyScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowNestedItemsToBePublicInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowNestedItemsToBePublicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureFilesAuthenticationInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthentication\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication? AzureFilesAuthenticationInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blobPropertiesInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobProperties\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountBlobProperties? BlobPropertiesInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossTenantReplicationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CrossTenantReplicationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDomainInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomDomain\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountCustomDomain? CustomDomainInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountCustomDomain?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerManagedKeyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomerManagedKey\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountCustomerManagedKey? CustomerManagedKeyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountCustomerManagedKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultToOauthAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DefaultToOauthAuthenticationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsEndpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsEndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsTrafficOnlyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsTrafficOnlyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountIdentity\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "immutabilityPolicyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountImmutabilityPolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountImmutabilityPolicy? ImmutabilityPolicyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountImmutabilityPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InfrastructureEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isHnsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsHnsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "largeFileShareEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LargeFileShareEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localUserEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LocalUserEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "networkRulesInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountNetworkRules\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountNetworkRules? NetworkRulesInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountNetworkRules?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nfsv3EnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? Nfsv3EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueEncryptionKeyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueueEncryptionKeyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuePropertiesInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueueProperties\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountQueueProperties? QueuePropertiesInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueueProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountRouting\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountRouting? RoutingInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountRouting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sasPolicyInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSasPolicy\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountSasPolicy? SasPolicyInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSasPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sftpEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SftpEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharedAccessKeyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SharedAccessKeyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharePropertiesInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountShareProperties\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountShareProperties? SharePropertiesInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountShareProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "staticWebsiteInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountStaticWebsite\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountStaticWebsite? StaticWebsiteInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountStaticWebsite?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableEncryptionKeyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableEncryptionKeyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.storageAccount.StorageAccountTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountReplicationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountReplicationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedCopyScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedCopyScope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowNestedItemsToBePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AllowNestedItemsToBePublic
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

        [JsiiProperty(name: "crossTenantReplicationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CrossTenantReplicationEnabled
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

        [JsiiProperty(name: "defaultToOauthAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DefaultToOauthAuthentication
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

        [JsiiProperty(name: "dnsEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsEndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsTrafficOnlyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HttpsTrafficOnlyEnabled
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

        [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InfrastructureEncryptionEnabled
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

        [JsiiProperty(name: "isHnsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IsHnsEnabled
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

        [JsiiProperty(name: "largeFileShareEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LargeFileShareEnabled
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

        [JsiiProperty(name: "localUserEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LocalUserEnabled
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Nfsv3Enabled
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

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublicNetworkAccessEnabled
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

        [JsiiProperty(name: "queueEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueEncryptionKeyType
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

        [JsiiProperty(name: "sftpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SftpEnabled
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

        [JsiiProperty(name: "sharedAccessKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SharedAccessKeyEnabled
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

        [JsiiProperty(name: "tableEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableEncryptionKeyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
