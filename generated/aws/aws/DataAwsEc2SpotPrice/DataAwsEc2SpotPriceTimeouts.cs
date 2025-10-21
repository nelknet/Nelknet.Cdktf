using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2SpotPrice
{
    [JsiiByValue(fqn: "aws.dataAwsEc2SpotPrice.DataAwsEc2SpotPriceTimeouts")]
    public class DataAwsEc2SpotPriceTimeouts : aws.DataAwsEc2SpotPrice.IDataAwsEc2SpotPriceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#read DataAwsEc2SpotPrice#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
