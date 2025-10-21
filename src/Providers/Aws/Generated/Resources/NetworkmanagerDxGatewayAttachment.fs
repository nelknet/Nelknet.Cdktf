namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations> = { assignments: ResizeArray<aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_dx_gateway_attachment">aws_networkmanager_dx_gateway_attachment</a>.
    /// </summary>
    type NetworkmanagerDxGatewayAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerDxGatewayAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerDxGatewayAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerDxGatewayAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerDxGatewayAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_dx_gateway_attachment#core_network_id-1">NetworkmanagerDxGatewayAttachment#core_network_id</a>.
        /// </summary>
        [<CustomOperation "core_network_id">]
        member _.CoreNetworkId(state: NetworkmanagerDxGatewayAttachmentState<Missing, 'DirectConnectGatewayArn, 'EdgeLocations>, value: string) : NetworkmanagerDxGatewayAttachmentState<Present, 'DirectConnectGatewayArn, 'EdgeLocations> =
            state.assignments.Add(fun config -> config.CoreNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerDxGatewayAttachmentState<Present, 'DirectConnectGatewayArn, 'EdgeLocations>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_dx_gateway_attachment#direct_connect_gateway_arn-1">NetworkmanagerDxGatewayAttachment#direct_connect_gateway_arn</a>.
        /// </summary>
        [<CustomOperation "direct_connect_gateway_arn">]
        member _.DirectConnectGatewayArn(state: NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, Missing, 'EdgeLocations>, value: string) : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, Present, 'EdgeLocations> =
            state.assignments.Add(fun config -> config.DirectConnectGatewayArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, Present, 'EdgeLocations>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_dx_gateway_attachment#edge_locations-1">NetworkmanagerDxGatewayAttachment#edge_locations</a>.
        /// </summary>
        [<CustomOperation "edge_locations">]
        member _.EdgeLocations(state: NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, Missing>, value: seq<string>) : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, Present> =
            state.assignments.Add(fun config -> config.EdgeLocations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_dx_gateway_attachment#tags-1">NetworkmanagerDxGatewayAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations>, value: seq<string * string>) : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_dx_gateway_attachment#timeouts-1">NetworkmanagerDxGatewayAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations>, value: aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachmentTimeouts) : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerDxGatewayAttachmentState<'CoreNetworkId, 'DirectConnectGatewayArn, 'EdgeLocations>

        member _.Run(state: NetworkmanagerDxGatewayAttachmentState<Present, Present, Present>) : aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachment =
            let config = aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerDxGatewayAttachment: missing required arguments. Must call: core_network_id, direct_connect_gateway_arn, edge_locations.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerDxGatewayAttachmentState<_, _, _>) : aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachment =
            Unchecked.defaultof<aws.NetworkmanagerDxGatewayAttachment.NetworkmanagerDxGatewayAttachment>
