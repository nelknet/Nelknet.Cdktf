namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LbNatRule.LbNatRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule">azurerm_lb_nat_rule</a>.
    /// </summary>
    type LbNatRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbNatRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbNatRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LbNatRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbNatRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#backend_port-1">LbNatRule#backend_port</a>.
        /// </summary>
        [<CustomOperation "backend_port">]
        member _.BackendPort(state: LbNatRuleState<Missing, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatRuleState<Present, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendPort <- value)
            ({ assignments = state.assignments } : LbNatRuleState<Present, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#frontend_ip_configuration_name-1">LbNatRule#frontend_ip_configuration_name</a>.
        /// </summary>
        [<CustomOperation "frontend_ip_configuration_name">]
        member _.FrontendIpConfigurationName(state: LbNatRuleState<'BackendPort, Missing, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatRuleState<'BackendPort, Present, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendIpConfigurationName <- value)
            ({ assignments = state.assignments } : LbNatRuleState<'BackendPort, Present, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#loadbalancer_id-1">LbNatRule#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, Missing, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, Present, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, Present, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#name-1">LbNatRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, Missing, 'Protocol, 'ResourceGroupName>, value: string) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, Present, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, Present, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#protocol-1">LbNatRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, Missing, 'ResourceGroupName>, value: string) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#resource_group_name-1">LbNatRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, Missing>, value: string) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#backend_address_pool_id-1">LbNatRule#backend_address_pool_id</a>.
        /// </summary>
        [<CustomOperation "backend_address_pool_id">]
        member _.BackendAddressPoolId(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendAddressPoolId <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#enable_floating_ip-1">LbNatRule#enable_floating_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_floating_ip">]
        member _.EnableFloatingIp(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: bool) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableFloatingIp <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#enable_floating_ip-1">LbNatRule#enable_floating_ip</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_floating_ip">]
        member _.EnableFloatingIp(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableFloatingIp <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#enable_tcp_reset-1">LbNatRule#enable_tcp_reset</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_tcp_reset">]
        member _.EnableTcpReset(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: bool) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableTcpReset <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#enable_tcp_reset-1">LbNatRule#enable_tcp_reset</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_tcp_reset">]
        member _.EnableTcpReset(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableTcpReset <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#frontend_port-1">LbNatRule#frontend_port</a>.
        /// </summary>
        [<CustomOperation "frontend_port">]
        member _.FrontendPort(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendPort <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#frontend_port_end-1">LbNatRule#frontend_port_end</a>.
        /// </summary>
        [<CustomOperation "frontend_port_end">]
        member _.FrontendPortEnd(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendPortEnd <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#frontend_port_start-1">LbNatRule#frontend_port_start</a>.
        /// </summary>
        [<CustomOperation "frontend_port_start">]
        member _.FrontendPortStart(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendPortStart <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#id-1">LbNatRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#idle_timeout_in_minutes-1">LbNatRule#idle_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_timeout_in_minutes">]
        member _.IdleTimeoutInMinutes(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdleTimeoutInMinutes <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_rule#timeouts-1">LbNatRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: azurerm.LbNatRule.LbNatRuleTimeouts) : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbNatRuleState<'BackendPort, 'FrontendIpConfigurationName, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        member _.Run(state: LbNatRuleState<Present, Present, Present, Present, Present, Present>) : azurerm.LbNatRule.LbNatRule =
            let config = azurerm.LbNatRule.LbNatRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbNatRule.LbNatRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbNatRule: missing required arguments. Must call: backend_port, frontend_ip_configuration_name, loadbalancer_id, name, protocol, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LbNatRuleState<_, _, _, _, _, _>) : azurerm.LbNatRule.LbNatRule =
            Unchecked.defaultof<azurerm.LbNatRule.LbNatRule>
