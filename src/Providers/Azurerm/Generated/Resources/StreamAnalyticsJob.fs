namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> = { assignments: ResizeArray<azurerm.StreamAnalyticsJob.StreamAnalyticsJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job">azurerm_stream_analytics_job</a>.
    /// </summary>
    type StreamAnalyticsJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsJobState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsJobState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsJobState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsJobState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#location-1">StreamAnalyticsJob#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StreamAnalyticsJobState<Missing, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<Present, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StreamAnalyticsJobState<Present, 'Name, 'ResourceGroupName, 'TransformationQuery>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#name-1">StreamAnalyticsJob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsJobState<'Location, Missing, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, Present, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsJobState<'Location, Present, 'ResourceGroupName, 'TransformationQuery>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#resource_group_name-1">StreamAnalyticsJob#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsJobState<'Location, 'Name, Missing, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, Present, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsJobState<'Location, 'Name, Present, 'TransformationQuery>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#transformation_query-1">StreamAnalyticsJob#transformation_query</a>.
        /// </summary>
        [<CustomOperation "transformation_query">]
        member _.TransformationQuery(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.TransformationQuery <- value)
            ({ assignments = state.assignments } : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#compatibility_level-1">StreamAnalyticsJob#compatibility_level</a>.
        /// </summary>
        [<CustomOperation "compatibility_level">]
        member _.CompatibilityLevel(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.CompatibilityLevel <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#content_storage_policy-1">StreamAnalyticsJob#content_storage_policy</a>.
        /// </summary>
        [<CustomOperation "content_storage_policy">]
        member _.ContentStoragePolicy(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.ContentStoragePolicy <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#data_locale-1">StreamAnalyticsJob#data_locale</a>.
        /// </summary>
        [<CustomOperation "data_locale">]
        member _.DataLocale(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.DataLocale <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#events_late_arrival_max_delay_in_seconds-1">StreamAnalyticsJob#events_late_arrival_max_delay_in_seconds</a>.
        /// </summary>
        [<CustomOperation "events_late_arrival_max_delay_in_seconds">]
        member _.EventsLateArrivalMaxDelayInSeconds(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: double) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.EventsLateArrivalMaxDelayInSeconds <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#events_out_of_order_max_delay_in_seconds-1">StreamAnalyticsJob#events_out_of_order_max_delay_in_seconds</a>.
        /// </summary>
        [<CustomOperation "events_out_of_order_max_delay_in_seconds">]
        member _.EventsOutOfOrderMaxDelayInSeconds(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: double) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.EventsOutOfOrderMaxDelayInSeconds <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#events_out_of_order_policy-1">StreamAnalyticsJob#events_out_of_order_policy</a>.
        /// </summary>
        [<CustomOperation "events_out_of_order_policy">]
        member _.EventsOutOfOrderPolicy(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.EventsOutOfOrderPolicy <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#id-1">StreamAnalyticsJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#identity-1">StreamAnalyticsJob#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: azurerm.StreamAnalyticsJob.StreamAnalyticsJobIdentity) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// job_storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#job_storage_account-1">StreamAnalyticsJob#job_storage_account</a> Accepts: azurerm.IResolvable | azurerm.StreamAnalyticsJob.StreamAnalyticsJobJobStorageAccount[]
        /// </summary>
        [<CustomOperation "job_storage_account">]
        member _.JobStorageAccount(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: HashiCorp.Cdktf.IResolvable) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.JobStorageAccount <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#output_error_policy-1">StreamAnalyticsJob#output_error_policy</a>.
        /// </summary>
        [<CustomOperation "output_error_policy">]
        member _.OutputErrorPolicy(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.OutputErrorPolicy <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#sku_name-1">StreamAnalyticsJob#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#stream_analytics_cluster_id-1">StreamAnalyticsJob#stream_analytics_cluster_id</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_cluster_id">]
        member _.StreamAnalyticsClusterId(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.StreamAnalyticsClusterId <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#streaming_units-1">StreamAnalyticsJob#streaming_units</a>.
        /// </summary>
        [<CustomOperation "streaming_units">]
        member _.StreamingUnits(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: double) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.StreamingUnits <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#tags-1">StreamAnalyticsJob#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: seq<string * string>) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#timeouts-1">StreamAnalyticsJob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: azurerm.StreamAnalyticsJob.StreamAnalyticsJobTimeouts) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_job#type-1">StreamAnalyticsJob#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>, value: string) : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : StreamAnalyticsJobState<'Location, 'Name, 'ResourceGroupName, 'TransformationQuery>

        member _.Run(state: StreamAnalyticsJobState<Present, Present, Present, Present>) : azurerm.StreamAnalyticsJob.StreamAnalyticsJob =
            let config = azurerm.StreamAnalyticsJob.StreamAnalyticsJobConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsJob.StreamAnalyticsJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsJob: missing required arguments. Must call: location, name, resource_group_name, transformation_query.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsJobState<_, _, _, _>) : azurerm.StreamAnalyticsJob.StreamAnalyticsJob =
            Unchecked.defaultof<azurerm.StreamAnalyticsJob.StreamAnalyticsJob>
