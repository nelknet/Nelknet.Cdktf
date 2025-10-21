namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbBackendAddressPoolState<'LoadbalancerId, 'Name> = { assignments: ResizeArray<azurerm.LbBackendAddressPool.LbBackendAddressPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool">azurerm_lb_backend_address_pool</a>.
    /// </summary>
    type LbBackendAddressPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbBackendAddressPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbBackendAddressPoolState<Missing, Missing>)

        member _.Zero(()) : LbBackendAddressPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbBackendAddressPoolState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#loadbalancer_id-1">LbBackendAddressPool#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: LbBackendAddressPoolState<Missing, 'Name>, value: string) : LbBackendAddressPoolState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : LbBackendAddressPoolState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#name-1">LbBackendAddressPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbBackendAddressPoolState<'LoadbalancerId, Missing>, value: string) : LbBackendAddressPoolState<'LoadbalancerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbBackendAddressPoolState<'LoadbalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#id-1">LbBackendAddressPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: string) : LbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbBackendAddressPoolState<'LoadbalancerId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#synchronous_mode-1">LbBackendAddressPool#synchronous_mode</a>.
        /// </summary>
        [<CustomOperation "synchronous_mode">]
        member _.SynchronousMode(state: LbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: string) : LbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.SynchronousMode <- value)
            state : LbBackendAddressPoolState<'LoadbalancerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#timeouts-1">LbBackendAddressPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: azurerm.LbBackendAddressPool.LbBackendAddressPoolTimeouts) : LbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbBackendAddressPoolState<'LoadbalancerId, 'Name>

        /// <summary>
        /// tunnel_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#tunnel_interface-1">LbBackendAddressPool#tunnel_interface</a> Accepts: azurerm.IResolvable | azurerm.LbBackendAddressPool.LbBackendAddressPoolTunnelInterface[]
        /// </summary>
        [<CustomOperation "tunnel_interface">]
        member _.TunnelInterface(state: LbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.TunnelInterface <- value)
            state : LbBackendAddressPoolState<'LoadbalancerId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#virtual_network_id-1">LbBackendAddressPool#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: LbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: string) : LbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            state : LbBackendAddressPoolState<'LoadbalancerId, 'Name>

        member _.Run(state: LbBackendAddressPoolState<Present, Present>) : azurerm.LbBackendAddressPool.LbBackendAddressPool =
            let config = azurerm.LbBackendAddressPool.LbBackendAddressPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbBackendAddressPool.LbBackendAddressPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbBackendAddressPool: missing required arguments. Must call: loadbalancer_id, name.", 9999, IsError = true)>]
        member _.Run(_: LbBackendAddressPoolState<_, _>) : azurerm.LbBackendAddressPool.LbBackendAddressPool =
            Unchecked.defaultof<azurerm.LbBackendAddressPool.LbBackendAddressPool>
