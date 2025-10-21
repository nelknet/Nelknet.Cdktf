using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2CoipPools
{
    [JsiiByValue(fqn: "aws.dataAwsEc2CoipPools.DataAwsEc2CoipPoolsTimeouts")]
    public class DataAwsEc2CoipPoolsTimeouts : aws.DataAwsEc2CoipPools.IDataAwsEc2CoipPoolsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pools#read DataAwsEc2CoipPools#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
