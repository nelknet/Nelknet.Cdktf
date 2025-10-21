namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocationTrackerAssociationState<'ConsumerArn, 'TrackerName> = { assignments: ResizeArray<aws.LocationTrackerAssociation.LocationTrackerAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker_association">aws_location_tracker_association</a>.
    /// </summary>
    type LocationTrackerAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocationTrackerAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationTrackerAssociationState<Missing, Missing>)

        member _.Zero(()) : LocationTrackerAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationTrackerAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker_association#consumer_arn-1">LocationTrackerAssociation#consumer_arn</a>.
        /// </summary>
        [<CustomOperation "consumer_arn">]
        member _.ConsumerArn(state: LocationTrackerAssociationState<Missing, 'TrackerName>, value: string) : LocationTrackerAssociationState<Present, 'TrackerName> =
            state.assignments.Add(fun config -> config.ConsumerArn <- value)
            ({ assignments = state.assignments } : LocationTrackerAssociationState<Present, 'TrackerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker_association#tracker_name-1">LocationTrackerAssociation#tracker_name</a>.
        /// </summary>
        [<CustomOperation "tracker_name">]
        member _.TrackerName(state: LocationTrackerAssociationState<'ConsumerArn, Missing>, value: string) : LocationTrackerAssociationState<'ConsumerArn, Present> =
            state.assignments.Add(fun config -> config.TrackerName <- value)
            ({ assignments = state.assignments } : LocationTrackerAssociationState<'ConsumerArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker_association#id-1">LocationTrackerAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocationTrackerAssociationState<'ConsumerArn, 'TrackerName>, value: string) : LocationTrackerAssociationState<'ConsumerArn, 'TrackerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocationTrackerAssociationState<'ConsumerArn, 'TrackerName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_tracker_association#timeouts-1">LocationTrackerAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LocationTrackerAssociationState<'ConsumerArn, 'TrackerName>, value: aws.LocationTrackerAssociation.LocationTrackerAssociationTimeouts) : LocationTrackerAssociationState<'ConsumerArn, 'TrackerName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LocationTrackerAssociationState<'ConsumerArn, 'TrackerName>

        member _.Run(state: LocationTrackerAssociationState<Present, Present>) : aws.LocationTrackerAssociation.LocationTrackerAssociation =
            let config = aws.LocationTrackerAssociation.LocationTrackerAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.LocationTrackerAssociation.LocationTrackerAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.locationTrackerAssociation: missing required arguments. Must call: consumer_arn, tracker_name.", 9999, IsError = true)>]
        member _.Run(_: LocationTrackerAssociationState<_, _>) : aws.LocationTrackerAssociation.LocationTrackerAssociation =
            Unchecked.defaultof<aws.LocationTrackerAssociation.LocationTrackerAssociation>
