using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection azurerm_function_app_connection}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.FunctionAppConnection.FunctionAppConnection), fullyQualifiedName: "azurerm.functionAppConnection.FunctionAppConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionConfig\"}}]")]
    public class FunctionAppConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection azurerm_function_app_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FunctionAppConnection(Constructs.Construct scope, string id, azurerm.FunctionAppConnection.IFunctionAppConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.FunctionAppConnection.IFunctionAppConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a FunctionAppConnection resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FunctionAppConnection to import.</param>
        /// <param name="importFromId">The id of the existing FunctionAppConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FunctionAppConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FunctionAppConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FunctionAppConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FunctionAppConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.FunctionAppConnection.FunctionAppConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionAuthentication\"}}]")]
        public virtual void PutAuthentication(azurerm.FunctionAppConnection.IFunctionAppConnectionAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppConnection.IFunctionAppConnectionAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecretStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionSecretStore\"}}]")]
        public virtual void PutSecretStore(azurerm.FunctionAppConnection.IFunctionAppConnectionSecretStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppConnection.IFunctionAppConnectionSecretStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.FunctionAppConnection.IFunctionAppConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FunctionAppConnection.IFunctionAppConnectionTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.FunctionAppConnection.FunctionAppConnection))!;

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionAuthenticationOutputReference\"}")]
        public virtual azurerm.FunctionAppConnection.FunctionAppConnectionAuthenticationOutputReference Authentication
        {
            get => GetInstanceProperty<azurerm.FunctionAppConnection.FunctionAppConnectionAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "secretStore", typeJson: "{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionSecretStoreOutputReference\"}")]
        public virtual azurerm.FunctionAppConnection.FunctionAppConnectionSecretStoreOutputReference SecretStore
        {
            get => GetInstanceProperty<azurerm.FunctionAppConnection.FunctionAppConnectionSecretStoreOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionTimeoutsOutputReference\"}")]
        public virtual azurerm.FunctionAppConnection.FunctionAppConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.FunctionAppConnection.FunctionAppConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationInput", typeJson: "{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionAuthentication\"}", isOptional: true)]
        public virtual azurerm.FunctionAppConnection.IFunctionAppConnectionAuthentication? AuthenticationInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppConnection.IFunctionAppConnectionAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionAppIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionAppIdInput
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
        [JsiiProperty(name: "secretStoreInput", typeJson: "{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionSecretStore\"}", isOptional: true)]
        public virtual azurerm.FunctionAppConnection.IFunctionAppConnectionSecretStore? SecretStoreInput
        {
            get => GetInstanceProperty<azurerm.FunctionAppConnection.IFunctionAppConnectionSecretStore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.functionAppConnection.FunctionAppConnectionTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "functionAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionAppId
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
