namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group">azurerm_virtual_desktop_application_group</a>.
    /// </summary>
    type DataAzurermVirtualDesktopApplicationGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualDesktopApplicationGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualDesktopApplicationGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualDesktopApplicationGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualDesktopApplicationGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#name-1">DataAzurermVirtualDesktopApplicationGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualDesktopApplicationGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualDesktopApplicationGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualDesktopApplicationGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#resource_group_name-1">DataAzurermVirtualDesktopApplicationGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualDesktopApplicationGroupState<'Name, Missing>, value: string) : DataAzurermVirtualDesktopApplicationGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualDesktopApplicationGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#id-1">DataAzurermVirtualDesktopApplicationGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_application_group#timeouts-1">DataAzurermVirtualDesktopApplicationGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroupTimeouts) : DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualDesktopApplicationGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualDesktopApplicationGroupState<Present, Present>) : azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroup =
            let config = azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualDesktopApplicationGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualDesktopApplicationGroupState<_, _>) : azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroup =
            Unchecked.defaultof<azurerm.DataAzurermVirtualDesktopApplicationGroup.DataAzurermVirtualDesktopApplicationGroup>
