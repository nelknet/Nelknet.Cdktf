namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId> = { assignments: ResizeArray<azurerm.NetworkManagerStaticMember.NetworkManagerStaticMemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_static_member">azurerm_network_manager_static_member</a>.
    /// </summary>
    type NetworkManagerStaticMemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerStaticMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerStaticMemberState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerStaticMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerStaticMemberState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_static_member#name-1">NetworkManagerStaticMember#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerStaticMemberState<Missing, 'NetworkGroupId, 'TargetVirtualNetworkId>, value: string) : NetworkManagerStaticMemberState<Present, 'NetworkGroupId, 'TargetVirtualNetworkId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerStaticMemberState<Present, 'NetworkGroupId, 'TargetVirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_static_member#network_group_id-1">NetworkManagerStaticMember#network_group_id</a>.
        /// </summary>
        [<CustomOperation "network_group_id">]
        member _.NetworkGroupId(state: NetworkManagerStaticMemberState<'Name, Missing, 'TargetVirtualNetworkId>, value: string) : NetworkManagerStaticMemberState<'Name, Present, 'TargetVirtualNetworkId> =
            state.assignments.Add(fun config -> config.NetworkGroupId <- value)
            ({ assignments = state.assignments } : NetworkManagerStaticMemberState<'Name, Present, 'TargetVirtualNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_static_member#target_virtual_network_id-1">NetworkManagerStaticMember#target_virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "target_virtual_network_id">]
        member _.TargetVirtualNetworkId(state: NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, Missing>, value: string) : NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, Present> =
            state.assignments.Add(fun config -> config.TargetVirtualNetworkId <- value)
            ({ assignments = state.assignments } : NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_static_member#id-1">NetworkManagerStaticMember#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId>, value: string) : NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_static_member#timeouts-1">NetworkManagerStaticMember#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId>, value: azurerm.NetworkManagerStaticMember.NetworkManagerStaticMemberTimeouts) : NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerStaticMemberState<'Name, 'NetworkGroupId, 'TargetVirtualNetworkId>

        member _.Run(state: NetworkManagerStaticMemberState<Present, Present, Present>) : azurerm.NetworkManagerStaticMember.NetworkManagerStaticMember =
            let config = azurerm.NetworkManagerStaticMember.NetworkManagerStaticMemberConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerStaticMember.NetworkManagerStaticMember(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerStaticMember: missing required arguments. Must call: name, network_group_id, target_virtual_network_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerStaticMemberState<_, _, _>) : azurerm.NetworkManagerStaticMember.NetworkManagerStaticMember =
            Unchecked.defaultof<azurerm.NetworkManagerStaticMember.NetworkManagerStaticMember>
