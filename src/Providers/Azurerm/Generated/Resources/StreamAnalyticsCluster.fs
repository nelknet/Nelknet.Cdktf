namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity> = { assignments: ResizeArray<azurerm.StreamAnalyticsCluster.StreamAnalyticsClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster">azurerm_stream_analytics_cluster</a>.
    /// </summary>
    type StreamAnalyticsClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#location-1">StreamAnalyticsCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StreamAnalyticsClusterState<Missing, 'Name, 'ResourceGroupName, 'StreamingCapacity>, value: string) : StreamAnalyticsClusterState<Present, 'Name, 'ResourceGroupName, 'StreamingCapacity> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StreamAnalyticsClusterState<Present, 'Name, 'ResourceGroupName, 'StreamingCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#name-1">StreamAnalyticsCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsClusterState<'Location, Missing, 'ResourceGroupName, 'StreamingCapacity>, value: string) : StreamAnalyticsClusterState<'Location, Present, 'ResourceGroupName, 'StreamingCapacity> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsClusterState<'Location, Present, 'ResourceGroupName, 'StreamingCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#resource_group_name-1">StreamAnalyticsCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsClusterState<'Location, 'Name, Missing, 'StreamingCapacity>, value: string) : StreamAnalyticsClusterState<'Location, 'Name, Present, 'StreamingCapacity> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsClusterState<'Location, 'Name, Present, 'StreamingCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#streaming_capacity-1">StreamAnalyticsCluster#streaming_capacity</a>.
        /// </summary>
        [<CustomOperation "streaming_capacity">]
        member _.StreamingCapacity(state: StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, Missing>, value: double) : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StreamingCapacity <- value)
            ({ assignments = state.assignments } : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#id-1">StreamAnalyticsCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity>, value: string) : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#tags-1">StreamAnalyticsCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity>, value: seq<string * string>) : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_cluster#timeouts-1">StreamAnalyticsCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity>, value: azurerm.StreamAnalyticsCluster.StreamAnalyticsClusterTimeouts) : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsClusterState<'Location, 'Name, 'ResourceGroupName, 'StreamingCapacity>

        member _.Run(state: StreamAnalyticsClusterState<Present, Present, Present, Present>) : azurerm.StreamAnalyticsCluster.StreamAnalyticsCluster =
            let config = azurerm.StreamAnalyticsCluster.StreamAnalyticsClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsCluster.StreamAnalyticsCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsCluster: missing required arguments. Must call: location, name, resource_group_name, streaming_capacity.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsClusterState<_, _, _, _>) : azurerm.StreamAnalyticsCluster.StreamAnalyticsCluster =
            Unchecked.defaultof<azurerm.StreamAnalyticsCluster.StreamAnalyticsCluster>
