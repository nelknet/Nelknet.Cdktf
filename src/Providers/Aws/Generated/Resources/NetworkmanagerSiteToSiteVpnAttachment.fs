namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn> = { assignments: ResizeArray<aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment">aws_networkmanager_site_to_site_vpn_attachment</a>.
    /// </summary>
    type NetworkmanagerSiteToSiteVpnAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerSiteToSiteVpnAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerSiteToSiteVpnAttachmentState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerSiteToSiteVpnAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerSiteToSiteVpnAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment#core_network_id-1">NetworkmanagerSiteToSiteVpnAttachment#core_network_id</a>.
        /// </summary>
        [<CustomOperation "core_network_id">]
        member _.CoreNetworkId(state: NetworkmanagerSiteToSiteVpnAttachmentState<Missing, 'VpnConnectionArn>, value: string) : NetworkmanagerSiteToSiteVpnAttachmentState<Present, 'VpnConnectionArn> =
            state.assignments.Add(fun config -> config.CoreNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerSiteToSiteVpnAttachmentState<Present, 'VpnConnectionArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment#vpn_connection_arn-1">NetworkmanagerSiteToSiteVpnAttachment#vpn_connection_arn</a>.
        /// </summary>
        [<CustomOperation "vpn_connection_arn">]
        member _.VpnConnectionArn(state: NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, Missing>, value: string) : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, Present> =
            state.assignments.Add(fun config -> config.VpnConnectionArn <- value)
            ({ assignments = state.assignments } : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment#id-1">NetworkmanagerSiteToSiteVpnAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>, value: string) : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment#tags-1">NetworkmanagerSiteToSiteVpnAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>, value: seq<string * string>) : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment#tags_all-1">NetworkmanagerSiteToSiteVpnAttachment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>, value: seq<string * string>) : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site_to_site_vpn_attachment#timeouts-1">NetworkmanagerSiteToSiteVpnAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>, value: aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachmentTimeouts) : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerSiteToSiteVpnAttachmentState<'CoreNetworkId, 'VpnConnectionArn>

        member _.Run(state: NetworkmanagerSiteToSiteVpnAttachmentState<Present, Present>) : aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachment =
            let config = aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerSiteToSiteVpnAttachment: missing required arguments. Must call: core_network_id, vpn_connection_arn.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerSiteToSiteVpnAttachmentState<_, _>) : aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachment =
            Unchecked.defaultof<aws.NetworkmanagerSiteToSiteVpnAttachment.NetworkmanagerSiteToSiteVpnAttachment>
