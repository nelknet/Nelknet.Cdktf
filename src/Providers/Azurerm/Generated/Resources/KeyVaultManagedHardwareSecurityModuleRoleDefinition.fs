namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> = { assignments: ResizeArray<azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition">azurerm_key_vault_managed_hardware_security_module_role_definition</a>.
    /// </summary>
    type KeyVaultManagedHardwareSecurityModuleRoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing>)

        member _.Zero(()) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#managed_hsm_id-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#managed_hsm_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_id">]
        member _.ManagedHsmId(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagedHsmId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#name-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, Missing>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#description-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#id-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        /// <summary>
        /// permission block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#permission-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#permission</a> Accepts: azurerm.IResolvable | azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinitionPermission[]
        /// </summary>
        [<CustomOperation "permission">]
        member _.Permission(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Permission <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#role_name-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_role_definition#timeouts-1">KeyVaultManagedHardwareSecurityModuleRoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts) : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        member _.Run(state: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Present, Present>) : azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinition =
            let config = azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultManagedHardwareSecurityModuleRoleDefinition: missing required arguments. Must call: managed_hsm_id, name.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultManagedHardwareSecurityModuleRoleDefinitionState<_, _>) : azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinition =
            Unchecked.defaultof<azurerm.KeyVaultManagedHardwareSecurityModuleRoleDefinition.KeyVaultManagedHardwareSecurityModuleRoleDefinition>
