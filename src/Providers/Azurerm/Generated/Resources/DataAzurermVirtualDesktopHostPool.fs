namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_host_pool">azurerm_virtual_desktop_host_pool</a>.
    /// </summary>
    type DataAzurermVirtualDesktopHostPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualDesktopHostPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualDesktopHostPoolState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualDesktopHostPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualDesktopHostPoolState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_host_pool#name-1">DataAzurermVirtualDesktopHostPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualDesktopHostPoolState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualDesktopHostPoolState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualDesktopHostPoolState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_host_pool#resource_group_name-1">DataAzurermVirtualDesktopHostPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualDesktopHostPoolState<'Name, Missing>, value: string) : DataAzurermVirtualDesktopHostPoolState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualDesktopHostPoolState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_host_pool#id-1">DataAzurermVirtualDesktopHostPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_desktop_host_pool#timeouts-1">DataAzurermVirtualDesktopHostPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPoolTimeouts) : DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualDesktopHostPoolState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualDesktopHostPoolState<Present, Present>) : azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPool =
            let config = azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualDesktopHostPool: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualDesktopHostPoolState<_, _>) : azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPool =
            Unchecked.defaultof<azurerm.DataAzurermVirtualDesktopHostPool.DataAzurermVirtualDesktopHostPool>
