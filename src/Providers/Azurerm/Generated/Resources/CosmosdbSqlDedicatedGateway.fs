namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize> = { assignments: ResizeArray<azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_dedicated_gateway">azurerm_cosmosdb_sql_dedicated_gateway</a>.
    /// </summary>
    type CosmosdbSqlDedicatedGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlDedicatedGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlDedicatedGatewayState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlDedicatedGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlDedicatedGatewayState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_dedicated_gateway#cosmosdb_account_id-1">CosmosdbSqlDedicatedGateway#cosmosdb_account_id</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_account_id">]
        member _.CosmosdbAccountId(state: CosmosdbSqlDedicatedGatewayState<Missing, 'InstanceCount, 'InstanceSize>, value: string) : CosmosdbSqlDedicatedGatewayState<Present, 'InstanceCount, 'InstanceSize> =
            state.assignments.Add(fun config -> config.CosmosdbAccountId <- value)
            ({ assignments = state.assignments } : CosmosdbSqlDedicatedGatewayState<Present, 'InstanceCount, 'InstanceSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_dedicated_gateway#instance_count-1">CosmosdbSqlDedicatedGateway#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, Missing, 'InstanceSize>, value: double) : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, Present, 'InstanceSize> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            ({ assignments = state.assignments } : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, Present, 'InstanceSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_dedicated_gateway#instance_size-1">CosmosdbSqlDedicatedGateway#instance_size</a>.
        /// </summary>
        [<CustomOperation "instance_size">]
        member _.InstanceSize(state: CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, Missing>, value: string) : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, Present> =
            state.assignments.Add(fun config -> config.InstanceSize <- value)
            ({ assignments = state.assignments } : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_dedicated_gateway#id-1">CosmosdbSqlDedicatedGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize>, value: string) : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_dedicated_gateway#timeouts-1">CosmosdbSqlDedicatedGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize>, value: azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGatewayTimeouts) : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlDedicatedGatewayState<'CosmosdbAccountId, 'InstanceCount, 'InstanceSize>

        member _.Run(state: CosmosdbSqlDedicatedGatewayState<Present, Present, Present>) : azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGateway =
            let config = azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlDedicatedGateway: missing required arguments. Must call: cosmosdb_account_id, instance_count, instance_size.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlDedicatedGatewayState<_, _, _>) : azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGateway =
            Unchecked.defaultof<azurerm.CosmosdbSqlDedicatedGateway.CosmosdbSqlDedicatedGateway>
