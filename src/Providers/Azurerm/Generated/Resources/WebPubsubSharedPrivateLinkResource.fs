namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId> = { assignments: ResizeArray<azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource">azurerm_web_pubsub_shared_private_link_resource</a>.
    /// </summary>
    type WebPubsubSharedPrivateLinkResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebPubsubSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WebPubsubSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebPubsubSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#name-1">WebPubsubSharedPrivateLinkResource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WebPubsubSharedPrivateLinkResourceState<Missing, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>, value: string) : WebPubsubSharedPrivateLinkResourceState<Present, 'SubresourceName, 'TargetResourceId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WebPubsubSharedPrivateLinkResourceState<Present, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#subresource_name-1">WebPubsubSharedPrivateLinkResource#subresource_name</a>.
        /// </summary>
        [<CustomOperation "subresource_name">]
        member _.SubresourceName(state: WebPubsubSharedPrivateLinkResourceState<'Name, Missing, 'TargetResourceId, 'WebPubsubId>, value: string) : WebPubsubSharedPrivateLinkResourceState<'Name, Present, 'TargetResourceId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.SubresourceName <- value)
            ({ assignments = state.assignments } : WebPubsubSharedPrivateLinkResourceState<'Name, Present, 'TargetResourceId, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#target_resource_id-1">WebPubsubSharedPrivateLinkResource#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, Missing, 'WebPubsubId>, value: string) : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, Present, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, Present, 'WebPubsubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#web_pubsub_id-1">WebPubsubSharedPrivateLinkResource#web_pubsub_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_id">]
        member _.WebPubsubId(state: WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, Missing>, value: string) : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, Present> =
            state.assignments.Add(fun config -> config.WebPubsubId <- value)
            ({ assignments = state.assignments } : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#id-1">WebPubsubSharedPrivateLinkResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>, value: string) : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#request_message-1">WebPubsubSharedPrivateLinkResource#request_message</a>.
        /// </summary>
        [<CustomOperation "request_message">]
        member _.RequestMessage(state: WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>, value: string) : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.RequestMessage <- value)
            state : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_shared_private_link_resource#timeouts-1">WebPubsubSharedPrivateLinkResource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>, value: azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResourceTimeouts) : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebPubsubSharedPrivateLinkResourceState<'Name, 'SubresourceName, 'TargetResourceId, 'WebPubsubId>

        member _.Run(state: WebPubsubSharedPrivateLinkResourceState<Present, Present, Present, Present>) : azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResource =
            let config = azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResourceConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webPubsubSharedPrivateLinkResource: missing required arguments. Must call: name, subresource_name, target_resource_id, web_pubsub_id.", 9999, IsError = true)>]
        member _.Run(_: WebPubsubSharedPrivateLinkResourceState<_, _, _, _>) : azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResource =
            Unchecked.defaultof<azurerm.WebPubsubSharedPrivateLinkResource.WebPubsubSharedPrivateLinkResource>
