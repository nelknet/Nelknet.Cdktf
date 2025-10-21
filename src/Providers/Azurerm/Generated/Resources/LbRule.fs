namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> = { assignments: ResizeArray<azurerm.LbRule.LbRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule">azurerm_lb_rule</a>.
    /// </summary>
    type LbRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LbRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#backend_port-1">LbRule#backend_port</a>.
        /// </summary>
        [<CustomOperation "backend_port">]
        member _.BackendPort(state: LbRuleState<Missing, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: double) : LbRuleState<Present, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.BackendPort <- value)
            ({ assignments = state.assignments } : LbRuleState<Present, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#frontend_ip_configuration_name-1">LbRule#frontend_ip_configuration_name</a>.
        /// </summary>
        [<CustomOperation "frontend_ip_configuration_name">]
        member _.FrontendIpConfigurationName(state: LbRuleState<'BackendPort, Missing, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: string) : LbRuleState<'BackendPort, Present, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.FrontendIpConfigurationName <- value)
            ({ assignments = state.assignments } : LbRuleState<'BackendPort, Present, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#frontend_port-1">LbRule#frontend_port</a>.
        /// </summary>
        [<CustomOperation "frontend_port">]
        member _.FrontendPort(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, Missing, 'LoadbalancerId, 'Name, 'Protocol>, value: double) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, Present, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.FrontendPort <- value)
            ({ assignments = state.assignments } : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, Present, 'LoadbalancerId, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#loadbalancer_id-1">LbRule#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, Missing, 'Name, 'Protocol>, value: string) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, Present, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, Present, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#name-1">LbRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, Missing, 'Protocol>, value: string) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, Present, 'Protocol> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, Present, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#protocol-1">LbRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, Missing>, value: string) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#backend_address_pool_ids-1">LbRule#backend_address_pool_ids</a>.
        /// </summary>
        [<CustomOperation "backend_address_pool_ids">]
        member _.BackendAddressPoolIds(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: seq<string>) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.BackendAddressPoolIds <- (value |> Seq.toArray))
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#disable_outbound_snat-1">LbRule#disable_outbound_snat</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_outbound_snat">]
        member _.DisableOutboundSnat(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: bool) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.DisableOutboundSnat <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#disable_outbound_snat-1">LbRule#disable_outbound_snat</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_outbound_snat">]
        member _.DisableOutboundSnat(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.DisableOutboundSnat <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#enable_floating_ip-1">LbRule#enable_floating_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_floating_ip">]
        member _.EnableFloatingIp(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: bool) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.EnableFloatingIp <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#enable_floating_ip-1">LbRule#enable_floating_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_floating_ip">]
        member _.EnableFloatingIp(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.EnableFloatingIp <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#enable_tcp_reset-1">LbRule#enable_tcp_reset</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_tcp_reset">]
        member _.EnableTcpReset(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: bool) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.EnableTcpReset <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#enable_tcp_reset-1">LbRule#enable_tcp_reset</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_tcp_reset">]
        member _.EnableTcpReset(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.EnableTcpReset <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#id-1">LbRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: string) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#idle_timeout_in_minutes-1">LbRule#idle_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_timeout_in_minutes">]
        member _.IdleTimeoutInMinutes(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: double) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.IdleTimeoutInMinutes <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#load_distribution-1">LbRule#load_distribution</a>.
        /// </summary>
        [<CustomOperation "load_distribution">]
        member _.LoadDistribution(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: string) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.LoadDistribution <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#probe_id-1">LbRule#probe_id</a>.
        /// </summary>
        [<CustomOperation "probe_id">]
        member _.ProbeId(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: string) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.ProbeId <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_rule#timeouts-1">LbRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>, value: azurerm.LbRule.LbRuleTimeouts) : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbRuleState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPort, 'LoadbalancerId, 'Name, 'Protocol>

        member _.Run(state: LbRuleState<Present, Present, Present, Present, Present, Present>) : azurerm.LbRule.LbRule =
            let config = azurerm.LbRule.LbRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbRule.LbRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbRule: missing required arguments. Must call: backend_port, frontend_ip_configuration_name, frontend_port, loadbalancer_id, name, protocol.", 9999, IsError = true)>]
        member _.Run(_: LbRuleState<_, _, _, _, _, _>) : azurerm.LbRule.LbRule =
            Unchecked.defaultof<azurerm.LbRule.LbRule>
