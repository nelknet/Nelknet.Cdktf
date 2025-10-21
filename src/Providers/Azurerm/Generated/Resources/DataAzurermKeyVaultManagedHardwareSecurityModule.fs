namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module">azurerm_key_vault_managed_hardware_security_module</a>.
    /// </summary>
    type DataAzurermKeyVaultManagedHardwareSecurityModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultManagedHardwareSecurityModuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultManagedHardwareSecurityModuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultManagedHardwareSecurityModuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultManagedHardwareSecurityModuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#name-1">DataAzurermKeyVaultManagedHardwareSecurityModule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultManagedHardwareSecurityModuleState<Missing, 'ResourceGroupName>, value: string) : DataAzurermKeyVaultManagedHardwareSecurityModuleState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultManagedHardwareSecurityModuleState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#resource_group_name-1">DataAzurermKeyVaultManagedHardwareSecurityModule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, Missing>, value: string) : DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#id-1">DataAzurermKeyVaultManagedHardwareSecurityModule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName>, value: string) : DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_managed_hardware_security_module#timeouts-1">DataAzurermKeyVaultManagedHardwareSecurityModule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModuleTimeouts) : DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultManagedHardwareSecurityModuleState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKeyVaultManagedHardwareSecurityModuleState<Present, Present>) : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModule =
            let config = azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultManagedHardwareSecurityModule: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultManagedHardwareSecurityModuleState<_, _>) : azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModule =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultManagedHardwareSecurityModule.DataAzurermKeyVaultManagedHardwareSecurityModule>
