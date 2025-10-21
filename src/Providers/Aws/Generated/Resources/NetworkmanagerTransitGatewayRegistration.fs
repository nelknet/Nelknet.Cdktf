namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn> = { assignments: ResizeArray<aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration">aws_networkmanager_transit_gateway_registration</a>.
    /// </summary>
    type NetworkmanagerTransitGatewayRegistrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerTransitGatewayRegistrationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayRegistrationState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerTransitGatewayRegistrationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerTransitGatewayRegistrationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#global_network_id-1">NetworkmanagerTransitGatewayRegistration#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerTransitGatewayRegistrationState<Missing, 'TransitGatewayArn>, value: string) : NetworkmanagerTransitGatewayRegistrationState<Present, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayRegistrationState<Present, 'TransitGatewayArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#transit_gateway_arn-1">NetworkmanagerTransitGatewayRegistration#transit_gateway_arn</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_arn">]
        member _.TransitGatewayArn(state: NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, Missing>, value: string) : NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, Present> =
            state.assignments.Add(fun config -> config.TransitGatewayArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#id-1">NetworkmanagerTransitGatewayRegistration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn>, value: string) : NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_transit_gateway_registration#timeouts-1">NetworkmanagerTransitGatewayRegistration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn>, value: aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistrationTimeouts) : NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerTransitGatewayRegistrationState<'GlobalNetworkId, 'TransitGatewayArn>

        member _.Run(state: NetworkmanagerTransitGatewayRegistrationState<Present, Present>) : aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistration =
            let config = aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistrationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerTransitGatewayRegistration: missing required arguments. Must call: global_network_id, transit_gateway_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerTransitGatewayRegistrationState<_, _>) : aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistration =
            Unchecked.defaultof<aws.NetworkmanagerTransitGatewayRegistration.NetworkmanagerTransitGatewayRegistration>
