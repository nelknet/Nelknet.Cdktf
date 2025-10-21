namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network">azurerm_mobile_network</a>.
    /// </summary>
    type DataAzurermMobileNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network#name-1">DataAzurermMobileNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMobileNetworkState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network#resource_group_name-1">DataAzurermMobileNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMobileNetworkState<'Name, Missing>, value: string) : DataAzurermMobileNetworkState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network#id-1">DataAzurermMobileNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMobileNetworkState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network#timeouts-1">DataAzurermMobileNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetworkTimeouts) : DataAzurermMobileNetworkState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMobileNetworkState<Present, Present>) : azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetwork =
            let config = azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetwork: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkState<_, _>) : azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetwork =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetwork.DataAzurermMobileNetwork>
