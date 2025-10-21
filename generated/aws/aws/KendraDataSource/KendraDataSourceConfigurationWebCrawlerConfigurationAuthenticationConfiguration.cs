using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration")]
    public class KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration
    {
        private object? _basicAuthentication;

        /// <summary>basic_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#basic_authentication KendraDataSource#basic_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basicAuthentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BasicAuthentication
        {
            get => _basicAuthentication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfigurationBasicAuthentication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _basicAuthentication = value;
            }
        }
    }
}
