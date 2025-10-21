using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayPeeringAttachment
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayPeeringAttachment.DataAwsEc2TransitGatewayPeeringAttachmentTimeouts")]
    public class DataAwsEc2TransitGatewayPeeringAttachmentTimeouts : aws.DataAwsEc2TransitGatewayPeeringAttachment.IDataAwsEc2TransitGatewayPeeringAttachmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_peering_attachment#read DataAwsEc2TransitGatewayPeeringAttachment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
