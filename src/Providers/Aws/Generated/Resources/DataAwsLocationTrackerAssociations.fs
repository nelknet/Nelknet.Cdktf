namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationTrackerAssociationsState<'TrackerName> = { assignments: ResizeArray<aws.DataAwsLocationTrackerAssociations.DataAwsLocationTrackerAssociationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_associations">aws_location_tracker_associations</a>.
    /// </summary>
    type DataAwsLocationTrackerAssociationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationTrackerAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationTrackerAssociationsState<Missing>)

        member _.Zero(()) : DataAwsLocationTrackerAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationTrackerAssociationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_associations#tracker_name-1">DataAwsLocationTrackerAssociations#tracker_name</a>.
        /// </summary>
        [<CustomOperation "tracker_name">]
        member _.TrackerName(state: DataAwsLocationTrackerAssociationsState<Missing>, value: string) : DataAwsLocationTrackerAssociationsState<Present> =
            state.assignments.Add(fun config -> config.TrackerName <- value)
            ({ assignments = state.assignments } : DataAwsLocationTrackerAssociationsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_associations#id-1">DataAwsLocationTrackerAssociations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationTrackerAssociationsState<'TrackerName>, value: string) : DataAwsLocationTrackerAssociationsState<'TrackerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationTrackerAssociationsState<'TrackerName>

        member _.Run(state: DataAwsLocationTrackerAssociationsState<Present>) : aws.DataAwsLocationTrackerAssociations.DataAwsLocationTrackerAssociations =
            let config = aws.DataAwsLocationTrackerAssociations.DataAwsLocationTrackerAssociationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationTrackerAssociations.DataAwsLocationTrackerAssociations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationTrackerAssociations: missing required arguments. Must call: tracker_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationTrackerAssociationsState<_>) : aws.DataAwsLocationTrackerAssociations.DataAwsLocationTrackerAssociations =
            Unchecked.defaultof<aws.DataAwsLocationTrackerAssociations.DataAwsLocationTrackerAssociations>
