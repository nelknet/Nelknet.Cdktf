using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition aws_sagemaker_flow_definition}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerFlowDefinition.SagemakerFlowDefinition), fullyQualifiedName: "aws.sagemakerFlowDefinition.SagemakerFlowDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionConfig\"}}]")]
    public class SagemakerFlowDefinition : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition aws_sagemaker_flow_definition} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerFlowDefinition(Constructs.Construct scope, string id, aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SagemakerFlowDefinition resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerFlowDefinition to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerFlowDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerFlowDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerFlowDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerFlowDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerFlowDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SagemakerFlowDefinition.SagemakerFlowDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHumanLoopActivationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfig\"}}]")]
        public virtual void PutHumanLoopActivationConfig(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHumanLoopConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig\"}}]")]
        public virtual void PutHumanLoopConfig(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHumanLoopRequestSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSource\"}}]")]
        public virtual void PutHumanLoopRequestSource(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfig\"}}]")]
        public virtual void PutOutputConfig(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHumanLoopActivationConfig")]
        public virtual void ResetHumanLoopActivationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHumanLoopRequestSource")]
        public virtual void ResetHumanLoopRequestSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerFlowDefinition.SagemakerFlowDefinition))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "humanLoopActivationConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference\"}")]
        public virtual aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference HumanLoopActivationConfig
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "humanLoopConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigOutputReference\"}")]
        public virtual aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigOutputReference HumanLoopConfig
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigOutputReference>()!;
        }

        [JsiiProperty(name: "humanLoopRequestSource", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference\"}")]
        public virtual aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference HumanLoopRequestSource
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference>()!;
        }

        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfigOutputReference\"}")]
        public virtual aws.SagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfigOutputReference OutputConfig
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowDefinitionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlowDefinitionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopActivationConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig? HumanLoopActivationConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig? HumanLoopConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopRequestSourceInput", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
        public virtual aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource? HumanLoopRequestSourceInput
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfig\"}", isOptional: true)]
        public virtual aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig? OutputConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionOutputConfig?>();
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

        [JsiiProperty(name: "flowDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowDefinitionName
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
