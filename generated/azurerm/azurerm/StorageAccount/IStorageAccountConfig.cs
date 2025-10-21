using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountConfig), fullyQualifiedName: "azurerm.storageAccount.StorageAccountConfig")]
    public interface IStorageAccountConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_replication_type StorageAccount#account_replication_type}.</summary>
        [JsiiProperty(name: "accountReplicationType", typeJson: "{\"primitive\":\"string\"}")]
        string AccountReplicationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_tier StorageAccount#account_tier}.</summary>
        [JsiiProperty(name: "accountTier", typeJson: "{\"primitive\":\"string\"}")]
        string AccountTier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#location StorageAccount#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#name StorageAccount#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#resource_group_name StorageAccount#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#access_tier StorageAccount#access_tier}.</summary>
        [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessTier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_kind StorageAccount#account_kind}.</summary>
        [JsiiProperty(name: "accountKind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allowed_copy_scope StorageAccount#allowed_copy_scope}.</summary>
        [JsiiProperty(name: "allowedCopyScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedCopyScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allow_nested_items_to_be_public StorageAccount#allow_nested_items_to_be_public}.</summary>
        [JsiiProperty(name: "allowNestedItemsToBePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowNestedItemsToBePublic
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_files_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#azure_files_authentication StorageAccount#azure_files_authentication}
        /// </remarks>
        [JsiiProperty(name: "azureFilesAuthentication", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication? AzureFilesAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>blob_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#blob_properties StorageAccount#blob_properties}
        /// </remarks>
        [JsiiProperty(name: "blobProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountBlobProperties? BlobProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cross_tenant_replication_enabled StorageAccount#cross_tenant_replication_enabled}.</summary>
        [JsiiProperty(name: "crossTenantReplicationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrossTenantReplicationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#custom_domain StorageAccount#custom_domain}
        /// </remarks>
        [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomDomain\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountCustomDomain? CustomDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>customer_managed_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#customer_managed_key StorageAccount#customer_managed_key}
        /// </remarks>
        [JsiiProperty(name: "customerManagedKey", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomerManagedKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountCustomerManagedKey? CustomerManagedKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_to_oauth_authentication StorageAccount#default_to_oauth_authentication}.</summary>
        [JsiiProperty(name: "defaultToOauthAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultToOauthAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#dns_endpoint_type StorageAccount#dns_endpoint_type}.</summary>
        [JsiiProperty(name: "dnsEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsEndpointType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#edge_zone StorageAccount#edge_zone}.</summary>
        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EdgeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#https_traffic_only_enabled StorageAccount#https_traffic_only_enabled}.</summary>
        [JsiiProperty(name: "httpsTrafficOnlyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsTrafficOnlyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#id StorageAccount#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#identity StorageAccount#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>immutability_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#immutability_policy StorageAccount#immutability_policy}
        /// </remarks>
        [JsiiProperty(name: "immutabilityPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountImmutabilityPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountImmutabilityPolicy? ImmutabilityPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#infrastructure_encryption_enabled StorageAccount#infrastructure_encryption_enabled}.</summary>
        [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InfrastructureEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#is_hns_enabled StorageAccount#is_hns_enabled}.</summary>
        [JsiiProperty(name: "isHnsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHnsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#large_file_share_enabled StorageAccount#large_file_share_enabled}.</summary>
        [JsiiProperty(name: "largeFileShareEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LargeFileShareEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#local_user_enabled StorageAccount#local_user_enabled}.</summary>
        [JsiiProperty(name: "localUserEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LocalUserEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#min_tls_version StorageAccount#min_tls_version}.</summary>
        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinTlsVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#network_rules StorageAccount#network_rules}
        /// </remarks>
        [JsiiProperty(name: "networkRules", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountNetworkRules\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountNetworkRules? NetworkRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#nfsv3_enabled StorageAccount#nfsv3_enabled}.</summary>
        [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nfsv3Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#public_network_access_enabled StorageAccount#public_network_access_enabled}.</summary>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#queue_encryption_key_type StorageAccount#queue_encryption_key_type}.</summary>
        [JsiiProperty(name: "queueEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueueEncryptionKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>queue_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#queue_properties StorageAccount#queue_properties}
        /// </remarks>
        [JsiiProperty(name: "queueProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueueProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountQueueProperties? QueueProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#routing StorageAccount#routing}
        /// </remarks>
        [JsiiProperty(name: "routing", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountRouting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountRouting? Routing
        {
            get
            {
                return null;
            }
        }

        /// <summary>sas_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sas_policy StorageAccount#sas_policy}
        /// </remarks>
        [JsiiProperty(name: "sasPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSasPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountSasPolicy? SasPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sftp_enabled StorageAccount#sftp_enabled}.</summary>
        [JsiiProperty(name: "sftpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SftpEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#shared_access_key_enabled StorageAccount#shared_access_key_enabled}.</summary>
        [JsiiProperty(name: "sharedAccessKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SharedAccessKeyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>share_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#share_properties StorageAccount#share_properties}
        /// </remarks>
        [JsiiProperty(name: "shareProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountShareProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountShareProperties? ShareProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>static_website block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#static_website StorageAccount#static_website}
        /// </remarks>
        [JsiiProperty(name: "staticWebsite", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountStaticWebsite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountStaticWebsite? StaticWebsite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#table_encryption_key_type StorageAccount#table_encryption_key_type}.</summary>
        [JsiiProperty(name: "tableEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TableEncryptionKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#tags StorageAccount#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#timeouts StorageAccount#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountConfig), fullyQualifiedName: "azurerm.storageAccount.StorageAccountConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_replication_type StorageAccount#account_replication_type}.</summary>
            [JsiiProperty(name: "accountReplicationType", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountReplicationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_tier StorageAccount#account_tier}.</summary>
            [JsiiProperty(name: "accountTier", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountTier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#location StorageAccount#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#name StorageAccount#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#resource_group_name StorageAccount#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#access_tier StorageAccount#access_tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessTier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_kind StorageAccount#account_kind}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allowed_copy_scope StorageAccount#allowed_copy_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedCopyScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedCopyScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allow_nested_items_to_be_public StorageAccount#allow_nested_items_to_be_public}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowNestedItemsToBePublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowNestedItemsToBePublic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>azure_files_authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#azure_files_authentication StorageAccount#azure_files_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureFilesAuthentication", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountAzureFilesAuthentication\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication? AzureFilesAuthentication
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountAzureFilesAuthentication?>();
            }

            /// <summary>blob_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#blob_properties StorageAccount#blob_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blobProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobProperties\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountBlobProperties? BlobProperties
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobProperties?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cross_tenant_replication_enabled StorageAccount#cross_tenant_replication_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crossTenantReplicationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CrossTenantReplicationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_domain block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#custom_domain StorageAccount#custom_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customDomain", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomDomain\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountCustomDomain? CustomDomain
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountCustomDomain?>();
            }

            /// <summary>customer_managed_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#customer_managed_key StorageAccount#customer_managed_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerManagedKey", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountCustomerManagedKey\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountCustomerManagedKey? CustomerManagedKey
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountCustomerManagedKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_to_oauth_authentication StorageAccount#default_to_oauth_authentication}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultToOauthAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultToOauthAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#dns_endpoint_type StorageAccount#dns_endpoint_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsEndpointType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#edge_zone StorageAccount#edge_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EdgeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#https_traffic_only_enabled StorageAccount#https_traffic_only_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsTrafficOnlyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsTrafficOnlyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#id StorageAccount#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#identity StorageAccount#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountIdentity\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountIdentity?>();
            }

            /// <summary>immutability_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#immutability_policy StorageAccount#immutability_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "immutabilityPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountImmutabilityPolicy\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountImmutabilityPolicy? ImmutabilityPolicy
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountImmutabilityPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#infrastructure_encryption_enabled StorageAccount#infrastructure_encryption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InfrastructureEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#is_hns_enabled StorageAccount#is_hns_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHnsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsHnsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#large_file_share_enabled StorageAccount#large_file_share_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "largeFileShareEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LargeFileShareEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#local_user_enabled StorageAccount#local_user_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localUserEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LocalUserEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#min_tls_version StorageAccount#min_tls_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinTlsVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#network_rules StorageAccount#network_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkRules", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountNetworkRules\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountNetworkRules? NetworkRules
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountNetworkRules?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#nfsv3_enabled StorageAccount#nfsv3_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nfsv3Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Nfsv3Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#public_network_access_enabled StorageAccount#public_network_access_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#queue_encryption_key_type StorageAccount#queue_encryption_key_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queueEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueueEncryptionKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>queue_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#queue_properties StorageAccount#queue_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueueProperties\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountQueueProperties? QueueProperties
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueueProperties?>();
            }

            /// <summary>routing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#routing StorageAccount#routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routing", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountRouting\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountRouting? Routing
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountRouting?>();
            }

            /// <summary>sas_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sas_policy StorageAccount#sas_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sasPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSasPolicy\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountSasPolicy? SasPolicy
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountSasPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sftp_enabled StorageAccount#sftp_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sftpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SftpEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#shared_access_key_enabled StorageAccount#shared_access_key_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sharedAccessKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SharedAccessKeyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>share_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#share_properties StorageAccount#share_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareProperties", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountShareProperties\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountShareProperties? ShareProperties
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountShareProperties?>();
            }

            /// <summary>static_website block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#static_website StorageAccount#static_website}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticWebsite", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountStaticWebsite\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountStaticWebsite? StaticWebsite
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountStaticWebsite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#table_encryption_key_type StorageAccount#table_encryption_key_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tableEncryptionKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TableEncryptionKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#tags StorageAccount#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#timeouts StorageAccount#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountTimeouts\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
