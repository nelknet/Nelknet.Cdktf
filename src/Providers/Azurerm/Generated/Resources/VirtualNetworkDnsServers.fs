namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualNetworkDnsServersState<'VirtualNetworkId> = { assignments: ResizeArray<azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_dns_servers">azurerm_virtual_network_dns_servers</a>.
    /// </summary>
    type VirtualNetworkDnsServersBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualNetworkDnsServersState<Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkDnsServersState<Missing>)

        member _.Zero(()) : VirtualNetworkDnsServersState<Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkDnsServersState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_dns_servers#virtual_network_id-1">VirtualNetworkDnsServers#virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_id">]
        member _.VirtualNetworkId(state: VirtualNetworkDnsServersState<Missing>, value: string) : VirtualNetworkDnsServersState<Present> =
            state.assignments.Add(fun config -> config.VirtualNetworkId <- value)
            ({ assignments = state.assignments } : VirtualNetworkDnsServersState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_dns_servers#dns_servers-1">VirtualNetworkDnsServers#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: VirtualNetworkDnsServersState<'VirtualNetworkId>, value: seq<string>) : VirtualNetworkDnsServersState<'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : VirtualNetworkDnsServersState<'VirtualNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_dns_servers#id-1">VirtualNetworkDnsServers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualNetworkDnsServersState<'VirtualNetworkId>, value: string) : VirtualNetworkDnsServersState<'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualNetworkDnsServersState<'VirtualNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_dns_servers#timeouts-1">VirtualNetworkDnsServers#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualNetworkDnsServersState<'VirtualNetworkId>, value: azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServersTimeouts) : VirtualNetworkDnsServersState<'VirtualNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualNetworkDnsServersState<'VirtualNetworkId>

        member _.Run(state: VirtualNetworkDnsServersState<Present>) : azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServers =
            let config = azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServersConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServers(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualNetworkDnsServers: missing required arguments. Must call: virtual_network_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualNetworkDnsServersState<_>) : azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServers =
            Unchecked.defaultof<azurerm.VirtualNetworkDnsServers.VirtualNetworkDnsServers>
