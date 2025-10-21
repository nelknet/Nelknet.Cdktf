using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBedrockCustomModel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_custom_model aws_bedrock_custom_model}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel), fullyQualifiedName: "aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModelConfig\"}}]")]
    public class DataAwsBedrockCustomModel : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_custom_model aws_bedrock_custom_model} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsBedrockCustomModel(Constructs.Construct scope, string id, aws.DataAwsBedrockCustomModel.IDataAwsBedrockCustomModelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsBedrockCustomModel.IDataAwsBedrockCustomModelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBedrockCustomModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBedrockCustomModel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsBedrockCustomModel resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsBedrockCustomModel to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsBedrockCustomModel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsBedrockCustomModel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsBedrockCustomModel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_custom_model#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsBedrockCustomModel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsBedrockCustomModel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel))!;

        [JsiiProperty(name: "baseModelArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseModelArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hyperparameters", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Hyperparameters
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobTags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap JobTags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "modelArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelKmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelTags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap ModelTags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "outputDataConfig", typeJson: "{\"fqn\":\"aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModelOutputDataConfigList\"}")]
        public virtual aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelOutputDataConfigList OutputDataConfig
        {
            get => GetInstanceProperty<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelOutputDataConfigList>()!;
        }

        [JsiiProperty(name: "trainingDataConfig", typeJson: "{\"fqn\":\"aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModelTrainingDataConfigList\"}")]
        public virtual aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelTrainingDataConfigList TrainingDataConfig
        {
            get => GetInstanceProperty<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelTrainingDataConfigList>()!;
        }

        [JsiiProperty(name: "trainingMetrics", typeJson: "{\"fqn\":\"aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModelTrainingMetricsList\"}")]
        public virtual aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelTrainingMetricsList TrainingMetrics
        {
            get => GetInstanceProperty<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelTrainingMetricsList>()!;
        }

        [JsiiProperty(name: "validationDataConfig", typeJson: "{\"fqn\":\"aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModelValidationDataConfigList\"}")]
        public virtual aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelValidationDataConfigList ValidationDataConfig
        {
            get => GetInstanceProperty<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelValidationDataConfigList>()!;
        }

        [JsiiProperty(name: "validationMetrics", typeJson: "{\"fqn\":\"aws.dataAwsBedrockCustomModel.DataAwsBedrockCustomModelValidationMetricsList\"}")]
        public virtual aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelValidationMetricsList ValidationMetrics
        {
            get => GetInstanceProperty<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelValidationMetricsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
