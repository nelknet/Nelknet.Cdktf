using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayPeeringAttachment
{
    [JsiiInterface(nativeType: typeof(IEc2TransitGatewayPeeringAttachmentOptions), fullyQualifiedName: "aws.ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachmentOptions")]
    public interface IEc2TransitGatewayPeeringAttachmentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#dynamic_routing Ec2TransitGatewayPeeringAttachment#dynamic_routing}.</summary>
        [JsiiProperty(name: "dynamicRouting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DynamicRouting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2TransitGatewayPeeringAttachmentOptions), fullyQualifiedName: "aws.ec2TransitGatewayPeeringAttachment.Ec2TransitGatewayPeeringAttachmentOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2TransitGatewayPeeringAttachment.IEc2TransitGatewayPeeringAttachmentOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_peering_attachment#dynamic_routing Ec2TransitGatewayPeeringAttachment#dynamic_routing}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicRouting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DynamicRouting
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
