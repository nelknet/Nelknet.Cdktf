using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationSharePointConfigurationCrawlerConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationSharePointConfigurationCrawlerConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationSharePointConfigurationCrawlerConfiguration
    {
        private object? _filterConfiguration;

        /// <summary>filter_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#filter_configuration BedrockagentDataSource#filter_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FilterConfiguration
        {
            get => _filterConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationSharePointConfigurationCrawlerConfigurationFilterConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filterConfiguration = value;
            }
        }
    }
}
