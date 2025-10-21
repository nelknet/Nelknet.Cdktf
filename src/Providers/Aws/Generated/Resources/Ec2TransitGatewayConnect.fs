namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> = { assignments: ResizeArray<aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect">aws_ec2_transit_gateway_connect</a>.
    /// </summary>
    type Ec2TransitGatewayConnectBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayConnectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayConnectState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayConnectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayConnectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#transit_gateway_id-1">Ec2TransitGatewayConnect#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayConnectState<Missing, 'TransportAttachmentId>, value: string) : Ec2TransitGatewayConnectState<Present, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayConnectState<Present, 'TransportAttachmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#transport_attachment_id-1">Ec2TransitGatewayConnect#transport_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transport_attachment_id">]
        member _.TransportAttachmentId(state: Ec2TransitGatewayConnectState<'TransitGatewayId, Missing>, value: string) : Ec2TransitGatewayConnectState<'TransitGatewayId, Present> =
            state.assignments.Add(fun config -> config.TransportAttachmentId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayConnectState<'TransitGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#id-1">Ec2TransitGatewayConnect#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: string) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#protocol-1">Ec2TransitGatewayConnect#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: string) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#tags-1">Ec2TransitGatewayConnect#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#tags_all-1">Ec2TransitGatewayConnect#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: seq<string * string>) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#timeouts-1">Ec2TransitGatewayConnect#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnectTimeouts) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#transit_gateway_default_route_table_association-1">Ec2TransitGatewayConnect#transit_gateway_default_route_table_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_association">]
        member _.TransitGatewayDefaultRouteTableAssociation(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: bool) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#transit_gateway_default_route_table_association-1">Ec2TransitGatewayConnect#transit_gateway_default_route_table_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_association">]
        member _.TransitGatewayDefaultRouteTableAssociation(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#transit_gateway_default_route_table_propagation-1">Ec2TransitGatewayConnect#transit_gateway_default_route_table_propagation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_propagation">]
        member _.TransitGatewayDefaultRouteTablePropagation(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: bool) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_connect#transit_gateway_default_route_table_propagation-1">Ec2TransitGatewayConnect#transit_gateway_default_route_table_propagation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_propagation">]
        member _.TransitGatewayDefaultRouteTablePropagation(state: Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayConnectState<'TransitGatewayId, 'TransportAttachmentId>

        member _.Run(state: Ec2TransitGatewayConnectState<Present, Present>) : aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnect =
            let config = aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnectConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnect(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayConnect: missing required arguments. Must call: transit_gateway_id, transport_attachment_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayConnectState<_, _>) : aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnect =
            Unchecked.defaultof<aws.Ec2TransitGatewayConnect.Ec2TransitGatewayConnect>
