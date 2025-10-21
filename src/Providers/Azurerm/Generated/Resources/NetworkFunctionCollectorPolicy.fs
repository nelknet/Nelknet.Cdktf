namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId> = { assignments: ResizeArray<azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy">azurerm_network_function_collector_policy</a>.
    /// </summary>
    type NetworkFunctionCollectorPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkFunctionCollectorPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkFunctionCollectorPolicyState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkFunctionCollectorPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkFunctionCollectorPolicyState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// ipfx_emission block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#ipfx_emission-1">NetworkFunctionCollectorPolicy#ipfx_emission</a>
        /// </summary>
        [<CustomOperation "ipfx_emission">]
        member _.IpfxEmission(state: NetworkFunctionCollectorPolicyState<Missing, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>, value: azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxEmission) : NetworkFunctionCollectorPolicyState<Present, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.IpfxEmission <- value)
            ({ assignments = state.assignments } : NetworkFunctionCollectorPolicyState<Present, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>)

        /// <summary>
        /// ipfx_ingestion block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#ipfx_ingestion-1">NetworkFunctionCollectorPolicy#ipfx_ingestion</a>
        /// </summary>
        [<CustomOperation "ipfx_ingestion">]
        member _.IpfxIngestion(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, Missing, 'Location, 'Name, 'TrafficCollectorId>, value: azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyIpfxIngestion) : NetworkFunctionCollectorPolicyState<'IpfxEmission, Present, 'Location, 'Name, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.IpfxIngestion <- value)
            ({ assignments = state.assignments } : NetworkFunctionCollectorPolicyState<'IpfxEmission, Present, 'Location, 'Name, 'TrafficCollectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#location-1">NetworkFunctionCollectorPolicy#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, Missing, 'Name, 'TrafficCollectorId>, value: string) : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, Present, 'Name, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, Present, 'Name, 'TrafficCollectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#name-1">NetworkFunctionCollectorPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, Missing, 'TrafficCollectorId>, value: string) : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, Present, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, Present, 'TrafficCollectorId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#traffic_collector_id-1">NetworkFunctionCollectorPolicy#traffic_collector_id</a>.
        /// </summary>
        [<CustomOperation "traffic_collector_id">]
        member _.TrafficCollectorId(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, Missing>, value: string) : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.TrafficCollectorId <- value)
            ({ assignments = state.assignments } : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#id-1">NetworkFunctionCollectorPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>, value: string) : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#tags-1">NetworkFunctionCollectorPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>, value: seq<string * string>) : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_collector_policy#timeouts-1">NetworkFunctionCollectorPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>, value: azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyTimeouts) : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkFunctionCollectorPolicyState<'IpfxEmission, 'IpfxIngestion, 'Location, 'Name, 'TrafficCollectorId>

        member _.Run(state: NetworkFunctionCollectorPolicyState<Present, Present, Present, Present, Present>) : azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy =
            let config = azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkFunctionCollectorPolicy: missing required arguments. Must call: ipfx_emission, ipfx_ingestion, location, name, traffic_collector_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkFunctionCollectorPolicyState<_, _, _, _, _>) : azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy =
            Unchecked.defaultof<azurerm.NetworkFunctionCollectorPolicy.NetworkFunctionCollectorPolicy>
