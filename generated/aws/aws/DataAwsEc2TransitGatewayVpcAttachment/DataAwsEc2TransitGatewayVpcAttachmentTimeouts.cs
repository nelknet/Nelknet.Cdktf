using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayVpcAttachment
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayVpcAttachment.DataAwsEc2TransitGatewayVpcAttachmentTimeouts")]
    public class DataAwsEc2TransitGatewayVpcAttachmentTimeouts : aws.DataAwsEc2TransitGatewayVpcAttachment.IDataAwsEc2TransitGatewayVpcAttachmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpc_attachment#read DataAwsEc2TransitGatewayVpcAttachment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
