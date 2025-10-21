namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_management_policy">azurerm_role_management_policy</a>.
    /// </summary>
    type DataAzurermRoleManagementPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRoleManagementPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRoleManagementPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermRoleManagementPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRoleManagementPolicyState<Missing, Missing>)

        /// <summary>
        /// ID of the Azure Role to which this policy is assigned. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_management_policy#role_definition_id-1">DataAzurermRoleManagementPolicy#role_definition_id</a>
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: DataAzurermRoleManagementPolicyState<Missing, 'Scope>, value: string) : DataAzurermRoleManagementPolicyState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : DataAzurermRoleManagementPolicyState<Present, 'Scope>)

        /// <summary>
        /// The scope of the role to which this policy will apply. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_management_policy#scope-1">DataAzurermRoleManagementPolicy#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAzurermRoleManagementPolicyState<'RoleDefinitionId, Missing>, value: string) : DataAzurermRoleManagementPolicyState<'RoleDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : DataAzurermRoleManagementPolicyState<'RoleDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_management_policy#id-1">DataAzurermRoleManagementPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: string) : DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/role_management_policy#timeouts-1">DataAzurermRoleManagementPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope>, value: azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyTimeouts) : DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRoleManagementPolicyState<'RoleDefinitionId, 'Scope>

        member _.Run(state: DataAzurermRoleManagementPolicyState<Present, Present>) : azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicy =
            let config = azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermRoleManagementPolicy: missing required arguments. Must call: role_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermRoleManagementPolicyState<_, _>) : azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicy =
            Unchecked.defaultof<azurerm.DataAzurermRoleManagementPolicy.DataAzurermRoleManagementPolicy>
