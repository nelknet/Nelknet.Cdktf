using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration")]
    public class KendraDataSourceConfigurationWebCrawlerConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration
    {
        /// <summary>urls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#urls KendraDataSource#urls}
        /// </remarks>
        [JsiiProperty(name: "urls", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrls\"}")]
        public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls Urls
        {
            get;
            set;
        }

        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#authentication_configuration KendraDataSource#authentication_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#crawl_depth KendraDataSource#crawl_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crawlDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CrawlDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_content_size_per_page_in_mega_bytes KendraDataSource#max_content_size_per_page_in_mega_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxContentSizePerPageInMegaBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxContentSizePerPageInMegaBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_links_per_page KendraDataSource#max_links_per_page}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxLinksPerPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxLinksPerPage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_urls_per_minute_crawl_rate KendraDataSource#max_urls_per_minute_crawl_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUrlsPerMinuteCrawlRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUrlsPerMinuteCrawlRate
        {
            get;
            set;
        }

        /// <summary>proxy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#proxy_configuration KendraDataSource#proxy_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#url_exclusion_patterns KendraDataSource#url_exclusion_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "urlExclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UrlExclusionPatterns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#url_inclusion_patterns KendraDataSource#url_inclusion_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "urlInclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UrlInclusionPatterns
        {
            get;
            set;
        }
    }
}
