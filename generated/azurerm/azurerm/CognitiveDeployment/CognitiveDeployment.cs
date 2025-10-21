using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment azurerm_cognitive_deployment}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CognitiveDeployment.CognitiveDeployment), fullyQualifiedName: "azurerm.cognitiveDeployment.CognitiveDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentConfig\"}}]")]
    public class CognitiveDeployment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment azurerm_cognitive_deployment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CognitiveDeployment(Constructs.Construct scope, string id, azurerm.CognitiveDeployment.ICognitiveDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CognitiveDeployment.ICognitiveDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitiveDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitiveDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CognitiveDeployment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CognitiveDeployment to import.</param>
        /// <param name="importFromId">The id of the existing CognitiveDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CognitiveDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CognitiveDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CognitiveDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CognitiveDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.CognitiveDeployment.CognitiveDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putModel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentModel\"}}]")]
        public virtual void PutModel(azurerm.CognitiveDeployment.ICognitiveDeploymentModel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CognitiveDeployment.ICognitiveDeploymentModel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSku", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentSku\"}}]")]
        public virtual void PutSku(azurerm.CognitiveDeployment.ICognitiveDeploymentSku @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CognitiveDeployment.ICognitiveDeploymentSku)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CognitiveDeployment.ICognitiveDeploymentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CognitiveDeployment.ICognitiveDeploymentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRaiPolicyName")]
        public virtual void ResetRaiPolicyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionUpgradeOption")]
        public virtual void ResetVersionUpgradeOption()
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
        = GetStaticProperty<string>(typeof(azurerm.CognitiveDeployment.CognitiveDeployment))!;

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentModelOutputReference\"}")]
        public virtual azurerm.CognitiveDeployment.CognitiveDeploymentModelOutputReference Model
        {
            get => GetInstanceProperty<azurerm.CognitiveDeployment.CognitiveDeploymentModelOutputReference>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentSkuOutputReference\"}")]
        public virtual azurerm.CognitiveDeployment.CognitiveDeploymentSkuOutputReference Sku
        {
            get => GetInstanceProperty<azurerm.CognitiveDeployment.CognitiveDeploymentSkuOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentTimeoutsOutputReference\"}")]
        public virtual azurerm.CognitiveDeployment.CognitiveDeploymentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CognitiveDeployment.CognitiveDeploymentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitiveAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CognitiveAccountIdInput
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
        [JsiiProperty(name: "modelInput", typeJson: "{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentModel\"}", isOptional: true)]
        public virtual azurerm.CognitiveDeployment.ICognitiveDeploymentModel? ModelInput
        {
            get => GetInstanceProperty<azurerm.CognitiveDeployment.ICognitiveDeploymentModel?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "raiPolicyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RaiPolicyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentSku\"}", isOptional: true)]
        public virtual azurerm.CognitiveDeployment.ICognitiveDeploymentSku? SkuInput
        {
            get => GetInstanceProperty<azurerm.CognitiveDeployment.ICognitiveDeploymentSku?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cognitiveDeployment.CognitiveDeploymentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionUpgradeOptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionUpgradeOptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cognitiveAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CognitiveAccountId
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

        [JsiiProperty(name: "raiPolicyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RaiPolicyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionUpgradeOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionUpgradeOption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
