namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnConnectionRouteState<'DestinationCidrBlock, 'VpnConnectionId> = { assignments: ResizeArray<aws.VpnConnectionRoute.VpnConnectionRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection_route">aws_vpn_connection_route</a>.
    /// </summary>
    type VpnConnectionRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnConnectionRouteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnConnectionRouteState<Missing, Missing>)

        member _.Zero(()) : VpnConnectionRouteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnConnectionRouteState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection_route#destination_cidr_block-1">VpnConnectionRoute#destination_cidr_block</a>.
        /// </summary>
        [<CustomOperation "destination_cidr_block">]
        member _.DestinationCidrBlock(state: VpnConnectionRouteState<Missing, 'VpnConnectionId>, value: string) : VpnConnectionRouteState<Present, 'VpnConnectionId> =
            state.assignments.Add(fun config -> config.DestinationCidrBlock <- value)
            ({ assignments = state.assignments } : VpnConnectionRouteState<Present, 'VpnConnectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection_route#vpn_connection_id-1">VpnConnectionRoute#vpn_connection_id</a>.
        /// </summary>
        [<CustomOperation "vpn_connection_id">]
        member _.VpnConnectionId(state: VpnConnectionRouteState<'DestinationCidrBlock, Missing>, value: string) : VpnConnectionRouteState<'DestinationCidrBlock, Present> =
            state.assignments.Add(fun config -> config.VpnConnectionId <- value)
            ({ assignments = state.assignments } : VpnConnectionRouteState<'DestinationCidrBlock, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpn_connection_route#id-1">VpnConnectionRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnConnectionRouteState<'DestinationCidrBlock, 'VpnConnectionId>, value: string) : VpnConnectionRouteState<'DestinationCidrBlock, 'VpnConnectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnConnectionRouteState<'DestinationCidrBlock, 'VpnConnectionId>

        member _.Run(state: VpnConnectionRouteState<Present, Present>) : aws.VpnConnectionRoute.VpnConnectionRoute =
            let config = aws.VpnConnectionRoute.VpnConnectionRouteConfig()
            for setter in state.assignments do
                setter config
            aws.VpnConnectionRoute.VpnConnectionRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpnConnectionRoute: missing required arguments. Must call: destination_cidr_block, vpn_connection_id.", 9999, IsError = true)>]
        member _.Run(_: VpnConnectionRouteState<_, _>) : aws.VpnConnectionRoute.VpnConnectionRoute =
            Unchecked.defaultof<aws.VpnConnectionRoute.VpnConnectionRoute>
