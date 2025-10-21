using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration")]
    public class KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#site_maps KendraDataSource#site_maps}.</summary>
        [JsiiProperty(name: "siteMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SiteMaps
        {
            get;
            set;
        }
    }
}
