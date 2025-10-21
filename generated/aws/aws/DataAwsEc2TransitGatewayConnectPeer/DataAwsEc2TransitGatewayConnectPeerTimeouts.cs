using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayConnectPeer
{
    [JsiiByValue(fqn: "aws.dataAwsEc2TransitGatewayConnectPeer.DataAwsEc2TransitGatewayConnectPeerTimeouts")]
    public class DataAwsEc2TransitGatewayConnectPeerTimeouts : aws.DataAwsEc2TransitGatewayConnectPeer.IDataAwsEc2TransitGatewayConnectPeerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect_peer#read DataAwsEc2TransitGatewayConnectPeer#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
