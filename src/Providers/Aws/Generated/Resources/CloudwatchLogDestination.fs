namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn> = { assignments: ResizeArray<aws.CloudwatchLogDestination.CloudwatchLogDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination">aws_cloudwatch_log_destination</a>.
    /// </summary>
    type CloudwatchLogDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDestinationState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchLogDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDestinationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination#name-1">CloudwatchLogDestination#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogDestinationState<Missing, 'RoleArn, 'TargetArn>, value: string) : CloudwatchLogDestinationState<Present, 'RoleArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchLogDestinationState<Present, 'RoleArn, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination#role_arn-1">CloudwatchLogDestination#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudwatchLogDestinationState<'Name, Missing, 'TargetArn>, value: string) : CloudwatchLogDestinationState<'Name, Present, 'TargetArn> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : CloudwatchLogDestinationState<'Name, Present, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination#target_arn-1">CloudwatchLogDestination#target_arn</a>.
        /// </summary>
        [<CustomOperation "target_arn">]
        member _.TargetArn(state: CloudwatchLogDestinationState<'Name, 'RoleArn, Missing>, value: string) : CloudwatchLogDestinationState<'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.TargetArn <- value)
            ({ assignments = state.assignments } : CloudwatchLogDestinationState<'Name, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination#id-1">CloudwatchLogDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn>, value: string) : CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination#tags-1">CloudwatchLogDestination#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn>, value: seq<string * string>) : CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_destination#tags_all-1">CloudwatchLogDestination#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn>, value: seq<string * string>) : CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchLogDestinationState<'Name, 'RoleArn, 'TargetArn>

        member _.Run(state: CloudwatchLogDestinationState<Present, Present, Present>) : aws.CloudwatchLogDestination.CloudwatchLogDestination =
            let config = aws.CloudwatchLogDestination.CloudwatchLogDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDestination.CloudwatchLogDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDestination: missing required arguments. Must call: name, role_arn, target_arn.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDestinationState<_, _, _>) : aws.CloudwatchLogDestination.CloudwatchLogDestination =
            Unchecked.defaultof<aws.CloudwatchLogDestination.CloudwatchLogDestination>
