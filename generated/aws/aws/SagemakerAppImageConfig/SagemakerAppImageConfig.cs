using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config aws_sagemaker_app_image_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfig), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigConfig\"}}]")]
    public class SagemakerAppImageConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config aws_sagemaker_app_image_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerAppImageConfig(Constructs.Construct scope, string id, aws.SagemakerAppImageConfig.ISagemakerAppImageConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerAppImageConfig.ISagemakerAppImageConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SagemakerAppImageConfig resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerAppImageConfig to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerAppImageConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerAppImageConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerAppImageConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerAppImageConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerAppImageConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCodeEditorAppImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig\"}}]")]
        public virtual void PutCodeEditorAppImageConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJupyterLabImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfig\"}}]")]
        public virtual void PutJupyterLabImageConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKernelGatewayImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig\"}}]")]
        public virtual void PutKernelGatewayImageConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeEditorAppImageConfig")]
        public virtual void ResetCodeEditorAppImageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJupyterLabImageConfig")]
        public virtual void ResetJupyterLabImageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelGatewayImageConfig")]
        public virtual void ResetKernelGatewayImageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfig))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "codeEditorAppImageConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference CodeEditorAppImageConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference>()!;
        }

        [JsiiProperty(name: "jupyterLabImageConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigOutputReference JupyterLabImageConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigOutputReference>()!;
        }

        [JsiiProperty(name: "kernelGatewayImageConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigOutputReference KernelGatewayImageConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appImageConfigNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppImageConfigNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeEditorAppImageConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig? CodeEditorAppImageConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterLabImageConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig? JupyterLabImageConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayImageConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig? KernelGatewayImageConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "appImageConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppImageConfigName
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
