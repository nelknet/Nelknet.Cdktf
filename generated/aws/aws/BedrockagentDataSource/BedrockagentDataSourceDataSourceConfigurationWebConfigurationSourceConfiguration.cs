using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfiguration
    {
        private object? _urlConfiguration;

        /// <summary>url_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#url_configuration BedrockagentDataSource#url_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "urlConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UrlConfiguration
        {
            get => _urlConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationWebConfigurationSourceConfigurationUrlConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _urlConfiguration = value;
            }
        }
    }
}
