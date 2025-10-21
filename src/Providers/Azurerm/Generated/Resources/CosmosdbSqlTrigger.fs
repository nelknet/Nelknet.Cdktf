namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type> = { assignments: ResizeArray<azurerm.CosmosdbSqlTrigger.CosmosdbSqlTriggerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger">azurerm_cosmosdb_sql_trigger</a>.
    /// </summary>
    type CosmosdbSqlTriggerBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlTriggerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlTriggerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlTriggerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlTriggerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#body-1">CosmosdbSqlTrigger#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: CosmosdbSqlTriggerState<Missing, 'ContainerId, 'Name, 'Operation, 'Type>, value: string) : CosmosdbSqlTriggerState<Present, 'ContainerId, 'Name, 'Operation, 'Type> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : CosmosdbSqlTriggerState<Present, 'ContainerId, 'Name, 'Operation, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#container_id-1">CosmosdbSqlTrigger#container_id</a>.
        /// </summary>
        [<CustomOperation "container_id">]
        member _.ContainerId(state: CosmosdbSqlTriggerState<'Body, Missing, 'Name, 'Operation, 'Type>, value: string) : CosmosdbSqlTriggerState<'Body, Present, 'Name, 'Operation, 'Type> =
            state.assignments.Add(fun config -> config.ContainerId <- value)
            ({ assignments = state.assignments } : CosmosdbSqlTriggerState<'Body, Present, 'Name, 'Operation, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#name-1">CosmosdbSqlTrigger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlTriggerState<'Body, 'ContainerId, Missing, 'Operation, 'Type>, value: string) : CosmosdbSqlTriggerState<'Body, 'ContainerId, Present, 'Operation, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbSqlTriggerState<'Body, 'ContainerId, Present, 'Operation, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#operation-1">CosmosdbSqlTrigger#operation</a>.
        /// </summary>
        [<CustomOperation "operation">]
        member _.Operation(state: CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, Missing, 'Type>, value: string) : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Operation <- value)
            ({ assignments = state.assignments } : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#type-1">CosmosdbSqlTrigger#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, Missing>, value: string) : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#id-1">CosmosdbSqlTrigger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type>, value: string) : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_trigger#timeouts-1">CosmosdbSqlTrigger#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type>, value: azurerm.CosmosdbSqlTrigger.CosmosdbSqlTriggerTimeouts) : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlTriggerState<'Body, 'ContainerId, 'Name, 'Operation, 'Type>

        member _.Run(state: CosmosdbSqlTriggerState<Present, Present, Present, Present, Present>) : azurerm.CosmosdbSqlTrigger.CosmosdbSqlTrigger =
            let config = azurerm.CosmosdbSqlTrigger.CosmosdbSqlTriggerConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlTrigger.CosmosdbSqlTrigger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlTrigger: missing required arguments. Must call: body, container_id, name, operation, type.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlTriggerState<_, _, _, _, _>) : azurerm.CosmosdbSqlTrigger.CosmosdbSqlTrigger =
            Unchecked.defaultof<azurerm.CosmosdbSqlTrigger.CosmosdbSqlTrigger>
