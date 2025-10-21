namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerSiteState<'GlobalNetworkId> = { assignments: ResizeArray<aws.NetworkmanagerSite.NetworkmanagerSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site">aws_networkmanager_site</a>.
    /// </summary>
    type NetworkmanagerSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerSiteState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerSiteState<Missing>)

        member _.Zero(()) : NetworkmanagerSiteState<Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerSiteState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#global_network_id-1">NetworkmanagerSite#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: NetworkmanagerSiteState<Missing>, value: string) : NetworkmanagerSiteState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerSiteState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#description-1">NetworkmanagerSite#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkmanagerSiteState<'GlobalNetworkId>, value: string) : NetworkmanagerSiteState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkmanagerSiteState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#id-1">NetworkmanagerSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerSiteState<'GlobalNetworkId>, value: string) : NetworkmanagerSiteState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerSiteState<'GlobalNetworkId>

        /// <summary>
        /// location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#location-1">NetworkmanagerSite#location</a>
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkmanagerSiteState<'GlobalNetworkId>, value: aws.NetworkmanagerSite.NetworkmanagerSiteLocation) : NetworkmanagerSiteState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : NetworkmanagerSiteState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#tags-1">NetworkmanagerSite#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkmanagerSiteState<'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerSiteState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkmanagerSiteState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#tags_all-1">NetworkmanagerSite#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkmanagerSiteState<'GlobalNetworkId>, value: seq<string * string>) : NetworkmanagerSiteState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkmanagerSiteState<'GlobalNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_site#timeouts-1">NetworkmanagerSite#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerSiteState<'GlobalNetworkId>, value: aws.NetworkmanagerSite.NetworkmanagerSiteTimeouts) : NetworkmanagerSiteState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerSiteState<'GlobalNetworkId>

        member _.Run(state: NetworkmanagerSiteState<Present>) : aws.NetworkmanagerSite.NetworkmanagerSite =
            let config = aws.NetworkmanagerSite.NetworkmanagerSiteConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerSite.NetworkmanagerSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerSite: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerSiteState<_>) : aws.NetworkmanagerSite.NetworkmanagerSite =
            Unchecked.defaultof<aws.NetworkmanagerSite.NetworkmanagerSite>
