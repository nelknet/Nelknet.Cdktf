using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration")]
    public class KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#host KendraDataSource#host}.</summary>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public string Host
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#port KendraDataSource#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#credentials KendraDataSource#credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Credentials
        {
            get;
            set;
        }
    }
}
