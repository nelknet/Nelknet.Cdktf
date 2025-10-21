using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsWebApp
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app azurerm_windows_web_app}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp), fullyQualifiedName: "azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebApp", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppConfig\"}}]")]
    public class DataAzurermWindowsWebApp : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app azurerm_windows_web_app} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermWindowsWebApp(Constructs.Construct scope, string id, azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebApp(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermWindowsWebApp resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermWindowsWebApp to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermWindowsWebApp that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermWindowsWebApp to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermWindowsWebApp to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermWindowsWebApp that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermWindowsWebApp to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebApp))!;

        [JsiiProperty(name: "appSettings", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap AppSettings
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "authSettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsList AuthSettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsList>()!;
        }

        [JsiiProperty(name: "authSettingsV2", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsV2List\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsV2List AuthSettingsV2
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppAuthSettingsV2List>()!;
        }

        [JsiiProperty(name: "backup", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppBackupList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppBackupList Backup
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppBackupList>()!;
        }

        [JsiiProperty(name: "clientAffinityEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ClientAffinityEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ClientCertificateEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCertificateExclusionPaths", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateExclusionPaths
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientCertificateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppConnectionStringList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppConnectionStringList>()!;
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

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ftpPublishBasicAuthenticationEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable FtpPublishBasicAuthenticationEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "hostingEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostingEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpsOnly", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HttpsOnly
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppIdentityList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppIdentityList>()!;
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

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppLogsList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppLogsList Logs
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppLogsList>()!;
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

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "servicePlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "siteConfig", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigList SiteConfig
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigList>()!;
        }

        [JsiiProperty(name: "siteCredential", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteCredentialList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteCredentialList SiteCredential
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteCredentialList>()!;
        }

        [JsiiProperty(name: "stickySettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppStickySettingsList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppStickySettingsList StickySettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppStickySettingsList>()!;
        }

        [JsiiProperty(name: "storageAccount", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppStorageAccountList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppStorageAccountList StorageAccount
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppStorageAccountList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualNetworkSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webdeployPublishBasicAuthenticationEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable WebdeployPublishBasicAuthenticationEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeouts\"}]}}", isOptional: true)]
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
