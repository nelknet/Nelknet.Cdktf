namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSliceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice">azurerm_mobile_network_slice</a>.
    /// </summary>
    type DataAzurermMobileNetworkSliceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkSliceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSliceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkSliceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSliceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice#mobile_network_id-1">DataAzurermMobileNetworkSlice#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: DataAzurermMobileNetworkSliceState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkSliceState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSliceState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice#name-1">DataAzurermMobileNetworkSlice#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkSliceState<'MobileNetworkId, Missing>, value: string) : DataAzurermMobileNetworkSliceState<'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSliceState<'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice#id-1">DataAzurermMobileNetworkSlice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name>, value: string) : DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_slice#timeouts-1">DataAzurermMobileNetworkSlice#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name>, value: azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSliceTimeouts) : DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkSliceState<'MobileNetworkId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkSliceState<Present, Present>) : azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSlice =
            let config = azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSliceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSlice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkSlice: missing required arguments. Must call: mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkSliceState<_, _>) : azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSlice =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkSlice.DataAzurermMobileNetworkSlice>
