namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermFirewallState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermFirewall.DataAzurermFirewallConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall">azurerm_firewall</a>.
    /// </summary>
    type DataAzurermFirewallBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermFirewallState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFirewallState<Missing, Missing>)

        member _.Zero(()) : DataAzurermFirewallState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFirewallState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#name-1">DataAzurermFirewall#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermFirewallState<Missing, 'ResourceGroupName>, value: string) : DataAzurermFirewallState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermFirewallState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#resource_group_name-1">DataAzurermFirewall#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermFirewallState<'Name, Missing>, value: string) : DataAzurermFirewallState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermFirewallState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#dns_proxy_enabled-1">DataAzurermFirewall#dns_proxy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_proxy_enabled">]
        member _.DnsProxyEnabled(state: DataAzurermFirewallState<'Name, 'ResourceGroupName>, value: bool) : DataAzurermFirewallState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsProxyEnabled <- value)
            state : DataAzurermFirewallState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#dns_proxy_enabled-1">DataAzurermFirewall#dns_proxy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_proxy_enabled">]
        member _.DnsProxyEnabled(state: DataAzurermFirewallState<'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermFirewallState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsProxyEnabled <- value)
            state : DataAzurermFirewallState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#id-1">DataAzurermFirewall#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermFirewallState<'Name, 'ResourceGroupName>, value: string) : DataAzurermFirewallState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermFirewallState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall#timeouts-1">DataAzurermFirewall#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermFirewallState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermFirewall.DataAzurermFirewallTimeouts) : DataAzurermFirewallState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermFirewallState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermFirewallState<Present, Present>) : azurerm.DataAzurermFirewall.DataAzurermFirewall =
            let config = azurerm.DataAzurermFirewall.DataAzurermFirewallConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermFirewall.DataAzurermFirewall(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermFirewall: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermFirewallState<_, _>) : azurerm.DataAzurermFirewall.DataAzurermFirewall =
            Unchecked.defaultof<azurerm.DataAzurermFirewall.DataAzurermFirewall>
