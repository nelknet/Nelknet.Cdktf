using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation")]
    public interface IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#step_to_apply BedrockagentDataSource#step_to_apply}.</summary>
        [JsiiProperty(name: "stepToApply", typeJson: "{\"primitive\":\"string\"}")]
        string StepToApply
        {
            get;
        }

        /// <summary>transformation_function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#transformation_function BedrockagentDataSource#transformation_function}
        /// </remarks>
        [JsiiProperty(name: "transformationFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransformationFunction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#step_to_apply BedrockagentDataSource#step_to_apply}.</summary>
            [JsiiProperty(name: "stepToApply", typeJson: "{\"primitive\":\"string\"}")]
            public string StepToApply
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>transformation_function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#transformation_function BedrockagentDataSource#transformation_function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformationFunction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformationTransformationFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransformationFunction
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
