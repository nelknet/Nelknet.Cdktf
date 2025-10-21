namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchLogGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsCloudwatchLogGroup.DataAwsCloudwatchLogGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_group">aws_cloudwatch_log_group</a>.
    /// </summary>
    type DataAwsCloudwatchLogGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchLogGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchLogGroupState<Missing>)

        member _.Zero(()) : DataAwsCloudwatchLogGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchLogGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_group#name-1">DataAwsCloudwatchLogGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudwatchLogGroupState<Missing>, value: string) : DataAwsCloudwatchLogGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudwatchLogGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_group#id-1">DataAwsCloudwatchLogGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudwatchLogGroupState<'Name>, value: string) : DataAwsCloudwatchLogGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudwatchLogGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_log_group#tags-1">DataAwsCloudwatchLogGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCloudwatchLogGroupState<'Name>, value: seq<string * string>) : DataAwsCloudwatchLogGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCloudwatchLogGroupState<'Name>

        member _.Run(state: DataAwsCloudwatchLogGroupState<Present>) : aws.DataAwsCloudwatchLogGroup.DataAwsCloudwatchLogGroup =
            let config = aws.DataAwsCloudwatchLogGroup.DataAwsCloudwatchLogGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchLogGroup.DataAwsCloudwatchLogGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudwatchLogGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudwatchLogGroupState<_>) : aws.DataAwsCloudwatchLogGroup.DataAwsCloudwatchLogGroup =
            Unchecked.defaultof<aws.DataAwsCloudwatchLogGroup.DataAwsCloudwatchLogGroup>
