using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppConfig), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppConfig")]
    public interface ILinuxFunctionAppConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#location LinuxFunctionApp#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Specifies the name of the Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#name LinuxFunctionApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#resource_group_name LinuxFunctionApp#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#service_plan_id LinuxFunctionApp#service_plan_id}
        /// </remarks>
        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePlanId
        {
            get;
        }

        /// <summary>site_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#site_config LinuxFunctionApp#site_config}
        /// </remarks>
        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfig\"}")]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfig SiteConfig
        {
            get;
        }

        /// <summary>A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_settings LinuxFunctionApp#app_settings}
        /// </remarks>
        [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>auth_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#auth_settings LinuxFunctionApp#auth_settings}
        /// </remarks>
        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettings? AuthSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>auth_settings_v2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#auth_settings_v2 LinuxFunctionApp#auth_settings_v2}
        /// </remarks>
        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsV2? AuthSettingsV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#backup LinuxFunctionApp#backup}
        /// </remarks>
        [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppBackup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppBackup? Backup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#builtin_logging_enabled LinuxFunctionApp#builtin_logging_enabled}
        /// </remarks>
        [JsiiProperty(name: "builtinLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BuiltinLoggingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the function app use Client Certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_certificate_enabled LinuxFunctionApp#client_certificate_enabled}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientCertificateEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Paths to exclude when using client certificates, separated by ;</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_certificate_exclusion_paths LinuxFunctionApp#client_certificate_exclusion_paths}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateExclusionPaths
        {
            get
            {
                return null;
            }
        }

        /// <summary>The mode of the Function App's client certificates requirement for incoming requests.</summary>
        /// <remarks>
        /// Possible values are <c>Required</c>, <c>Optional</c>, and <c>OptionalInteractiveUser</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_certificate_mode LinuxFunctionApp#client_certificate_mode}
        /// </remarks>
        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#connection_string LinuxFunctionApp#connection_string}
        /// </remarks>
        [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Force disable the content share settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#content_share_force_disabled LinuxFunctionApp#content_share_force_disabled}
        /// </remarks>
        [JsiiProperty(name: "contentShareForceDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentShareForceDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day.</summary>
        /// <remarks>
        /// Setting this value only affects function apps in Consumption Plans.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#daily_memory_time_quota LinuxFunctionApp#daily_memory_time_quota}
        /// </remarks>
        [JsiiProperty(name: "dailyMemoryTimeQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DailyMemoryTimeQuota
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is the Linux Function App enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#enabled LinuxFunctionApp#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#ftp_publish_basic_authentication_enabled LinuxFunctionApp#ftp_publish_basic_authentication_enabled}.</summary>
        [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FtpPublishBasicAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The runtime version associated with the Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#functions_extension_version LinuxFunctionApp#functions_extension_version}
        /// </remarks>
        [JsiiProperty(name: "functionsExtensionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionsExtensionVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Can the Function App only be accessed via HTTPS?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#https_only LinuxFunctionApp#https_only}
        /// </remarks>
        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpsOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#id LinuxFunctionApp#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#identity LinuxFunctionApp#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The User Assigned Identity to use for Key Vault access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#key_vault_reference_identity_id LinuxFunctionApp#key_vault_reference_identity_id}
        /// </remarks>
        [JsiiProperty(name: "keyVaultReferenceIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultReferenceIdentityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#public_network_access_enabled LinuxFunctionApp#public_network_access_enabled}.</summary>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>sticky_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#sticky_settings LinuxFunctionApp#sticky_settings}
        /// </remarks>
        [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppStickySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppStickySettings? StickySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account LinuxFunctionApp#storage_account}
        /// </remarks>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The access key which will be used to access the storage account for the Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account_access_key LinuxFunctionApp#storage_account_access_key}
        /// </remarks>
        [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The backend storage account name which will be used by this Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account_name LinuxFunctionApp#storage_account_name}
        /// </remarks>
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_key_vault_secret_id LinuxFunctionApp#storage_key_vault_secret_id}
        /// </remarks>
        [JsiiProperty(name: "storageKeyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageKeyVaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Function App use its Managed Identity to access storage?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_uses_managed_identity LinuxFunctionApp#storage_uses_managed_identity}
        /// </remarks>
        [JsiiProperty(name: "storageUsesManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageUsesManagedIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#tags LinuxFunctionApp#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#timeouts LinuxFunctionApp#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxFunctionApp.ILinuxFunctionAppTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#virtual_network_subnet_id LinuxFunctionApp#virtual_network_subnet_id}.</summary>
        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is container image pull over virtual network enabled? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#vnet_image_pull_enabled LinuxFunctionApp#vnet_image_pull_enabled}
        /// </remarks>
        [JsiiProperty(name: "vnetImagePullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VnetImagePullEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#webdeploy_publish_basic_authentication_enabled LinuxFunctionApp#webdeploy_publish_basic_authentication_enabled}.</summary>
        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebdeployPublishBasicAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The local path and filename of the Zip packaged application to deploy to this Linux Function App.</summary>
        /// <remarks>
        /// <strong>Note:</strong> Using this value requires either <c>WEBSITE_RUN_FROM_PACKAGE=1</c> or <c>SCM_DO_BUILD_DURING_DEPLOYMENT=true</c> to be set on the App in <c>app_settings</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#zip_deploy_file LinuxFunctionApp#zip_deploy_file}
        /// </remarks>
        [JsiiProperty(name: "zipDeployFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZipDeployFile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppConfig), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionApp.ILinuxFunctionAppConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#location LinuxFunctionApp#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the name of the Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#name LinuxFunctionApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#resource_group_name LinuxFunctionApp#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the App Service Plan within which to create this Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#service_plan_id LinuxFunctionApp#service_plan_id}
            /// </remarks>
            [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePlanId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>site_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#site_config LinuxFunctionApp#site_config}
            /// </remarks>
            [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfig\"}")]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfig SiteConfig
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfig>()!;
            }

            /// <summary>A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_settings LinuxFunctionApp#app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AppSettings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>auth_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#auth_settings LinuxFunctionApp#auth_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettings\"}", isOptional: true)]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettings? AuthSettings
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettings?>();
            }

            /// <summary>auth_settings_v2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#auth_settings_v2 LinuxFunctionApp#auth_settings_v2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2\"}", isOptional: true)]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsV2? AuthSettingsV2
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsV2?>();
            }

            /// <summary>backup block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#backup LinuxFunctionApp#backup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppBackup\"}", isOptional: true)]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppBackup? Backup
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppBackup?>();
            }

            /// <summary>Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#builtin_logging_enabled LinuxFunctionApp#builtin_logging_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "builtinLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? BuiltinLoggingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the function app use Client Certificates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_certificate_enabled LinuxFunctionApp#client_certificate_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ClientCertificateEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Paths to exclude when using client certificates, separated by ;</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_certificate_exclusion_paths LinuxFunctionApp#client_certificate_exclusion_paths}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateExclusionPaths
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The mode of the Function App's client certificates requirement for incoming requests.</summary>
            /// <remarks>
            /// Possible values are <c>Required</c>, <c>Optional</c>, and <c>OptionalInteractiveUser</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#client_certificate_mode LinuxFunctionApp#client_certificate_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#connection_string LinuxFunctionApp#connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectionString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Force disable the content share settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#content_share_force_disabled LinuxFunctionApp#content_share_force_disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentShareForceDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ContentShareForceDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day.</summary>
            /// <remarks>
            /// Setting this value only affects function apps in Consumption Plans.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#daily_memory_time_quota LinuxFunctionApp#daily_memory_time_quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dailyMemoryTimeQuota", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DailyMemoryTimeQuota
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Is the Linux Function App enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#enabled LinuxFunctionApp#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#ftp_publish_basic_authentication_enabled LinuxFunctionApp#ftp_publish_basic_authentication_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FtpPublishBasicAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The runtime version associated with the Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#functions_extension_version LinuxFunctionApp#functions_extension_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "functionsExtensionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionsExtensionVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Can the Function App only be accessed via HTTPS?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#https_only LinuxFunctionApp#https_only}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HttpsOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#id LinuxFunctionApp#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#identity LinuxFunctionApp#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppIdentity\"}", isOptional: true)]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppIdentity?>();
            }

            /// <summary>The User Assigned Identity to use for Key Vault access.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#key_vault_reference_identity_id LinuxFunctionApp#key_vault_reference_identity_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultReferenceIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultReferenceIdentityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#public_network_access_enabled LinuxFunctionApp#public_network_access_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sticky_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#sticky_settings LinuxFunctionApp#sticky_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppStickySettings\"}", isOptional: true)]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppStickySettings? StickySettings
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppStickySettings?>();
            }

            /// <summary>storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account LinuxFunctionApp#storage_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The access key which will be used to access the storage account for the Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account_access_key LinuxFunctionApp#storage_account_access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The backend storage account name which will be used by this Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_account_name LinuxFunctionApp#storage_account_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_key_vault_secret_id LinuxFunctionApp#storage_key_vault_secret_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageKeyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageKeyVaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the Function App use its Managed Identity to access storage?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#storage_uses_managed_identity LinuxFunctionApp#storage_uses_managed_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageUsesManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StorageUsesManagedIdentity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#tags LinuxFunctionApp#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#timeouts LinuxFunctionApp#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppTimeouts\"}", isOptional: true)]
            public azurerm.LinuxFunctionApp.ILinuxFunctionAppTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#virtual_network_subnet_id LinuxFunctionApp#virtual_network_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Is container image pull over virtual network enabled? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#vnet_image_pull_enabled LinuxFunctionApp#vnet_image_pull_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vnetImagePullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VnetImagePullEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#webdeploy_publish_basic_authentication_enabled LinuxFunctionApp#webdeploy_publish_basic_authentication_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WebdeployPublishBasicAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The local path and filename of the Zip packaged application to deploy to this Linux Function App.</summary>
            /// <remarks>
            /// <strong>Note:</strong> Using this value requires either <c>WEBSITE_RUN_FROM_PACKAGE=1</c> or <c>SCM_DO_BUILD_DURING_DEPLOYMENT=true</c> to be set on the App in <c>app_settings</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#zip_deploy_file LinuxFunctionApp#zip_deploy_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zipDeployFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZipDeployFile
            {
                get => GetInstanceProperty<string?>();
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
