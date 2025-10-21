namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId> = { assignments: ResizeArray<azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource">azurerm_signalr_shared_private_link_resource</a>.
    /// </summary>
    type SignalrSharedPrivateLinkResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignalrSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SignalrSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignalrSharedPrivateLinkResourceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#name-1">SignalrSharedPrivateLinkResource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SignalrSharedPrivateLinkResourceState<Missing, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>, value: string) : SignalrSharedPrivateLinkResourceState<Present, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SignalrSharedPrivateLinkResourceState<Present, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#signalr_service_id-1">SignalrSharedPrivateLinkResource#signalr_service_id</a>.
        /// </summary>
        [<CustomOperation "signalr_service_id">]
        member _.SignalrServiceId(state: SignalrSharedPrivateLinkResourceState<'Name, Missing, 'SubResourceName, 'TargetResourceId>, value: string) : SignalrSharedPrivateLinkResourceState<'Name, Present, 'SubResourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SignalrServiceId <- value)
            ({ assignments = state.assignments } : SignalrSharedPrivateLinkResourceState<'Name, Present, 'SubResourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#sub_resource_name-1">SignalrSharedPrivateLinkResource#sub_resource_name</a>.
        /// </summary>
        [<CustomOperation "sub_resource_name">]
        member _.SubResourceName(state: SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, Missing, 'TargetResourceId>, value: string) : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SubResourceName <- value)
            ({ assignments = state.assignments } : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#target_resource_id-1">SignalrSharedPrivateLinkResource#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, Missing>, value: string) : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#id-1">SignalrSharedPrivateLinkResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>, value: string) : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#request_message-1">SignalrSharedPrivateLinkResource#request_message</a>.
        /// </summary>
        [<CustomOperation "request_message">]
        member _.RequestMessage(state: SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>, value: string) : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.RequestMessage <- value)
            state : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_shared_private_link_resource#timeouts-1">SignalrSharedPrivateLinkResource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>, value: azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResourceTimeouts) : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SignalrSharedPrivateLinkResourceState<'Name, 'SignalrServiceId, 'SubResourceName, 'TargetResourceId>

        member _.Run(state: SignalrSharedPrivateLinkResourceState<Present, Present, Present, Present>) : azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResource =
            let config = azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResourceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.signalrSharedPrivateLinkResource: missing required arguments. Must call: name, signalr_service_id, sub_resource_name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: SignalrSharedPrivateLinkResourceState<_, _, _, _>) : azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResource =
            Unchecked.defaultof<azurerm.SignalrSharedPrivateLinkResource.SignalrSharedPrivateLinkResource>
