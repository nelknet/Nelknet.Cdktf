using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot azurerm_windows_web_app_slot}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlot), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotConfig\"}}]")]
    public class WindowsWebAppSlot : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot azurerm_windows_web_app_slot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WindowsWebAppSlot(Constructs.Construct scope, string id, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSlot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSlot(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a WindowsWebAppSlot resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WindowsWebAppSlot to import.</param>
        /// <param name="importFromId">The id of the existing WindowsWebAppSlot that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WindowsWebAppSlot to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WindowsWebAppSlot to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WindowsWebAppSlot that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WindowsWebAppSlot to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlot), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettings\"}}]")]
        public virtual void PutAuthSettings(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthSettingsV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2\"}}]")]
        public virtual void PutAuthSettingsV2(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotBackup\"}}]")]
        public virtual void PutBackup(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotBackup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotBackup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotConnectionString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnectionString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.WindowsWebAppSlot.IWindowsWebAppSlotConnectionString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotConnectionString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotConnectionString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogs\"}}]")]
        public virtual void PutLogs(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSiteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfig\"}}]")]
        public virtual void PutSiteConfig(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotStorageAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.WindowsWebAppSlot.IWindowsWebAppSlotStorageAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotStorageAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotStorageAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetClientAffinityEnabled")]
        public virtual void ResetClientAffinityEnabled()
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

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
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

        [JsiiMethod(name: "resetWebdeployPublishBasicAuthenticationEnabled")]
        public virtual void ResetWebdeployPublishBasicAuthenticationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZipDeployFile")]
        public virtual void ResetZipDeployFile()
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
        = GetStaticProperty<string>(typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlot))!;

        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsOutputReference AuthSettings
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2OutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2OutputReference AuthSettingsV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2OutputReference>()!;
        }

        [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotBackupOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotBackupOutputReference Backup
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotBackupOutputReference>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotConnectionStringList\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotConnectionStringList>()!;
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

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotIdentityOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsOutputReference Logs
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotLogsOutputReference>()!;
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

        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigOutputReference SiteConfig
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteConfigOutputReference>()!;
        }

        [JsiiProperty(name: "siteCredential", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteCredentialList\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteCredentialList SiteCredential
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotSiteCredentialList>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotStorageAccountList\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotStorageAccountList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotTimeoutsOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AppSettingsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSettingsInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettings\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings? AuthSettingsInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSettingsV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2? AuthSettingsV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotBackup\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotBackup? BackupInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotBackup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAffinityEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ClientAffinityEnabledInput
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
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotConnectionString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionStringInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "httpsOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotIdentity\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotIdentity?>();
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
        [JsiiProperty(name: "logsInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogs\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogs? LogsInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogs?>();
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
        [JsiiProperty(name: "siteConfigInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfig\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfig? SiteConfigInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageAccountInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotTimeouts\"}]}}", isOptional: true)]
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
        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WebdeployPublishBasicAuthenticationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipDeployFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipDeployFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "appServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AppSettings
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientAffinityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ClientAffinityEnabled
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

        [JsiiProperty(name: "zipDeployFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipDeployFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
