namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> = { assignments: ResizeArray<azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group">azurerm_virtual_desktop_application_group</a>.
    /// </summary>
    type VirtualDesktopApplicationGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopApplicationGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopApplicationGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualDesktopApplicationGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopApplicationGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#host_pool_id-1">VirtualDesktopApplicationGroup#host_pool_id</a>.
        /// </summary>
        [<CustomOperation "host_pool_id">]
        member _.HostPoolId(state: VirtualDesktopApplicationGroupState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<Present, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.HostPoolId <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationGroupState<Present, 'Location, 'Name, 'ResourceGroupName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#location-1">VirtualDesktopApplicationGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualDesktopApplicationGroupState<'HostPoolId, Missing, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, Present, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationGroupState<'HostPoolId, Present, 'Name, 'ResourceGroupName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#name-1">VirtualDesktopApplicationGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, Missing, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, Present, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, Present, 'ResourceGroupName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#resource_group_name-1">VirtualDesktopApplicationGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, Missing, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#type-1">VirtualDesktopApplicationGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#default_desktop_display_name-1">VirtualDesktopApplicationGroup#default_desktop_display_name</a>.
        /// </summary>
        [<CustomOperation "default_desktop_display_name">]
        member _.DefaultDesktopDisplayName(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.DefaultDesktopDisplayName <- value)
            state : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#description-1">VirtualDesktopApplicationGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#friendly_name-1">VirtualDesktopApplicationGroup#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#id-1">VirtualDesktopApplicationGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#tags-1">VirtualDesktopApplicationGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: seq<string * string>) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_application_group#timeouts-1">VirtualDesktopApplicationGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroupTimeouts) : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopApplicationGroupState<'HostPoolId, 'Location, 'Name, 'ResourceGroupName, 'Type>

        member _.Run(state: VirtualDesktopApplicationGroupState<Present, Present, Present, Present, Present>) : azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroup =
            let config = azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopApplicationGroup: missing required arguments. Must call: host_pool_id, location, name, resource_group_name, type.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopApplicationGroupState<_, _, _, _, _>) : azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroup =
            Unchecked.defaultof<azurerm.VirtualDesktopApplicationGroup.VirtualDesktopApplicationGroup>
