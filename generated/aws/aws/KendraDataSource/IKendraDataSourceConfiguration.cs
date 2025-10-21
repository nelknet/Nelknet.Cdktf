using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfiguration")]
    public interface IKendraDataSourceConfiguration
    {
        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#s3_configuration KendraDataSource#s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3Configuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration? S3Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>template_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#template_configuration KendraDataSource#template_configuration}
        /// </remarks>
        [JsiiProperty(name: "templateConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration? TemplateConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_crawler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#web_crawler_configuration KendraDataSource#web_crawler_configuration}
        /// </remarks>
        [JsiiProperty(name: "webCrawlerConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration? WebCrawlerConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#s3_configuration KendraDataSource#s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationS3Configuration\"}", isOptional: true)]
            public aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration? S3Configuration
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationS3Configuration?>();
            }

            /// <summary>template_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#template_configuration KendraDataSource#template_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration\"}", isOptional: true)]
            public aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration? TemplateConfiguration
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration?>();
            }

            /// <summary>web_crawler_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#web_crawler_configuration KendraDataSource#web_crawler_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webCrawlerConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration\"}", isOptional: true)]
            public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration? WebCrawlerConfiguration
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration?>();
            }
        }
    }
}
