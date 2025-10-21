using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnGatewayRoutePropagation
{
    [JsiiByValue(fqn: "aws.vpnGatewayRoutePropagation.VpnGatewayRoutePropagationTimeouts")]
    public class VpnGatewayRoutePropagationTimeouts : aws.VpnGatewayRoutePropagation.IVpnGatewayRoutePropagationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation#create VpnGatewayRoutePropagation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_gateway_route_propagation#delete VpnGatewayRoutePropagation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
