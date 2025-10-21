using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StaticWebAppFunctionAppRegistration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration azurerm_static_web_app_function_app_registration}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration), fullyQualifiedName: "azurerm.staticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.staticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationConfig\"}}]")]
    public class StaticWebAppFunctionAppRegistration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration azurerm_static_web_app_function_app_registration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StaticWebAppFunctionAppRegistration(Constructs.Construct scope, string id, azurerm.StaticWebAppFunctionAppRegistration.IStaticWebAppFunctionAppRegistrationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.StaticWebAppFunctionAppRegistration.IStaticWebAppFunctionAppRegistrationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StaticWebAppFunctionAppRegistration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StaticWebAppFunctionAppRegistration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a StaticWebAppFunctionAppRegistration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StaticWebAppFunctionAppRegistration to import.</param>
        /// <param name="importFromId">The id of the existing StaticWebAppFunctionAppRegistration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StaticWebAppFunctionAppRegistration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StaticWebAppFunctionAppRegistration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StaticWebAppFunctionAppRegistration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StaticWebAppFunctionAppRegistration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.staticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.StaticWebAppFunctionAppRegistration.IStaticWebAppFunctionAppRegistrationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StaticWebAppFunctionAppRegistration.IStaticWebAppFunctionAppRegistrationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.staticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationTimeoutsOutputReference\"}")]
        public virtual azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "staticWebAppIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StaticWebAppIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.staticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "staticWebAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StaticWebAppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
