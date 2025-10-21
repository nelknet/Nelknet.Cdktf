namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group">azurerm_mobile_network_sim_group</a>.
    /// </summary>
    type DataAzurermMobileNetworkSimGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkSimGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSimGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkSimGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSimGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group#mobile_network_id-1">DataAzurermMobileNetworkSimGroup#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: DataAzurermMobileNetworkSimGroupState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkSimGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSimGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group#name-1">DataAzurermMobileNetworkSimGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, Missing>, value: string) : DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group#id-1">DataAzurermMobileNetworkSimGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name>, value: string) : DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_group#timeouts-1">DataAzurermMobileNetworkSimGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name>, value: azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroupTimeouts) : DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkSimGroupState<'MobileNetworkId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkSimGroupState<Present, Present>) : azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroup =
            let config = azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkSimGroup: missing required arguments. Must call: mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkSimGroupState<_, _>) : azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroup =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkSimGroup.DataAzurermMobileNetworkSimGroup>
