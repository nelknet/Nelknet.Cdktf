using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerPipeline
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline aws_sagemaker_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerPipeline.SagemakerPipeline), fullyQualifiedName: "aws.sagemakerPipeline.SagemakerPipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelineConfig\"}}]")]
    public class SagemakerPipeline : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline aws_sagemaker_pipeline} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerPipeline(Constructs.Construct scope, string id, aws.SagemakerPipeline.ISagemakerPipelineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerPipeline.ISagemakerPipelineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerPipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerPipeline(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SagemakerPipeline resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerPipeline to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerPipeline that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerPipeline to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerPipeline to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerPipeline that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerPipeline to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SagemakerPipeline.SagemakerPipeline), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putParallelismConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelineParallelismConfiguration\"}}]")]
        public virtual void PutParallelismConfiguration(aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipelineDefinitionS3Location", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelinePipelineDefinitionS3Location\"}}]")]
        public virtual void PutPipelineDefinitionS3Location(aws.SagemakerPipeline.ISagemakerPipelinePipelineDefinitionS3Location @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerPipeline.ISagemakerPipelinePipelineDefinitionS3Location)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelismConfiguration")]
        public virtual void ResetParallelismConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineDefinition")]
        public virtual void ResetPipelineDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineDefinitionS3Location")]
        public virtual void ResetPipelineDefinitionS3Location()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineDescription")]
        public virtual void ResetPipelineDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerPipeline.SagemakerPipeline))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parallelismConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelineParallelismConfigurationOutputReference\"}")]
        public virtual aws.SagemakerPipeline.SagemakerPipelineParallelismConfigurationOutputReference ParallelismConfiguration
        {
            get => GetInstanceProperty<aws.SagemakerPipeline.SagemakerPipelineParallelismConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "pipelineDefinitionS3Location", typeJson: "{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelinePipelineDefinitionS3LocationOutputReference\"}")]
        public virtual aws.SagemakerPipeline.SagemakerPipelinePipelineDefinitionS3LocationOutputReference PipelineDefinitionS3Location
        {
            get => GetInstanceProperty<aws.SagemakerPipeline.SagemakerPipelinePipelineDefinitionS3LocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelismConfigurationInput", typeJson: "{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelineParallelismConfiguration\"}", isOptional: true)]
        public virtual aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration? ParallelismConfigurationInput
        {
            get => GetInstanceProperty<aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineDefinitionS3LocationInput", typeJson: "{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelinePipelineDefinitionS3Location\"}", isOptional: true)]
        public virtual aws.SagemakerPipeline.ISagemakerPipelinePipelineDefinitionS3Location? PipelineDefinitionS3LocationInput
        {
            get => GetInstanceProperty<aws.SagemakerPipeline.ISagemakerPipelinePipelineDefinitionS3Location?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineDisplayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineDisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pipelineDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pipelineDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pipelineDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineDisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pipelineName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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
