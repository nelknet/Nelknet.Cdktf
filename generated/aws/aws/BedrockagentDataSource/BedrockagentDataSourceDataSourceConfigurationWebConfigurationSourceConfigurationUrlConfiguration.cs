using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration
    {
        private object? _seedUrls;

        /// <summary>seed_urls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#seed_urls BedrockagentDataSource#seed_urls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "seedUrls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SeedUrls
        {
            get => _seedUrls;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfigurationSeedUrls).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _seedUrls = value;
            }
        }
    }
}
