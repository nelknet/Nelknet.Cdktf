namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId> = { assignments: ResizeArray<azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl">azurerm_web_pubsub_network_acl</a>.
    /// </summary>
    type WebPubsubNetworkAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebPubsubNetworkAclState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubNetworkAclState<Missing, Missing>)

        member _.Zero(()) : WebPubsubNetworkAclState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubNetworkAclState<Missing, Missing>)

        /// <summary>
        /// public_network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#public_network-1">WebPubsubNetworkAcl#public_network</a>
        /// </summary>
        [<CustomOperation "public_network">]
        member _.PublicNetwork(state: WebPubsubNetworkAclState<Missing, 'WebPubsubId>, value: azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAclPublicNetwork) : WebPubsubNetworkAclState<Present, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.PublicNetwork <- value)
            ({ assignments = state.assignments } : WebPubsubNetworkAclState<Present, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#web_pubsub_id-1">WebPubsubNetworkAcl#web_pubsub_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_id">]
        member _.WebPubsubId(state: WebPubsubNetworkAclState<'PublicNetwork, Missing>, value: string) : WebPubsubNetworkAclState<'PublicNetwork, Present> =
            state.assignments.Add(fun config -> config.WebPubsubId <- value)
            ({ assignments = state.assignments } : WebPubsubNetworkAclState<'PublicNetwork, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#default_action-1">WebPubsubNetworkAcl#default_action</a>.
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>, value: string) : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            state : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#id-1">WebPubsubNetworkAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>, value: string) : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>

        /// <summary>
        /// private_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#private_endpoint-1">WebPubsubNetworkAcl#private_endpoint</a> Accepts: azurerm.IResolvable | azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAclPrivateEndpoint[]
        /// </summary>
        [<CustomOperation "private_endpoint">]
        member _.PrivateEndpoint(state: WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>, value: HashiCorp.Cdktf.IResolvable) : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.PrivateEndpoint <- value)
            state : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#timeouts-1">WebPubsubNetworkAcl#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>, value: azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAclTimeouts) : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebPubsubNetworkAclState<'PublicNetwork, 'WebPubsubId>

        member _.Run(state: WebPubsubNetworkAclState<Present, Present>) : azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAcl =
            let config = azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAclConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webPubsubNetworkAcl: missing required arguments. Must call: public_network, web_pubsub_id.", 9999, IsError = true)>]
        member _.Run(_: WebPubsubNetworkAclState<_, _>) : azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAcl =
            Unchecked.defaultof<azurerm.WebPubsubNetworkAcl.WebPubsubNetworkAcl>
