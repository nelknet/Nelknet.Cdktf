namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSimConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim">azurerm_mobile_network_sim</a>.
    /// </summary>
    type DataAzurermMobileNetworkSimBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkSimState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSimState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkSimState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSimState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim#mobile_network_sim_group_id-1">DataAzurermMobileNetworkSim#mobile_network_sim_group_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_sim_group_id">]
        member _.MobileNetworkSimGroupId(state: DataAzurermMobileNetworkSimState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkSimState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkSimGroupId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSimState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim#name-1">DataAzurermMobileNetworkSim#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, Missing>, value: string) : DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim#id-1">DataAzurermMobileNetworkSim#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name>, value: string) : DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim#timeouts-1">DataAzurermMobileNetworkSim#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name>, value: azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSimTimeouts) : DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkSimState<'MobileNetworkSimGroupId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkSimState<Present, Present>) : azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSim =
            let config = azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSimConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSim(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkSim: missing required arguments. Must call: mobile_network_sim_group_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkSimState<_, _>) : azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSim =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkSim.DataAzurermMobileNetworkSim>
