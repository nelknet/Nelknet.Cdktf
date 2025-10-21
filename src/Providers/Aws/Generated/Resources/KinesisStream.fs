namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KinesisStreamState<'Name> = { assignments: ResizeArray<aws.KinesisStream.KinesisStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream">aws_kinesis_stream</a>.
    /// </summary>
    type KinesisStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : KinesisStreamState<Missing> =
            ({ assignments = ResizeArray() } : KinesisStreamState<Missing>)

        member _.Zero(()) : KinesisStreamState<Missing> =
            ({ assignments = ResizeArray() } : KinesisStreamState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#name-1">KinesisStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KinesisStreamState<Missing>, value: string) : KinesisStreamState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KinesisStreamState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#arn-1">KinesisStream#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: KinesisStreamState<'Name>, value: string) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#encryption_type-1">KinesisStream#encryption_type</a>.
        /// </summary>
        [<CustomOperation "encryption_type">]
        member _.EncryptionType(state: KinesisStreamState<'Name>, value: string) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.EncryptionType <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#enforce_consumer_deletion-1">KinesisStream#enforce_consumer_deletion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enforce_consumer_deletion">]
        member _.EnforceConsumerDeletion(state: KinesisStreamState<'Name>, value: bool) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.EnforceConsumerDeletion <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#enforce_consumer_deletion-1">KinesisStream#enforce_consumer_deletion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enforce_consumer_deletion">]
        member _.EnforceConsumerDeletion(state: KinesisStreamState<'Name>, value: HashiCorp.Cdktf.IResolvable) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.EnforceConsumerDeletion <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#id-1">KinesisStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KinesisStreamState<'Name>, value: string) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#kms_key_id-1">KinesisStream#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: KinesisStreamState<'Name>, value: string) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#retention_period-1">KinesisStream#retention_period</a>.
        /// </summary>
        [<CustomOperation "retention_period">]
        member _.RetentionPeriod(state: KinesisStreamState<'Name>, value: double) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.RetentionPeriod <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#shard_count-1">KinesisStream#shard_count</a>.
        /// </summary>
        [<CustomOperation "shard_count">]
        member _.ShardCount(state: KinesisStreamState<'Name>, value: double) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.ShardCount <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#shard_level_metrics-1">KinesisStream#shard_level_metrics</a>.
        /// </summary>
        [<CustomOperation "shard_level_metrics">]
        member _.ShardLevelMetrics(state: KinesisStreamState<'Name>, value: seq<string>) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.ShardLevelMetrics <- (value |> Seq.toArray))
            state : KinesisStreamState<'Name>

        /// <summary>
        /// stream_mode_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#stream_mode_details-1">KinesisStream#stream_mode_details</a>
        /// </summary>
        [<CustomOperation "stream_mode_details">]
        member _.StreamModeDetails(state: KinesisStreamState<'Name>, value: aws.KinesisStream.KinesisStreamStreamModeDetails) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.StreamModeDetails <- value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#tags-1">KinesisStream#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KinesisStreamState<'Name>, value: seq<string * string>) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#tags_all-1">KinesisStream#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KinesisStreamState<'Name>, value: seq<string * string>) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KinesisStreamState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#timeouts-1">KinesisStream#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KinesisStreamState<'Name>, value: aws.KinesisStream.KinesisStreamTimeouts) : KinesisStreamState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KinesisStreamState<'Name>

        member _.Run(state: KinesisStreamState<Present>) : aws.KinesisStream.KinesisStream =
            let config = aws.KinesisStream.KinesisStreamConfig()
            for setter in state.assignments do
                setter config
            aws.KinesisStream.KinesisStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisStream: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: KinesisStreamState<_>) : aws.KinesisStream.KinesisStream =
            Unchecked.defaultof<aws.KinesisStream.KinesisStream>
