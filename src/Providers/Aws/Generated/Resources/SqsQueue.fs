namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SqsQueueState = { assignments: ResizeArray<aws.SqsQueue.SqsQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue">aws_sqs_queue</a>.
    /// </summary>
    type SqsQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : SqsQueueState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SqsQueueState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#content_based_deduplication-1">SqsQueue#content_based_deduplication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "content_based_deduplication">]
        member _.ContentBasedDeduplication(state: SqsQueueState, value: bool) : SqsQueueState =
            state.assignments.Add(fun config -> config.ContentBasedDeduplication <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#content_based_deduplication-1">SqsQueue#content_based_deduplication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "content_based_deduplication">]
        member _.ContentBasedDeduplication(state: SqsQueueState, value: HashiCorp.Cdktf.IResolvable) : SqsQueueState =
            state.assignments.Add(fun config -> config.ContentBasedDeduplication <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#deduplication_scope-1">SqsQueue#deduplication_scope</a>.
        /// </summary>
        [<CustomOperation "deduplication_scope">]
        member _.DeduplicationScope(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.DeduplicationScope <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#delay_seconds-1">SqsQueue#delay_seconds</a>.
        /// </summary>
        [<CustomOperation "delay_seconds">]
        member _.DelaySeconds(state: SqsQueueState, value: double) : SqsQueueState =
            state.assignments.Add(fun config -> config.DelaySeconds <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#fifo_queue-1">SqsQueue#fifo_queue</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fifo_queue">]
        member _.FifoQueue(state: SqsQueueState, value: bool) : SqsQueueState =
            state.assignments.Add(fun config -> config.FifoQueue <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#fifo_queue-1">SqsQueue#fifo_queue</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fifo_queue">]
        member _.FifoQueue(state: SqsQueueState, value: HashiCorp.Cdktf.IResolvable) : SqsQueueState =
            state.assignments.Add(fun config -> config.FifoQueue <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#fifo_throughput_limit-1">SqsQueue#fifo_throughput_limit</a>.
        /// </summary>
        [<CustomOperation "fifo_throughput_limit">]
        member _.FifoThroughputLimit(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.FifoThroughputLimit <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#id-1">SqsQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#kms_data_key_reuse_period_seconds-1">SqsQueue#kms_data_key_reuse_period_seconds</a>.
        /// </summary>
        [<CustomOperation "kms_data_key_reuse_period_seconds">]
        member _.KmsDataKeyReusePeriodSeconds(state: SqsQueueState, value: double) : SqsQueueState =
            state.assignments.Add(fun config -> config.KmsDataKeyReusePeriodSeconds <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#kms_master_key_id-1">SqsQueue#kms_master_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_master_key_id">]
        member _.KmsMasterKeyId(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.KmsMasterKeyId <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#max_message_size-1">SqsQueue#max_message_size</a>.
        /// </summary>
        [<CustomOperation "max_message_size">]
        member _.MaxMessageSize(state: SqsQueueState, value: double) : SqsQueueState =
            state.assignments.Add(fun config -> config.MaxMessageSize <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#message_retention_seconds-1">SqsQueue#message_retention_seconds</a>.
        /// </summary>
        [<CustomOperation "message_retention_seconds">]
        member _.MessageRetentionSeconds(state: SqsQueueState, value: double) : SqsQueueState =
            state.assignments.Add(fun config -> config.MessageRetentionSeconds <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#name-1">SqsQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#name_prefix-1">SqsQueue#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#policy-1">SqsQueue#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#receive_wait_time_seconds-1">SqsQueue#receive_wait_time_seconds</a>.
        /// </summary>
        [<CustomOperation "receive_wait_time_seconds">]
        member _.ReceiveWaitTimeSeconds(state: SqsQueueState, value: double) : SqsQueueState =
            state.assignments.Add(fun config -> config.ReceiveWaitTimeSeconds <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#redrive_allow_policy-1">SqsQueue#redrive_allow_policy</a>.
        /// </summary>
        [<CustomOperation "redrive_allow_policy">]
        member _.RedriveAllowPolicy(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.RedriveAllowPolicy <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#redrive_policy-1">SqsQueue#redrive_policy</a>.
        /// </summary>
        [<CustomOperation "redrive_policy">]
        member _.RedrivePolicy(state: SqsQueueState, value: string) : SqsQueueState =
            state.assignments.Add(fun config -> config.RedrivePolicy <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#sqs_managed_sse_enabled-1">SqsQueue#sqs_managed_sse_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sqs_managed_sse_enabled">]
        member _.SqsManagedSseEnabled(state: SqsQueueState, value: bool) : SqsQueueState =
            state.assignments.Add(fun config -> config.SqsManagedSseEnabled <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#sqs_managed_sse_enabled-1">SqsQueue#sqs_managed_sse_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sqs_managed_sse_enabled">]
        member _.SqsManagedSseEnabled(state: SqsQueueState, value: HashiCorp.Cdktf.IResolvable) : SqsQueueState =
            state.assignments.Add(fun config -> config.SqsManagedSseEnabled <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#tags-1">SqsQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SqsQueueState, value: seq<string * string>) : SqsQueueState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#tags_all-1">SqsQueue#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SqsQueueState, value: seq<string * string>) : SqsQueueState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SqsQueueState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#timeouts-1">SqsQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SqsQueueState, value: aws.SqsQueue.SqsQueueTimeouts) : SqsQueueState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SqsQueueState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sqs_queue#visibility_timeout_seconds-1">SqsQueue#visibility_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "visibility_timeout_seconds">]
        member _.VisibilityTimeoutSeconds(state: SqsQueueState, value: double) : SqsQueueState =
            state.assignments.Add(fun config -> config.VisibilityTimeoutSeconds <- value)
            state : SqsQueueState

        member _.Run(state: SqsQueueState) : aws.SqsQueue.SqsQueue =
            let config = aws.SqsQueue.SqsQueueConfig()
            for setter in state.assignments do
                setter config
            aws.SqsQueue.SqsQueue(StackContext.get (), logicalId, config)
