namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy">azurerm_mobile_network_sim_policy</a>.
    /// </summary>
    type DataAzurermMobileNetworkSimPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMobileNetworkSimPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSimPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMobileNetworkSimPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMobileNetworkSimPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy#mobile_network_id-1">DataAzurermMobileNetworkSimPolicy#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: DataAzurermMobileNetworkSimPolicyState<Missing, 'Name>, value: string) : DataAzurermMobileNetworkSimPolicyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSimPolicyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy#name-1">DataAzurermMobileNetworkSimPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, Missing>, value: string) : DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy#id-1">DataAzurermMobileNetworkSimPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name>, value: string) : DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_sim_policy#timeouts-1">DataAzurermMobileNetworkSimPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name>, value: azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyTimeouts) : DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMobileNetworkSimPolicyState<'MobileNetworkId, 'Name>

        member _.Run(state: DataAzurermMobileNetworkSimPolicyState<Present, Present>) : azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy =
            let config = azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMobileNetworkSimPolicy: missing required arguments. Must call: mobile_network_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMobileNetworkSimPolicyState<_, _>) : azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy =
            Unchecked.defaultof<azurerm.DataAzurermMobileNetworkSimPolicy.DataAzurermMobileNetworkSimPolicy>
