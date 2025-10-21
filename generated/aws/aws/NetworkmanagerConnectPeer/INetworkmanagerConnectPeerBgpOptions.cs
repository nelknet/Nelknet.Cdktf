using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerConnectPeer
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerConnectPeerBgpOptions), fullyQualifiedName: "aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptions")]
    public interface INetworkmanagerConnectPeerBgpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#peer_asn NetworkmanagerConnectPeer#peer_asn}.</summary>
        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerAsn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerConnectPeerBgpOptions), fullyQualifiedName: "aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptions")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerConnectPeer.INetworkmanagerConnectPeerBgpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#peer_asn NetworkmanagerConnectPeer#peer_asn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerAsn
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
