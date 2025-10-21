using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration")]
    public interface IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#seed_urls KendraDataSource#seed_urls}.</summary>
        [JsiiProperty(name: "seedUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SeedUrls
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#web_crawler_mode KendraDataSource#web_crawler_mode}.</summary>
        [JsiiProperty(name: "webCrawlerMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebCrawlerMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#seed_urls KendraDataSource#seed_urls}.</summary>
            [JsiiProperty(name: "seedUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SeedUrls
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#web_crawler_mode KendraDataSource#web_crawler_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webCrawlerMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebCrawlerMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
