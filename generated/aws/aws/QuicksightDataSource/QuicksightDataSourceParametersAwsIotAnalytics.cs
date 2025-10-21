using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics")]
    public class QuicksightDataSourceParametersAwsIotAnalytics : aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#data_set_name QuicksightDataSource#data_set_name}.</summary>
        [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetName
        {
            get;
            set;
        }
    }
}
