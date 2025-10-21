namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId> = { assignments: ResizeArray<azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_database">azurerm_data_share_dataset_kusto_database</a>.
    /// </summary>
    type DataAzurermDataShareDatasetKustoDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataShareDatasetKustoDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetKustoDatabaseState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataShareDatasetKustoDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetKustoDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_database#name-1">DataAzurermDataShareDatasetKustoDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataShareDatasetKustoDatabaseState<Missing, 'ShareId>, value: string) : DataAzurermDataShareDatasetKustoDatabaseState<Present, 'ShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetKustoDatabaseState<Present, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_database#share_id-1">DataAzurermDataShareDatasetKustoDatabase#share_id</a>.
        /// </summary>
        [<CustomOperation "share_id">]
        member _.ShareId(state: DataAzurermDataShareDatasetKustoDatabaseState<'Name, Missing>, value: string) : DataAzurermDataShareDatasetKustoDatabaseState<'Name, Present> =
            state.assignments.Add(fun config -> config.ShareId <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetKustoDatabaseState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_database#id-1">DataAzurermDataShareDatasetKustoDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId>, value: string) : DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_database#timeouts-1">DataAzurermDataShareDatasetKustoDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId>, value: azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabaseTimeouts) : DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataShareDatasetKustoDatabaseState<'Name, 'ShareId>

        member _.Run(state: DataAzurermDataShareDatasetKustoDatabaseState<Present, Present>) : azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabase =
            let config = azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataShareDatasetKustoDatabase: missing required arguments. Must call: name, share_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataShareDatasetKustoDatabaseState<_, _>) : azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabase =
            Unchecked.defaultof<azurerm.DataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabase>
