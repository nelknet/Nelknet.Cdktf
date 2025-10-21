using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow")]
    public class QuicksightDataSourceParametersServiceNow : aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#site_base_url QuicksightDataSource#site_base_url}.</summary>
        [JsiiProperty(name: "siteBaseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string SiteBaseUrl
        {
            get;
            set;
        }
    }
}
