using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteCircuitPeering
{
    [JsiiByValue(fqn: "azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringIpv6MicrosoftPeering")]
    public class ExpressRouteCircuitPeeringIpv6MicrosoftPeering : azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringIpv6MicrosoftPeering
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#advertised_communities ExpressRouteCircuitPeering#advertised_communities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advertisedCommunities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdvertisedCommunities
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#advertised_public_prefixes ExpressRouteCircuitPeering#advertised_public_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advertisedPublicPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdvertisedPublicPrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#customer_asn ExpressRouteCircuitPeering#customer_asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CustomerAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#routing_registry_name ExpressRouteCircuitPeering#routing_registry_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingRegistryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingRegistryName
        {
            get;
            set;
        }
    }
}
