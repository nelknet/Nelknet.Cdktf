namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerLink.DataAwsNetworkmanagerLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_link">aws_networkmanager_link</a>.
    /// </summary>
    type DataAwsNetworkmanagerLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerLinkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerLinkState<Missing, Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerLinkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerLinkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_link#global_network_id-1">DataAwsNetworkmanagerLink#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerLinkState<Missing, 'LinkId>, value: string) : DataAwsNetworkmanagerLinkState<Present, 'LinkId> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerLinkState<Present, 'LinkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_link#link_id-1">DataAwsNetworkmanagerLink#link_id</a>.
        /// </summary>
        [<CustomOperation "link_id">]
        member _.LinkId(state: DataAwsNetworkmanagerLinkState<'GlobalNetworkId, Missing>, value: string) : DataAwsNetworkmanagerLinkState<'GlobalNetworkId, Present> =
            state.assignments.Add(fun config -> config.LinkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerLinkState<'GlobalNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_link#id-1">DataAwsNetworkmanagerLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId>, value: string) : DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_link#tags-1">DataAwsNetworkmanagerLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId>, value: seq<string * string>) : DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerLinkState<'GlobalNetworkId, 'LinkId>

        member _.Run(state: DataAwsNetworkmanagerLinkState<Present, Present>) : aws.DataAwsNetworkmanagerLink.DataAwsNetworkmanagerLink =
            let config = aws.DataAwsNetworkmanagerLink.DataAwsNetworkmanagerLinkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerLink.DataAwsNetworkmanagerLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerLink: missing required arguments. Must call: global_network_id, link_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerLinkState<_, _>) : aws.DataAwsNetworkmanagerLink.DataAwsNetworkmanagerLink =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerLink.DataAwsNetworkmanagerLink>
