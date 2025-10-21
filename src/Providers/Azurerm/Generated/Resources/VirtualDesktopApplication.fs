namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> = { assignments: ResizeArray<azurerm.VirtualDesktopApplication.VirtualDesktopApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application">azurerm_virtual_desktop_application</a>.
    /// </summary>
    type VirtualDesktopApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopApplicationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopApplicationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualDesktopApplicationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopApplicationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#application_group_id-1">VirtualDesktopApplication#application_group_id</a>.
        /// </summary>
        [<CustomOperation "application_group_id">]
        member _.ApplicationGroupId(state: VirtualDesktopApplicationState<Missing, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<Present, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.ApplicationGroupId <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationState<Present, 'CommandLineArgumentPolicy, 'Name, 'Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#command_line_argument_policy-1">VirtualDesktopApplication#command_line_argument_policy</a>.
        /// </summary>
        [<CustomOperation "command_line_argument_policy">]
        member _.CommandLineArgumentPolicy(state: VirtualDesktopApplicationState<'ApplicationGroupId, Missing, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, Present, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.CommandLineArgumentPolicy <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationState<'ApplicationGroupId, Present, 'Name, 'Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#name-1">VirtualDesktopApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, Missing, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, Present, 'Path> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, Present, 'Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#path-1">VirtualDesktopApplication#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, Missing>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, Present> =
            state.assignments.Add(fun config -> config.Path <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#command_line_arguments-1">VirtualDesktopApplication#command_line_arguments</a>.
        /// </summary>
        [<CustomOperation "command_line_arguments">]
        member _.CommandLineArguments(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.CommandLineArguments <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#description-1">VirtualDesktopApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#friendly_name-1">VirtualDesktopApplication#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#icon_index-1">VirtualDesktopApplication#icon_index</a>.
        /// </summary>
        [<CustomOperation "icon_index">]
        member _.IconIndex(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: double) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.IconIndex <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#icon_path-1">VirtualDesktopApplication#icon_path</a>.
        /// </summary>
        [<CustomOperation "icon_path">]
        member _.IconPath(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.IconPath <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#id-1">VirtualDesktopApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: string) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#show_in_portal-1">VirtualDesktopApplication#show_in_portal</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "show_in_portal">]
        member _.ShowInPortal(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: bool) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.ShowInPortal <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#show_in_portal-1">VirtualDesktopApplication#show_in_portal</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "show_in_portal">]
        member _.ShowInPortal(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.ShowInPortal <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application#timeouts-1">VirtualDesktopApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>, value: azurerm.VirtualDesktopApplication.VirtualDesktopApplicationTimeouts) : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopApplicationState<'ApplicationGroupId, 'CommandLineArgumentPolicy, 'Name, 'Path>

        member _.Run(state: VirtualDesktopApplicationState<Present, Present, Present, Present>) : azurerm.VirtualDesktopApplication.VirtualDesktopApplication =
            let config = azurerm.VirtualDesktopApplication.VirtualDesktopApplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopApplication.VirtualDesktopApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopApplication: missing required arguments. Must call: application_group_id, command_line_argument_policy, name, path.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopApplicationState<_, _, _, _>) : azurerm.VirtualDesktopApplication.VirtualDesktopApplication =
            Unchecked.defaultof<azurerm.VirtualDesktopApplication.VirtualDesktopApplication>
