namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId> = { assignments: ResizeArray<azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_role_definition">azurerm_cosmosdb_sql_role_definition</a>.
    /// </summary>
    type DataAzurermCosmosdbSqlRoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCosmosdbSqlRoleDefinitionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbSqlRoleDefinitionState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCosmosdbSqlRoleDefinitionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbSqlRoleDefinitionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_role_definition#account_name-1">DataAzurermCosmosdbSqlRoleDefinition#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermCosmosdbSqlRoleDefinitionState<Missing, 'ResourceGroupName, 'RoleDefinitionId>, value: string) : DataAzurermCosmosdbSqlRoleDefinitionState<Present, 'ResourceGroupName, 'RoleDefinitionId> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbSqlRoleDefinitionState<Present, 'ResourceGroupName, 'RoleDefinitionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_role_definition#resource_group_name-1">DataAzurermCosmosdbSqlRoleDefinition#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, Missing, 'RoleDefinitionId>, value: string) : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, Present, 'RoleDefinitionId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, Present, 'RoleDefinitionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_role_definition#role_definition_id-1">DataAzurermCosmosdbSqlRoleDefinition#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, Missing>, value: string) : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_role_definition#id-1">DataAzurermCosmosdbSqlRoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId>, value: string) : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_role_definition#timeouts-1">DataAzurermCosmosdbSqlRoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId>, value: azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinitionTimeouts) : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCosmosdbSqlRoleDefinitionState<'AccountName, 'ResourceGroupName, 'RoleDefinitionId>

        member _.Run(state: DataAzurermCosmosdbSqlRoleDefinitionState<Present, Present, Present>) : azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinition =
            let config = azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCosmosdbSqlRoleDefinition: missing required arguments. Must call: account_name, resource_group_name, role_definition_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCosmosdbSqlRoleDefinitionState<_, _, _>) : azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinition =
            Unchecked.defaultof<azurerm.DataAzurermCosmosdbSqlRoleDefinition.DataAzurermCosmosdbSqlRoleDefinition>
