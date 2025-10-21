using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudBuildPackBinding
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding azurerm_spring_cloud_build_pack_binding}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding), fullyQualifiedName: "azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBinding", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingConfig\"}}]")]
    public class SpringCloudBuildPackBinding : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding azurerm_spring_cloud_build_pack_binding} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SpringCloudBuildPackBinding(Constructs.Construct scope, string id, azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudBuildPackBinding(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudBuildPackBinding(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SpringCloudBuildPackBinding resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SpringCloudBuildPackBinding to import.</param>
        /// <param name="importFromId">The id of the existing SpringCloudBuildPackBinding that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SpringCloudBuildPackBinding to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SpringCloudBuildPackBinding to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_pack_binding#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SpringCloudBuildPackBinding that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SpringCloudBuildPackBinding to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLaunch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingLaunch\"}}]")]
        public virtual void PutLaunch(azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingLaunch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingLaunch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBindingType")]
        public virtual void ResetBindingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunch")]
        public virtual void ResetLaunch()
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
        = GetStaticProperty<string>(typeof(azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBinding))!;

        [JsiiProperty(name: "launch", typeJson: "{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingLaunchOutputReference\"}")]
        public virtual azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingLaunchOutputReference Launch
        {
            get => GetInstanceProperty<azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingLaunchOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingTimeoutsOutputReference\"}")]
        public virtual azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SpringCloudBuildPackBinding.SpringCloudBuildPackBindingTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bindingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BindingTypeInput
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
        [JsiiProperty(name: "launchInput", typeJson: "{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingLaunch\"}", isOptional: true)]
        public virtual azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingLaunch? LaunchInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudBuildPackBinding.ISpringCloudBuildPackBindingLaunch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "springCloudBuilderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpringCloudBuilderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.springCloudBuildPackBinding.SpringCloudBuildPackBindingTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bindingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BindingType
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

        [JsiiProperty(name: "springCloudBuilderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpringCloudBuilderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
