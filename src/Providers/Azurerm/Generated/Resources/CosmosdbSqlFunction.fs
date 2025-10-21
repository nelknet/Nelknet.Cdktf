namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name> = { assignments: ResizeArray<azurerm.CosmosdbSqlFunction.CosmosdbSqlFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_function">azurerm_cosmosdb_sql_function</a>.
    /// </summary>
    type CosmosdbSqlFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlFunctionState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlFunctionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlFunctionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_function#body-1">CosmosdbSqlFunction#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: CosmosdbSqlFunctionState<Missing, 'ContainerId, 'Name>, value: string) : CosmosdbSqlFunctionState<Present, 'ContainerId, 'Name> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : CosmosdbSqlFunctionState<Present, 'ContainerId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_function#container_id-1">CosmosdbSqlFunction#container_id</a>.
        /// </summary>
        [<CustomOperation "container_id">]
        member _.ContainerId(state: CosmosdbSqlFunctionState<'Body, Missing, 'Name>, value: string) : CosmosdbSqlFunctionState<'Body, Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerId <- value)
            ({ assignments = state.assignments } : CosmosdbSqlFunctionState<'Body, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_function#name-1">CosmosdbSqlFunction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlFunctionState<'Body, 'ContainerId, Missing>, value: string) : CosmosdbSqlFunctionState<'Body, 'ContainerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbSqlFunctionState<'Body, 'ContainerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_function#id-1">CosmosdbSqlFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name>, value: string) : CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_function#timeouts-1">CosmosdbSqlFunction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name>, value: azurerm.CosmosdbSqlFunction.CosmosdbSqlFunctionTimeouts) : CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlFunctionState<'Body, 'ContainerId, 'Name>

        member _.Run(state: CosmosdbSqlFunctionState<Present, Present, Present>) : azurerm.CosmosdbSqlFunction.CosmosdbSqlFunction =
            let config = azurerm.CosmosdbSqlFunction.CosmosdbSqlFunctionConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlFunction.CosmosdbSqlFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlFunction: missing required arguments. Must call: body, container_id, name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlFunctionState<_, _, _>) : azurerm.CosmosdbSqlFunction.CosmosdbSqlFunction =
            Unchecked.defaultof<azurerm.CosmosdbSqlFunction.CosmosdbSqlFunction>
