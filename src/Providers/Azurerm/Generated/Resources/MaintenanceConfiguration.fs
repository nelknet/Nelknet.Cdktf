namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> = { assignments: ResizeArray<azurerm.MaintenanceConfiguration.MaintenanceConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration">azurerm_maintenance_configuration</a>.
    /// </summary>
    type MaintenanceConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MaintenanceConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MaintenanceConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MaintenanceConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#location-1">MaintenanceConfiguration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MaintenanceConfigurationState<Missing, 'Name, 'ResourceGroupName, 'Scope>, value: string) : MaintenanceConfigurationState<Present, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MaintenanceConfigurationState<Present, 'Name, 'ResourceGroupName, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#name-1">MaintenanceConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MaintenanceConfigurationState<'Location, Missing, 'ResourceGroupName, 'Scope>, value: string) : MaintenanceConfigurationState<'Location, Present, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MaintenanceConfigurationState<'Location, Present, 'ResourceGroupName, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#resource_group_name-1">MaintenanceConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MaintenanceConfigurationState<'Location, 'Name, Missing, 'Scope>, value: string) : MaintenanceConfigurationState<'Location, 'Name, Present, 'Scope> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MaintenanceConfigurationState<'Location, 'Name, Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#scope-1">MaintenanceConfiguration#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#id-1">MaintenanceConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: string) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#in_guest_user_patch_mode-1">MaintenanceConfiguration#in_guest_user_patch_mode</a>.
        /// </summary>
        [<CustomOperation "in_guest_user_patch_mode">]
        member _.InGuestUserPatchMode(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: string) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.InGuestUserPatchMode <- value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// install_patches block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#install_patches-1">MaintenanceConfiguration#install_patches</a>
        /// </summary>
        [<CustomOperation "install_patches">]
        member _.InstallPatches(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: azurerm.MaintenanceConfiguration.MaintenanceConfigurationInstallPatches) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.InstallPatches <- value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#properties-1">MaintenanceConfiguration#properties</a>.
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: seq<string * string>) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Properties <- dict value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#tags-1">MaintenanceConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: seq<string * string>) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#timeouts-1">MaintenanceConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: azurerm.MaintenanceConfiguration.MaintenanceConfigurationTimeouts) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#visibility-1">MaintenanceConfiguration#visibility</a>.
        /// </summary>
        [<CustomOperation "visibility">]
        member _.Visibility(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: string) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Visibility <- value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        /// <summary>
        /// window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#window-1">MaintenanceConfiguration#window</a>
        /// </summary>
        [<CustomOperation "window">]
        member _.Window(state: MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>, value: azurerm.MaintenanceConfiguration.MaintenanceConfigurationWindow) : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope> =
            state.assignments.Add(fun config -> config.Window <- value)
            state : MaintenanceConfigurationState<'Location, 'Name, 'ResourceGroupName, 'Scope>

        member _.Run(state: MaintenanceConfigurationState<Present, Present, Present, Present>) : azurerm.MaintenanceConfiguration.MaintenanceConfiguration =
            let config = azurerm.MaintenanceConfiguration.MaintenanceConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.MaintenanceConfiguration.MaintenanceConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.maintenanceConfiguration: missing required arguments. Must call: location, name, resource_group_name, scope.", 9999, IsError = true)>]
        member _.Run(_: MaintenanceConfigurationState<_, _, _, _>) : azurerm.MaintenanceConfiguration.MaintenanceConfiguration =
            Unchecked.defaultof<azurerm.MaintenanceConfiguration.MaintenanceConfiguration>
