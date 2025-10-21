using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration")]
    public class BedrockagentDataSourceVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationChunkingConfigurationSemanticChunkingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#breakpoint_percentile_threshold BedrockagentDataSource#breakpoint_percentile_threshold}.</summary>
        [JsiiProperty(name: "breakpointPercentileThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public double BreakpointPercentileThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#buffer_size BedrockagentDataSource#buffer_size}.</summary>
        [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}")]
        public double BufferSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#max_token BedrockagentDataSource#max_token}.</summary>
        [JsiiProperty(name: "maxToken", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxToken
        {
            get;
            set;
        }
    }
}
