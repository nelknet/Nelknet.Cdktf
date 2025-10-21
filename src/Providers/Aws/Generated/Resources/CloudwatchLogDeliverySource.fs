namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDeliverySourceState<'LogType, 'Name, 'ResourceArn> = { assignments: ResizeArray<aws.CloudwatchLogDeliverySource.CloudwatchLogDeliverySourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_source">aws_cloudwatch_log_delivery_source</a>.
    /// </summary>
    type CloudwatchLogDeliverySourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDeliverySourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliverySourceState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchLogDeliverySourceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliverySourceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_source#log_type-1">CloudwatchLogDeliverySource#log_type</a>.
        /// </summary>
        [<CustomOperation "log_type">]
        member _.LogType(state: CloudwatchLogDeliverySourceState<Missing, 'Name, 'ResourceArn>, value: string) : CloudwatchLogDeliverySourceState<Present, 'Name, 'ResourceArn> =
            state.assignments.Add(fun config -> config.LogType <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliverySourceState<Present, 'Name, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_source#name-1">CloudwatchLogDeliverySource#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogDeliverySourceState<'LogType, Missing, 'ResourceArn>, value: string) : CloudwatchLogDeliverySourceState<'LogType, Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliverySourceState<'LogType, Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_source#resource_arn-1">CloudwatchLogDeliverySource#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: CloudwatchLogDeliverySourceState<'LogType, 'Name, Missing>, value: string) : CloudwatchLogDeliverySourceState<'LogType, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliverySourceState<'LogType, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_source#tags-1">CloudwatchLogDeliverySource#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchLogDeliverySourceState<'LogType, 'Name, 'ResourceArn>, value: seq<string * string>) : CloudwatchLogDeliverySourceState<'LogType, 'Name, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchLogDeliverySourceState<'LogType, 'Name, 'ResourceArn>

        member _.Run(state: CloudwatchLogDeliverySourceState<Present, Present, Present>) : aws.CloudwatchLogDeliverySource.CloudwatchLogDeliverySource =
            let config = aws.CloudwatchLogDeliverySource.CloudwatchLogDeliverySourceConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDeliverySource.CloudwatchLogDeliverySource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDeliverySource: missing required arguments. Must call: log_type, name, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDeliverySourceState<_, _, _>) : aws.CloudwatchLogDeliverySource.CloudwatchLogDeliverySource =
            Unchecked.defaultof<aws.CloudwatchLogDeliverySource.CloudwatchLogDeliverySource>
