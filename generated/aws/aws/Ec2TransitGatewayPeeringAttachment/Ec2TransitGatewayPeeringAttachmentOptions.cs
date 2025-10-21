using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayPeeringAttachment
{
    [JsiiByValue(fqn: "aws.ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachmentOptions")]
    public class Ec2TransitGatewayPeeringAttachmentOptions : aws.Ec2TransitGatewayPeeringAttachment.IEc2TransitGatewayPeeringAttachmentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#dynamic_routing Ec2TransitGatewayPeeringAttachment#dynamic_routing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicRouting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DynamicRouting
        {
            get;
            set;
        }
    }
}
