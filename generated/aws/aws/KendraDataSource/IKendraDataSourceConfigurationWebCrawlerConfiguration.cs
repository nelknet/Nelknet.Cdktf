using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration")]
    public interface IKendraDataSourceConfigurationWebCrawlerConfiguration
    {
        /// <summary>urls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#urls KendraDataSource#urls}
        /// </remarks>
        [JsiiProperty(name: "urls", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrls\"}")]
        aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls Urls
        {
            get;
        }

        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#authentication_configuration KendraDataSource#authentication_configuration}
        /// </remarks>
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#crawl_depth KendraDataSource#crawl_depth}.</summary>
        [JsiiProperty(name: "crawlDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CrawlDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_content_size_per_page_in_mega_bytes KendraDataSource#max_content_size_per_page_in_mega_bytes}.</summary>
        [JsiiProperty(name: "maxContentSizePerPageInMegaBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxContentSizePerPageInMegaBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_links_per_page KendraDataSource#max_links_per_page}.</summary>
        [JsiiProperty(name: "maxLinksPerPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxLinksPerPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_urls_per_minute_crawl_rate KendraDataSource#max_urls_per_minute_crawl_rate}.</summary>
        [JsiiProperty(name: "maxUrlsPerMinuteCrawlRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUrlsPerMinuteCrawlRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>proxy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#proxy_configuration KendraDataSource#proxy_configuration}
        /// </remarks>
        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#url_exclusion_patterns KendraDataSource#url_exclusion_patterns}.</summary>
        [JsiiProperty(name: "urlExclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UrlExclusionPatterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#url_inclusion_patterns KendraDataSource#url_inclusion_patterns}.</summary>
        [JsiiProperty(name: "urlInclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UrlInclusionPatterns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>urls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#urls KendraDataSource#urls}
            /// </remarks>
            [JsiiProperty(name: "urls", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrls\"}")]
            public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls Urls
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls>()!;
            }

            /// <summary>authentication_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#authentication_configuration KendraDataSource#authentication_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration\"}", isOptional: true)]
            public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration? AuthenticationConfiguration
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationAuthenticationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#crawl_depth KendraDataSource#crawl_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crawlDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CrawlDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_content_size_per_page_in_mega_bytes KendraDataSource#max_content_size_per_page_in_mega_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxContentSizePerPageInMegaBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxContentSizePerPageInMegaBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_links_per_page KendraDataSource#max_links_per_page}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxLinksPerPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxLinksPerPage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#max_urls_per_minute_crawl_rate KendraDataSource#max_urls_per_minute_crawl_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUrlsPerMinuteCrawlRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUrlsPerMinuteCrawlRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>proxy_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#proxy_configuration KendraDataSource#proxy_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration\"}", isOptional: true)]
            public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration? ProxyConfiguration
            {
                get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#url_exclusion_patterns KendraDataSource#url_exclusion_patterns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "urlExclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UrlExclusionPatterns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#url_inclusion_patterns KendraDataSource#url_inclusion_patterns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "urlInclusionPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UrlInclusionPatterns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
