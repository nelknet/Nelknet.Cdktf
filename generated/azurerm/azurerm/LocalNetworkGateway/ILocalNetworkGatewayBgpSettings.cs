using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LocalNetworkGateway
{
    [JsiiInterface(nativeType: typeof(ILocalNetworkGatewayBgpSettings), fullyQualifiedName: "azurerm.localNetworkGateway.LocalNetworkGatewayBgpSettings")]
    public interface ILocalNetworkGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#asn LocalNetworkGateway#asn}.</summary>
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        double Asn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#bgp_peering_address LocalNetworkGateway#bgp_peering_address}.</summary>
        [JsiiProperty(name: "bgpPeeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        string BgpPeeringAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#peer_weight LocalNetworkGateway#peer_weight}.</summary>
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerWeight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILocalNetworkGatewayBgpSettings), fullyQualifiedName: "azurerm.localNetworkGateway.LocalNetworkGatewayBgpSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.LocalNetworkGateway.ILocalNetworkGatewayBgpSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#asn LocalNetworkGateway#asn}.</summary>
            [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
            public double Asn
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#bgp_peering_address LocalNetworkGateway#bgp_peering_address}.</summary>
            [JsiiProperty(name: "bgpPeeringAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string BgpPeeringAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#peer_weight LocalNetworkGateway#peer_weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerWeight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
