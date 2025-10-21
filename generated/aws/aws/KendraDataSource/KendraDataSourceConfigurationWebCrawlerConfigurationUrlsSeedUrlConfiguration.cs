using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration")]
    public class KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#seed_urls KendraDataSource#seed_urls}.</summary>
        [JsiiProperty(name: "seedUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SeedUrls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#web_crawler_mode KendraDataSource#web_crawler_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebCrawlerMode
        {
            get;
            set;
        }
    }
}
