namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> = { assignments: ResizeArray<azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_network_group">azurerm_network_manager_network_group</a>.
    /// </summary>
    type NetworkManagerNetworkGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerNetworkGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerNetworkGroupState<Missing, Missing>)

        member _.Zero(()) : NetworkManagerNetworkGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerNetworkGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_network_group#name-1">NetworkManagerNetworkGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerNetworkGroupState<Missing, 'NetworkManagerId>, value: string) : NetworkManagerNetworkGroupState<Present, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerNetworkGroupState<Present, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_network_group#network_manager_id-1">NetworkManagerNetworkGroup#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerNetworkGroupState<'Name, Missing>, value: string) : NetworkManagerNetworkGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerNetworkGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_network_group#description-1">NetworkManagerNetworkGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>, value: string) : NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_network_group#id-1">NetworkManagerNetworkGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>, value: string) : NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_network_group#timeouts-1">NetworkManagerNetworkGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>, value: azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroupTimeouts) : NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>

        member _.Run(state: NetworkManagerNetworkGroupState<Present, Present>) : azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroup =
            let config = azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerNetworkGroup: missing required arguments. Must call: name, network_manager_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerNetworkGroupState<_, _>) : azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroup =
            Unchecked.defaultof<azurerm.NetworkManagerNetworkGroup.NetworkManagerNetworkGroup>
