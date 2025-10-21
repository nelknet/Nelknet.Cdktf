using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RouteTable
{
    [JsiiByValue(fqn: "aws.routeTable.RouteTableRoute")]
    public class RouteTableRoute : aws.RouteTable.IRouteTableRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#carrier_gateway_id RouteTable#carrier_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "carrierGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CarrierGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#cidr_block RouteTable#cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#core_network_arn RouteTable#core_network_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreNetworkArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CoreNetworkArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#destination_prefix_list_id RouteTable#destination_prefix_list_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPrefixListId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPrefixListId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#egress_only_gateway_id RouteTable#egress_only_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressOnlyGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EgressOnlyGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#gateway_id RouteTable#gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#ipv6_cidr_block RouteTable#ipv6_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#local_gateway_id RouteTable#local_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#nat_gateway_id RouteTable#nat_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "natGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NatGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#network_interface_id RouteTable#network_interface_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#transit_gateway_id RouteTable#transit_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#vpc_endpoint_id RouteTable#vpc_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route_table#vpc_peering_connection_id RouteTable#vpc_peering_connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcPeeringConnectionId
        {
            get;
            set;
        }
    }
}
