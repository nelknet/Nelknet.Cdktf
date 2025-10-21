using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerApp
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app azurerm_container_app}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerApp), fullyQualifiedName: "azurerm.dataAzurermContainerApp.DataAzurermContainerApp", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppConfig\"}}]")]
    public class DataAzurermContainerApp : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app azurerm_container_app} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermContainerApp(Constructs.Construct scope, string id, azurerm.DataAzurermContainerApp.IDataAzurermContainerAppConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermContainerApp.IDataAzurermContainerAppConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermContainerApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermContainerApp(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermContainerApp resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermContainerApp to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermContainerApp that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermContainerApp to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermContainerApp to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermContainerApp that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermContainerApp to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerApp), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermContainerApp.IDataAzurermContainerAppTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermContainerApp.DataAzurermContainerApp))!;

        [JsiiProperty(name: "containerAppEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerAppEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customDomainVerificationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomainVerificationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dapr", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppDaprList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppDaprList Dapr
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppDaprList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppIdentityList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppIdentityList>()!;
        }

        [JsiiProperty(name: "ingress", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppIngressList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressList Ingress
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppIngressList>()!;
        }

        [JsiiProperty(name: "latestRevisionFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestRevisionFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestRevisionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestRevisionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registry", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppRegistryList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppRegistryList Registry
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppRegistryList>()!;
        }

        [JsiiProperty(name: "revisionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppSecretList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppSecretList Secret
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppSecretList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTemplateList\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateList Template
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTemplateList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermContainerApp.DataAzurermContainerAppTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermContainerApp.DataAzurermContainerAppTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workloadProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadProfileName
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermContainerApp.DataAzurermContainerAppTimeouts\"}]}}", isOptional: true)]
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
