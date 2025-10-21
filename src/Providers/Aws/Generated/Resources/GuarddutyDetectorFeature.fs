namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status> = { assignments: ResizeArray<aws.GuarddutyDetectorFeature.GuarddutyDetectorFeatureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature">aws_guardduty_detector_feature</a>.
    /// </summary>
    type GuarddutyDetectorFeatureBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyDetectorFeatureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyDetectorFeatureState<Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyDetectorFeatureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyDetectorFeatureState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#detector_id-1">GuarddutyDetectorFeature#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyDetectorFeatureState<Missing, 'Name, 'Status>, value: string) : GuarddutyDetectorFeatureState<Present, 'Name, 'Status> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyDetectorFeatureState<Present, 'Name, 'Status>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#name-1">GuarddutyDetectorFeature#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GuarddutyDetectorFeatureState<'DetectorId, Missing, 'Status>, value: string) : GuarddutyDetectorFeatureState<'DetectorId, Present, 'Status> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GuarddutyDetectorFeatureState<'DetectorId, Present, 'Status>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#status-1">GuarddutyDetectorFeature#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: GuarddutyDetectorFeatureState<'DetectorId, 'Name, Missing>, value: string) : GuarddutyDetectorFeatureState<'DetectorId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : GuarddutyDetectorFeatureState<'DetectorId, 'Name, Present>)

        /// <summary>
        /// additional_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#additional_configuration-1">GuarddutyDetectorFeature#additional_configuration</a> Accepts: aws.IResolvable | aws.GuarddutyDetectorFeature.GuarddutyDetectorFeatureAdditionalConfiguration[]
        /// </summary>
        [<CustomOperation "additional_configuration">]
        member _.AdditionalConfiguration(state: GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status> =
            state.assignments.Add(fun config -> config.AdditionalConfiguration <- value)
            state : GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#id-1">GuarddutyDetectorFeature#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status>, value: string) : GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyDetectorFeatureState<'DetectorId, 'Name, 'Status>

        member _.Run(state: GuarddutyDetectorFeatureState<Present, Present, Present>) : aws.GuarddutyDetectorFeature.GuarddutyDetectorFeature =
            let config = aws.GuarddutyDetectorFeature.GuarddutyDetectorFeatureConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyDetectorFeature.GuarddutyDetectorFeature(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyDetectorFeature: missing required arguments. Must call: detector_id, name, status.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyDetectorFeatureState<_, _, _>) : aws.GuarddutyDetectorFeature.GuarddutyDetectorFeature =
            Unchecked.defaultof<aws.GuarddutyDetectorFeature.GuarddutyDetectorFeature>
