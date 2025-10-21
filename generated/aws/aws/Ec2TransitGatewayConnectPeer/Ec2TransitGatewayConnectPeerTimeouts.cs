using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2TransitGatewayConnectPeer
{
    [JsiiByValue(fqn: "aws.ec2TransitGatewayConnectPeer.Ec2TransitGatewayConnectPeerTimeouts")]
    public class Ec2TransitGatewayConnectPeerTimeouts : aws.Ec2TransitGatewayConnectPeer.IEc2TransitGatewayConnectPeerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#create Ec2TransitGatewayConnectPeer#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect_peer#delete Ec2TransitGatewayConnectPeer#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
