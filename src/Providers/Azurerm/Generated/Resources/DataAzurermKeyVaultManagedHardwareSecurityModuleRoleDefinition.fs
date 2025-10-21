namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition">azurerm_key_vault_managed_hardware_security_module_role_definition</a>.
    /// </summary>
    type DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition#managed_hsm_id-1">DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition#managed_hsm_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_id">]
        member _.ManagedHsmId(state: DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Missing, 'Name>, value: string) : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagedHsmId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition#name-1">DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, Missing>, value: string) : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition#id-1">DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: string) : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module_role_definition#timeouts-1">DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>, value: azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionTimeouts) : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<'ManagedHsmId, 'Name>

        member _.Run(state: DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<Present, Present>) : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition =
            let config = azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition: missing required arguments. Must call: managed_hsm_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinitionState<_, _>) : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition.DataAzurermKeyVaultManagedHardwareSecurityModuleRoleDefinition>
