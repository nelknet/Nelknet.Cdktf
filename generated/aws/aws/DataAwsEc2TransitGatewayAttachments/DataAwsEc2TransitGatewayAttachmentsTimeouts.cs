using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayAttachments
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsTimeouts")]
    public class DataAwsEc2TransitGatewayAttachmentsTimeouts : aws.DataAwsEc2TransitGatewayAttachments.IDataAwsEc2TransitGatewayAttachmentsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#read DataAwsEc2TransitGatewayAttachments#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
