namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogGroupState = { assignments: ResizeArray<aws.CloudwatchLogGroup.CloudwatchLogGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group">aws_cloudwatch_log_group</a>.
    /// </summary>
    type CloudwatchLogGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : CloudwatchLogGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#id-1">CloudwatchLogGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogGroupState, value: string) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#kms_key_id-1">CloudwatchLogGroup#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: CloudwatchLogGroupState, value: string) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#log_group_class-1">CloudwatchLogGroup#log_group_class</a>.
        /// </summary>
        [<CustomOperation "log_group_class">]
        member _.LogGroupClass(state: CloudwatchLogGroupState, value: string) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.LogGroupClass <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#name-1">CloudwatchLogGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogGroupState, value: string) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#name_prefix-1">CloudwatchLogGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: CloudwatchLogGroupState, value: string) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#retention_in_days-1">CloudwatchLogGroup#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: CloudwatchLogGroupState, value: double) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#skip_destroy-1">CloudwatchLogGroup#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: CloudwatchLogGroupState, value: bool) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#skip_destroy-1">CloudwatchLogGroup#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: CloudwatchLogGroupState, value: HashiCorp.Cdktf.IResolvable) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#tags-1">CloudwatchLogGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchLogGroupState, value: seq<string * string>) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchLogGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_group#tags_all-1">CloudwatchLogGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchLogGroupState, value: seq<string * string>) : CloudwatchLogGroupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchLogGroupState

        member _.Run(state: CloudwatchLogGroupState) : aws.CloudwatchLogGroup.CloudwatchLogGroup =
            let config = aws.CloudwatchLogGroup.CloudwatchLogGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogGroup.CloudwatchLogGroup(StackContext.get (), logicalId, config)
