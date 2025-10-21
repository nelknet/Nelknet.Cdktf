namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogStreamState<'LogGroupName, 'Name> = { assignments: ResizeArray<aws.CloudwatchLogStream.CloudwatchLogStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_stream">aws_cloudwatch_log_stream</a>.
    /// </summary>
    type CloudwatchLogStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogStreamState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogStreamState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogStreamState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogStreamState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_stream#log_group_name-1">CloudwatchLogStream#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: CloudwatchLogStreamState<Missing, 'Name>, value: string) : CloudwatchLogStreamState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            ({ assignments = state.assignments } : CloudwatchLogStreamState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_stream#name-1">CloudwatchLogStream#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogStreamState<'LogGroupName, Missing>, value: string) : CloudwatchLogStreamState<'LogGroupName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchLogStreamState<'LogGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_stream#id-1">CloudwatchLogStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogStreamState<'LogGroupName, 'Name>, value: string) : CloudwatchLogStreamState<'LogGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogStreamState<'LogGroupName, 'Name>

        member _.Run(state: CloudwatchLogStreamState<Present, Present>) : aws.CloudwatchLogStream.CloudwatchLogStream =
            let config = aws.CloudwatchLogStream.CloudwatchLogStreamConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogStream.CloudwatchLogStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogStream: missing required arguments. Must call: log_group_name, name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogStreamState<_, _>) : aws.CloudwatchLogStream.CloudwatchLogStream =
            Unchecked.defaultof<aws.CloudwatchLogStream.CloudwatchLogStream>
