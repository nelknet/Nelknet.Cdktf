using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management azurerm_api_management}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApiManagement.DataAzurermApiManagement), fullyQualifiedName: "azurerm.dataAzurermApiManagement.DataAzurermApiManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementConfig\"}}]")]
    public class DataAzurermApiManagement : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management azurerm_api_management} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermApiManagement(Constructs.Construct scope, string id, azurerm.DataAzurermApiManagement.IDataAzurermApiManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermApiManagement.IDataAzurermApiManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApiManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApiManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermApiManagement resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermApiManagement to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermApiManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermApiManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermApiManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermApiManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermApiManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermApiManagement.DataAzurermApiManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermApiManagement.IDataAzurermApiManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermApiManagement.IDataAzurermApiManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermApiManagement.DataAzurermApiManagement))!;

        [JsiiProperty(name: "additionalLocation", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementAdditionalLocationList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementAdditionalLocationList AdditionalLocation
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementAdditionalLocationList>()!;
        }

        [JsiiProperty(name: "developerPortalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeveloperPortalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayRegionalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayRegionalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostnameConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationList HostnameConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementHostnameConfigurationList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementIdentityList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementIdentityList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementApiUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementApiUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationSenderEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationSenderEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publicIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpAddressId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publisherName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantAccess", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementTenantAccessList\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementTenantAccessList TenantAccess
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementTenantAccessList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermApiManagement.DataAzurermApiManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermApiManagement.DataAzurermApiManagementTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermApiManagement.DataAzurermApiManagementTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
