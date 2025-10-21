namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerSitesState<'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerSites.DataAwsNetworkmanagerSitesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_sites">aws_networkmanager_sites</a>.
    /// </summary>
    type DataAwsNetworkmanagerSitesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerSitesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerSitesState<Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerSitesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerSitesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_sites#global_network_id-1">DataAwsNetworkmanagerSites#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerSitesState<Missing>, value: string) : DataAwsNetworkmanagerSitesState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerSitesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_sites#id-1">DataAwsNetworkmanagerSites#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerSitesState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerSitesState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerSitesState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_sites#tags-1">DataAwsNetworkmanagerSites#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerSitesState<'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerSitesState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerSitesState<'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerSitesState<Present>) : aws.DataAwsNetworkmanagerSites.DataAwsNetworkmanagerSites =
            let config = aws.DataAwsNetworkmanagerSites.DataAwsNetworkmanagerSitesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerSites.DataAwsNetworkmanagerSites(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerSites: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerSitesState<_>) : aws.DataAwsNetworkmanagerSites.DataAwsNetworkmanagerSites =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerSites.DataAwsNetworkmanagerSites>
