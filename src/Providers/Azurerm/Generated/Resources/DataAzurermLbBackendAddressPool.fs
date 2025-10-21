namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool">azurerm_lb_backend_address_pool</a>.
    /// </summary>
    type DataAzurermLbBackendAddressPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLbBackendAddressPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLbBackendAddressPoolState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLbBackendAddressPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLbBackendAddressPoolState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#loadbalancer_id-1">DataAzurermLbBackendAddressPool#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: DataAzurermLbBackendAddressPoolState<Missing, 'Name>, value: string) : DataAzurermLbBackendAddressPoolState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : DataAzurermLbBackendAddressPoolState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#name-1">DataAzurermLbBackendAddressPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLbBackendAddressPoolState<'LoadbalancerId, Missing>, value: string) : DataAzurermLbBackendAddressPoolState<'LoadbalancerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLbBackendAddressPoolState<'LoadbalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#id-1">DataAzurermLbBackendAddressPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: string) : DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_backend_address_pool#timeouts-1">DataAzurermLbBackendAddressPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name>, value: azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPoolTimeouts) : DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLbBackendAddressPoolState<'LoadbalancerId, 'Name>

        member _.Run(state: DataAzurermLbBackendAddressPoolState<Present, Present>) : azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPool =
            let config = azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLbBackendAddressPool: missing required arguments. Must call: loadbalancer_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLbBackendAddressPoolState<_, _>) : azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPool =
            Unchecked.defaultof<azurerm.DataAzurermLbBackendAddressPool.DataAzurermLbBackendAddressPool>
