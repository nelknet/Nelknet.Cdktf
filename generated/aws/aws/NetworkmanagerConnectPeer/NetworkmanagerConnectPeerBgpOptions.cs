using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerConnectPeer
{
    [JsiiByValue(fqn: "aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptions")]
    public class NetworkmanagerConnectPeerBgpOptions : aws.NetworkmanagerConnectPeer.INetworkmanagerConnectPeerBgpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_peer#peer_asn NetworkmanagerConnectPeer#peer_asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeerAsn
        {
            get;
            set;
        }
    }
}
