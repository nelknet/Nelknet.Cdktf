namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts">azurerm_cosmosdb_restorable_database_accounts</a>.
    /// </summary>
    type DataAzurermCosmosdbRestorableDatabaseAccountsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCosmosdbRestorableDatabaseAccountsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbRestorableDatabaseAccountsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCosmosdbRestorableDatabaseAccountsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbRestorableDatabaseAccountsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts#location-1">DataAzurermCosmosdbRestorableDatabaseAccounts#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermCosmosdbRestorableDatabaseAccountsState<Missing, 'Name>, value: string) : DataAzurermCosmosdbRestorableDatabaseAccountsState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbRestorableDatabaseAccountsState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts#name-1">DataAzurermCosmosdbRestorableDatabaseAccounts#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, Missing>, value: string) : DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts#id-1">DataAzurermCosmosdbRestorableDatabaseAccounts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name>, value: string) : DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_restorable_database_accounts#timeouts-1">DataAzurermCosmosdbRestorableDatabaseAccounts#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name>, value: azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsTimeouts) : DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCosmosdbRestorableDatabaseAccountsState<'Location, 'Name>

        member _.Run(state: DataAzurermCosmosdbRestorableDatabaseAccountsState<Present, Present>) : azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts =
            let config = azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccountsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCosmosdbRestorableDatabaseAccounts: missing required arguments. Must call: location, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCosmosdbRestorableDatabaseAccountsState<_, _>) : azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts =
            Unchecked.defaultof<azurerm.DataAzurermCosmosdbRestorableDatabaseAccounts.DataAzurermCosmosdbRestorableDatabaseAccounts>
