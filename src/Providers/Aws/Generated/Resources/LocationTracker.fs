namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocationTrackerState<'TrackerName> = { assignments: ResizeArray<aws.LocationTracker.LocationTrackerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker">aws_location_tracker</a>.
    /// </summary>
    type LocationTrackerBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocationTrackerState<Missing> =
            ({ assignments = ResizeArray() } : LocationTrackerState<Missing>)

        member _.Zero(()) : LocationTrackerState<Missing> =
            ({ assignments = ResizeArray() } : LocationTrackerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#tracker_name-1">LocationTracker#tracker_name</a>.
        /// </summary>
        [<CustomOperation "tracker_name">]
        member _.TrackerName(state: LocationTrackerState<Missing>, value: string) : LocationTrackerState<Present> =
            state.assignments.Add(fun config -> config.TrackerName <- value)
            ({ assignments = state.assignments } : LocationTrackerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#description-1">LocationTracker#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LocationTrackerState<'TrackerName>, value: string) : LocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LocationTrackerState<'TrackerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#id-1">LocationTracker#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocationTrackerState<'TrackerName>, value: string) : LocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocationTrackerState<'TrackerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#kms_key_id-1">LocationTracker#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: LocationTrackerState<'TrackerName>, value: string) : LocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : LocationTrackerState<'TrackerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#position_filtering-1">LocationTracker#position_filtering</a>.
        /// </summary>
        [<CustomOperation "position_filtering">]
        member _.PositionFiltering(state: LocationTrackerState<'TrackerName>, value: string) : LocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.PositionFiltering <- value)
            state : LocationTrackerState<'TrackerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#tags-1">LocationTracker#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LocationTrackerState<'TrackerName>, value: seq<string * string>) : LocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LocationTrackerState<'TrackerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker#tags_all-1">LocationTracker#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LocationTrackerState<'TrackerName>, value: seq<string * string>) : LocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LocationTrackerState<'TrackerName>

        member _.Run(state: LocationTrackerState<Present>) : aws.LocationTracker.LocationTracker =
            let config = aws.LocationTracker.LocationTrackerConfig()
            for setter in state.assignments do
                setter config
            aws.LocationTracker.LocationTracker(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.locationTracker: missing required arguments. Must call: tracker_name.", 9999, IsError = true)>]
        member _.Run(_: LocationTrackerState<_>) : aws.LocationTracker.LocationTracker =
            Unchecked.defaultof<aws.LocationTracker.LocationTracker>
