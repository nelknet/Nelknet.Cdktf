namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudtrailState<'Name, 'S3BucketName> = { assignments: ResizeArray<aws.Cloudtrail.CloudtrailConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail">aws_cloudtrail</a>.
    /// </summary>
    type CloudtrailBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudtrailState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudtrailState<Missing, Missing>)

        member _.Zero(()) : CloudtrailState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudtrailState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#name-1">Cloudtrail#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudtrailState<Missing, 'S3BucketName>, value: string) : CloudtrailState<Present, 'S3BucketName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudtrailState<Present, 'S3BucketName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#s3_bucket_name-1">Cloudtrail#s3_bucket_name</a>.
        /// </summary>
        [<CustomOperation "s3_bucket_name">]
        member _.S3BucketName(state: CloudtrailState<'Name, Missing>, value: string) : CloudtrailState<'Name, Present> =
            state.assignments.Add(fun config -> config.S3BucketName <- value)
            ({ assignments = state.assignments } : CloudtrailState<'Name, Present>)

        /// <summary>
        /// advanced_event_selector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#advanced_event_selector-1">Cloudtrail#advanced_event_selector</a> Accepts: aws.IResolvable | aws.Cloudtrail.CloudtrailAdvancedEventSelector[]
        /// </summary>
        [<CustomOperation "advanced_event_selector">]
        member _.AdvancedEventSelector(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.AdvancedEventSelector <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#cloud_watch_logs_group_arn-1">Cloudtrail#cloud_watch_logs_group_arn</a>.
        /// </summary>
        [<CustomOperation "cloud_watch_logs_group_arn">]
        member _.CloudWatchLogsGroupArn(state: CloudtrailState<'Name, 'S3BucketName>, value: string) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.CloudWatchLogsGroupArn <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#cloud_watch_logs_role_arn-1">Cloudtrail#cloud_watch_logs_role_arn</a>.
        /// </summary>
        [<CustomOperation "cloud_watch_logs_role_arn">]
        member _.CloudWatchLogsRoleArn(state: CloudtrailState<'Name, 'S3BucketName>, value: string) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.CloudWatchLogsRoleArn <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#enable_log_file_validation-1">Cloudtrail#enable_log_file_validation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_log_file_validation">]
        member _.EnableLogFileValidation(state: CloudtrailState<'Name, 'S3BucketName>, value: bool) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.EnableLogFileValidation <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#enable_log_file_validation-1">Cloudtrail#enable_log_file_validation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_log_file_validation">]
        member _.EnableLogFileValidation(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.EnableLogFileValidation <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#enable_logging-1">Cloudtrail#enable_logging</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_logging">]
        member _.EnableLogging(state: CloudtrailState<'Name, 'S3BucketName>, value: bool) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.EnableLogging <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#enable_logging-1">Cloudtrail#enable_logging</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_logging">]
        member _.EnableLogging(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.EnableLogging <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// event_selector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#event_selector-1">Cloudtrail#event_selector</a> Accepts: aws.IResolvable | aws.Cloudtrail.CloudtrailEventSelector[]
        /// </summary>
        [<CustomOperation "event_selector">]
        member _.EventSelector(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.EventSelector <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#id-1">Cloudtrail#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudtrailState<'Name, 'S3BucketName>, value: string) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#include_global_service_events-1">Cloudtrail#include_global_service_events</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_global_service_events">]
        member _.IncludeGlobalServiceEvents(state: CloudtrailState<'Name, 'S3BucketName>, value: bool) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.IncludeGlobalServiceEvents <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#include_global_service_events-1">Cloudtrail#include_global_service_events</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_global_service_events">]
        member _.IncludeGlobalServiceEvents(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.IncludeGlobalServiceEvents <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// insight_selector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#insight_selector-1">Cloudtrail#insight_selector</a> Accepts: aws.IResolvable | aws.Cloudtrail.CloudtrailInsightSelector[]
        /// </summary>
        [<CustomOperation "insight_selector">]
        member _.InsightSelector(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.InsightSelector <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#is_multi_region_trail-1">Cloudtrail#is_multi_region_trail</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_multi_region_trail">]
        member _.IsMultiRegionTrail(state: CloudtrailState<'Name, 'S3BucketName>, value: bool) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.IsMultiRegionTrail <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#is_multi_region_trail-1">Cloudtrail#is_multi_region_trail</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_multi_region_trail">]
        member _.IsMultiRegionTrail(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.IsMultiRegionTrail <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#is_organization_trail-1">Cloudtrail#is_organization_trail</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_organization_trail">]
        member _.IsOrganizationTrail(state: CloudtrailState<'Name, 'S3BucketName>, value: bool) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.IsOrganizationTrail <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#is_organization_trail-1">Cloudtrail#is_organization_trail</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_organization_trail">]
        member _.IsOrganizationTrail(state: CloudtrailState<'Name, 'S3BucketName>, value: HashiCorp.Cdktf.IResolvable) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.IsOrganizationTrail <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#kms_key_id-1">Cloudtrail#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: CloudtrailState<'Name, 'S3BucketName>, value: string) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#s3_key_prefix-1">Cloudtrail#s3_key_prefix</a>.
        /// </summary>
        [<CustomOperation "s3_key_prefix">]
        member _.S3KeyPrefix(state: CloudtrailState<'Name, 'S3BucketName>, value: string) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.S3KeyPrefix <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#sns_topic_name-1">Cloudtrail#sns_topic_name</a>.
        /// </summary>
        [<CustomOperation "sns_topic_name">]
        member _.SnsTopicName(state: CloudtrailState<'Name, 'S3BucketName>, value: string) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.SnsTopicName <- value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#tags-1">Cloudtrail#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudtrailState<'Name, 'S3BucketName>, value: seq<string * string>) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudtrailState<'Name, 'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#tags_all-1">Cloudtrail#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudtrailState<'Name, 'S3BucketName>, value: seq<string * string>) : CloudtrailState<'Name, 'S3BucketName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudtrailState<'Name, 'S3BucketName>

        member _.Run(state: CloudtrailState<Present, Present>) : aws.Cloudtrail.Cloudtrail =
            let config = aws.Cloudtrail.CloudtrailConfig()
            for setter in state.assignments do
                setter config
            aws.Cloudtrail.Cloudtrail(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudtrail: missing required arguments. Must call: name, s3_bucket_name.", 9999, IsError = true)>]
        member _.Run(_: CloudtrailState<_, _>) : aws.Cloudtrail.Cloudtrail =
            Unchecked.defaultof<aws.Cloudtrail.Cloudtrail>
