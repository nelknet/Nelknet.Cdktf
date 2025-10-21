namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventTargetState<'Arn, 'Rule> = { assignments: ResizeArray<aws.CloudwatchEventTarget.CloudwatchEventTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target">aws_cloudwatch_event_target</a>.
    /// </summary>
    type CloudwatchEventTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventTargetState<Missing, Missing>)

        member _.Zero(()) : CloudwatchEventTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventTargetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#arn-1">CloudwatchEventTarget#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: CloudwatchEventTargetState<Missing, 'Rule>, value: string) : CloudwatchEventTargetState<Present, 'Rule> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : CloudwatchEventTargetState<Present, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#rule-1">CloudwatchEventTarget#rule</a>.
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: CloudwatchEventTargetState<'Arn, Missing>, value: string) : CloudwatchEventTargetState<'Arn, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : CloudwatchEventTargetState<'Arn, Present>)

        /// <summary>
        /// appsync_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#appsync_target-1">CloudwatchEventTarget#appsync_target</a>
        /// </summary>
        [<CustomOperation "appsync_target">]
        member _.AppsyncTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.AppsyncTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// batch_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#batch_target-1">CloudwatchEventTarget#batch_target</a>
        /// </summary>
        [<CustomOperation "batch_target">]
        member _.BatchTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetBatchTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.BatchTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// dead_letter_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#dead_letter_config-1">CloudwatchEventTarget#dead_letter_config</a>
        /// </summary>
        [<CustomOperation "dead_letter_config">]
        member _.DeadLetterConfig(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfig) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.DeadLetterConfig <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// ecs_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#ecs_target-1">CloudwatchEventTarget#ecs_target</a>
        /// </summary>
        [<CustomOperation "ecs_target">]
        member _.EcsTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetEcsTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.EcsTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#event_bus_name-1">CloudwatchEventTarget#event_bus_name</a>.
        /// </summary>
        [<CustomOperation "event_bus_name">]
        member _.EventBusName(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: string) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.EventBusName <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#force_destroy-1">CloudwatchEventTarget#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: bool) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#force_destroy-1">CloudwatchEventTarget#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// http_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#http_target-1">CloudwatchEventTarget#http_target</a>
        /// </summary>
        [<CustomOperation "http_target">]
        member _.HttpTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetHttpTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.HttpTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#id-1">CloudwatchEventTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: string) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#input-1">CloudwatchEventTarget#input</a>.
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: string) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.Input <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#input_path-1">CloudwatchEventTarget#input_path</a>.
        /// </summary>
        [<CustomOperation "input_path">]
        member _.InputPath(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: string) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.InputPath <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// input_transformer block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#input_transformer-1">CloudwatchEventTarget#input_transformer</a>
        /// </summary>
        [<CustomOperation "input_transformer">]
        member _.InputTransformer(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetInputTransformer) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.InputTransformer <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// kinesis_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#kinesis_target-1">CloudwatchEventTarget#kinesis_target</a>
        /// </summary>
        [<CustomOperation "kinesis_target">]
        member _.KinesisTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetKinesisTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.KinesisTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// redshift_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#redshift_target-1">CloudwatchEventTarget#redshift_target</a>
        /// </summary>
        [<CustomOperation "redshift_target">]
        member _.RedshiftTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.RedshiftTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// retry_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#retry_policy-1">CloudwatchEventTarget#retry_policy</a>
        /// </summary>
        [<CustomOperation "retry_policy">]
        member _.RetryPolicy(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetRetryPolicy) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.RetryPolicy <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#role_arn-1">CloudwatchEventTarget#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: string) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// run_command_targets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#run_command_targets-1">CloudwatchEventTarget#run_command_targets</a> Accepts: aws.IResolvable | aws.CloudwatchEventTarget.CloudwatchEventTargetRunCommandTargets[]
        /// </summary>
        [<CustomOperation "run_command_targets">]
        member _.RunCommandTargets(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.RunCommandTargets <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// sagemaker_pipeline_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#sagemaker_pipeline_target-1">CloudwatchEventTarget#sagemaker_pipeline_target</a>
        /// </summary>
        [<CustomOperation "sagemaker_pipeline_target">]
        member _.SagemakerPipelineTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.SagemakerPipelineTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// sqs_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#sqs_target-1">CloudwatchEventTarget#sqs_target</a>
        /// </summary>
        [<CustomOperation "sqs_target">]
        member _.SqsTarget(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: aws.CloudwatchEventTarget.CloudwatchEventTargetSqsTarget) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.SqsTarget <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#target_id-1">CloudwatchEventTarget#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: CloudwatchEventTargetState<'Arn, 'Rule>, value: string) : CloudwatchEventTargetState<'Arn, 'Rule> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            state : CloudwatchEventTargetState<'Arn, 'Rule>

        member _.Run(state: CloudwatchEventTargetState<Present, Present>) : aws.CloudwatchEventTarget.CloudwatchEventTarget =
            let config = aws.CloudwatchEventTarget.CloudwatchEventTargetConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventTarget.CloudwatchEventTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventTarget: missing required arguments. Must call: arn, rule.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventTargetState<_, _>) : aws.CloudwatchEventTarget.CloudwatchEventTarget =
            Unchecked.defaultof<aws.CloudwatchEventTarget.CloudwatchEventTarget>
