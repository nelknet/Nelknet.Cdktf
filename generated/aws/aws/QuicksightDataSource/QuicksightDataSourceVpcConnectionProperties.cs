using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceVpcConnectionProperties")]
    public class QuicksightDataSourceVpcConnectionProperties : aws.QuicksightDataSource.IQuicksightDataSourceVpcConnectionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#vpc_connection_arn QuicksightDataSource#vpc_connection_arn}.</summary>
        [JsiiProperty(name: "vpcConnectionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcConnectionArn
        {
            get;
            set;
        }
    }
}
