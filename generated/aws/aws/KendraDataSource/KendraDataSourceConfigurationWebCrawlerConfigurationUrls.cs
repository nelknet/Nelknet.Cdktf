using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrls")]
    public class KendraDataSourceConfigurationWebCrawlerConfigurationUrls : aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrls
    {
        /// <summary>seed_url_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#seed_url_configuration KendraDataSource#seed_url_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "seedUrlConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSeedUrlConfiguration? SeedUrlConfiguration
        {
            get;
            set;
        }

        /// <summary>site_maps_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#site_maps_configuration KendraDataSource#site_maps_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "siteMapsConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration? SiteMapsConfiguration
        {
            get;
            set;
        }
    }
}
