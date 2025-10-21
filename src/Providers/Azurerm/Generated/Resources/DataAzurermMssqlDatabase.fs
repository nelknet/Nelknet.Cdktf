namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMssqlDatabaseState<'Name, 'ServerId> = { assignments: ResizeArray<azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database">azurerm_mssql_database</a>.
    /// </summary>
    type DataAzurermMssqlDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMssqlDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlDatabaseState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMssqlDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#name-1">DataAzurermMssqlDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMssqlDatabaseState<Missing, 'ServerId>, value: string) : DataAzurermMssqlDatabaseState<Present, 'ServerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlDatabaseState<Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#server_id-1">DataAzurermMssqlDatabase#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: DataAzurermMssqlDatabaseState<'Name, Missing>, value: string) : DataAzurermMssqlDatabaseState<'Name, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlDatabaseState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#id-1">DataAzurermMssqlDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMssqlDatabaseState<'Name, 'ServerId>, value: string) : DataAzurermMssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#timeouts-1">DataAzurermMssqlDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMssqlDatabaseState<'Name, 'ServerId>, value: azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabaseTimeouts) : DataAzurermMssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMssqlDatabaseState<'Name, 'ServerId>

        member _.Run(state: DataAzurermMssqlDatabaseState<Present, Present>) : azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabase =
            let config = azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMssqlDatabase: missing required arguments. Must call: name, server_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMssqlDatabaseState<_, _>) : azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabase =
            Unchecked.defaultof<azurerm.DataAzurermMssqlDatabase.DataAzurermMssqlDatabase>
