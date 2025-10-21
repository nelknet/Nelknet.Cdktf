namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure">azurerm_cosmosdb_sql_stored_procedure</a>.
    /// </summary>
    type CosmosdbSqlStoredProcedureBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlStoredProcedureState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlStoredProcedureState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlStoredProcedureState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlStoredProcedureState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#account_name-1">CosmosdbSqlStoredProcedure#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbSqlStoredProcedureState<Missing, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlStoredProcedureState<Present, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlStoredProcedureState<Present, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#body-1">CosmosdbSqlStoredProcedure#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: CosmosdbSqlStoredProcedureState<'AccountName, Missing, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlStoredProcedureState<'AccountName, Present, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : CosmosdbSqlStoredProcedureState<'AccountName, Present, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#container_name-1">CosmosdbSqlStoredProcedure#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: CosmosdbSqlStoredProcedureState<'AccountName, 'Body, Missing, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, Present, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, Present, 'DatabaseName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#database_name-1">CosmosdbSqlStoredProcedure#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#name-1">CosmosdbSqlStoredProcedure#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, Missing, 'ResourceGroupName>, value: string) : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#resource_group_name-1">CosmosdbSqlStoredProcedure#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, Missing>, value: string) : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#id-1">CosmosdbSqlStoredProcedure#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_stored_procedure#timeouts-1">CosmosdbSqlStoredProcedure#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedureTimeouts) : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlStoredProcedureState<'AccountName, 'Body, 'ContainerName, 'DatabaseName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbSqlStoredProcedureState<Present, Present, Present, Present, Present, Present>) : azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedure =
            let config = azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedureConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedure(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlStoredProcedure: missing required arguments. Must call: account_name, body, container_name, database_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlStoredProcedureState<_, _, _, _, _, _>) : azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedure =
            Unchecked.defaultof<azurerm.CosmosdbSqlStoredProcedure.CosmosdbSqlStoredProcedure>
