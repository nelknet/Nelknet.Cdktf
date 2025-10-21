using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfiguration")]
    public class KendraDataSourceCustomDocumentEnrichmentConfiguration : aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfiguration
    {
        private object? _inlineConfigurations;

        /// <summary>inline_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#inline_configurations KendraDataSource#inline_configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inlineConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InlineConfigurations
        {
            get => _inlineConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inlineConfigurations = value;
            }
        }

        /// <summary>post_extraction_hook_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#post_extraction_hook_configuration KendraDataSource#post_extraction_hook_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postExtractionHookConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration? PostExtractionHookConfiguration
        {
            get;
            set;
        }

        /// <summary>pre_extraction_hook_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#pre_extraction_hook_configuration KendraDataSource#pre_extraction_hook_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preExtractionHookConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration? PreExtractionHookConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#role_arn KendraDataSource#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }
    }
}
