namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> = { assignments: ResizeArray<aws.QldbStream.QldbStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream">aws_qldb_stream</a>.
    /// </summary>
    type QldbStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : QldbStreamState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QldbStreamState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : QldbStreamState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QldbStreamState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#inclusive_start_time-1">QldbStream#inclusive_start_time</a>.
        /// </summary>
        [<CustomOperation "inclusive_start_time">]
        member _.InclusiveStartTime(state: QldbStreamState<Missing, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>, value: string) : QldbStreamState<Present, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.InclusiveStartTime <- value)
            ({ assignments = state.assignments } : QldbStreamState<Present, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>)

        /// <summary>
        /// kinesis_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#kinesis_configuration-1">QldbStream#kinesis_configuration</a>
        /// </summary>
        [<CustomOperation "kinesis_configuration">]
        member _.KinesisConfiguration(state: QldbStreamState<'InclusiveStartTime, Missing, 'LedgerName, 'RoleArn, 'StreamName>, value: aws.QldbStream.QldbStreamKinesisConfiguration) : QldbStreamState<'InclusiveStartTime, Present, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.KinesisConfiguration <- value)
            ({ assignments = state.assignments } : QldbStreamState<'InclusiveStartTime, Present, 'LedgerName, 'RoleArn, 'StreamName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#ledger_name-1">QldbStream#ledger_name</a>.
        /// </summary>
        [<CustomOperation "ledger_name">]
        member _.LedgerName(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, Missing, 'RoleArn, 'StreamName>, value: string) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, Present, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.LedgerName <- value)
            ({ assignments = state.assignments } : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, Present, 'RoleArn, 'StreamName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#role_arn-1">QldbStream#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, Missing, 'StreamName>, value: string) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, Present, 'StreamName> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, Present, 'StreamName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#stream_name-1">QldbStream#stream_name</a>.
        /// </summary>
        [<CustomOperation "stream_name">]
        member _.StreamName(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, Missing>, value: string) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.StreamName <- value)
            ({ assignments = state.assignments } : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#exclusive_end_time-1">QldbStream#exclusive_end_time</a>.
        /// </summary>
        [<CustomOperation "exclusive_end_time">]
        member _.ExclusiveEndTime(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>, value: string) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.ExclusiveEndTime <- value)
            state : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#id-1">QldbStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>, value: string) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#tags-1">QldbStream#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>, value: seq<string * string>) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#tags_all-1">QldbStream#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>, value: seq<string * string>) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/qldb_stream#timeouts-1">QldbStream#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>, value: aws.QldbStream.QldbStreamTimeouts) : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QldbStreamState<'InclusiveStartTime, 'KinesisConfiguration, 'LedgerName, 'RoleArn, 'StreamName>

        member _.Run(state: QldbStreamState<Present, Present, Present, Present, Present>) : aws.QldbStream.QldbStream =
            let config = aws.QldbStream.QldbStreamConfig()
            for setter in state.assignments do
                setter config
            aws.QldbStream.QldbStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.qldbStream: missing required arguments. Must call: inclusive_start_time, kinesis_configuration, ledger_name, role_arn, stream_name.", 9999, IsError = true)>]
        member _.Run(_: QldbStreamState<_, _, _, _, _>) : aws.QldbStream.QldbStream =
            Unchecked.defaultof<aws.QldbStream.QldbStream>
