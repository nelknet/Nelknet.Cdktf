namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_service">azurerm_mobile_network_service</a>.
    /// </summary>
    type DataAzurermMobileNetworkServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_service#mobile_network_id-1">DataAzurermMobileNetworkService#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: DataAzurermMobileNetworkServiceState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkServiceState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkServiceState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_service#name-1">DataAzurermMobileNetworkService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkServiceState<'MobileNetworkId, Missing>, value: string) : DataAzurermMobileNetworkServiceState<'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkServiceState<'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_service#id-1">DataAzurermMobileNetworkService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name>, value: string) : DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_service#timeouts-1">DataAzurermMobileNetworkService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name>, value: azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceTimeouts) : DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkServiceState<'MobileNetworkId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkServiceState<Present, Present>) : azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkService =
            let config = azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkService: missing required arguments. Must call: mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkServiceState<_, _>) : azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkService =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkService.DataAzurermMobileNetworkService>
