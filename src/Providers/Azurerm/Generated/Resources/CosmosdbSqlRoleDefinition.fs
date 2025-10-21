namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition">azurerm_cosmosdb_sql_role_definition</a>.
    /// </summary>
    type CosmosdbSqlRoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlRoleDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlRoleDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlRoleDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlRoleDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#account_name-1">CosmosdbSqlRoleDefinition#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbSqlRoleDefinitionState<Missing, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>, value: string) : CosmosdbSqlRoleDefinitionState<Present, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleDefinitionState<Present, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#assignable_scopes-1">CosmosdbSqlRoleDefinition#assignable_scopes</a>.
        /// </summary>
        [<CustomOperation "assignable_scopes">]
        member _.AssignableScopes(state: CosmosdbSqlRoleDefinitionState<'AccountName, Missing, 'Name, 'Permissions, 'ResourceGroupName>, value: seq<string>) : CosmosdbSqlRoleDefinitionState<'AccountName, Present, 'Name, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AssignableScopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CosmosdbSqlRoleDefinitionState<'AccountName, Present, 'Name, 'Permissions, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#name-1">CosmosdbSqlRoleDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, Missing, 'Permissions, 'ResourceGroupName>, value: string) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, Present, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, Present, 'Permissions, 'ResourceGroupName>)

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#permissions-1">CosmosdbSqlRoleDefinition#permissions</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinitionPermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, Missing, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#resource_group_name-1">CosmosdbSqlRoleDefinition#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, Missing>, value: string) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#id-1">CosmosdbSqlRoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>, value: string) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#role_definition_id-1">CosmosdbSqlRoleDefinition#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>, value: string) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            state : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#timeouts-1">CosmosdbSqlRoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>, value: azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinitionTimeouts) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_role_definition#type-1">CosmosdbSqlRoleDefinition#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>, value: string) : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : CosmosdbSqlRoleDefinitionState<'AccountName, 'AssignableScopes, 'Name, 'Permissions, 'ResourceGroupName>

        member _.Run(state: CosmosdbSqlRoleDefinitionState<Present, Present, Present, Present, Present>) : azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinition =
            let config = azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlRoleDefinition: missing required arguments. Must call: account_name, assignable_scopes, name, permissions, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlRoleDefinitionState<_, _, _, _, _>) : azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinition =
            Unchecked.defaultof<azurerm.CosmosdbSqlRoleDefinition.CosmosdbSqlRoleDefinition>
