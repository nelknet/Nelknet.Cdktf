namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbTableExportState<'S3Bucket, 'TableArn> = { assignments: ResizeArray<aws.DynamodbTableExport.DynamodbTableExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export">aws_dynamodb_table_export</a>.
    /// </summary>
    type DynamodbTableExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbTableExportState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableExportState<Missing, Missing>)

        member _.Zero(()) : DynamodbTableExportState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbTableExportState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#s3_bucket-1">DynamodbTableExport#s3_bucket</a>.
        /// </summary>
        [<CustomOperation "s3_bucket">]
        member _.S3Bucket(state: DynamodbTableExportState<Missing, 'TableArn>, value: string) : DynamodbTableExportState<Present, 'TableArn> =
            state.assignments.Add(fun config -> config.S3Bucket <- value)
            ({ assignments = state.assignments } : DynamodbTableExportState<Present, 'TableArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#table_arn-1">DynamodbTableExport#table_arn</a>.
        /// </summary>
        [<CustomOperation "table_arn">]
        member _.TableArn(state: DynamodbTableExportState<'S3Bucket, Missing>, value: string) : DynamodbTableExportState<'S3Bucket, Present> =
            state.assignments.Add(fun config -> config.TableArn <- value)
            ({ assignments = state.assignments } : DynamodbTableExportState<'S3Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_format-1">DynamodbTableExport#export_format</a>.
        /// </summary>
        [<CustomOperation "export_format">]
        member _.ExportFormat(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.ExportFormat <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_time-1">DynamodbTableExport#export_time</a>.
        /// </summary>
        [<CustomOperation "export_time">]
        member _.ExportTime(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.ExportTime <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_type-1">DynamodbTableExport#export_type</a>.
        /// </summary>
        [<CustomOperation "export_type">]
        member _.ExportType(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.ExportType <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#id-1">DynamodbTableExport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// incremental_export_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#incremental_export_specification-1">DynamodbTableExport#incremental_export_specification</a>
        /// </summary>
        [<CustomOperation "incremental_export_specification">]
        member _.IncrementalExportSpecification(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: aws.DynamodbTableExport.DynamodbTableExportIncrementalExportSpecification) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.IncrementalExportSpecification <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#s3_bucket_owner-1">DynamodbTableExport#s3_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "s3_bucket_owner">]
        member _.S3BucketOwner(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.S3BucketOwner <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#s3_prefix-1">DynamodbTableExport#s3_prefix</a>.
        /// </summary>
        [<CustomOperation "s3_prefix">]
        member _.S3Prefix(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.S3Prefix <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#s3_sse_algorithm-1">DynamodbTableExport#s3_sse_algorithm</a>.
        /// </summary>
        [<CustomOperation "s3_sse_algorithm">]
        member _.S3SseAlgorithm(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.S3SseAlgorithm <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#s3_sse_kms_key_id-1">DynamodbTableExport#s3_sse_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "s3_sse_kms_key_id">]
        member _.S3SseKmsKeyId(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: string) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.S3SseKmsKeyId <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#timeouts-1">DynamodbTableExport#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DynamodbTableExportState<'S3Bucket, 'TableArn>, value: aws.DynamodbTableExport.DynamodbTableExportTimeouts) : DynamodbTableExportState<'S3Bucket, 'TableArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DynamodbTableExportState<'S3Bucket, 'TableArn>

        member _.Run(state: DynamodbTableExportState<Present, Present>) : aws.DynamodbTableExport.DynamodbTableExport =
            let config = aws.DynamodbTableExport.DynamodbTableExportConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbTableExport.DynamodbTableExport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbTableExport: missing required arguments. Must call: s3_bucket, table_arn.", 9999, IsError = true)>]
        member _.Run(_: DynamodbTableExportState<_, _>) : aws.DynamodbTableExport.DynamodbTableExport =
            Unchecked.defaultof<aws.DynamodbTableExport.DynamodbTableExport>
