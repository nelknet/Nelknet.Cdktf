using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2LocalGateway
{
    [JsiiByValue(fqn: "aws.dataAwsEc2LocalGateway.DataAwsEc2LocalGatewayTimeouts")]
    public class DataAwsEc2LocalGatewayTimeouts : aws.DataAwsEc2LocalGateway.IDataAwsEc2LocalGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway#read DataAwsEc2LocalGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
