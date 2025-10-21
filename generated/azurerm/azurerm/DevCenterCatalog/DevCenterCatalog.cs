using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevCenterCatalog
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog azurerm_dev_center_catalog}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DevCenterCatalog.DevCenterCatalog), fullyQualifiedName: "azurerm.devCenterCatalog.DevCenterCatalog", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogConfig\"}}]")]
    public class DevCenterCatalog : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog azurerm_dev_center_catalog} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevCenterCatalog(Constructs.Construct scope, string id, azurerm.DevCenterCatalog.IDevCenterCatalogConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DevCenterCatalog.IDevCenterCatalogConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevCenterCatalog(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevCenterCatalog(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DevCenterCatalog resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevCenterCatalog to import.</param>
        /// <param name="importFromId">The id of the existing DevCenterCatalog that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevCenterCatalog to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevCenterCatalog to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevCenterCatalog that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevCenterCatalog to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DevCenterCatalog.DevCenterCatalog), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCatalogAdogit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogCatalogAdogit\"}}]")]
        public virtual void PutCatalogAdogit(azurerm.DevCenterCatalog.IDevCenterCatalogCatalogAdogit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevCenterCatalog.IDevCenterCatalogCatalogAdogit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCatalogGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogCatalogGithub\"}}]")]
        public virtual void PutCatalogGithub(azurerm.DevCenterCatalog.IDevCenterCatalogCatalogGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevCenterCatalog.IDevCenterCatalogCatalogGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DevCenterCatalog.IDevCenterCatalogTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevCenterCatalog.IDevCenterCatalogTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogAdogit")]
        public virtual void ResetCatalogAdogit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCatalogGithub")]
        public virtual void ResetCatalogGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(azurerm.DevCenterCatalog.DevCenterCatalog))!;

        [JsiiProperty(name: "catalogAdogit", typeJson: "{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogCatalogAdogitOutputReference\"}")]
        public virtual azurerm.DevCenterCatalog.DevCenterCatalogCatalogAdogitOutputReference CatalogAdogit
        {
            get => GetInstanceProperty<azurerm.DevCenterCatalog.DevCenterCatalogCatalogAdogitOutputReference>()!;
        }

        [JsiiProperty(name: "catalogGithub", typeJson: "{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogCatalogGithubOutputReference\"}")]
        public virtual azurerm.DevCenterCatalog.DevCenterCatalogCatalogGithubOutputReference CatalogGithub
        {
            get => GetInstanceProperty<azurerm.DevCenterCatalog.DevCenterCatalogCatalogGithubOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogTimeoutsOutputReference\"}")]
        public virtual azurerm.DevCenterCatalog.DevCenterCatalogTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DevCenterCatalog.DevCenterCatalogTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogAdogitInput", typeJson: "{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogCatalogAdogit\"}", isOptional: true)]
        public virtual azurerm.DevCenterCatalog.IDevCenterCatalogCatalogAdogit? CatalogAdogitInput
        {
            get => GetInstanceProperty<azurerm.DevCenterCatalog.IDevCenterCatalogCatalogAdogit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogGithubInput", typeJson: "{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogCatalogGithub\"}", isOptional: true)]
        public virtual azurerm.DevCenterCatalog.IDevCenterCatalogCatalogGithub? CatalogGithubInput
        {
            get => GetInstanceProperty<azurerm.DevCenterCatalog.IDevCenterCatalogCatalogGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devCenterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DevCenterIdInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.devCenterCatalog.DevCenterCatalogTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "devCenterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DevCenterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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
