namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name> = { assignments: ResizeArray<azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddressConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address">azurerm_lb_backend_address_pool_address</a>.
    /// </summary>
    type LbBackendAddressPoolAddressBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbBackendAddressPoolAddressState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbBackendAddressPoolAddressState<Missing, Missing>)

        member _.Zero(()) : LbBackendAddressPoolAddressState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbBackendAddressPoolAddressState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#backend_address_pool_id-1">LbBackendAddressPoolAddress#backend_address_pool_id</a>.
        /// </summary>
        [<CustomOperation "backend_address_pool_id">]
        member _.BackendAddressPoolId(state: LbBackendAddressPoolAddressState<Missing, 'Name>, value: string) : LbBackendAddressPoolAddressState<Present, 'Name> =
            state.assignments.Add(fun config -> config.BackendAddressPoolId <- value)
            ({ assignments = state.assignments } : LbBackendAddressPoolAddressState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#name-1">LbBackendAddressPoolAddress#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbBackendAddressPoolAddressState<'BackendAddressPoolId, Missing>, value: string) : LbBackendAddressPoolAddressState<'BackendAddressPoolId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbBackendAddressPoolAddressState<'BackendAddressPoolId, Present>)

        /// <summary>
        /// For global load balancer, user needs to specify the `backend_address_ip_configuration_id` of the added regional load balancers. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#backend_address_ip_configuration_id-1">LbBackendAddressPoolAddress#backend_address_ip_configuration_id</a>
        /// </summary>
        [<CustomOperation "backend_address_ip_configuration_id">]
        member _.BackendAddressIpConfigurationId(state: LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>, value: string) : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name> =
            state.assignments.Add(fun config -> config.BackendAddressIpConfigurationId <- value)
            state : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#id-1">LbBackendAddressPoolAddress#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>, value: string) : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#ip_address-1">LbBackendAddressPoolAddress#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>, value: string) : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#timeouts-1">LbBackendAddressPoolAddress#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>, value: azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddressTimeouts) : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool_address#virtual_network_id-1">LbBackendAddressPoolAddress#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>, value: string) : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            state : LbBackendAddressPoolAddressState<'BackendAddressPoolId, 'Name>

        member _.Run(state: LbBackendAddressPoolAddressState<Present, Present>) : azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddress =
            let config = azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddressConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddress(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbBackendAddressPoolAddress: missing required arguments. Must call: backend_address_pool_id, name.", 9999, IsError = true)>]
        member _.Run(_: LbBackendAddressPoolAddressState<_, _>) : azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddress =
            Unchecked.defaultof<azurerm.LbBackendAddressPoolAddress.LbBackendAddressPoolAddress>
