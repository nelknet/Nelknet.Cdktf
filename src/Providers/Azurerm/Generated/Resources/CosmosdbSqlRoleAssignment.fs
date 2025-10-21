namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment">azurerm_cosmosdb_sql_role_assignment</a>.
    /// </summary>
    type CosmosdbSqlRoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlRoleAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlRoleAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlRoleAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlRoleAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#account_name-1">CosmosdbSqlRoleAssignment#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbSqlRoleAssignmentState<Missing, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>, value: string) : CosmosdbSqlRoleAssignmentState<Present, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleAssignmentState<Present, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#principal_id-1">CosmosdbSqlRoleAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: CosmosdbSqlRoleAssignmentState<'AccountName, Missing, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>, value: string) : CosmosdbSqlRoleAssignmentState<'AccountName, Present, 'ResourceGroupName, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleAssignmentState<'AccountName, Present, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#resource_group_name-1">CosmosdbSqlRoleAssignment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, Missing, 'RoleDefinitionId, 'Scope>, value: string) : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, Present, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, Present, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#role_definition_id-1">CosmosdbSqlRoleAssignment#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, Missing, 'Scope>, value: string) : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, Present, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#scope-1">CosmosdbSqlRoleAssignment#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, Missing>, value: string) : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#id-1">CosmosdbSqlRoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>, value: string) : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#name-1">CosmosdbSqlRoleAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>, value: string) : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_assignment#timeouts-1">CosmosdbSqlRoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>, value: azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignmentTimeouts) : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlRoleAssignmentState<'AccountName, 'PrincipalId, 'ResourceGroupName, 'RoleDefinitionId, 'Scope>

        member _.Run(state: CosmosdbSqlRoleAssignmentState<Present, Present, Present, Present, Present>) : azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignment =
            let config = azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlRoleAssignment: missing required arguments. Must call: account_name, principal_id, resource_group_name, role_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlRoleAssignmentState<_, _, _, _, _>) : azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignment =
            Unchecked.defaultof<azurerm.CosmosdbSqlRoleAssignment.CosmosdbSqlRoleAssignment>
