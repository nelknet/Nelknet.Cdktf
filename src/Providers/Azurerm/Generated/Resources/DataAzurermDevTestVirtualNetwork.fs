namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network">azurerm_dev_test_virtual_network</a>.
    /// </summary>
    type DataAzurermDevTestVirtualNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDevTestVirtualNetworkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDevTestVirtualNetworkState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDevTestVirtualNetworkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDevTestVirtualNetworkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#lab_name-1">DataAzurermDevTestVirtualNetwork#lab_name</a>.
        /// </summary>
        [<CustomOperation "lab_name">]
        member _.LabName(state: DataAzurermDevTestVirtualNetworkState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermDevTestVirtualNetworkState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LabName <- value)
            ({ assignments = state.assignments } : DataAzurermDevTestVirtualNetworkState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#name-1">DataAzurermDevTestVirtualNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDevTestVirtualNetworkState<'LabName, Missing, 'ResourceGroupName>, value: string) : DataAzurermDevTestVirtualNetworkState<'LabName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDevTestVirtualNetworkState<'LabName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#resource_group_name-1">DataAzurermDevTestVirtualNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, Missing>, value: string) : DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#id-1">DataAzurermDevTestVirtualNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_virtual_network#timeouts-1">DataAzurermDevTestVirtualNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkTimeouts) : DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDevTestVirtualNetworkState<'LabName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDevTestVirtualNetworkState<Present, Present, Present>) : azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork =
            let config = azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDevTestVirtualNetwork: missing required arguments. Must call: lab_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDevTestVirtualNetworkState<_, _, _>) : azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork =
            Unchecked.defaultof<azurerm.DataAzurermDevTestVirtualNetwork.DataAzurermDevTestVirtualNetwork>
