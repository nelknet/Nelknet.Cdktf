namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchLogGroupsState = { assignments: ResizeArray<aws.DataAwsCloudwatchLogGroups.DataAwsCloudwatchLogGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_groups">aws_cloudwatch_log_groups</a>.
    /// </summary>
    type DataAwsCloudwatchLogGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchLogGroupsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudwatchLogGroupsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_groups#id-1">DataAwsCloudwatchLogGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudwatchLogGroupsState, value: string) : DataAwsCloudwatchLogGroupsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudwatchLogGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_groups#log_group_name_prefix-1">DataAwsCloudwatchLogGroups#log_group_name_prefix</a>.
        /// </summary>
        [<CustomOperation "log_group_name_prefix">]
        member _.LogGroupNamePrefix(state: DataAwsCloudwatchLogGroupsState, value: string) : DataAwsCloudwatchLogGroupsState =
            state.assignments.Add(fun config -> config.LogGroupNamePrefix <- value)
            state : DataAwsCloudwatchLogGroupsState

        member _.Run(state: DataAwsCloudwatchLogGroupsState) : aws.DataAwsCloudwatchLogGroups.DataAwsCloudwatchLogGroups =
            let config = aws.DataAwsCloudwatchLogGroups.DataAwsCloudwatchLogGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchLogGroups.DataAwsCloudwatchLogGroups(StackContext.get (), logicalId, config)
