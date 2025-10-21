namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchEventSourceState = { assignments: ResizeArray<aws.DataAwsCloudwatchEventSource.DataAwsCloudwatchEventSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_source">aws_cloudwatch_event_source</a>.
    /// </summary>
    type DataAwsCloudwatchEventSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchEventSourceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudwatchEventSourceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_source#id-1">DataAwsCloudwatchEventSource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudwatchEventSourceState, value: string) : DataAwsCloudwatchEventSourceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudwatchEventSourceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_source#name_prefix-1">DataAwsCloudwatchEventSource#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAwsCloudwatchEventSourceState, value: string) : DataAwsCloudwatchEventSourceState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAwsCloudwatchEventSourceState

        member _.Run(state: DataAwsCloudwatchEventSourceState) : aws.DataAwsCloudwatchEventSource.DataAwsCloudwatchEventSource =
            let config = aws.DataAwsCloudwatchEventSource.DataAwsCloudwatchEventSourceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchEventSource.DataAwsCloudwatchEventSource(StackContext.get (), logicalId, config)
