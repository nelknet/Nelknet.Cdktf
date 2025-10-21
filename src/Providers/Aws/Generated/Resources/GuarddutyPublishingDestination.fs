namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn> = { assignments: ResizeArray<aws.GuarddutyPublishingDestination.GuarddutyPublishingDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_publishing_destination">aws_guardduty_publishing_destination</a>.
    /// </summary>
    type GuarddutyPublishingDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyPublishingDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyPublishingDestinationState<Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyPublishingDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyPublishingDestinationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_publishing_destination#destination_arn-1">GuarddutyPublishingDestination#destination_arn</a>.
        /// </summary>
        [<CustomOperation "destination_arn">]
        member _.DestinationArn(state: GuarddutyPublishingDestinationState<Missing, 'DetectorId, 'KmsKeyArn>, value: string) : GuarddutyPublishingDestinationState<Present, 'DetectorId, 'KmsKeyArn> =
            state.assignments.Add(fun config -> config.DestinationArn <- value)
            ({ assignments = state.assignments } : GuarddutyPublishingDestinationState<Present, 'DetectorId, 'KmsKeyArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_publishing_destination#detector_id-1">GuarddutyPublishingDestination#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyPublishingDestinationState<'DestinationArn, Missing, 'KmsKeyArn>, value: string) : GuarddutyPublishingDestinationState<'DestinationArn, Present, 'KmsKeyArn> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyPublishingDestinationState<'DestinationArn, Present, 'KmsKeyArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_publishing_destination#kms_key_arn-1">GuarddutyPublishingDestination#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, Missing>, value: string) : GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, Present> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            ({ assignments = state.assignments } : GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_publishing_destination#destination_type-1">GuarddutyPublishingDestination#destination_type</a>.
        /// </summary>
        [<CustomOperation "destination_type">]
        member _.DestinationType(state: GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn>, value: string) : GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn> =
            state.assignments.Add(fun config -> config.DestinationType <- value)
            state : GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_publishing_destination#id-1">GuarddutyPublishingDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn>, value: string) : GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyPublishingDestinationState<'DestinationArn, 'DetectorId, 'KmsKeyArn>

        member _.Run(state: GuarddutyPublishingDestinationState<Present, Present, Present>) : aws.GuarddutyPublishingDestination.GuarddutyPublishingDestination =
            let config = aws.GuarddutyPublishingDestination.GuarddutyPublishingDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyPublishingDestination.GuarddutyPublishingDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyPublishingDestination: missing required arguments. Must call: destination_arn, detector_id, kms_key_arn.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyPublishingDestinationState<_, _, _>) : aws.GuarddutyPublishingDestination.GuarddutyPublishingDestination =
            Unchecked.defaultof<aws.GuarddutyPublishingDestination.GuarddutyPublishingDestination>
