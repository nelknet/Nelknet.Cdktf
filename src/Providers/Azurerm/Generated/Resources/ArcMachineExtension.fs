namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> = { assignments: ResizeArray<azurerm.ArcMachineExtension.ArcMachineExtensionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension">azurerm_arc_machine_extension</a>.
    /// </summary>
    type ArcMachineExtensionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ArcMachineExtensionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcMachineExtensionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ArcMachineExtensionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcMachineExtensionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#arc_machine_id-1">ArcMachineExtension#arc_machine_id</a>.
        /// </summary>
        [<CustomOperation "arc_machine_id">]
        member _.ArcMachineId(state: ArcMachineExtensionState<Missing, 'Location, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<Present, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.ArcMachineId <- value)
            ({ assignments = state.assignments } : ArcMachineExtensionState<Present, 'Location, 'Name, 'Publisher, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#location-1">ArcMachineExtension#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ArcMachineExtensionState<'ArcMachineId, Missing, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, Present, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ArcMachineExtensionState<'ArcMachineId, Present, 'Name, 'Publisher, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#name-1">ArcMachineExtension#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ArcMachineExtensionState<'ArcMachineId, 'Location, Missing, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, Present, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ArcMachineExtensionState<'ArcMachineId, 'Location, Present, 'Publisher, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#publisher-1">ArcMachineExtension#publisher</a>.
        /// </summary>
        [<CustomOperation "publisher">]
        member _.Publisher(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, Missing, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Publisher <- value)
            ({ assignments = state.assignments } : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#type-1">ArcMachineExtension#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, Missing>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#automatic_upgrade_enabled-1">ArcMachineExtension#automatic_upgrade_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_upgrade_enabled">]
        member _.AutomaticUpgradeEnabled(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: bool) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeEnabled <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#automatic_upgrade_enabled-1">ArcMachineExtension#automatic_upgrade_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_upgrade_enabled">]
        member _.AutomaticUpgradeEnabled(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: HashiCorp.Cdktf.IResolvable) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeEnabled <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#force_update_tag-1">ArcMachineExtension#force_update_tag</a>.
        /// </summary>
        [<CustomOperation "force_update_tag">]
        member _.ForceUpdateTag(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.ForceUpdateTag <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#id-1">ArcMachineExtension#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#protected_settings-1">ArcMachineExtension#protected_settings</a>.
        /// </summary>
        [<CustomOperation "protected_settings">]
        member _.ProtectedSettings(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.ProtectedSettings <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#settings-1">ArcMachineExtension#settings</a>.
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.Settings <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#tags-1">ArcMachineExtension#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: seq<string * string>) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#timeouts-1">ArcMachineExtension#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: azurerm.ArcMachineExtension.ArcMachineExtensionTimeouts) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_machine_extension#type_handler_version-1">ArcMachineExtension#type_handler_version</a>.
        /// </summary>
        [<CustomOperation "type_handler_version">]
        member _.TypeHandlerVersion(state: ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>, value: string) : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type> =
            state.assignments.Add(fun config -> config.TypeHandlerVersion <- value)
            state : ArcMachineExtensionState<'ArcMachineId, 'Location, 'Name, 'Publisher, 'Type>

        member _.Run(state: ArcMachineExtensionState<Present, Present, Present, Present, Present>) : azurerm.ArcMachineExtension.ArcMachineExtension =
            let config = azurerm.ArcMachineExtension.ArcMachineExtensionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ArcMachineExtension.ArcMachineExtension(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.arcMachineExtension: missing required arguments. Must call: arc_machine_id, location, name, publisher, type.", 9999, IsError = true)>]
        member _.Run(_: ArcMachineExtensionState<_, _, _, _, _>) : azurerm.ArcMachineExtension.ArcMachineExtension =
            Unchecked.defaultof<azurerm.ArcMachineExtension.ArcMachineExtension>
