namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventBusPolicyState<'Policy> = { assignments: ResizeArray<aws.CloudwatchEventBusPolicy.CloudwatchEventBusPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus_policy">aws_cloudwatch_event_bus_policy</a>.
    /// </summary>
    type CloudwatchEventBusPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventBusPolicyState<Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventBusPolicyState<Missing>)

        member _.Zero(()) : CloudwatchEventBusPolicyState<Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventBusPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus_policy#policy-1">CloudwatchEventBusPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: CloudwatchEventBusPolicyState<Missing>, value: string) : CloudwatchEventBusPolicyState<Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : CloudwatchEventBusPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus_policy#event_bus_name-1">CloudwatchEventBusPolicy#event_bus_name</a>.
        /// </summary>
        [<CustomOperation "event_bus_name">]
        member _.EventBusName(state: CloudwatchEventBusPolicyState<'Policy>, value: string) : CloudwatchEventBusPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.EventBusName <- value)
            state : CloudwatchEventBusPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus_policy#id-1">CloudwatchEventBusPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventBusPolicyState<'Policy>, value: string) : CloudwatchEventBusPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventBusPolicyState<'Policy>

        member _.Run(state: CloudwatchEventBusPolicyState<Present>) : aws.CloudwatchEventBusPolicy.CloudwatchEventBusPolicy =
            let config = aws.CloudwatchEventBusPolicy.CloudwatchEventBusPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventBusPolicy.CloudwatchEventBusPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventBusPolicy: missing required arguments. Must call: policy.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventBusPolicyState<_>) : aws.CloudwatchEventBusPolicy.CloudwatchEventBusPolicy =
            Unchecked.defaultof<aws.CloudwatchEventBusPolicy.CloudwatchEventBusPolicy>
