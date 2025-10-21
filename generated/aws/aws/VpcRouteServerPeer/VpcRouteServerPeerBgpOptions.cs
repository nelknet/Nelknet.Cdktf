using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcRouteServerPeer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpcRouteServerPeer.VpcRouteServerPeerBgpOptions")]
    public class VpcRouteServerPeerBgpOptions : aws.VpcRouteServerPeer.IVpcRouteServerPeerBgpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_asn VpcRouteServerPeer#peer_asn}.</summary>
        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public double PeerAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_liveness_detection VpcRouteServerPeer#peer_liveness_detection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerLivenessDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerLivenessDetection
        {
            get;
            set;
        }
    }
}
