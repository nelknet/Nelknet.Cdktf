namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> = { assignments: ResizeArray<azurerm.LbOutboundRule.LbOutboundRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule">azurerm_lb_outbound_rule</a>.
    /// </summary>
    type LbOutboundRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbOutboundRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbOutboundRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LbOutboundRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbOutboundRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#backend_address_pool_id-1">LbOutboundRule#backend_address_pool_id</a>.
        /// </summary>
        [<CustomOperation "backend_address_pool_id">]
        member _.BackendAddressPoolId(state: LbOutboundRuleState<Missing, 'LoadbalancerId, 'Name, 'Protocol>, value: string) : LbOutboundRuleState<Present, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.BackendAddressPoolId <- value)
            ({ assignments = state.assignments } : LbOutboundRuleState<Present, 'LoadbalancerId, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#loadbalancer_id-1">LbOutboundRule#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: LbOutboundRuleState<'BackendAddressPoolId, Missing, 'Name, 'Protocol>, value: string) : LbOutboundRuleState<'BackendAddressPoolId, Present, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : LbOutboundRuleState<'BackendAddressPoolId, Present, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#name-1">LbOutboundRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, Missing, 'Protocol>, value: string) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, Present, 'Protocol> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, Present, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#protocol-1">LbOutboundRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, Missing>, value: string) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#allocated_outbound_ports-1">LbOutboundRule#allocated_outbound_ports</a>.
        /// </summary>
        [<CustomOperation "allocated_outbound_ports">]
        member _.AllocatedOutboundPorts(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: double) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.AllocatedOutboundPorts <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#enable_tcp_reset-1">LbOutboundRule#enable_tcp_reset</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_tcp_reset">]
        member _.EnableTcpReset(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: bool) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.EnableTcpReset <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#enable_tcp_reset-1">LbOutboundRule#enable_tcp_reset</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_tcp_reset">]
        member _.EnableTcpReset(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.EnableTcpReset <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// frontend_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#frontend_ip_configuration-1">LbOutboundRule#frontend_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.LbOutboundRule.LbOutboundRuleFrontendIpConfiguration[]
        /// </summary>
        [<CustomOperation "frontend_ip_configuration">]
        member _.FrontendIpConfiguration(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.FrontendIpConfiguration <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#id-1">LbOutboundRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: string) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#idle_timeout_in_minutes-1">LbOutboundRule#idle_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_timeout_in_minutes">]
        member _.IdleTimeoutInMinutes(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: double) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.IdleTimeoutInMinutes <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#timeouts-1">LbOutboundRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>, value: azurerm.LbOutboundRule.LbOutboundRuleTimeouts) : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbOutboundRuleState<'BackendAddressPoolId, 'LoadbalancerId, 'Name, 'Protocol>

        member _.Run(state: LbOutboundRuleState<Present, Present, Present, Present>) : azurerm.LbOutboundRule.LbOutboundRule =
            let config = azurerm.LbOutboundRule.LbOutboundRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbOutboundRule.LbOutboundRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbOutboundRule: missing required arguments. Must call: backend_address_pool_id, loadbalancer_id, name, protocol.", 9999, IsError = true)>]
        member _.Run(_: LbOutboundRuleState<_, _, _, _>) : azurerm.LbOutboundRule.LbOutboundRule =
            Unchecked.defaultof<azurerm.LbOutboundRule.LbOutboundRule>
