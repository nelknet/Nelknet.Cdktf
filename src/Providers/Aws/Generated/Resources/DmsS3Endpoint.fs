namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> = { assignments: ResizeArray<aws.DmsS3Endpoint.DmsS3EndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint">aws_dms_s3_endpoint</a>.
    /// </summary>
    type DmsS3EndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsS3EndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsS3EndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DmsS3EndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsS3EndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#bucket_name-1">DmsS3Endpoint#bucket_name</a>.
        /// </summary>
        [<CustomOperation "bucket_name">]
        member _.BucketName(state: DmsS3EndpointState<Missing, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<Present, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.BucketName <- value)
            ({ assignments = state.assignments } : DmsS3EndpointState<Present, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#endpoint_id-1">DmsS3Endpoint#endpoint_id</a>.
        /// </summary>
        [<CustomOperation "endpoint_id">]
        member _.EndpointId(state: DmsS3EndpointState<'BucketName, Missing, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, Present, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.EndpointId <- value)
            ({ assignments = state.assignments } : DmsS3EndpointState<'BucketName, Present, 'EndpointType, 'ServiceAccessRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#endpoint_type-1">DmsS3Endpoint#endpoint_type</a>.
        /// </summary>
        [<CustomOperation "endpoint_type">]
        member _.EndpointType(state: DmsS3EndpointState<'BucketName, 'EndpointId, Missing, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, Present, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.EndpointType <- value)
            ({ assignments = state.assignments } : DmsS3EndpointState<'BucketName, 'EndpointId, Present, 'ServiceAccessRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#service_access_role_arn-1">DmsS3Endpoint#service_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_access_role_arn">]
        member _.ServiceAccessRoleArn(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, Missing>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, Present> =
            state.assignments.Add(fun config -> config.ServiceAccessRoleArn <- value)
            ({ assignments = state.assignments } : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#add_column_name-1">DmsS3Endpoint#add_column_name</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "add_column_name">]
        member _.AddColumnName(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.AddColumnName <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#add_column_name-1">DmsS3Endpoint#add_column_name</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "add_column_name">]
        member _.AddColumnName(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.AddColumnName <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#add_trailing_padding_character-1">DmsS3Endpoint#add_trailing_padding_character</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "add_trailing_padding_character">]
        member _.AddTrailingPaddingCharacter(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.AddTrailingPaddingCharacter <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#add_trailing_padding_character-1">DmsS3Endpoint#add_trailing_padding_character</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "add_trailing_padding_character">]
        member _.AddTrailingPaddingCharacter(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.AddTrailingPaddingCharacter <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#bucket_folder-1">DmsS3Endpoint#bucket_folder</a>.
        /// </summary>
        [<CustomOperation "bucket_folder">]
        member _.BucketFolder(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.BucketFolder <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#canned_acl_for_objects-1">DmsS3Endpoint#canned_acl_for_objects</a>.
        /// </summary>
        [<CustomOperation "canned_acl_for_objects">]
        member _.CannedAclForObjects(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CannedAclForObjects <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_inserts_and_updates-1">DmsS3Endpoint#cdc_inserts_and_updates</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cdc_inserts_and_updates">]
        member _.CdcInsertsAndUpdates(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcInsertsAndUpdates <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_inserts_and_updates-1">DmsS3Endpoint#cdc_inserts_and_updates</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cdc_inserts_and_updates">]
        member _.CdcInsertsAndUpdates(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcInsertsAndUpdates <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_inserts_only-1">DmsS3Endpoint#cdc_inserts_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cdc_inserts_only">]
        member _.CdcInsertsOnly(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcInsertsOnly <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_inserts_only-1">DmsS3Endpoint#cdc_inserts_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cdc_inserts_only">]
        member _.CdcInsertsOnly(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcInsertsOnly <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_max_batch_interval-1">DmsS3Endpoint#cdc_max_batch_interval</a>.
        /// </summary>
        [<CustomOperation "cdc_max_batch_interval">]
        member _.CdcMaxBatchInterval(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcMaxBatchInterval <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_min_file_size-1">DmsS3Endpoint#cdc_min_file_size</a>.
        /// </summary>
        [<CustomOperation "cdc_min_file_size">]
        member _.CdcMinFileSize(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcMinFileSize <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#cdc_path-1">DmsS3Endpoint#cdc_path</a>.
        /// </summary>
        [<CustomOperation "cdc_path">]
        member _.CdcPath(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CdcPath <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#certificate_arn-1">DmsS3Endpoint#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#compression_type-1">DmsS3Endpoint#compression_type</a>.
        /// </summary>
        [<CustomOperation "compression_type">]
        member _.CompressionType(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CompressionType <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#csv_delimiter-1">DmsS3Endpoint#csv_delimiter</a>.
        /// </summary>
        [<CustomOperation "csv_delimiter">]
        member _.CsvDelimiter(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CsvDelimiter <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#csv_no_sup_value-1">DmsS3Endpoint#csv_no_sup_value</a>.
        /// </summary>
        [<CustomOperation "csv_no_sup_value">]
        member _.CsvNoSupValue(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CsvNoSupValue <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#csv_null_value-1">DmsS3Endpoint#csv_null_value</a>.
        /// </summary>
        [<CustomOperation "csv_null_value">]
        member _.CsvNullValue(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CsvNullValue <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#csv_row_delimiter-1">DmsS3Endpoint#csv_row_delimiter</a>.
        /// </summary>
        [<CustomOperation "csv_row_delimiter">]
        member _.CsvRowDelimiter(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.CsvRowDelimiter <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#data_format-1">DmsS3Endpoint#data_format</a>.
        /// </summary>
        [<CustomOperation "data_format">]
        member _.DataFormat(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DataFormat <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#data_page_size-1">DmsS3Endpoint#data_page_size</a>.
        /// </summary>
        [<CustomOperation "data_page_size">]
        member _.DataPageSize(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DataPageSize <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#date_partition_delimiter-1">DmsS3Endpoint#date_partition_delimiter</a>.
        /// </summary>
        [<CustomOperation "date_partition_delimiter">]
        member _.DatePartitionDelimiter(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DatePartitionDelimiter <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#date_partition_enabled-1">DmsS3Endpoint#date_partition_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "date_partition_enabled">]
        member _.DatePartitionEnabled(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DatePartitionEnabled <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#date_partition_enabled-1">DmsS3Endpoint#date_partition_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "date_partition_enabled">]
        member _.DatePartitionEnabled(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DatePartitionEnabled <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#date_partition_sequence-1">DmsS3Endpoint#date_partition_sequence</a>.
        /// </summary>
        [<CustomOperation "date_partition_sequence">]
        member _.DatePartitionSequence(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DatePartitionSequence <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#date_partition_timezone-1">DmsS3Endpoint#date_partition_timezone</a>.
        /// </summary>
        [<CustomOperation "date_partition_timezone">]
        member _.DatePartitionTimezone(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DatePartitionTimezone <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#detach_target_on_lob_lookup_failure_parquet-1">DmsS3Endpoint#detach_target_on_lob_lookup_failure_parquet</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "detach_target_on_lob_lookup_failure_parquet">]
        member _.DetachTargetOnLobLookupFailureParquet(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DetachTargetOnLobLookupFailureParquet <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#detach_target_on_lob_lookup_failure_parquet-1">DmsS3Endpoint#detach_target_on_lob_lookup_failure_parquet</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "detach_target_on_lob_lookup_failure_parquet">]
        member _.DetachTargetOnLobLookupFailureParquet(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DetachTargetOnLobLookupFailureParquet <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#dict_page_size_limit-1">DmsS3Endpoint#dict_page_size_limit</a>.
        /// </summary>
        [<CustomOperation "dict_page_size_limit">]
        member _.DictPageSizeLimit(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.DictPageSizeLimit <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#enable_statistics-1">DmsS3Endpoint#enable_statistics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_statistics">]
        member _.EnableStatistics(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.EnableStatistics <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#enable_statistics-1">DmsS3Endpoint#enable_statistics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_statistics">]
        member _.EnableStatistics(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.EnableStatistics <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#encoding_type-1">DmsS3Endpoint#encoding_type</a>.
        /// </summary>
        [<CustomOperation "encoding_type">]
        member _.EncodingType(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.EncodingType <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#encryption_mode-1">DmsS3Endpoint#encryption_mode</a>.
        /// </summary>
        [<CustomOperation "encryption_mode">]
        member _.EncryptionMode(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.EncryptionMode <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#expected_bucket_owner-1">DmsS3Endpoint#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#external_table_definition-1">DmsS3Endpoint#external_table_definition</a>.
        /// </summary>
        [<CustomOperation "external_table_definition">]
        member _.ExternalTableDefinition(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.ExternalTableDefinition <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#glue_catalog_generation-1">DmsS3Endpoint#glue_catalog_generation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "glue_catalog_generation">]
        member _.GlueCatalogGeneration(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.GlueCatalogGeneration <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#glue_catalog_generation-1">DmsS3Endpoint#glue_catalog_generation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "glue_catalog_generation">]
        member _.GlueCatalogGeneration(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.GlueCatalogGeneration <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#id-1">DmsS3Endpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#ignore_header_rows-1">DmsS3Endpoint#ignore_header_rows</a>.
        /// </summary>
        [<CustomOperation "ignore_header_rows">]
        member _.IgnoreHeaderRows(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.IgnoreHeaderRows <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#include_op_for_full_load-1">DmsS3Endpoint#include_op_for_full_load</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_op_for_full_load">]
        member _.IncludeOpForFullLoad(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.IncludeOpForFullLoad <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#include_op_for_full_load-1">DmsS3Endpoint#include_op_for_full_load</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_op_for_full_load">]
        member _.IncludeOpForFullLoad(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.IncludeOpForFullLoad <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#kms_key_arn-1">DmsS3Endpoint#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#max_file_size-1">DmsS3Endpoint#max_file_size</a>.
        /// </summary>
        [<CustomOperation "max_file_size">]
        member _.MaxFileSize(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.MaxFileSize <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#parquet_timestamp_in_millisecond-1">DmsS3Endpoint#parquet_timestamp_in_millisecond</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "parquet_timestamp_in_millisecond">]
        member _.ParquetTimestampInMillisecond(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.ParquetTimestampInMillisecond <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#parquet_timestamp_in_millisecond-1">DmsS3Endpoint#parquet_timestamp_in_millisecond</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "parquet_timestamp_in_millisecond">]
        member _.ParquetTimestampInMillisecond(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.ParquetTimestampInMillisecond <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#parquet_version-1">DmsS3Endpoint#parquet_version</a>.
        /// </summary>
        [<CustomOperation "parquet_version">]
        member _.ParquetVersion(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.ParquetVersion <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#preserve_transactions-1">DmsS3Endpoint#preserve_transactions</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_transactions">]
        member _.PreserveTransactions(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.PreserveTransactions <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#preserve_transactions-1">DmsS3Endpoint#preserve_transactions</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve_transactions">]
        member _.PreserveTransactions(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.PreserveTransactions <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#rfc_4180-1">DmsS3Endpoint#rfc_4180</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "rfc4180">]
        member _.Rfc4180(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Rfc4180 <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#rfc_4180-1">DmsS3Endpoint#rfc_4180</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "rfc4180">]
        member _.Rfc4180(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Rfc4180 <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#row_group_length-1">DmsS3Endpoint#row_group_length</a>.
        /// </summary>
        [<CustomOperation "row_group_length">]
        member _.RowGroupLength(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: double) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.RowGroupLength <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#server_side_encryption_kms_key_id-1">DmsS3Endpoint#server_side_encryption_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "server_side_encryption_kms_key_id">]
        member _.ServerSideEncryptionKmsKeyId(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.ServerSideEncryptionKmsKeyId <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#ssl_mode-1">DmsS3Endpoint#ssl_mode</a>.
        /// </summary>
        [<CustomOperation "ssl_mode">]
        member _.SslMode(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.SslMode <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#tags-1">DmsS3Endpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: seq<string * string>) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#tags_all-1">DmsS3Endpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: seq<string * string>) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#timeouts-1">DmsS3Endpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: aws.DmsS3Endpoint.DmsS3EndpointTimeouts) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#timestamp_column_name-1">DmsS3Endpoint#timestamp_column_name</a>.
        /// </summary>
        [<CustomOperation "timestamp_column_name">]
        member _.TimestampColumnName(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: string) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.TimestampColumnName <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#use_csv_no_sup_value-1">DmsS3Endpoint#use_csv_no_sup_value</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_csv_no_sup_value">]
        member _.UseCsvNoSupValue(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.UseCsvNoSupValue <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#use_csv_no_sup_value-1">DmsS3Endpoint#use_csv_no_sup_value</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_csv_no_sup_value">]
        member _.UseCsvNoSupValue(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.UseCsvNoSupValue <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#use_task_start_time_for_full_load_timestamp-1">DmsS3Endpoint#use_task_start_time_for_full_load_timestamp</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_task_start_time_for_full_load_timestamp">]
        member _.UseTaskStartTimeForFullLoadTimestamp(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: bool) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.UseTaskStartTimeForFullLoadTimestamp <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_s3_endpoint#use_task_start_time_for_full_load_timestamp-1">DmsS3Endpoint#use_task_start_time_for_full_load_timestamp</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_task_start_time_for_full_load_timestamp">]
        member _.UseTaskStartTimeForFullLoadTimestamp(state: DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>, value: HashiCorp.Cdktf.IResolvable) : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn> =
            state.assignments.Add(fun config -> config.UseTaskStartTimeForFullLoadTimestamp <- value)
            state : DmsS3EndpointState<'BucketName, 'EndpointId, 'EndpointType, 'ServiceAccessRoleArn>

        member _.Run(state: DmsS3EndpointState<Present, Present, Present, Present>) : aws.DmsS3Endpoint.DmsS3Endpoint =
            let config = aws.DmsS3Endpoint.DmsS3EndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DmsS3Endpoint.DmsS3Endpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsS3Endpoint: missing required arguments. Must call: bucket_name, endpoint_id, endpoint_type, service_access_role_arn.", 9999, IsError = true)>]
        member _.Run(_: DmsS3EndpointState<_, _, _, _>) : aws.DmsS3Endpoint.DmsS3Endpoint =
            Unchecked.defaultof<aws.DmsS3Endpoint.DmsS3Endpoint>
