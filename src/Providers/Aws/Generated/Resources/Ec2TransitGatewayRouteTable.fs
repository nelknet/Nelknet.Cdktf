namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayRouteTableState<'TransitGatewayId> = { assignments: ResizeArray<aws.Ec2TransitGatewayRouteTable.Ec2TransitGatewayRouteTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table">aws_ec2_transit_gateway_route_table</a>.
    /// </summary>
    type Ec2TransitGatewayRouteTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayRouteTableState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteTableState<Missing>)

        member _.Zero(()) : Ec2TransitGatewayRouteTableState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayRouteTableState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table#transit_gateway_id-1">Ec2TransitGatewayRouteTable#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayRouteTableState<Missing>, value: string) : Ec2TransitGatewayRouteTableState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayRouteTableState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table#id-1">Ec2TransitGatewayRouteTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayRouteTableState<'TransitGatewayId>, value: string) : Ec2TransitGatewayRouteTableState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayRouteTableState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table#tags-1">Ec2TransitGatewayRouteTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayRouteTableState<'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayRouteTableState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayRouteTableState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_route_table#tags_all-1">Ec2TransitGatewayRouteTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayRouteTableState<'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayRouteTableState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayRouteTableState<'TransitGatewayId>

        member _.Run(state: Ec2TransitGatewayRouteTableState<Present>) : aws.Ec2TransitGatewayRouteTable.Ec2TransitGatewayRouteTable =
            let config = aws.Ec2TransitGatewayRouteTable.Ec2TransitGatewayRouteTableConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayRouteTable.Ec2TransitGatewayRouteTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayRouteTable: missing required arguments. Must call: transit_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayRouteTableState<_>) : aws.Ec2TransitGatewayRouteTable.Ec2TransitGatewayRouteTable =
            Unchecked.defaultof<aws.Ec2TransitGatewayRouteTable.Ec2TransitGatewayRouteTable>
