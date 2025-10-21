namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KinesisFirehoseDeliveryStreamState<'Destination, 'Name> = { assignments: ResizeArray<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream">aws_kinesis_firehose_delivery_stream</a>.
    /// </summary>
    type KinesisFirehoseDeliveryStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : KinesisFirehoseDeliveryStreamState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KinesisFirehoseDeliveryStreamState<Missing, Missing>)

        member _.Zero(()) : KinesisFirehoseDeliveryStreamState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KinesisFirehoseDeliveryStreamState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#destination-1">KinesisFirehoseDeliveryStream#destination</a>.
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: KinesisFirehoseDeliveryStreamState<Missing, 'Name>, value: string) : KinesisFirehoseDeliveryStreamState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : KinesisFirehoseDeliveryStreamState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#name-1">KinesisFirehoseDeliveryStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KinesisFirehoseDeliveryStreamState<'Destination, Missing>, value: string) : KinesisFirehoseDeliveryStreamState<'Destination, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KinesisFirehoseDeliveryStreamState<'Destination, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#arn-1">KinesisFirehoseDeliveryStream#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: string) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#destination_id-1">KinesisFirehoseDeliveryStream#destination_id</a>.
        /// </summary>
        [<CustomOperation "destination_id">]
        member _.DestinationId(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: string) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.DestinationId <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// elasticsearch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#elasticsearch_configuration-1">KinesisFirehoseDeliveryStream#elasticsearch_configuration</a>
        /// </summary>
        [<CustomOperation "elasticsearch_configuration">]
        member _.ElasticsearchConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamElasticsearchConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.ElasticsearchConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// extended_s3_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#extended_s3_configuration-1">KinesisFirehoseDeliveryStream#extended_s3_configuration</a>
        /// </summary>
        [<CustomOperation "extended_s3_configuration">]
        member _.ExtendedS3Configuration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamExtendedS3Configuration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.ExtendedS3Configuration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// http_endpoint_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#http_endpoint_configuration-1">KinesisFirehoseDeliveryStream#http_endpoint_configuration</a>
        /// </summary>
        [<CustomOperation "http_endpoint_configuration">]
        member _.HttpEndpointConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.HttpEndpointConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// iceberg_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#iceberg_configuration-1">KinesisFirehoseDeliveryStream#iceberg_configuration</a>
        /// </summary>
        [<CustomOperation "iceberg_configuration">]
        member _.IcebergConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.IcebergConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#id-1">KinesisFirehoseDeliveryStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: string) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// kinesis_source_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#kinesis_source_configuration-1">KinesisFirehoseDeliveryStream#kinesis_source_configuration</a>
        /// </summary>
        [<CustomOperation "kinesis_source_configuration">]
        member _.KinesisSourceConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.KinesisSourceConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// msk_source_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#msk_source_configuration-1">KinesisFirehoseDeliveryStream#msk_source_configuration</a>
        /// </summary>
        [<CustomOperation "msk_source_configuration">]
        member _.MskSourceConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.MskSourceConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// opensearch_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#opensearch_configuration-1">KinesisFirehoseDeliveryStream#opensearch_configuration</a>
        /// </summary>
        [<CustomOperation "opensearch_configuration">]
        member _.OpensearchConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.OpensearchConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// opensearchserverless_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#opensearchserverless_configuration-1">KinesisFirehoseDeliveryStream#opensearchserverless_configuration</a>
        /// </summary>
        [<CustomOperation "opensearchserverless_configuration">]
        member _.OpensearchserverlessConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.OpensearchserverlessConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// redshift_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#redshift_configuration-1">KinesisFirehoseDeliveryStream#redshift_configuration</a>
        /// </summary>
        [<CustomOperation "redshift_configuration">]
        member _.RedshiftConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.RedshiftConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// server_side_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#server_side_encryption-1">KinesisFirehoseDeliveryStream#server_side_encryption</a>
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamServerSideEncryption) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// snowflake_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#snowflake_configuration-1">KinesisFirehoseDeliveryStream#snowflake_configuration</a>
        /// </summary>
        [<CustomOperation "snowflake_configuration">]
        member _.SnowflakeConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.SnowflakeConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// splunk_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#splunk_configuration-1">KinesisFirehoseDeliveryStream#splunk_configuration</a>
        /// </summary>
        [<CustomOperation "splunk_configuration">]
        member _.SplunkConfiguration(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSplunkConfiguration) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.SplunkConfiguration <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#tags-1">KinesisFirehoseDeliveryStream#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: seq<string * string>) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#tags_all-1">KinesisFirehoseDeliveryStream#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: seq<string * string>) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#timeouts-1">KinesisFirehoseDeliveryStream#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamTimeouts) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#version_id-1">KinesisFirehoseDeliveryStream#version_id</a>.
        /// </summary>
        [<CustomOperation "version_id">]
        member _.VersionId(state: KinesisFirehoseDeliveryStreamState<'Destination, 'Name>, value: string) : KinesisFirehoseDeliveryStreamState<'Destination, 'Name> =
            state.assignments.Add(fun config -> config.VersionId <- value)
            state : KinesisFirehoseDeliveryStreamState<'Destination, 'Name>

        member _.Run(state: KinesisFirehoseDeliveryStreamState<Present, Present>) : aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream =
            let config = aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamConfig()
            for setter in state.assignments do
                setter config
            aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisFirehoseDeliveryStream: missing required arguments. Must call: destination, name.", 9999, IsError = true)>]
        member _.Run(_: KinesisFirehoseDeliveryStreamState<_, _>) : aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream =
            Unchecked.defaultof<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream>
