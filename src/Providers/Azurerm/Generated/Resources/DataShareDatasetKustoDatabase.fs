namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId> = { assignments: ResizeArray<azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_database">azurerm_data_share_dataset_kusto_database</a>.
    /// </summary>
    type DataShareDatasetKustoDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataShareDatasetKustoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetKustoDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : DataShareDatasetKustoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareDatasetKustoDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_database#kusto_database_id-1">DataShareDatasetKustoDatabase#kusto_database_id</a>.
        /// </summary>
        [<CustomOperation "kusto_database_id">]
        member _.KustoDatabaseId(state: DataShareDatasetKustoDatabaseState<Missing, 'Name, 'ShareId>, value: string) : DataShareDatasetKustoDatabaseState<Present, 'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.KustoDatabaseId <- value)
            ({ assignments = state.assignments } : DataShareDatasetKustoDatabaseState<Present, 'Name, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_database#name-1">DataShareDatasetKustoDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataShareDatasetKustoDatabaseState<'KustoDatabaseId, Missing, 'ShareId>, value: string) : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, Present, 'ShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, Present, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_database#share_id-1">DataShareDatasetKustoDatabase#share_id</a>.
        /// </summary>
        [<CustomOperation "share_id">]
        member _.ShareId(state: DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, Missing>, value: string) : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ShareId <- value)
            ({ assignments = state.assignments } : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_database#id-1">DataShareDatasetKustoDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId>, value: string) : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_kusto_database#timeouts-1">DataShareDatasetKustoDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId>, value: azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabaseTimeouts) : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataShareDatasetKustoDatabaseState<'KustoDatabaseId, 'Name, 'ShareId>

        member _.Run(state: DataShareDatasetKustoDatabaseState<Present, Present, Present>) : azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabase =
            let config = azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataShareDatasetKustoDatabase: missing required arguments. Must call: kusto_database_id, name, share_id.", 9999, IsError = true)>]
        member _.Run(_: DataShareDatasetKustoDatabaseState<_, _, _>) : azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabase =
            Unchecked.defaultof<azurerm.DataShareDatasetKustoDatabase.DataShareDatasetKustoDatabase>
