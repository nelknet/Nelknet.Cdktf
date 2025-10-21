namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationTrackerState<'TrackerName> = { assignments: ResizeArray<aws.DataAwsLocationTracker.DataAwsLocationTrackerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker">aws_location_tracker</a>.
    /// </summary>
    type DataAwsLocationTrackerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationTrackerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationTrackerState<Missing>)

        member _.Zero(()) : DataAwsLocationTrackerState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationTrackerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker#tracker_name-1">DataAwsLocationTracker#tracker_name</a>.
        /// </summary>
        [<CustomOperation "tracker_name">]
        member _.TrackerName(state: DataAwsLocationTrackerState<Missing>, value: string) : DataAwsLocationTrackerState<Present> =
            state.assignments.Add(fun config -> config.TrackerName <- value)
            ({ assignments = state.assignments } : DataAwsLocationTrackerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker#id-1">DataAwsLocationTracker#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationTrackerState<'TrackerName>, value: string) : DataAwsLocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationTrackerState<'TrackerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker#tags-1">DataAwsLocationTracker#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLocationTrackerState<'TrackerName>, value: seq<string * string>) : DataAwsLocationTrackerState<'TrackerName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLocationTrackerState<'TrackerName>

        member _.Run(state: DataAwsLocationTrackerState<Present>) : aws.DataAwsLocationTracker.DataAwsLocationTracker =
            let config = aws.DataAwsLocationTracker.DataAwsLocationTrackerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationTracker.DataAwsLocationTracker(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationTracker: missing required arguments. Must call: tracker_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationTrackerState<_>) : aws.DataAwsLocationTracker.DataAwsLocationTracker =
            Unchecked.defaultof<aws.DataAwsLocationTracker.DataAwsLocationTracker>
