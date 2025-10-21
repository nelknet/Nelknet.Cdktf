namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnsTopicState = { assignments: ResizeArray<aws.SnsTopic.SnsTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic">aws_sns_topic</a>.
    /// </summary>
    type SnsTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnsTopicState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SnsTopicState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#application_failure_feedback_role_arn-1">SnsTopic#application_failure_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "application_failure_feedback_role_arn">]
        member _.ApplicationFailureFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.ApplicationFailureFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#application_success_feedback_role_arn-1">SnsTopic#application_success_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "application_success_feedback_role_arn">]
        member _.ApplicationSuccessFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.ApplicationSuccessFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#application_success_feedback_sample_rate-1">SnsTopic#application_success_feedback_sample_rate</a>.
        /// </summary>
        [<CustomOperation "application_success_feedback_sample_rate">]
        member _.ApplicationSuccessFeedbackSampleRate(state: SnsTopicState, value: double) : SnsTopicState =
            state.assignments.Add(fun config -> config.ApplicationSuccessFeedbackSampleRate <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#archive_policy-1">SnsTopic#archive_policy</a>.
        /// </summary>
        [<CustomOperation "archive_policy">]
        member _.ArchivePolicy(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.ArchivePolicy <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#content_based_deduplication-1">SnsTopic#content_based_deduplication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "content_based_deduplication">]
        member _.ContentBasedDeduplication(state: SnsTopicState, value: bool) : SnsTopicState =
            state.assignments.Add(fun config -> config.ContentBasedDeduplication <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#content_based_deduplication-1">SnsTopic#content_based_deduplication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "content_based_deduplication">]
        member _.ContentBasedDeduplication(state: SnsTopicState, value: HashiCorp.Cdktf.IResolvable) : SnsTopicState =
            state.assignments.Add(fun config -> config.ContentBasedDeduplication <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#delivery_policy-1">SnsTopic#delivery_policy</a>.
        /// </summary>
        [<CustomOperation "delivery_policy">]
        member _.DeliveryPolicy(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.DeliveryPolicy <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#display_name-1">SnsTopic#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#fifo_throughput_scope-1">SnsTopic#fifo_throughput_scope</a>.
        /// </summary>
        [<CustomOperation "fifo_throughput_scope">]
        member _.FifoThroughputScope(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.FifoThroughputScope <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#fifo_topic-1">SnsTopic#fifo_topic</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fifo_topic">]
        member _.FifoTopic(state: SnsTopicState, value: bool) : SnsTopicState =
            state.assignments.Add(fun config -> config.FifoTopic <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#fifo_topic-1">SnsTopic#fifo_topic</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fifo_topic">]
        member _.FifoTopic(state: SnsTopicState, value: HashiCorp.Cdktf.IResolvable) : SnsTopicState =
            state.assignments.Add(fun config -> config.FifoTopic <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#firehose_failure_feedback_role_arn-1">SnsTopic#firehose_failure_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "firehose_failure_feedback_role_arn">]
        member _.FirehoseFailureFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.FirehoseFailureFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#firehose_success_feedback_role_arn-1">SnsTopic#firehose_success_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "firehose_success_feedback_role_arn">]
        member _.FirehoseSuccessFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.FirehoseSuccessFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#firehose_success_feedback_sample_rate-1">SnsTopic#firehose_success_feedback_sample_rate</a>.
        /// </summary>
        [<CustomOperation "firehose_success_feedback_sample_rate">]
        member _.FirehoseSuccessFeedbackSampleRate(state: SnsTopicState, value: double) : SnsTopicState =
            state.assignments.Add(fun config -> config.FirehoseSuccessFeedbackSampleRate <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#http_failure_feedback_role_arn-1">SnsTopic#http_failure_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "http_failure_feedback_role_arn">]
        member _.HttpFailureFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.HttpFailureFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#http_success_feedback_role_arn-1">SnsTopic#http_success_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "http_success_feedback_role_arn">]
        member _.HttpSuccessFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.HttpSuccessFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#http_success_feedback_sample_rate-1">SnsTopic#http_success_feedback_sample_rate</a>.
        /// </summary>
        [<CustomOperation "http_success_feedback_sample_rate">]
        member _.HttpSuccessFeedbackSampleRate(state: SnsTopicState, value: double) : SnsTopicState =
            state.assignments.Add(fun config -> config.HttpSuccessFeedbackSampleRate <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#id-1">SnsTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#kms_master_key_id-1">SnsTopic#kms_master_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_master_key_id">]
        member _.KmsMasterKeyId(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.KmsMasterKeyId <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#lambda_failure_feedback_role_arn-1">SnsTopic#lambda_failure_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "lambda_failure_feedback_role_arn">]
        member _.LambdaFailureFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.LambdaFailureFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#lambda_success_feedback_role_arn-1">SnsTopic#lambda_success_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "lambda_success_feedback_role_arn">]
        member _.LambdaSuccessFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.LambdaSuccessFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#lambda_success_feedback_sample_rate-1">SnsTopic#lambda_success_feedback_sample_rate</a>.
        /// </summary>
        [<CustomOperation "lambda_success_feedback_sample_rate">]
        member _.LambdaSuccessFeedbackSampleRate(state: SnsTopicState, value: double) : SnsTopicState =
            state.assignments.Add(fun config -> config.LambdaSuccessFeedbackSampleRate <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#name-1">SnsTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#name_prefix-1">SnsTopic#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#policy-1">SnsTopic#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#signature_version-1">SnsTopic#signature_version</a>.
        /// </summary>
        [<CustomOperation "signature_version">]
        member _.SignatureVersion(state: SnsTopicState, value: double) : SnsTopicState =
            state.assignments.Add(fun config -> config.SignatureVersion <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#sqs_failure_feedback_role_arn-1">SnsTopic#sqs_failure_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "sqs_failure_feedback_role_arn">]
        member _.SqsFailureFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.SqsFailureFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#sqs_success_feedback_role_arn-1">SnsTopic#sqs_success_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "sqs_success_feedback_role_arn">]
        member _.SqsSuccessFeedbackRoleArn(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.SqsSuccessFeedbackRoleArn <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#sqs_success_feedback_sample_rate-1">SnsTopic#sqs_success_feedback_sample_rate</a>.
        /// </summary>
        [<CustomOperation "sqs_success_feedback_sample_rate">]
        member _.SqsSuccessFeedbackSampleRate(state: SnsTopicState, value: double) : SnsTopicState =
            state.assignments.Add(fun config -> config.SqsSuccessFeedbackSampleRate <- value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#tags-1">SnsTopic#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SnsTopicState, value: seq<string * string>) : SnsTopicState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#tags_all-1">SnsTopic#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SnsTopicState, value: seq<string * string>) : SnsTopicState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SnsTopicState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_topic#tracing_config-1">SnsTopic#tracing_config</a>.
        /// </summary>
        [<CustomOperation "tracing_config">]
        member _.TracingConfig(state: SnsTopicState, value: string) : SnsTopicState =
            state.assignments.Add(fun config -> config.TracingConfig <- value)
            state : SnsTopicState

        member _.Run(state: SnsTopicState) : aws.SnsTopic.SnsTopic =
            let config = aws.SnsTopic.SnsTopicConfig()
            for setter in state.assignments do
                setter config
            aws.SnsTopic.SnsTopic(StackContext.get (), logicalId, config)
