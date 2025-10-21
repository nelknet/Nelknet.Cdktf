namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId> = { assignments: ResizeArray<azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl">azurerm_signalr_service_network_acl</a>.
    /// </summary>
    type SignalrServiceNetworkAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignalrServiceNetworkAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceNetworkAclState<Missing, Missing, Missing>)

        member _.Zero(()) : SignalrServiceNetworkAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrServiceNetworkAclState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#default_action-1">SignalrServiceNetworkAcl#default_action</a>.
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: SignalrServiceNetworkAclState<Missing, 'PublicNetwork, 'SignalrServiceId>, value: string) : SignalrServiceNetworkAclState<Present, 'PublicNetwork, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : SignalrServiceNetworkAclState<Present, 'PublicNetwork, 'SignalrServiceId>)

        /// <summary>
        /// public_network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#public_network-1">SignalrServiceNetworkAcl#public_network</a>
        /// </summary>
        [<CustomOperation "public_network">]
        member _.PublicNetwork(state: SignalrServiceNetworkAclState<'DefaultAction, Missing, 'SignalrServiceId>, value: azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetwork) : SignalrServiceNetworkAclState<'DefaultAction, Present, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.PublicNetwork <- value)
            ({ assignments = state.assignments } : SignalrServiceNetworkAclState<'DefaultAction, Present, 'SignalrServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#signalr_service_id-1">SignalrServiceNetworkAcl#signalr_service_id</a>.
        /// </summary>
        [<CustomOperation "signalr_service_id">]
        member _.SignalrServiceId(state: SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, Missing>, value: string) : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, Present> =
            state.assignments.Add(fun config -> config.SignalrServiceId <- value)
            ({ assignments = state.assignments } : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#id-1">SignalrServiceNetworkAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId>, value: string) : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId>

        /// <summary>
        /// private_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#private_endpoint-1">SignalrServiceNetworkAcl#private_endpoint</a> Accepts: azurerm.IResolvable | azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclPrivateEndpoint[]
        /// </summary>
        [<CustomOperation "private_endpoint">]
        member _.PrivateEndpoint(state: SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId>, value: HashiCorp.Cdktf.IResolvable) : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.PrivateEndpoint <- value)
            state : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#timeouts-1">SignalrServiceNetworkAcl#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId>, value: azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclTimeouts) : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SignalrServiceNetworkAclState<'DefaultAction, 'PublicNetwork, 'SignalrServiceId>

        member _.Run(state: SignalrServiceNetworkAclState<Present, Present, Present>) : azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl =
            let config = azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAclConfig()
            for setter in state.assignments do
                setter config
            azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.signalrServiceNetworkAcl: missing required arguments. Must call: default_action, public_network, signalr_service_id.", 9999, IsError = true)>]
        member _.Run(_: SignalrServiceNetworkAclState<_, _, _>) : azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl =
            Unchecked.defaultof<azurerm.SignalrServiceNetworkAcl.SignalrServiceNetworkAcl>
