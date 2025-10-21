using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection azurerm_app_service_connection}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.AppServiceConnection.AppServiceConnection), fullyQualifiedName: "azurerm.appServiceConnection.AppServiceConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionConfig\"}}]")]
    public class AppServiceConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection azurerm_app_service_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppServiceConnection(Constructs.Construct scope, string id, azurerm.AppServiceConnection.IAppServiceConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.AppServiceConnection.IAppServiceConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AppServiceConnection resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AppServiceConnection to import.</param>
        /// <param name="importFromId">The id of the existing AppServiceConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AppServiceConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AppServiceConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AppServiceConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AppServiceConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.AppServiceConnection.AppServiceConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionAuthentication\"}}]")]
        public virtual void PutAuthentication(azurerm.AppServiceConnection.IAppServiceConnectionAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceConnection.IAppServiceConnectionAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionSecretStore\"}}]")]
        public virtual void PutSecretStore(azurerm.AppServiceConnection.IAppServiceConnectionSecretStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceConnection.IAppServiceConnectionSecretStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.AppServiceConnection.IAppServiceConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceConnection.IAppServiceConnectionTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.AppServiceConnection.AppServiceConnection))!;

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionAuthenticationOutputReference\"}")]
        public virtual azurerm.AppServiceConnection.AppServiceConnectionAuthenticationOutputReference Authentication
        {
            get => GetInstanceProperty<azurerm.AppServiceConnection.AppServiceConnectionAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "secretStore", typeJson: "{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionSecretStoreOutputReference\"}")]
        public virtual azurerm.AppServiceConnection.AppServiceConnectionSecretStoreOutputReference SecretStore
        {
            get => GetInstanceProperty<azurerm.AppServiceConnection.AppServiceConnectionSecretStoreOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionTimeoutsOutputReference\"}")]
        public virtual azurerm.AppServiceConnection.AppServiceConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.AppServiceConnection.AppServiceConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationInput", typeJson: "{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionAuthentication\"}", isOptional: true)]
        public virtual azurerm.AppServiceConnection.IAppServiceConnectionAuthentication? AuthenticationInput
        {
            get => GetInstanceProperty<azurerm.AppServiceConnection.IAppServiceConnectionAuthentication?>();
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
        [JsiiProperty(name: "secretStoreInput", typeJson: "{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionSecretStore\"}", isOptional: true)]
        public virtual azurerm.AppServiceConnection.IAppServiceConnectionSecretStore? SecretStoreInput
        {
            get => GetInstanceProperty<azurerm.AppServiceConnection.IAppServiceConnectionSecretStore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.appServiceConnection.AppServiceConnectionTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "appServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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
