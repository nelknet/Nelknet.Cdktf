namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> = { assignments: ResizeArray<aws.CloudwatchLogAnomalyDetector.CloudwatchLogAnomalyDetectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector">aws_cloudwatch_log_anomaly_detector</a>.
    /// </summary>
    type CloudwatchLogAnomalyDetectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogAnomalyDetectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogAnomalyDetectorState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogAnomalyDetectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogAnomalyDetectorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#enabled-1">CloudwatchLogAnomalyDetector#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CloudwatchLogAnomalyDetectorState<Missing, 'LogGroupArnList>, value: bool) : CloudwatchLogAnomalyDetectorState<Present, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : CloudwatchLogAnomalyDetectorState<Present, 'LogGroupArnList>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#enabled-1">CloudwatchLogAnomalyDetector#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CloudwatchLogAnomalyDetectorState<Missing, 'LogGroupArnList>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchLogAnomalyDetectorState<Present, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : CloudwatchLogAnomalyDetectorState<Present, 'LogGroupArnList>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#log_group_arn_list-1">CloudwatchLogAnomalyDetector#log_group_arn_list</a>.
        /// </summary>
        [<CustomOperation "log_group_arn_list">]
        member _.LogGroupArnList(state: CloudwatchLogAnomalyDetectorState<'Enabled, Missing>, value: seq<string>) : CloudwatchLogAnomalyDetectorState<'Enabled, Present> =
            state.assignments.Add(fun config -> config.LogGroupArnList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CloudwatchLogAnomalyDetectorState<'Enabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#anomaly_visibility_time-1">CloudwatchLogAnomalyDetector#anomaly_visibility_time</a>.
        /// </summary>
        [<CustomOperation "anomaly_visibility_time">]
        member _.AnomalyVisibilityTime(state: CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>, value: double) : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.AnomalyVisibilityTime <- value)
            state : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#detector_name-1">CloudwatchLogAnomalyDetector#detector_name</a>.
        /// </summary>
        [<CustomOperation "detector_name">]
        member _.DetectorName(state: CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>, value: string) : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.DetectorName <- value)
            state : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#evaluation_frequency-1">CloudwatchLogAnomalyDetector#evaluation_frequency</a>.
        /// </summary>
        [<CustomOperation "evaluation_frequency">]
        member _.EvaluationFrequency(state: CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>, value: string) : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.EvaluationFrequency <- value)
            state : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#filter_pattern-1">CloudwatchLogAnomalyDetector#filter_pattern</a>.
        /// </summary>
        [<CustomOperation "filter_pattern">]
        member _.FilterPattern(state: CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>, value: string) : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.FilterPattern <- value)
            state : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#kms_key_id-1">CloudwatchLogAnomalyDetector#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>, value: string) : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_anomaly_detector#tags-1">CloudwatchLogAnomalyDetector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>, value: seq<string * string>) : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchLogAnomalyDetectorState<'Enabled, 'LogGroupArnList>

        member _.Run(state: CloudwatchLogAnomalyDetectorState<Present, Present>) : aws.CloudwatchLogAnomalyDetector.CloudwatchLogAnomalyDetector =
            let config = aws.CloudwatchLogAnomalyDetector.CloudwatchLogAnomalyDetectorConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogAnomalyDetector.CloudwatchLogAnomalyDetector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogAnomalyDetector: missing required arguments. Must call: enabled, log_group_arn_list.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogAnomalyDetectorState<_, _>) : aws.CloudwatchLogAnomalyDetector.CloudwatchLogAnomalyDetector =
            Unchecked.defaultof<aws.CloudwatchLogAnomalyDetector.CloudwatchLogAnomalyDetector>
