namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector">azurerm_network_function_azure_traffic_collector</a>.
    /// </summary>
    type NetworkFunctionAzureTrafficCollectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkFunctionAzureTrafficCollectorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkFunctionAzureTrafficCollectorState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkFunctionAzureTrafficCollectorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkFunctionAzureTrafficCollectorState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector#location-1">NetworkFunctionAzureTrafficCollector#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkFunctionAzureTrafficCollectorState<Missing, 'Name, 'ResourceGroupName>, value: string) : NetworkFunctionAzureTrafficCollectorState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkFunctionAzureTrafficCollectorState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector#name-1">NetworkFunctionAzureTrafficCollector#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkFunctionAzureTrafficCollectorState<'Location, Missing, 'ResourceGroupName>, value: string) : NetworkFunctionAzureTrafficCollectorState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkFunctionAzureTrafficCollectorState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector#resource_group_name-1">NetworkFunctionAzureTrafficCollector#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, Missing>, value: string) : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector#id-1">NetworkFunctionAzureTrafficCollector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector#tags-1">NetworkFunctionAzureTrafficCollector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_function_azure_traffic_collector#timeouts-1">NetworkFunctionAzureTrafficCollector#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollectorTimeouts) : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkFunctionAzureTrafficCollectorState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetworkFunctionAzureTrafficCollectorState<Present, Present, Present>) : azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollector =
            let config = azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollectorConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkFunctionAzureTrafficCollector: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkFunctionAzureTrafficCollectorState<_, _, _>) : azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollector =
            Unchecked.defaultof<azurerm.NetworkFunctionAzureTrafficCollector.NetworkFunctionAzureTrafficCollector>
