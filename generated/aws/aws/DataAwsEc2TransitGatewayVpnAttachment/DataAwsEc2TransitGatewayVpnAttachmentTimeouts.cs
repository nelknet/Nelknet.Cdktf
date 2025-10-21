using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayVpnAttachment
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayVpnAttachment.DataAwsEc2TransitGatewayVpnAttachmentTimeouts")]
    public class DataAwsEc2TransitGatewayVpnAttachmentTimeouts : aws.DataAwsEc2TransitGatewayVpnAttachment.IDataAwsEc2TransitGatewayVpnAttachmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_vpn_attachment#read DataAwsEc2TransitGatewayVpnAttachment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
