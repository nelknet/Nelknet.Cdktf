namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, 'Status> = { assignments: ResizeArray<aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeatureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature">aws_guardduty_member_detector_feature</a>.
    /// </summary>
    type GuarddutyMemberDetectorFeatureBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyMemberDetectorFeatureState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyMemberDetectorFeatureState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyMemberDetectorFeatureState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyMemberDetectorFeatureState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#account_id-1">GuarddutyMemberDetectorFeature#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: GuarddutyMemberDetectorFeatureState<Missing, 'DetectorId, 'Name, 'Status>, value: string) : GuarddutyMemberDetectorFeatureState<Present, 'DetectorId, 'Name, 'Status> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : GuarddutyMemberDetectorFeatureState<Present, 'DetectorId, 'Name, 'Status>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#detector_id-1">GuarddutyMemberDetectorFeature#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyMemberDetectorFeatureState<'AccountId, Missing, 'Name, 'Status>, value: string) : GuarddutyMemberDetectorFeatureState<'AccountId, Present, 'Name, 'Status> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyMemberDetectorFeatureState<'AccountId, Present, 'Name, 'Status>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#name-1">GuarddutyMemberDetectorFeature#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, Missing, 'Status>, value: string) : GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, Present, 'Status> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, Present, 'Status>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#status-1">GuarddutyMemberDetectorFeature#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, Missing>, value: string) : GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, Present>)

        /// <summary>
        /// additional_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member_detector_feature#additional_configuration-1">GuarddutyMemberDetectorFeature#additional_configuration</a> Accepts: aws.IResolvable | aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeatureAdditionalConfiguration[]
        /// </summary>
        [<CustomOperation "additional_configuration">]
        member _.AdditionalConfiguration(state: GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, 'Status>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, 'Status> =
            state.assignments.Add(fun config -> config.AdditionalConfiguration <- value)
            state : GuarddutyMemberDetectorFeatureState<'AccountId, 'DetectorId, 'Name, 'Status>

        member _.Run(state: GuarddutyMemberDetectorFeatureState<Present, Present, Present, Present>) : aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeature =
            let config = aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeatureConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeature(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyMemberDetectorFeature: missing required arguments. Must call: account_id, detector_id, name, status.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyMemberDetectorFeatureState<_, _, _, _>) : aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeature =
            Unchecked.defaultof<aws.GuarddutyMemberDetectorFeature.GuarddutyMemberDetectorFeature>
