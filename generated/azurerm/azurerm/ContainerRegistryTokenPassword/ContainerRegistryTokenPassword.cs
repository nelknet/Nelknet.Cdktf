using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTokenPassword
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password azurerm_container_registry_token_password}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword), fullyQualifiedName: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPassword", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordConfig\"}}]")]
    public class ContainerRegistryTokenPassword : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password azurerm_container_registry_token_password} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerRegistryTokenPassword(Constructs.Construct scope, string id, azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTokenPassword(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTokenPassword(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ContainerRegistryTokenPassword resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerRegistryTokenPassword to import.</param>
        /// <param name="importFromId">The id of the existing ContainerRegistryTokenPassword that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerRegistryTokenPassword to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerRegistryTokenPassword to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerRegistryTokenPassword that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerRegistryTokenPassword to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPassword1", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1\"}}]")]
        public virtual void PutPassword1(azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassword2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2\"}}]")]
        public virtual void PutPassword2(azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword2")]
        public virtual void ResetPassword2()
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
        = GetStaticProperty<string>(typeof(azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword))!;

        [JsiiProperty(name: "password1", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1OutputReference\"}")]
        public virtual azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1OutputReference Password1
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1OutputReference>()!;
        }

        [JsiiProperty(name: "password2", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2OutputReference\"}")]
        public virtual azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2OutputReference Password2
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2OutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeoutsOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryTokenIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRegistryTokenIdInput
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
        [JsiiProperty(name: "password1Input", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1? Password1Input
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "password2Input", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2? Password2Input
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "containerRegistryTokenId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryTokenId
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
    }
}
