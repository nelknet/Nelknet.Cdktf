using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGateway
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGateway.DataAwsEc2TransitGatewayTimeouts")]
    public class DataAwsEc2TransitGatewayTimeouts : aws.DataAwsEc2TransitGateway.IDataAwsEc2TransitGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#read DataAwsEc2TransitGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
