namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId> = { assignments: ResizeArray<aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment">aws_networkmanager_connect_attachment</a>.
    /// </summary>
    type NetworkmanagerConnectAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerConnectAttachmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerConnectAttachmentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerConnectAttachmentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerConnectAttachmentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#core_network_id-1">NetworkmanagerConnectAttachment#core_network_id</a>.
        /// </summary>
        [<CustomOperation "core_network_id">]
        member _.CoreNetworkId(state: NetworkmanagerConnectAttachmentState<Missing, 'EdgeLocation, 'Options, 'TransportAttachmentId>, value: string) : NetworkmanagerConnectAttachmentState<Present, 'EdgeLocation, 'Options, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.CoreNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectAttachmentState<Present, 'EdgeLocation, 'Options, 'TransportAttachmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#edge_location-1">NetworkmanagerConnectAttachment#edge_location</a>.
        /// </summary>
        [<CustomOperation "edge_location">]
        member _.EdgeLocation(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, Missing, 'Options, 'TransportAttachmentId>, value: string) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, Present, 'Options, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.EdgeLocation <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectAttachmentState<'CoreNetworkId, Present, 'Options, 'TransportAttachmentId>)

        /// <summary>
        /// options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#options-1">NetworkmanagerConnectAttachment#options</a>
        /// </summary>
        [<CustomOperation "options">]
        member _.Options(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, Missing, 'TransportAttachmentId>, value: aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptions) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, Present, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Options <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, Present, 'TransportAttachmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#transport_attachment_id-1">NetworkmanagerConnectAttachment#transport_attachment_id</a>.
        /// </summary>
        [<CustomOperation "transport_attachment_id">]
        member _.TransportAttachmentId(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, Missing>, value: string) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, Present> =
            state.assignments.Add(fun config -> config.TransportAttachmentId <- value)
            ({ assignments = state.assignments } : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#id-1">NetworkmanagerConnectAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>, value: string) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#tags-1">NetworkmanagerConnectAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>, value: seq<string * string>) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#tags_all-1">NetworkmanagerConnectAttachment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>, value: seq<string * string>) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#timeouts-1">NetworkmanagerConnectAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>, value: aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentTimeouts) : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerConnectAttachmentState<'CoreNetworkId, 'EdgeLocation, 'Options, 'TransportAttachmentId>

        member _.Run(state: NetworkmanagerConnectAttachmentState<Present, Present, Present, Present>) : aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment =
            let config = aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerConnectAttachment: missing required arguments. Must call: core_network_id, edge_location, options, transport_attachment_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerConnectAttachmentState<_, _, _, _>) : aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment =
            Unchecked.defaultof<aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment>
