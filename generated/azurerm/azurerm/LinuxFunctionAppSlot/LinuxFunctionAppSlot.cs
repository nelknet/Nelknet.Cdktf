using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot azurerm_linux_function_app_slot}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlot), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotConfig\"}}]")]
    public class LinuxFunctionAppSlot : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot azurerm_linux_function_app_slot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LinuxFunctionAppSlot(Constructs.Construct scope, string id, azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppSlot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppSlot(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LinuxFunctionAppSlot resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LinuxFunctionAppSlot to import.</param>
        /// <param name="importFromId">The id of the existing LinuxFunctionAppSlot that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LinuxFunctionAppSlot to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LinuxFunctionAppSlot to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LinuxFunctionAppSlot that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LinuxFunctionAppSlot to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlot), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettings\"}}]")]
        public virtual void PutAuthSettings(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthSettingsV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2\"}}]")]
        public virtual void PutAuthSettingsV2(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackup\"}}]")]
        public virtual void PutBackup(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotConnectionString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnectionString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotConnectionString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotConnectionString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotConnectionString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSiteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfig\"}}]")]
        public virtual void PutSiteConfig(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAppSettings")]
        public virtual void ResetAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthSettings")]
        public virtual void ResetAuthSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthSettingsV2")]
        public virtual void ResetAuthSettingsV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackup")]
        public virtual void ResetBackup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuiltinLoggingEnabled")]
        public virtual void ResetBuiltinLoggingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateEnabled")]
        public virtual void ResetClientCertificateEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateExclusionPaths")]
        public virtual void ResetClientCertificateExclusionPaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateMode")]
        public virtual void ResetClientCertificateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionString")]
        public virtual void ResetConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentShareForceDisabled")]
        public virtual void ResetContentShareForceDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDailyMemoryTimeQuota")]
        public virtual void ResetDailyMemoryTimeQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFtpPublishBasicAuthenticationEnabled")]
        public virtual void ResetFtpPublishBasicAuthenticationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunctionsExtensionVersion")]
        public virtual void ResetFunctionsExtensionVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpsOnly")]
        public virtual void ResetHttpsOnly()
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

        [JsiiMethod(name: "resetKeyVaultReferenceIdentityId")]
        public virtual void ResetKeyVaultReferenceIdentityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServicePlanId")]
        public virtual void ResetServicePlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccount")]
        public virtual void ResetStorageAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccountAccessKey")]
        public virtual void ResetStorageAccountAccessKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageAccountName")]
        public virtual void ResetStorageAccountName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageKeyVaultSecretId")]
        public virtual void ResetStorageKeyVaultSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageUsesManagedIdentity")]
        public virtual void ResetStorageUsesManagedIdentity()
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

        [JsiiMethod(name: "resetVirtualNetworkSubnetId")]
        public virtual void ResetVirtualNetworkSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVnetImagePullEnabled")]
        public virtual void ResetVnetImagePullEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebdeployPublishBasicAuthenticationEnabled")]
        public virtual void ResetWebdeployPublishBasicAuthenticationEnabled()
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
        = GetStaticProperty<string>(typeof(azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlot))!;

        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsOutputReference AuthSettings
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2OutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2OutputReference AuthSettingsV2
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2OutputReference>()!;
        }

        [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackupOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotBackupOutputReference Backup
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotBackupOutputReference>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotConnectionStringList\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotConnectionStringList>()!;
        }

        [JsiiProperty(name: "customDomainVerificationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainVerificationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostingEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostingEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotIdentityOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundIpAddresses
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddressList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundIpAddressList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "possibleOutboundIpAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PossibleOutboundIpAddresses
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "possibleOutboundIpAddressList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PossibleOutboundIpAddressList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigOutputReference SiteConfig
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigOutputReference>()!;
        }

        [JsiiProperty(name: "siteCredential", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteCredentialList\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotSiteCredentialList SiteCredential
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotSiteCredentialList>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotStorageAccountList\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotStorageAccountList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotTimeoutsOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AppSettingsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSettingsInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettings\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettings? AuthSettingsInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSettingsV2Input", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsV2\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2? AuthSettingsV2Input
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackup\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackup? BackupInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "builtinLoggingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BuiltinLoggingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ClientCertificateEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateExclusionPathsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateExclusionPathsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentShareForceDisabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ContentShareForceDisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyMemoryTimeQuotaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DailyMemoryTimeQuotaInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FtpPublishBasicAuthenticationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionAppIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionAppIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionsExtensionVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionsExtensionVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotIdentity\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultReferenceIdentityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultReferenceIdentityIdInput
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
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServicePlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "siteConfigInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfig\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfig? SiteConfigInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountAccessKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountAccessKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageKeyVaultSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageKeyVaultSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageUsesManagedIdentityInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StorageUsesManagedIdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualNetworkSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnetImagePullEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VnetImagePullEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WebdeployPublishBasicAuthenticationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AppSettings
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "builtinLoggingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BuiltinLoggingEnabled
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

        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ClientCertificateEnabled
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

        [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateExclusionPaths
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentShareForceDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ContentShareForceDisabled
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

        [JsiiProperty(name: "dailyMemoryTimeQuota", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DailyMemoryTimeQuota
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FtpPublishBasicAuthenticationEnabled
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

        [JsiiProperty(name: "functionAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionAppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionsExtensionVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionsExtensionVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HttpsOnly
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

        [JsiiProperty(name: "keyVaultReferenceIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultReferenceIdentityId
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

        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountAccessKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageKeyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageKeyVaultSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageUsesManagedIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StorageUsesManagedIdentity
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vnetImagePullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object VnetImagePullEnabled
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

        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WebdeployPublishBasicAuthenticationEnabled
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
    }
}
