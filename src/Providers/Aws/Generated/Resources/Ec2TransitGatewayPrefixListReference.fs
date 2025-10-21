namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.Ec2TransitGatewayPrefixListReference.Ec2TransitGatewayPrefixListReferenceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference">aws_ec2_transit_gateway_prefix_list_reference</a>.
    /// </summary>
    type Ec2TransitGatewayPrefixListReferenceBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayPrefixListReferenceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPrefixListReferenceState<Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayPrefixListReferenceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPrefixListReferenceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference#prefix_list_id-1">Ec2TransitGatewayPrefixListReference#prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "prefix_list_id">]
        member _.PrefixListId(state: Ec2TransitGatewayPrefixListReferenceState<Missing, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayPrefixListReferenceState<Present, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.PrefixListId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPrefixListReferenceState<Present, 'TransitGatewayRouteTableId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference#transit_gateway_route_table_id-1">Ec2TransitGatewayPrefixListReference#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, Missing>, value: string) : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference#blackhole-1">Ec2TransitGatewayPrefixListReference#blackhole</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "blackhole">]
        member _.Blackhole(state: Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>, value: bool) : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Blackhole <- value)
            state : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference#blackhole-1">Ec2TransitGatewayPrefixListReference#blackhole</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "blackhole">]
        member _.Blackhole(state: Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Blackhole <- value)
            state : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference#id-1">Ec2TransitGatewayPrefixListReference#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_prefix_list_reference#transit_gateway_attachment_id-1">Ec2TransitGatewayPrefixListReference#transit_gateway_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_attachment_id">]
        member _.TransitGatewayAttachmentId(state: Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>, value: string) : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.TransitGatewayAttachmentId <- value)
            state : Ec2TransitGatewayPrefixListReferenceState<'PrefixListId, 'TransitGatewayRouteTableId>

        member _.Run(state: Ec2TransitGatewayPrefixListReferenceState<Present, Present>) : aws.Ec2TransitGatewayPrefixListReference.Ec2TransitGatewayPrefixListReference =
            let config = aws.Ec2TransitGatewayPrefixListReference.Ec2TransitGatewayPrefixListReferenceConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayPrefixListReference.Ec2TransitGatewayPrefixListReference(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayPrefixListReference: missing required arguments. Must call: prefix_list_id, transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayPrefixListReferenceState<_, _>) : aws.Ec2TransitGatewayPrefixListReference.Ec2TransitGatewayPrefixListReference =
            Unchecked.defaultof<aws.Ec2TransitGatewayPrefixListReference.Ec2TransitGatewayPrefixListReference>
