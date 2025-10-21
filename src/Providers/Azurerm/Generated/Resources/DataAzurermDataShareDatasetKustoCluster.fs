namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId> = { assignments: ResizeArray<azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster">azurerm_data_share_dataset_kusto_cluster</a>.
    /// </summary>
    type DataAzurermDataShareDatasetKustoClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataShareDatasetKustoClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetKustoClusterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataShareDatasetKustoClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetKustoClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster#name-1">DataAzurermDataShareDatasetKustoCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataShareDatasetKustoClusterState<Missing, 'ShareId>, value: string) : DataAzurermDataShareDatasetKustoClusterState<Present, 'ShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetKustoClusterState<Present, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster#share_id-1">DataAzurermDataShareDatasetKustoCluster#share_id</a>.
        /// </summary>
        [<CustomOperation "share_id">]
        member _.ShareId(state: DataAzurermDataShareDatasetKustoClusterState<'Name, Missing>, value: string) : DataAzurermDataShareDatasetKustoClusterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ShareId <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetKustoClusterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster#id-1">DataAzurermDataShareDatasetKustoCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId>, value: string) : DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster#timeouts-1">DataAzurermDataShareDatasetKustoCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId>, value: azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoClusterTimeouts) : DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataShareDatasetKustoClusterState<'Name, 'ShareId>

        member _.Run(state: DataAzurermDataShareDatasetKustoClusterState<Present, Present>) : azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoCluster =
            let config = azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataShareDatasetKustoCluster: missing required arguments. Must call: name, share_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataShareDatasetKustoClusterState<_, _>) : azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoCluster =
            Unchecked.defaultof<azurerm.DataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoCluster>
