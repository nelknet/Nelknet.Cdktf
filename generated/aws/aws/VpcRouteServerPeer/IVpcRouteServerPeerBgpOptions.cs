using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcRouteServerPeer
{
    [JsiiInterface(nativeType: typeof(IVpcRouteServerPeerBgpOptions), fullyQualifiedName: "aws.vpcRouteServerPeer.VpcRouteServerPeerBgpOptions")]
    public interface IVpcRouteServerPeerBgpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_asn VpcRouteServerPeer#peer_asn}.</summary>
        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
        double PeerAsn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_liveness_detection VpcRouteServerPeer#peer_liveness_detection}.</summary>
        [JsiiProperty(name: "peerLivenessDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerLivenessDetection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcRouteServerPeerBgpOptions), fullyQualifiedName: "aws.vpcRouteServerPeer.VpcRouteServerPeerBgpOptions")]
        internal sealed class _Proxy : DeputyBase, aws.VpcRouteServerPeer.IVpcRouteServerPeerBgpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_asn VpcRouteServerPeer#peer_asn}.</summary>
            [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
            public double PeerAsn
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server_peer#peer_liveness_detection VpcRouteServerPeer#peer_liveness_detection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerLivenessDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerLivenessDetection
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
