namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchEventBusesState = { assignments: ResizeArray<aws.DataAwsCloudwatchEventBuses.DataAwsCloudwatchEventBusesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_buses">aws_cloudwatch_event_buses</a>.
    /// </summary>
    type DataAwsCloudwatchEventBusesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchEventBusesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudwatchEventBusesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_buses#name_prefix-1">DataAwsCloudwatchEventBuses#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAwsCloudwatchEventBusesState, value: string) : DataAwsCloudwatchEventBusesState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAwsCloudwatchEventBusesState

        member _.Run(state: DataAwsCloudwatchEventBusesState) : aws.DataAwsCloudwatchEventBuses.DataAwsCloudwatchEventBuses =
            let config = aws.DataAwsCloudwatchEventBuses.DataAwsCloudwatchEventBusesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchEventBuses.DataAwsCloudwatchEventBuses(StackContext.get (), logicalId, config)
