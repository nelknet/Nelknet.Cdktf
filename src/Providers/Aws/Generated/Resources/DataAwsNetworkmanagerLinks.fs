namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerLinksState<'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerLinks.DataAwsNetworkmanagerLinksConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links">aws_networkmanager_links</a>.
    /// </summary>
    type DataAwsNetworkmanagerLinksBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerLinksState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerLinksState<Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerLinksState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerLinksState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links#global_network_id-1">DataAwsNetworkmanagerLinks#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerLinksState<Missing>, value: string) : DataAwsNetworkmanagerLinksState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerLinksState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links#id-1">DataAwsNetworkmanagerLinks#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerLinksState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerLinksState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerLinksState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links#provider_name-1">DataAwsNetworkmanagerLinks#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: DataAwsNetworkmanagerLinksState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerLinksState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            state : DataAwsNetworkmanagerLinksState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links#site_id-1">DataAwsNetworkmanagerLinks#site_id</a>.
        /// </summary>
        [<CustomOperation "site_id">]
        member _.SiteId(state: DataAwsNetworkmanagerLinksState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerLinksState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.SiteId <- value)
            state : DataAwsNetworkmanagerLinksState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links#tags-1">DataAwsNetworkmanagerLinks#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerLinksState<'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerLinksState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerLinksState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_links#type-1">DataAwsNetworkmanagerLinks#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsNetworkmanagerLinksState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerLinksState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataAwsNetworkmanagerLinksState<'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerLinksState<Present>) : aws.DataAwsNetworkmanagerLinks.DataAwsNetworkmanagerLinks =
            let config = aws.DataAwsNetworkmanagerLinks.DataAwsNetworkmanagerLinksConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerLinks.DataAwsNetworkmanagerLinks(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerLinks: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerLinksState<_>) : aws.DataAwsNetworkmanagerLinks.DataAwsNetworkmanagerLinks =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerLinks.DataAwsNetworkmanagerLinks>
