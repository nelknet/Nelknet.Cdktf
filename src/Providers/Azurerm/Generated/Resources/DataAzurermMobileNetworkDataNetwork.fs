namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network">azurerm_mobile_network_data_network</a>.
    /// </summary>
    type DataAzurermMobileNetworkDataNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkDataNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkDataNetworkState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkDataNetworkState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkDataNetworkState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#mobile_network_id-1">DataAzurermMobileNetworkDataNetwork#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: DataAzurermMobileNetworkDataNetworkState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkDataNetworkState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkDataNetworkState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#name-1">DataAzurermMobileNetworkDataNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, Missing>, value: string) : DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#id-1">DataAzurermMobileNetworkDataNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name>, value: string) : DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#timeouts-1">DataAzurermMobileNetworkDataNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name>, value: azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetworkTimeouts) : DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkDataNetworkState<'MobileNetworkId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkDataNetworkState<Present, Present>) : azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetwork =
            let config = azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkDataNetwork: missing required arguments. Must call: mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkDataNetworkState<_, _>) : azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetwork =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetwork>
