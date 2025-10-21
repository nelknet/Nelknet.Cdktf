namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName> = { assignments: ResizeArray<azurerm.DataAzurermSubnet.DataAzurermSubnetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subnet">azurerm_subnet</a>.
    /// </summary>
    type DataAzurermSubnetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSubnetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSubnetState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSubnetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSubnetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subnet#name-1">DataAzurermSubnet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSubnetState<Missing, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : DataAzurermSubnetState<Present, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSubnetState<Present, 'ResourceGroupName, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subnet#resource_group_name-1">DataAzurermSubnet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSubnetState<'Name, Missing, 'VirtualNetworkName>, value: string) : DataAzurermSubnetState<'Name, Present, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSubnetState<'Name, Present, 'VirtualNetworkName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subnet#virtual_network_name-1">DataAzurermSubnet#virtual_network_name</a>.
        /// </summary>
        [<CustomOperation "virtual_network_name">]
        member _.VirtualNetworkName(state: DataAzurermSubnetState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermSubnetState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkName <- value)
            ({ assignments = state.assignments } : DataAzurermSubnetState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subnet#id-1">DataAzurermSubnet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: string) : DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subnet#timeouts-1">DataAzurermSubnet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName>, value: azurerm.DataAzurermSubnet.DataAzurermSubnetTimeouts) : DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSubnetState<'Name, 'ResourceGroupName, 'VirtualNetworkName>

        member _.Run(state: DataAzurermSubnetState<Present, Present, Present>) : azurerm.DataAzurermSubnet.DataAzurermSubnet =
            let config = azurerm.DataAzurermSubnet.DataAzurermSubnetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSubnet.DataAzurermSubnet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSubnet: missing required arguments. Must call: name, resource_group_name, virtual_network_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSubnetState<_, _, _>) : azurerm.DataAzurermSubnet.DataAzurermSubnet =
            Unchecked.defaultof<azurerm.DataAzurermSubnet.DataAzurermSubnet>
