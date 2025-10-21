using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeCustomLogSource
{
    [JsiiByValue(fqn: "aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfiguration")]
    public class SecuritylakeCustomLogSourceConfiguration : aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfiguration
    {
        private object? _crawlerConfiguration;

        /// <summary>crawler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#crawler_configuration SecuritylakeCustomLogSource#crawler_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crawlerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationCrawlerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CrawlerConfiguration
        {
            get => _crawlerConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationCrawlerConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationCrawlerConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _crawlerConfiguration = value;
            }
        }

        private object? _providerIdentity;

        /// <summary>provider_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#provider_identity SecuritylakeCustomLogSource#provider_identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "providerIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationProviderIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProviderIdentity
        {
            get => _providerIdentity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationProviderIdentity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationProviderIdentity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _providerIdentity = value;
            }
        }
    }
}
