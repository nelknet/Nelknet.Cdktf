namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId> = { assignments: ResizeArray<azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint">azurerm_stream_analytics_managed_private_endpoint</a>.
    /// </summary>
    type StreamAnalyticsManagedPrivateEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#name-1">StreamAnalyticsManagedPrivateEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsManagedPrivateEndpointState<Missing, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>, value: string) : StreamAnalyticsManagedPrivateEndpointState<Present, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsManagedPrivateEndpointState<Present, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#resource_group_name-1">StreamAnalyticsManagedPrivateEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsManagedPrivateEndpointState<'Name, Missing, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>, value: string) : StreamAnalyticsManagedPrivateEndpointState<'Name, Present, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsManagedPrivateEndpointState<'Name, Present, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#stream_analytics_cluster_name-1">StreamAnalyticsManagedPrivateEndpoint#stream_analytics_cluster_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_cluster_name">]
        member _.StreamAnalyticsClusterName(state: StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, Missing, 'SubresourceName, 'TargetResourceId>, value: string) : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, Present, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.StreamAnalyticsClusterName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, Present, 'SubresourceName, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#subresource_name-1">StreamAnalyticsManagedPrivateEndpoint#subresource_name</a>.
        /// </summary>
        [<CustomOperation "subresource_name">]
        member _.SubresourceName(state: StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, Missing, 'TargetResourceId>, value: string) : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.SubresourceName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#target_resource_id-1">StreamAnalyticsManagedPrivateEndpoint#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, Missing>, value: string) : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#id-1">StreamAnalyticsManagedPrivateEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>, value: string) : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_managed_private_endpoint#timeouts-1">StreamAnalyticsManagedPrivateEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>, value: azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpointTimeouts) : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsManagedPrivateEndpointState<'Name, 'ResourceGroupName, 'StreamAnalyticsClusterName, 'SubresourceName, 'TargetResourceId>

        member _.Run(state: StreamAnalyticsManagedPrivateEndpointState<Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpoint =
            let config = azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsManagedPrivateEndpoint: missing required arguments. Must call: name, resource_group_name, stream_analytics_cluster_name, subresource_name, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsManagedPrivateEndpointState<_, _, _, _, _>) : azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpoint =
            Unchecked.defaultof<azurerm.StreamAnalyticsManagedPrivateEndpoint.StreamAnalyticsManagedPrivateEndpoint>
