using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection azurerm_spring_cloud_connection}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudConnection.SpringCloudConnection), fullyQualifiedName: "azurerm.springCloudConnection.SpringCloudConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionConfig\"}}]")]
    public class SpringCloudConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection azurerm_spring_cloud_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SpringCloudConnection(Constructs.Construct scope, string id, azurerm.SpringCloudConnection.ISpringCloudConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SpringCloudConnection.ISpringCloudConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SpringCloudConnection resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SpringCloudConnection to import.</param>
        /// <param name="importFromId">The id of the existing SpringCloudConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SpringCloudConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SpringCloudConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SpringCloudConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SpringCloudConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SpringCloudConnection.SpringCloudConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionAuthentication\"}}]")]
        public virtual void PutAuthentication(azurerm.SpringCloudConnection.ISpringCloudConnectionAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudConnection.ISpringCloudConnectionAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionSecretStore\"}}]")]
        public virtual void PutSecretStore(azurerm.SpringCloudConnection.ISpringCloudConnectionSecretStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudConnection.ISpringCloudConnectionSecretStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SpringCloudConnection.ISpringCloudConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudConnection.ISpringCloudConnectionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientType")]
        public virtual void ResetClientType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretStore")]
        public virtual void ResetSecretStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVnetSolution")]
        public virtual void ResetVnetSolution()
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
        = GetStaticProperty<string>(typeof(azurerm.SpringCloudConnection.SpringCloudConnection))!;

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionAuthenticationOutputReference\"}")]
        public virtual azurerm.SpringCloudConnection.SpringCloudConnectionAuthenticationOutputReference Authentication
        {
            get => GetInstanceProperty<azurerm.SpringCloudConnection.SpringCloudConnectionAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "secretStore", typeJson: "{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionSecretStoreOutputReference\"}")]
        public virtual azurerm.SpringCloudConnection.SpringCloudConnectionSecretStoreOutputReference SecretStore
        {
            get => GetInstanceProperty<azurerm.SpringCloudConnection.SpringCloudConnectionSecretStoreOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionTimeoutsOutputReference\"}")]
        public virtual azurerm.SpringCloudConnection.SpringCloudConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SpringCloudConnection.SpringCloudConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationInput", typeJson: "{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionAuthentication\"}", isOptional: true)]
        public virtual azurerm.SpringCloudConnection.ISpringCloudConnectionAuthentication? AuthenticationInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudConnection.ISpringCloudConnectionAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientTypeInput
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
        [JsiiProperty(name: "secretStoreInput", typeJson: "{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionSecretStore\"}", isOptional: true)]
        public virtual azurerm.SpringCloudConnection.ISpringCloudConnectionSecretStore? SecretStoreInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudConnection.ISpringCloudConnectionSecretStore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "springCloudIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpringCloudIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.springCloudConnection.SpringCloudConnectionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnetSolutionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VnetSolutionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientType
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

        [JsiiProperty(name: "springCloudId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpringCloudId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vnetSolution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VnetSolution
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
