namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId> = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations">aws_ec2_transit_gateway_route_table_associations</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayRouteTableAssociationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayRouteTableAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2TransitGatewayRouteTableAssociationsState<Missing>)

        member _.Zero(()) : DataAwsEc2TransitGatewayRouteTableAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEc2TransitGatewayRouteTableAssociationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#transit_gateway_route_table_id-1">DataAwsEc2TransitGatewayRouteTableAssociations#transit_gateway_route_table_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_route_table_id">]
        member _.TransitGatewayRouteTableId(state: DataAwsEc2TransitGatewayRouteTableAssociationsState<Missing>, value: string) : DataAwsEc2TransitGatewayRouteTableAssociationsState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayRouteTableId <- value)
            ({ assignments = state.assignments } : DataAwsEc2TransitGatewayRouteTableAssociationsState<Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#filter-1">DataAwsEc2TransitGatewayRouteTableAssociations#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#id-1">DataAwsEc2TransitGatewayRouteTableAssociations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId>, value: string) : DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_route_table_associations#timeouts-1">DataAwsEc2TransitGatewayRouteTableAssociations#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId>, value: aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsTimeouts) : DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayRouteTableAssociationsState<'TransitGatewayRouteTableId>

        member _.Run(state: DataAwsEc2TransitGatewayRouteTableAssociationsState<Present>) : aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociations =
            let config = aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEc2TransitGatewayRouteTableAssociations: missing required arguments. Must call: transit_gateway_route_table_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEc2TransitGatewayRouteTableAssociationsState<_>) : aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociations =
            Unchecked.defaultof<aws.DataAwsEc2TransitGatewayRouteTableAssociations.DataAwsEc2TransitGatewayRouteTableAssociations>
