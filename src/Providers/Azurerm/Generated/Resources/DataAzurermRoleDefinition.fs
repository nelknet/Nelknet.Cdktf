namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRoleDefinitionState = { assignments: ResizeArray<azurerm.DataAzurermRoleDefinition.DataAzurermRoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_definition">azurerm_role_definition</a>.
    /// </summary>
    type DataAzurermRoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRoleDefinitionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermRoleDefinitionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_definition#id-1">DataAzurermRoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRoleDefinitionState, value: string) : DataAzurermRoleDefinitionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRoleDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_definition#name-1">DataAzurermRoleDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermRoleDefinitionState, value: string) : DataAzurermRoleDefinitionState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermRoleDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_definition#role_definition_id-1">DataAzurermRoleDefinition#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: DataAzurermRoleDefinitionState, value: string) : DataAzurermRoleDefinitionState =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            state : DataAzurermRoleDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_definition#scope-1">DataAzurermRoleDefinition#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAzurermRoleDefinitionState, value: string) : DataAzurermRoleDefinitionState =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : DataAzurermRoleDefinitionState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_definition#timeouts-1">DataAzurermRoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRoleDefinitionState, value: azurerm.DataAzurermRoleDefinition.DataAzurermRoleDefinitionTimeouts) : DataAzurermRoleDefinitionState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRoleDefinitionState

        member _.Run(state: DataAzurermRoleDefinitionState) : azurerm.DataAzurermRoleDefinition.DataAzurermRoleDefinition =
            let config = azurerm.DataAzurermRoleDefinition.DataAzurermRoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRoleDefinition.DataAzurermRoleDefinition(StackContext.get (), logicalId, config)
