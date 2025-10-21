namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LbNatPool.LbNatPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool">azurerm_lb_nat_pool</a>.
    /// </summary>
    type LbNatPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbNatPoolState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbNatPoolState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LbNatPoolState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbNatPoolState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#backend_port-1">LbNatPool#backend_port</a>.
        /// </summary>
        [<CustomOperation "backend_port">]
        member _.BackendPort(state: LbNatPoolState<Missing, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatPoolState<Present, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackendPort <- value)
            ({ assignments = state.assignments } : LbNatPoolState<Present, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#frontend_ip_configuration_name-1">LbNatPool#frontend_ip_configuration_name</a>.
        /// </summary>
        [<CustomOperation "frontend_ip_configuration_name">]
        member _.FrontendIpConfigurationName(state: LbNatPoolState<'BackendPort, Missing, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatPoolState<'BackendPort, Present, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendIpConfigurationName <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, Present, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#frontend_port_end-1">LbNatPool#frontend_port_end</a>.
        /// </summary>
        [<CustomOperation "frontend_port_end">]
        member _.FrontendPortEnd(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, Missing, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, Present, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendPortEnd <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, Present, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#frontend_port_start-1">LbNatPool#frontend_port_start</a>.
        /// </summary>
        [<CustomOperation "frontend_port_start">]
        member _.FrontendPortStart(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, Missing, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, Present, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FrontendPortStart <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, Present, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#loadbalancer_id-1">LbNatPool#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, Missing, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, Present, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, Present, 'Name, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#name-1">LbNatPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, Missing, 'Protocol, 'ResourceGroupName>, value: string) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, Present, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, Present, 'Protocol, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#protocol-1">LbNatPool#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, Missing, 'ResourceGroupName>, value: string) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#resource_group_name-1">LbNatPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, Missing>, value: string) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#floating_ip_enabled-1">LbNatPool#floating_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "floating_ip_enabled">]
        member _.FloatingIpEnabled(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: bool) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FloatingIpEnabled <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#floating_ip_enabled-1">LbNatPool#floating_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "floating_ip_enabled">]
        member _.FloatingIpEnabled(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FloatingIpEnabled <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#id-1">LbNatPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: string) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#idle_timeout_in_minutes-1">LbNatPool#idle_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_timeout_in_minutes">]
        member _.IdleTimeoutInMinutes(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: double) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdleTimeoutInMinutes <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#tcp_reset_enabled-1">LbNatPool#tcp_reset_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tcp_reset_enabled">]
        member _.TcpResetEnabled(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: bool) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TcpResetEnabled <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#tcp_reset_enabled-1">LbNatPool#tcp_reset_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tcp_reset_enabled">]
        member _.TcpResetEnabled(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TcpResetEnabled <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_nat_pool#timeouts-1">LbNatPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>, value: azurerm.LbNatPool.LbNatPoolTimeouts) : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbNatPoolState<'BackendPort, 'FrontendIpConfigurationName, 'FrontendPortEnd, 'FrontendPortStart, 'LoadbalancerId, 'Name, 'Protocol, 'ResourceGroupName>

        member _.Run(state: LbNatPoolState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.LbNatPool.LbNatPool =
            let config = azurerm.LbNatPool.LbNatPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbNatPool.LbNatPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbNatPool: missing required arguments. Must call: backend_port, frontend_ip_configuration_name, frontend_port_end, frontend_port_start, loadbalancer_id, name, protocol, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LbNatPoolState<_, _, _, _, _, _, _, _>) : azurerm.LbNatPool.LbNatPool =
            Unchecked.defaultof<azurerm.LbNatPool.LbNatPool>
