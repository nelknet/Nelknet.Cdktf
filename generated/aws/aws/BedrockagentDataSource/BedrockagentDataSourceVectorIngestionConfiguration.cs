using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfiguration")]
    public class BedrockagentDataSourceVectorIngestionConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfiguration
    {
        private object? _chunkingConfiguration;

        /// <summary>chunking_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#chunking_configuration BedrockagentDataSource#chunking_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chunkingConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationChunkingConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ChunkingConfiguration
        {
            get => _chunkingConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationChunkingConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationChunkingConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _chunkingConfiguration = value;
            }
        }

        private object? _customTransformationConfiguration;

        /// <summary>custom_transformation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#custom_transformation_configuration BedrockagentDataSource#custom_transformation_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customTransformationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomTransformationConfiguration
        {
            get => _customTransformationConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customTransformationConfiguration = value;
            }
        }

        private object? _parsingConfiguration;

        /// <summary>parsing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#parsing_configuration BedrockagentDataSource#parsing_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parsingConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationParsingConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParsingConfiguration
        {
            get => _parsingConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationParsingConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationParsingConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parsingConfiguration = value;
            }
        }
    }
}
