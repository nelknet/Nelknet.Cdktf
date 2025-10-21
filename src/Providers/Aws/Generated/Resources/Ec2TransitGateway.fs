namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayState = { assignments: ResizeArray<aws.Ec2TransitGateway.Ec2TransitGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway">aws_ec2_transit_gateway</a>.
    /// </summary>
    type Ec2TransitGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Ec2TransitGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#amazon_side_asn-1">Ec2TransitGateway#amazon_side_asn</a>.
        /// </summary>
        [<CustomOperation "amazon_side_asn">]
        member _.AmazonSideAsn(state: Ec2TransitGatewayState, value: double) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.AmazonSideAsn <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#auto_accept_shared_attachments-1">Ec2TransitGateway#auto_accept_shared_attachments</a>.
        /// </summary>
        [<CustomOperation "auto_accept_shared_attachments">]
        member _.AutoAcceptSharedAttachments(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.AutoAcceptSharedAttachments <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#default_route_table_association-1">Ec2TransitGateway#default_route_table_association</a>.
        /// </summary>
        [<CustomOperation "default_route_table_association">]
        member _.DefaultRouteTableAssociation(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.DefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#default_route_table_propagation-1">Ec2TransitGateway#default_route_table_propagation</a>.
        /// </summary>
        [<CustomOperation "default_route_table_propagation">]
        member _.DefaultRouteTablePropagation(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.DefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#description-1">Ec2TransitGateway#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#dns_support-1">Ec2TransitGateway#dns_support</a>.
        /// </summary>
        [<CustomOperation "dns_support">]
        member _.DnsSupport(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.DnsSupport <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#id-1">Ec2TransitGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#multicast_support-1">Ec2TransitGateway#multicast_support</a>.
        /// </summary>
        [<CustomOperation "multicast_support">]
        member _.MulticastSupport(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.MulticastSupport <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#security_group_referencing_support-1">Ec2TransitGateway#security_group_referencing_support</a>.
        /// </summary>
        [<CustomOperation "security_group_referencing_support">]
        member _.SecurityGroupReferencingSupport(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.SecurityGroupReferencingSupport <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#tags-1">Ec2TransitGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayState, value: seq<string * string>) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#tags_all-1">Ec2TransitGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayState, value: seq<string * string>) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#timeouts-1">Ec2TransitGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayState, value: aws.Ec2TransitGateway.Ec2TransitGatewayTimeouts) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#transit_gateway_cidr_blocks-1">Ec2TransitGateway#transit_gateway_cidr_blocks</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_cidr_blocks">]
        member _.TransitGatewayCidrBlocks(state: Ec2TransitGatewayState, value: seq<string>) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.TransitGatewayCidrBlocks <- (value |> Seq.toArray))
            state : Ec2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway#vpn_ecmp_support-1">Ec2TransitGateway#vpn_ecmp_support</a>.
        /// </summary>
        [<CustomOperation "vpn_ecmp_support">]
        member _.VpnEcmpSupport(state: Ec2TransitGatewayState, value: string) : Ec2TransitGatewayState =
            state.assignments.Add(fun config -> config.VpnEcmpSupport <- value)
            state : Ec2TransitGatewayState

        member _.Run(state: Ec2TransitGatewayState) : aws.Ec2TransitGateway.Ec2TransitGateway =
            let config = aws.Ec2TransitGateway.Ec2TransitGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGateway.Ec2TransitGateway(StackContext.get (), logicalId, config)
