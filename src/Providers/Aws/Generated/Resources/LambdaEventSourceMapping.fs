namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaEventSourceMappingState<'FunctionName> = { assignments: ResizeArray<aws.LambdaEventSourceMapping.LambdaEventSourceMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping">aws_lambda_event_source_mapping</a>.
    /// </summary>
    type LambdaEventSourceMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaEventSourceMappingState<Missing> =
            ({ assignments = ResizeArray() } : LambdaEventSourceMappingState<Missing>)

        member _.Zero(()) : LambdaEventSourceMappingState<Missing> =
            ({ assignments = ResizeArray() } : LambdaEventSourceMappingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#function_name-1">LambdaEventSourceMapping#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaEventSourceMappingState<Missing>, value: string) : LambdaEventSourceMappingState<Present> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaEventSourceMappingState<Present>)

        /// <summary>
        /// amazon_managed_kafka_event_source_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#amazon_managed_kafka_event_source_config-1">LambdaEventSourceMapping#amazon_managed_kafka_event_source_config</a>
        /// </summary>
        [<CustomOperation "amazon_managed_kafka_event_source_config">]
        member _.AmazonManagedKafkaEventSourceConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingAmazonManagedKafkaEventSourceConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.AmazonManagedKafkaEventSourceConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#batch_size-1">LambdaEventSourceMapping#batch_size</a>.
        /// </summary>
        [<CustomOperation "batch_size">]
        member _.BatchSize(state: LambdaEventSourceMappingState<'FunctionName>, value: double) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.BatchSize <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#bisect_batch_on_function_error-1">LambdaEventSourceMapping#bisect_batch_on_function_error</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bisect_batch_on_function_error">]
        member _.BisectBatchOnFunctionError(state: LambdaEventSourceMappingState<'FunctionName>, value: bool) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.BisectBatchOnFunctionError <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#bisect_batch_on_function_error-1">LambdaEventSourceMapping#bisect_batch_on_function_error</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bisect_batch_on_function_error">]
        member _.BisectBatchOnFunctionError(state: LambdaEventSourceMappingState<'FunctionName>, value: HashiCorp.Cdktf.IResolvable) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.BisectBatchOnFunctionError <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// destination_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#destination_config-1">LambdaEventSourceMapping#destination_config</a>
        /// </summary>
        [<CustomOperation "destination_config">]
        member _.DestinationConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingDestinationConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.DestinationConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// document_db_event_source_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#document_db_event_source_config-1">LambdaEventSourceMapping#document_db_event_source_config</a>
        /// </summary>
        [<CustomOperation "document_db_event_source_config">]
        member _.DocumentDbEventSourceConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingDocumentDbEventSourceConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.DocumentDbEventSourceConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#enabled-1">LambdaEventSourceMapping#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LambdaEventSourceMappingState<'FunctionName>, value: bool) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#enabled-1">LambdaEventSourceMapping#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LambdaEventSourceMappingState<'FunctionName>, value: HashiCorp.Cdktf.IResolvable) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#event_source_arn-1">LambdaEventSourceMapping#event_source_arn</a>.
        /// </summary>
        [<CustomOperation "event_source_arn">]
        member _.EventSourceArn(state: LambdaEventSourceMappingState<'FunctionName>, value: string) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.EventSourceArn <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// filter_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#filter_criteria-1">LambdaEventSourceMapping#filter_criteria</a>
        /// </summary>
        [<CustomOperation "filter_criteria">]
        member _.FilterCriteria(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingFilterCriteria) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.FilterCriteria <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#function_response_types-1">LambdaEventSourceMapping#function_response_types</a>.
        /// </summary>
        [<CustomOperation "function_response_types">]
        member _.FunctionResponseTypes(state: LambdaEventSourceMappingState<'FunctionName>, value: seq<string>) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.FunctionResponseTypes <- (value |> Seq.toArray))
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#id-1">LambdaEventSourceMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaEventSourceMappingState<'FunctionName>, value: string) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#kms_key_arn-1">LambdaEventSourceMapping#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: LambdaEventSourceMappingState<'FunctionName>, value: string) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_batching_window_in_seconds-1">LambdaEventSourceMapping#maximum_batching_window_in_seconds</a>.
        /// </summary>
        [<CustomOperation "maximum_batching_window_in_seconds">]
        member _.MaximumBatchingWindowInSeconds(state: LambdaEventSourceMappingState<'FunctionName>, value: double) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.MaximumBatchingWindowInSeconds <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_record_age_in_seconds-1">LambdaEventSourceMapping#maximum_record_age_in_seconds</a>.
        /// </summary>
        [<CustomOperation "maximum_record_age_in_seconds">]
        member _.MaximumRecordAgeInSeconds(state: LambdaEventSourceMappingState<'FunctionName>, value: double) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.MaximumRecordAgeInSeconds <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_retry_attempts-1">LambdaEventSourceMapping#maximum_retry_attempts</a>.
        /// </summary>
        [<CustomOperation "maximum_retry_attempts">]
        member _.MaximumRetryAttempts(state: LambdaEventSourceMappingState<'FunctionName>, value: double) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.MaximumRetryAttempts <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// metrics_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#metrics_config-1">LambdaEventSourceMapping#metrics_config</a>
        /// </summary>
        [<CustomOperation "metrics_config">]
        member _.MetricsConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingMetricsConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.MetricsConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#parallelization_factor-1">LambdaEventSourceMapping#parallelization_factor</a>.
        /// </summary>
        [<CustomOperation "parallelization_factor">]
        member _.ParallelizationFactor(state: LambdaEventSourceMappingState<'FunctionName>, value: double) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.ParallelizationFactor <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// provisioned_poller_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#provisioned_poller_config-1">LambdaEventSourceMapping#provisioned_poller_config</a>
        /// </summary>
        [<CustomOperation "provisioned_poller_config">]
        member _.ProvisionedPollerConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.ProvisionedPollerConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#queues-1">LambdaEventSourceMapping#queues</a>.
        /// </summary>
        [<CustomOperation "queues">]
        member _.Queues(state: LambdaEventSourceMappingState<'FunctionName>, value: seq<string>) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.Queues <- (value |> Seq.toArray))
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// scaling_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#scaling_config-1">LambdaEventSourceMapping#scaling_config</a>
        /// </summary>
        [<CustomOperation "scaling_config">]
        member _.ScalingConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingScalingConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.ScalingConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// self_managed_event_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#self_managed_event_source-1">LambdaEventSourceMapping#self_managed_event_source</a>
        /// </summary>
        [<CustomOperation "self_managed_event_source">]
        member _.SelfManagedEventSource(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedEventSource) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.SelfManagedEventSource <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// self_managed_kafka_event_source_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#self_managed_kafka_event_source_config-1">LambdaEventSourceMapping#self_managed_kafka_event_source_config</a>
        /// </summary>
        [<CustomOperation "self_managed_kafka_event_source_config">]
        member _.SelfManagedKafkaEventSourceConfig(state: LambdaEventSourceMappingState<'FunctionName>, value: aws.LambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfig) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.SelfManagedKafkaEventSourceConfig <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// source_access_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#source_access_configuration-1">LambdaEventSourceMapping#source_access_configuration</a> Accepts: aws.IResolvable | aws.LambdaEventSourceMapping.LambdaEventSourceMappingSourceAccessConfiguration[]
        /// </summary>
        [<CustomOperation "source_access_configuration">]
        member _.SourceAccessConfiguration(state: LambdaEventSourceMappingState<'FunctionName>, value: HashiCorp.Cdktf.IResolvable) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.SourceAccessConfiguration <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#starting_position-1">LambdaEventSourceMapping#starting_position</a>.
        /// </summary>
        [<CustomOperation "starting_position">]
        member _.StartingPosition(state: LambdaEventSourceMappingState<'FunctionName>, value: string) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.StartingPosition <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#starting_position_timestamp-1">LambdaEventSourceMapping#starting_position_timestamp</a>.
        /// </summary>
        [<CustomOperation "starting_position_timestamp">]
        member _.StartingPositionTimestamp(state: LambdaEventSourceMappingState<'FunctionName>, value: string) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.StartingPositionTimestamp <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#tags-1">LambdaEventSourceMapping#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LambdaEventSourceMappingState<'FunctionName>, value: seq<string * string>) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#tags_all-1">LambdaEventSourceMapping#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LambdaEventSourceMappingState<'FunctionName>, value: seq<string * string>) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#topics-1">LambdaEventSourceMapping#topics</a>.
        /// </summary>
        [<CustomOperation "topics">]
        member _.Topics(state: LambdaEventSourceMappingState<'FunctionName>, value: seq<string>) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.Topics <- (value |> Seq.toArray))
            state : LambdaEventSourceMappingState<'FunctionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#tumbling_window_in_seconds-1">LambdaEventSourceMapping#tumbling_window_in_seconds</a>.
        /// </summary>
        [<CustomOperation "tumbling_window_in_seconds">]
        member _.TumblingWindowInSeconds(state: LambdaEventSourceMappingState<'FunctionName>, value: double) : LambdaEventSourceMappingState<'FunctionName> =
            state.assignments.Add(fun config -> config.TumblingWindowInSeconds <- value)
            state : LambdaEventSourceMappingState<'FunctionName>

        member _.Run(state: LambdaEventSourceMappingState<Present>) : aws.LambdaEventSourceMapping.LambdaEventSourceMapping =
            let config = aws.LambdaEventSourceMapping.LambdaEventSourceMappingConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaEventSourceMapping.LambdaEventSourceMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaEventSourceMapping: missing required arguments. Must call: function_name.", 9999, IsError = true)>]
        member _.Run(_: LambdaEventSourceMappingState<_>) : aws.LambdaEventSourceMapping.LambdaEventSourceMapping =
            Unchecked.defaultof<aws.LambdaEventSourceMapping.LambdaEventSourceMapping>
