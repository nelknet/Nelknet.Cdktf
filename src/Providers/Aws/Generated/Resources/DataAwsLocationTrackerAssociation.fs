namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationTrackerAssociationState<'ConsumerArn, 'TrackerName> = { assignments: ResizeArray<aws.DataAwsLocationTrackerAssociation.DataAwsLocationTrackerAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_association">aws_location_tracker_association</a>.
    /// </summary>
    type DataAwsLocationTrackerAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationTrackerAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationTrackerAssociationState<Missing, Missing>)

        member _.Zero(()) : DataAwsLocationTrackerAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationTrackerAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_association#consumer_arn-1">DataAwsLocationTrackerAssociation#consumer_arn</a>.
        /// </summary>
        [<CustomOperation "consumer_arn">]
        member _.ConsumerArn(state: DataAwsLocationTrackerAssociationState<Missing, 'TrackerName>, value: string) : DataAwsLocationTrackerAssociationState<Present, 'TrackerName> =
            state.assignments.Add(fun config -> config.ConsumerArn <- value)
            ({ assignments = state.assignments } : DataAwsLocationTrackerAssociationState<Present, 'TrackerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_association#tracker_name-1">DataAwsLocationTrackerAssociation#tracker_name</a>.
        /// </summary>
        [<CustomOperation "tracker_name">]
        member _.TrackerName(state: DataAwsLocationTrackerAssociationState<'ConsumerArn, Missing>, value: string) : DataAwsLocationTrackerAssociationState<'ConsumerArn, Present> =
            state.assignments.Add(fun config -> config.TrackerName <- value)
            ({ assignments = state.assignments } : DataAwsLocationTrackerAssociationState<'ConsumerArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_tracker_association#id-1">DataAwsLocationTrackerAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationTrackerAssociationState<'ConsumerArn, 'TrackerName>, value: string) : DataAwsLocationTrackerAssociationState<'ConsumerArn, 'TrackerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationTrackerAssociationState<'ConsumerArn, 'TrackerName>

        member _.Run(state: DataAwsLocationTrackerAssociationState<Present, Present>) : aws.DataAwsLocationTrackerAssociation.DataAwsLocationTrackerAssociation =
            let config = aws.DataAwsLocationTrackerAssociation.DataAwsLocationTrackerAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationTrackerAssociation.DataAwsLocationTrackerAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationTrackerAssociation: missing required arguments. Must call: consumer_arn, tracker_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationTrackerAssociationState<_, _>) : aws.DataAwsLocationTrackerAssociation.DataAwsLocationTrackerAssociation =
            Unchecked.defaultof<aws.DataAwsLocationTrackerAssociation.DataAwsLocationTrackerAssociation>
