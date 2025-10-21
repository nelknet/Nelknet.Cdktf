namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password> = { assignments: ResizeArray<azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRoleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_role">azurerm_cosmosdb_postgresql_role</a>.
    /// </summary>
    type CosmosdbPostgresqlRoleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbPostgresqlRoleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlRoleState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbPostgresqlRoleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlRoleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_role#cluster_id-1">CosmosdbPostgresqlRole#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: CosmosdbPostgresqlRoleState<Missing, 'Name, 'Password>, value: string) : CosmosdbPostgresqlRoleState<Present, 'Name, 'Password> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlRoleState<Present, 'Name, 'Password>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_role#name-1">CosmosdbPostgresqlRole#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbPostgresqlRoleState<'ClusterId, Missing, 'Password>, value: string) : CosmosdbPostgresqlRoleState<'ClusterId, Present, 'Password> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlRoleState<'ClusterId, Present, 'Password>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_role#password-1">CosmosdbPostgresqlRole#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: CosmosdbPostgresqlRoleState<'ClusterId, 'Name, Missing>, value: string) : CosmosdbPostgresqlRoleState<'ClusterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlRoleState<'ClusterId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_role#id-1">CosmosdbPostgresqlRole#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password>, value: string) : CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_role#timeouts-1">CosmosdbPostgresqlRole#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password>, value: azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRoleTimeouts) : CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbPostgresqlRoleState<'ClusterId, 'Name, 'Password>

        member _.Run(state: CosmosdbPostgresqlRoleState<Present, Present, Present>) : azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRole =
            let config = azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRoleConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRole(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbPostgresqlRole: missing required arguments. Must call: cluster_id, name, password.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbPostgresqlRoleState<_, _, _>) : azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRole =
            Unchecked.defaultof<azurerm.CosmosdbPostgresqlRole.CosmosdbPostgresqlRole>
