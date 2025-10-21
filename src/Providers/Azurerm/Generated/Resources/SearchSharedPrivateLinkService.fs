namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId> = { assignments: ResizeArray<azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service">azurerm_search_shared_private_link_service</a>.
    /// </summary>
    type SearchSharedPrivateLinkServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SearchSharedPrivateLinkServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SearchSharedPrivateLinkServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SearchSharedPrivateLinkServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SearchSharedPrivateLinkServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#name-1">SearchSharedPrivateLinkService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SearchSharedPrivateLinkServiceState<Missing, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>, value: string) : SearchSharedPrivateLinkServiceState<Present, 'SearchServiceId, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SearchSharedPrivateLinkServiceState<Present, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#search_service_id-1">SearchSharedPrivateLinkService#search_service_id</a>.
        /// </summary>
        [<CustomOperation "search_service_id">]
        member _.SearchServiceId(state: SearchSharedPrivateLinkServiceState<'Name, Missing, 'SubresourceName, 'TargetResourceId>, value: string) : SearchSharedPrivateLinkServiceState<'Name, Present, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SearchServiceId <- value)
            ({ assignments = state.assignments } : SearchSharedPrivateLinkServiceState<'Name, Present, 'SubresourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#subresource_name-1">SearchSharedPrivateLinkService#subresource_name</a>.
        /// </summary>
        [<CustomOperation "subresource_name">]
        member _.SubresourceName(state: SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, Missing, 'TargetResourceId>, value: string) : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SubresourceName <- value)
            ({ assignments = state.assignments } : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#target_resource_id-1">SearchSharedPrivateLinkService#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, Missing>, value: string) : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#id-1">SearchSharedPrivateLinkService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>, value: string) : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#request_message-1">SearchSharedPrivateLinkService#request_message</a>.
        /// </summary>
        [<CustomOperation "request_message">]
        member _.RequestMessage(state: SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>, value: string) : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.RequestMessage <- value)
            state : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_shared_private_link_service#timeouts-1">SearchSharedPrivateLinkService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>, value: azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkServiceTimeouts) : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SearchSharedPrivateLinkServiceState<'Name, 'SearchServiceId, 'SubresourceName, 'TargetResourceId>

        member _.Run(state: SearchSharedPrivateLinkServiceState<Present, Present, Present, Present>) : azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkService =
            let config = azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.searchSharedPrivateLinkService: missing required arguments. Must call: name, search_service_id, subresource_name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: SearchSharedPrivateLinkServiceState<_, _, _, _>) : azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkService =
            Unchecked.defaultof<azurerm.SearchSharedPrivateLinkService.SearchSharedPrivateLinkService>
