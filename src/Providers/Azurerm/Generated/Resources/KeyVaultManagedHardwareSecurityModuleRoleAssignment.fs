namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope> = { assignments: ResizeArray<azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment">azurerm_key_vault_managed_hardware_security_module_role_assignment</a>.
    /// </summary>
    type KeyVaultManagedHardwareSecurityModuleRoleAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#managed_hsm_id-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#managed_hsm_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_id">]
        member _.ManagedHsmId(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Missing, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Present, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.ManagedHsmId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Present, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#name-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, Missing, 'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, Present, 'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, Present, 'PrincipalId, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#principal_id-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, Missing, 'RoleDefinitionId, 'Scope>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, Present, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, Present, 'RoleDefinitionId, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#role_definition_id-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, Missing, 'Scope>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, Present, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#scope-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, Missing>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#id-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_assignment#timeouts-1">KeyVaultManagedHardwareSecurityModuleRoleAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope>, value: azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentTimeouts) : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<'ManagedHsmId, 'Name, 'PrincipalId, 'RoleDefinitionId, 'Scope>

        member _.Run(state: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<Present, Present, Present, Present, Present>) : azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignment =
            let config = azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultManagedHardwareSecurityModuleRoleAssignment: missing required arguments. Must call: managed_hsm_id, name, principal_id, role_definition_id, scope.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultManagedHardwareSecurityModuleRoleAssignmentState<_, _, _, _, _>) : azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignment =
            Unchecked.defaultof<azurerm.KeyVaultManagedHardwareSecurityModuleRoleAssignment.KeyVaultManagedHardwareSecurityModuleRoleAssignment>
