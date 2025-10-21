namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> = { assignments: ResizeArray<azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension">azurerm_virtual_machine_scale_set_extension</a>.
    /// </summary>
    type VirtualMachineScaleSetExtensionABuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineScaleSetExtensionAState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineScaleSetExtensionAState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineScaleSetExtensionAState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineScaleSetExtensionAState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#name-1">VirtualMachineScaleSetExtensionA#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineScaleSetExtensionAState<Missing, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<Present, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetExtensionAState<Present, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#publisher-1">VirtualMachineScaleSetExtensionA#publisher</a>.
        /// </summary>
        [<CustomOperation "publisher">]
        member _.Publisher(state: VirtualMachineScaleSetExtensionAState<'Name, Missing, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, Present, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Publisher <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetExtensionAState<'Name, Present, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#type-1">VirtualMachineScaleSetExtensionA#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, Missing, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, Present, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, Present, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#type_handler_version-1">VirtualMachineScaleSetExtensionA#type_handler_version</a>.
        /// </summary>
        [<CustomOperation "type_handler_version">]
        member _.TypeHandlerVersion(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, Missing, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, Present, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.TypeHandlerVersion <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, Present, 'VirtualMachineScaleSetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#virtual_machine_scale_set_id-1">VirtualMachineScaleSetExtensionA#virtual_machine_scale_set_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_scale_set_id">]
        member _.VirtualMachineScaleSetId(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, Missing>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineScaleSetId <- value)
            ({ assignments = state.assignments } : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#automatic_upgrade_enabled-1">VirtualMachineScaleSetExtensionA#automatic_upgrade_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_upgrade_enabled">]
        member _.AutomaticUpgradeEnabled(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: bool) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeEnabled <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#automatic_upgrade_enabled-1">VirtualMachineScaleSetExtensionA#automatic_upgrade_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_upgrade_enabled">]
        member _.AutomaticUpgradeEnabled(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeEnabled <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#auto_upgrade_minor_version-1">VirtualMachineScaleSetExtensionA#auto_upgrade_minor_version</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_upgrade_minor_version">]
        member _.AutoUpgradeMinorVersion(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: bool) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.AutoUpgradeMinorVersion <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#auto_upgrade_minor_version-1">VirtualMachineScaleSetExtensionA#auto_upgrade_minor_version</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_upgrade_minor_version">]
        member _.AutoUpgradeMinorVersion(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.AutoUpgradeMinorVersion <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#failure_suppression_enabled-1">VirtualMachineScaleSetExtensionA#failure_suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "failure_suppression_enabled">]
        member _.FailureSuppressionEnabled(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: bool) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.FailureSuppressionEnabled <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#failure_suppression_enabled-1">VirtualMachineScaleSetExtensionA#failure_suppression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "failure_suppression_enabled">]
        member _.FailureSuppressionEnabled(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.FailureSuppressionEnabled <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#force_update_tag-1">VirtualMachineScaleSetExtensionA#force_update_tag</a>.
        /// </summary>
        [<CustomOperation "force_update_tag">]
        member _.ForceUpdateTag(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.ForceUpdateTag <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#id-1">VirtualMachineScaleSetExtensionA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#protected_settings-1">VirtualMachineScaleSetExtensionA#protected_settings</a>.
        /// </summary>
        [<CustomOperation "protected_settings">]
        member _.ProtectedSettings(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.ProtectedSettings <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// protected_settings_from_key_vault block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#protected_settings_from_key_vault-1">VirtualMachineScaleSetExtensionA#protected_settings_from_key_vault</a>
        /// </summary>
        [<CustomOperation "protected_settings_from_key_vault">]
        member _.ProtectedSettingsFromKeyVault(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionProtectedSettingsFromKeyVault) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.ProtectedSettingsFromKeyVault <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#provision_after_extensions-1">VirtualMachineScaleSetExtensionA#provision_after_extensions</a>.
        /// </summary>
        [<CustomOperation "provision_after_extensions">]
        member _.ProvisionAfterExtensions(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: seq<string>) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.ProvisionAfterExtensions <- (value |> Seq.toArray))
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#settings-1">VirtualMachineScaleSetExtensionA#settings</a>.
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: string) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Settings <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_extension#timeouts-1">VirtualMachineScaleSetExtensionA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>, value: azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionTimeouts) : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineScaleSetExtensionAState<'Name, 'Publisher, 'Type, 'TypeHandlerVersion, 'VirtualMachineScaleSetId>

        member _.Run(state: VirtualMachineScaleSetExtensionAState<Present, Present, Present, Present, Present>) : azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionA =
            let config = azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionAConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineScaleSetExtensionA: missing required arguments. Must call: name, publisher, type, type_handler_version, virtual_machine_scale_set_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineScaleSetExtensionAState<_, _, _, _, _>) : azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionA =
            Unchecked.defaultof<azurerm.VirtualMachineScaleSetExtension.VirtualMachineScaleSetExtensionA>
