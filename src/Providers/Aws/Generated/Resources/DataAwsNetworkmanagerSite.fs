namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerSite.DataAwsNetworkmanagerSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_site">aws_networkmanager_site</a>.
    /// </summary>
    type DataAwsNetworkmanagerSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerSiteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerSiteState<Missing, Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerSiteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerSiteState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_site#global_network_id-1">DataAwsNetworkmanagerSite#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerSiteState<Missing, 'SiteId>, value: string) : DataAwsNetworkmanagerSiteState<Present, 'SiteId> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerSiteState<Present, 'SiteId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_site#site_id-1">DataAwsNetworkmanagerSite#site_id</a>.
        /// </summary>
        [<CustomOperation "site_id">]
        member _.SiteId(state: DataAwsNetworkmanagerSiteState<'GlobalNetworkId, Missing>, value: string) : DataAwsNetworkmanagerSiteState<'GlobalNetworkId, Present> =
            state.assignments.Add(fun config -> config.SiteId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerSiteState<'GlobalNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_site#id-1">DataAwsNetworkmanagerSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId>, value: string) : DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_site#tags-1">DataAwsNetworkmanagerSite#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId>, value: seq<string * string>) : DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerSiteState<'GlobalNetworkId, 'SiteId>

        member _.Run(state: DataAwsNetworkmanagerSiteState<Present, Present>) : aws.DataAwsNetworkmanagerSite.DataAwsNetworkmanagerSite =
            let config = aws.DataAwsNetworkmanagerSite.DataAwsNetworkmanagerSiteConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerSite.DataAwsNetworkmanagerSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerSite: missing required arguments. Must call: global_network_id, site_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerSiteState<_, _>) : aws.DataAwsNetworkmanagerSite.DataAwsNetworkmanagerSite =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerSite.DataAwsNetworkmanagerSite>
