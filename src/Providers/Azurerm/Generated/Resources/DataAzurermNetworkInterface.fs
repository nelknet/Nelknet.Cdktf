namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface">azurerm_network_interface</a>.
    /// </summary>
    type DataAzurermNetworkInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkInterfaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkInterfaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkInterfaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkInterfaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface#name-1">DataAzurermNetworkInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetworkInterfaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNetworkInterfaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkInterfaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface#resource_group_name-1">DataAzurermNetworkInterface#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetworkInterfaceState<'Name, Missing>, value: string) : DataAzurermNetworkInterfaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkInterfaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface#id-1">DataAzurermNetworkInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_interface#timeouts-1">DataAzurermNetworkInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterfaceTimeouts) : DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkInterfaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetworkInterfaceState<Present, Present>) : azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterface =
            let config = azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterfaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkInterface: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkInterfaceState<_, _>) : azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterface =
            Unchecked.defaultof<azurerm.DataAzurermNetworkInterface.DataAzurermNetworkInterface>
