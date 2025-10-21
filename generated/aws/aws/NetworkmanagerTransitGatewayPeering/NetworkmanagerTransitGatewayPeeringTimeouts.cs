using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerTransitGatewayPeering
{
    [JsiiByValue(fqn: "aws.networkmanagerTransitGatewayPeering.NetworkmanagerTransitGatewayPeeringTimeouts")]
    public class NetworkmanagerTransitGatewayPeeringTimeouts : aws.NetworkmanagerTransitGatewayPeering.INetworkmanagerTransitGatewayPeeringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#create NetworkmanagerTransitGatewayPeering#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_peering#delete NetworkmanagerTransitGatewayPeering#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
