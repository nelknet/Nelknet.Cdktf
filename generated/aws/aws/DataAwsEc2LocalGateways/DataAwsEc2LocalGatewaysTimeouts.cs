using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2LocalGateways
{
    [JsiiByValue(fqn: "aws.dataAwsEc2LocalGateways.DataAwsEc2LocalGatewaysTimeouts")]
    public class DataAwsEc2LocalGatewaysTimeouts : aws.DataAwsEc2LocalGateways.IDataAwsEc2LocalGatewaysTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateways#read DataAwsEc2LocalGateways#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
