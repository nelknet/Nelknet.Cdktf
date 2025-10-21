using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfiguration")]
    public class KendraDataSourceConfiguration : aws.KendraDataSource.IKendraDataSourceConfiguration
    {
        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#s3_configuration KendraDataSource#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3Configuration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration? S3Configuration
        {
            get;
            set;
        }

        /// <summary>template_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#template_configuration KendraDataSource#template_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration? TemplateConfiguration
        {
            get;
            set;
        }

        /// <summary>web_crawler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#web_crawler_configuration KendraDataSource#web_crawler_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration? WebCrawlerConfiguration
        {
            get;
            set;
        }
    }
}
