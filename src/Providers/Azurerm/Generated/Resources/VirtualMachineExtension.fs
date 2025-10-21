namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineExtension.VirtualMachineExtensionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension">azurerm_virtual_machine_extension</a>.
    /// </summary>
    type VirtualMachineExtensionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineExtensionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineExtensionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineExtensionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineExtensionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#name-1">VirtualMachineExtension#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineExtensionState<Missing, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<Present, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineExtensionState<Present, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#publisher-1">VirtualMachineExtension#publisher</a>.
        /// </summary>
        [<CustomOperation "publisher">]
        member _.Publisher(state: VirtualMachineExtensionState<'Name, Missing, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<'Name, Present, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Publisher <- value)
            ({ assignments = state.assignments } : VirtualMachineExtensionState<'Name, Present, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#type-1">VirtualMachineExtension#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualMachineExtensionState<'Name, 'Publisher, Missing, 'TypeHandlerVersion, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<'Name, 'Publisher, Present, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VirtualMachineExtensionState<'Name, 'Publisher, Present, 'TypeHandlerVersion, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#type_handler_version-1">VirtualMachineExtension#type_handler_version</a>.
        /// </summary>
        [<CustomOperation "type_handler_version">]
        member _.TypeHandlerVersion(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, Missing, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.TypeHandlerVersion <- value)
            ({ assignments = state.assignments } : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#virtual_machine_id-1">VirtualMachineExtension#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, Missing>, value: string) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#automatic_upgrade_enabled-1">VirtualMachineExtension#automatic_upgrade_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_upgrade_enabled">]
        member _.AutomaticUpgradeEnabled(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: bool) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeEnabled <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#automatic_upgrade_enabled-1">VirtualMachineExtension#automatic_upgrade_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_upgrade_enabled">]
        member _.AutomaticUpgradeEnabled(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeEnabled <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#auto_upgrade_minor_version-1">VirtualMachineExtension#auto_upgrade_minor_version</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_upgrade_minor_version">]
        member _.AutoUpgradeMinorVersion(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: bool) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.AutoUpgradeMinorVersion <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#auto_upgrade_minor_version-1">VirtualMachineExtension#auto_upgrade_minor_version</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_upgrade_minor_version">]
        member _.AutoUpgradeMinorVersion(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.AutoUpgradeMinorVersion <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#failure_suppression_enabled-1">VirtualMachineExtension#failure_suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "failure_suppression_enabled">]
        member _.FailureSuppressionEnabled(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: bool) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.FailureSuppressionEnabled <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#failure_suppression_enabled-1">VirtualMachineExtension#failure_suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "failure_suppression_enabled">]
        member _.FailureSuppressionEnabled(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.FailureSuppressionEnabled <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#id-1">VirtualMachineExtension#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#protected_settings-1">VirtualMachineExtension#protected_settings</a>.
        /// </summary>
        [<CustomOperation "protected_settings">]
        member _.ProtectedSettings(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ProtectedSettings <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// protected_settings_from_key_vault block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#protected_settings_from_key_vault-1">VirtualMachineExtension#protected_settings_from_key_vault</a>
        /// </summary>
        [<CustomOperation "protected_settings_from_key_vault">]
        member _.ProtectedSettingsFromKeyVault(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: azurerm.VirtualMachineExtension.VirtualMachineExtensionProtectedSettingsFromKeyVault) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ProtectedSettingsFromKeyVault <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#provision_after_extensions-1">VirtualMachineExtension#provision_after_extensions</a>.
        /// </summary>
        [<CustomOperation "provision_after_extensions">]
        member _.ProvisionAfterExtensions(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: seq<string>) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ProvisionAfterExtensions <- (value |> Seq.toArray))
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#settings-1">VirtualMachineExtension#settings</a>.
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: string) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Settings <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#tags-1">VirtualMachineExtension#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: seq<string * string>) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_extension#timeouts-1">VirtualMachineExtension#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>, value: azurerm.VirtualMachineExtension.VirtualMachineExtensionTimeouts) : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineExtensionState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineId>

        member _.Run(state: VirtualMachineExtensionState<Present, Present, Present, Present, Present>) : azurerm.VirtualMachineExtension.VirtualMachineExtension =
            let config = azurerm.VirtualMachineExtension.VirtualMachineExtensionConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineExtension.VirtualMachineExtension(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineExtension: missing required arguments. Must call: name, publisher, type, type_handler_version, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineExtensionState<_, _, _, _, _>) : azurerm.VirtualMachineExtension.VirtualMachineExtension =
            Unchecked.defaultof<azurerm.VirtualMachineExtension.VirtualMachineExtension>
