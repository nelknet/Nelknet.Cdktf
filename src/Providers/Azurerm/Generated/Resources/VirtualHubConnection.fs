namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId> = { assignments: ResizeArray<azurerm.VirtualHubConnection.VirtualHubConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection">azurerm_virtual_hub_connection</a>.
    /// </summary>
    type VirtualHubConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#name-1">VirtualHubConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubConnectionState<Missing, 'RemoteVirtualNetworkId, 'VirtualHubId>, value: string) : VirtualHubConnectionState<Present, 'RemoteVirtualNetworkId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubConnectionState<Present, 'RemoteVirtualNetworkId, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#remote_virtual_network_id-1">VirtualHubConnection#remote_virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "remote_virtual_network_id">]
        member _.RemoteVirtualNetworkId(state: VirtualHubConnectionState<'Name, Missing, 'VirtualHubId>, value: string) : VirtualHubConnectionState<'Name, Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.RemoteVirtualNetworkId <- value)
            ({ assignments = state.assignments } : VirtualHubConnectionState<'Name, Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#virtual_hub_id-1">VirtualHubConnection#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, Missing>, value: string) : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#id-1">VirtualHubConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>, value: string) : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#internet_security_enabled-1">VirtualHubConnection#internet_security_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_security_enabled">]
        member _.InternetSecurityEnabled(state: VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>, value: bool) : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.InternetSecurityEnabled <- value)
            state : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#internet_security_enabled-1">VirtualHubConnection#internet_security_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_security_enabled">]
        member _.InternetSecurityEnabled(state: VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>, value: HashiCorp.Cdktf.IResolvable) : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.InternetSecurityEnabled <- value)
            state : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>

        /// <summary>
        /// routing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#routing-1">VirtualHubConnection#routing</a>
        /// </summary>
        [<CustomOperation "routing">]
        member _.Routing(state: VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>, value: azurerm.VirtualHubConnection.VirtualHubConnectionRouting) : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Routing <- value)
            state : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_connection#timeouts-1">VirtualHubConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>, value: azurerm.VirtualHubConnection.VirtualHubConnectionTimeouts) : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubConnectionState<'Name, 'RemoteVirtualNetworkId, 'VirtualHubId>

        member _.Run(state: VirtualHubConnectionState<Present, Present, Present>) : azurerm.VirtualHubConnection.VirtualHubConnection =
            let config = azurerm.VirtualHubConnection.VirtualHubConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubConnection.VirtualHubConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubConnection: missing required arguments. Must call: name, remote_virtual_network_id, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubConnectionState<_, _, _>) : azurerm.VirtualHubConnection.VirtualHubConnection =
            Unchecked.defaultof<azurerm.VirtualHubConnection.VirtualHubConnection>
