namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> = { assignments: ResizeArray<aws.NetworkmanagerLink.NetworkmanagerLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link">aws_networkmanager_link</a>.
    /// </summary>
    type NetworkmanagerLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerLinkState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkmanagerLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerLinkState<Missing, Missing, Missing>)

        /// <summary>
        /// bandwidth block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#bandwidth-1">NetworkmanagerLink#bandwidth</a>
        /// </summary>
        [<CustomOperation "bandwidth">]
        member _.Bandwidth(state: NetworkmanagerLinkState<Missing, 'GlobalNetworkId, 'SiteId>, value: aws.NetworkmanagerLink.NetworkmanagerLinkBandwidth) : NetworkmanagerLinkState<Present, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Bandwidth <- value)
            ({ assignments = state.assignments } : NetworkmanagerLinkState<Present, 'GlobalNetworkId, 'SiteId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#global_network_id-1">NetworkmanagerLink#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerLinkState<'Bandwidth, Missing, 'SiteId>, value: string) : NetworkmanagerLinkState<'Bandwidth, Present, 'SiteId> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerLinkState<'Bandwidth, Present, 'SiteId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#site_id-1">NetworkmanagerLink#site_id</a>.
        /// </summary>
        [<CustomOperation "site_id">]
        member _.SiteId(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, Missing>, value: string) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, Present> =
            state.assignments.Add(fun config -> config.SiteId <- value)
            ({ assignments = state.assignments } : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#description-1">NetworkmanagerLink#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: string) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#id-1">NetworkmanagerLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: string) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#provider_name-1">NetworkmanagerLink#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: string) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#tags-1">NetworkmanagerLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: seq<string * string>) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#tags_all-1">NetworkmanagerLink#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: seq<string * string>) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#timeouts-1">NetworkmanagerLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: aws.NetworkmanagerLink.NetworkmanagerLinkTimeouts) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_link#type-1">NetworkmanagerLink#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>, value: string) : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : NetworkmanagerLinkState<'Bandwidth, 'GlobalNetworkId, 'SiteId>

        member _.Run(state: NetworkmanagerLinkState<Present, Present, Present>) : aws.NetworkmanagerLink.NetworkmanagerLink =
            let config = aws.NetworkmanagerLink.NetworkmanagerLinkConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerLink.NetworkmanagerLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerLink: missing required arguments. Must call: bandwidth, global_network_id, site_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerLinkState<_, _, _>) : aws.NetworkmanagerLink.NetworkmanagerLink =
            Unchecked.defaultof<aws.NetworkmanagerLink.NetworkmanagerLink>
