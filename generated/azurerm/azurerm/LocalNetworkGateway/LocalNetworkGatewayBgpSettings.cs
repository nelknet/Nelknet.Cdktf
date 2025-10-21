using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LocalNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.localNetworkGateway.LocalNetworkGatewayBgpSettings")]
    public class LocalNetworkGatewayBgpSettings : azurerm.LocalNetworkGateway.ILocalNetworkGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#asn LocalNetworkGateway#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public double Asn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#bgp_peering_address LocalNetworkGateway#bgp_peering_address}.</summary>
        [JsiiProperty(name: "bgpPeeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string BgpPeeringAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#peer_weight LocalNetworkGateway#peer_weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeerWeight
        {
            get;
            set;
        }
    }
}
