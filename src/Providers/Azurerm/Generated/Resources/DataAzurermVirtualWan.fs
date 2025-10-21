namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualWanState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualWan.DataAzurermVirtualWanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan">azurerm_virtual_wan</a>.
    /// </summary>
    type DataAzurermVirtualWanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualWanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualWanState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualWanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualWanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#name-1">DataAzurermVirtualWan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualWanState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualWanState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualWanState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#resource_group_name-1">DataAzurermVirtualWan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualWanState<'Name, Missing>, value: string) : DataAzurermVirtualWanState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualWanState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#id-1">DataAzurermVirtualWan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualWanState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualWanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualWanState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_wan#timeouts-1">DataAzurermVirtualWan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualWanState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualWan.DataAzurermVirtualWanTimeouts) : DataAzurermVirtualWanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualWanState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualWanState<Present, Present>) : azurerm.DataAzurermVirtualWan.DataAzurermVirtualWan =
            let config = azurerm.DataAzurermVirtualWan.DataAzurermVirtualWanConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualWan.DataAzurermVirtualWan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualWan: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualWanState<_, _>) : azurerm.DataAzurermVirtualWan.DataAzurermVirtualWan =
            Unchecked.defaultof<azurerm.DataAzurermVirtualWan.DataAzurermVirtualWan>
