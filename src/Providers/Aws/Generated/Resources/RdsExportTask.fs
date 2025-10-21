namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn> = { assignments: ResizeArray<aws.RdsExportTask.RdsExportTaskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task">aws_rds_export_task</a>.
    /// </summary>
    type RdsExportTaskBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsExportTaskState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsExportTaskState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RdsExportTaskState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsExportTaskState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#export_task_identifier-1">RdsExportTask#export_task_identifier</a>.
        /// </summary>
        [<CustomOperation "export_task_identifier">]
        member _.ExportTaskIdentifier(state: RdsExportTaskState<Missing, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>, value: string) : RdsExportTaskState<Present, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn> =
            state.assignments.Add(fun config -> config.ExportTaskIdentifier <- value)
            ({ assignments = state.assignments } : RdsExportTaskState<Present, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#iam_role_arn-1">RdsExportTask#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: RdsExportTaskState<'ExportTaskIdentifier, Missing, 'KmsKeyId, 'S3BucketName, 'SourceArn>, value: string) : RdsExportTaskState<'ExportTaskIdentifier, Present, 'KmsKeyId, 'S3BucketName, 'SourceArn> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : RdsExportTaskState<'ExportTaskIdentifier, Present, 'KmsKeyId, 'S3BucketName, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#kms_key_id-1">RdsExportTask#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, Missing, 'S3BucketName, 'SourceArn>, value: string) : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, Present, 'S3BucketName, 'SourceArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            ({ assignments = state.assignments } : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, Present, 'S3BucketName, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#s3_bucket_name-1">RdsExportTask#s3_bucket_name</a>.
        /// </summary>
        [<CustomOperation "s3_bucket_name">]
        member _.S3BucketName(state: RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, Missing, 'SourceArn>, value: string) : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, Present, 'SourceArn> =
            state.assignments.Add(fun config -> config.S3BucketName <- value)
            ({ assignments = state.assignments } : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, Present, 'SourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#source_arn-1">RdsExportTask#source_arn</a>.
        /// </summary>
        [<CustomOperation "source_arn">]
        member _.SourceArn(state: RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, Missing>, value: string) : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, Present> =
            state.assignments.Add(fun config -> config.SourceArn <- value)
            ({ assignments = state.assignments } : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#export_only-1">RdsExportTask#export_only</a>.
        /// </summary>
        [<CustomOperation "export_only">]
        member _.ExportOnly(state: RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>, value: seq<string>) : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn> =
            state.assignments.Add(fun config -> config.ExportOnly <- (value |> Seq.toArray))
            state : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#s3_prefix-1">RdsExportTask#s3_prefix</a>.
        /// </summary>
        [<CustomOperation "s3_prefix">]
        member _.S3Prefix(state: RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>, value: string) : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn> =
            state.assignments.Add(fun config -> config.S3Prefix <- value)
            state : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_export_task#timeouts-1">RdsExportTask#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>, value: aws.RdsExportTask.RdsExportTaskTimeouts) : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsExportTaskState<'ExportTaskIdentifier, 'IamRoleArn, 'KmsKeyId, 'S3BucketName, 'SourceArn>

        member _.Run(state: RdsExportTaskState<Present, Present, Present, Present, Present>) : aws.RdsExportTask.RdsExportTask =
            let config = aws.RdsExportTask.RdsExportTaskConfig()
            for setter in state.assignments do
                setter config
            aws.RdsExportTask.RdsExportTask(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsExportTask: missing required arguments. Must call: export_task_identifier, iam_role_arn, kms_key_id, s3_bucket_name, source_arn.", 9999, IsError = true)>]
        member _.Run(_: RdsExportTaskState<_, _, _, _, _>) : aws.RdsExportTask.RdsExportTask =
            Unchecked.defaultof<aws.RdsExportTask.RdsExportTask>
