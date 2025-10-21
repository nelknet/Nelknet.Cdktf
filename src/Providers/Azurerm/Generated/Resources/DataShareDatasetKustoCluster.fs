namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId> = { assignments: ResizeArray<azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_cluster">azurerm_data_share_dataset_kusto_cluster</a>.
    /// </summary>
    type DataShareDatasetKustoClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataShareDatasetKustoClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetKustoClusterState<Missing, Missing, Missing>)

        member _.Zero(()) : DataShareDatasetKustoClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetKustoClusterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_cluster#kusto_cluster_id-1">DataShareDatasetKustoCluster#kusto_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kusto_cluster_id">]
        member _.KustoClusterId(state: DataShareDatasetKustoClusterState<Missing, 'Name, 'ShareId>, value: string) : DataShareDatasetKustoClusterState<Present, 'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.KustoClusterId <- value)
            ({ assignments = state.assignments } : DataShareDatasetKustoClusterState<Present, 'Name, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_cluster#name-1">DataShareDatasetKustoCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataShareDatasetKustoClusterState<'KustoClusterId, Missing, 'ShareId>, value: string) : DataShareDatasetKustoClusterState<'KustoClusterId, Present, 'ShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataShareDatasetKustoClusterState<'KustoClusterId, Present, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_cluster#share_id-1">DataShareDatasetKustoCluster#share_id</a>.
        /// </summary>
        [<CustomOperation "share_id">]
        member _.ShareId(state: DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, Missing>, value: string) : DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ShareId <- value)
            ({ assignments = state.assignments } : DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_cluster#id-1">DataShareDatasetKustoCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId>, value: string) : DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_cluster#timeouts-1">DataShareDatasetKustoCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId>, value: azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoClusterTimeouts) : DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataShareDatasetKustoClusterState<'KustoClusterId, 'Name, 'ShareId>

        member _.Run(state: DataShareDatasetKustoClusterState<Present, Present, Present>) : azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoCluster =
            let config = azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataShareDatasetKustoCluster: missing required arguments. Must call: kusto_cluster_id, name, share_id.", 9999, IsError = true)>]
        member _.Run(_: DataShareDatasetKustoClusterState<_, _, _>) : azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoCluster =
            Unchecked.defaultof<azurerm.DataShareDatasetKustoCluster.DataShareDatasetKustoCluster>
