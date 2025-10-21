namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name> = { assignments: ResizeArray<aws.CloudwatchEventApiDestination.CloudwatchEventApiDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination">aws_cloudwatch_event_api_destination</a>.
    /// </summary>
    type CloudwatchEventApiDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventApiDestinationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventApiDestinationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchEventApiDestinationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventApiDestinationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#connection_arn-1">CloudwatchEventApiDestination#connection_arn</a>.
        /// </summary>
        [<CustomOperation "connection_arn">]
        member _.ConnectionArn(state: CloudwatchEventApiDestinationState<Missing, 'HttpMethod, 'InvocationEndpoint, 'Name>, value: string) : CloudwatchEventApiDestinationState<Present, 'HttpMethod, 'InvocationEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionArn <- value)
            ({ assignments = state.assignments } : CloudwatchEventApiDestinationState<Present, 'HttpMethod, 'InvocationEndpoint, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#http_method-1">CloudwatchEventApiDestination#http_method</a>.
        /// </summary>
        [<CustomOperation "http_method">]
        member _.HttpMethod(state: CloudwatchEventApiDestinationState<'ConnectionArn, Missing, 'InvocationEndpoint, 'Name>, value: string) : CloudwatchEventApiDestinationState<'ConnectionArn, Present, 'InvocationEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.HttpMethod <- value)
            ({ assignments = state.assignments } : CloudwatchEventApiDestinationState<'ConnectionArn, Present, 'InvocationEndpoint, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#invocation_endpoint-1">CloudwatchEventApiDestination#invocation_endpoint</a>.
        /// </summary>
        [<CustomOperation "invocation_endpoint">]
        member _.InvocationEndpoint(state: CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, Missing, 'Name>, value: string) : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, Present, 'Name> =
            state.assignments.Add(fun config -> config.InvocationEndpoint <- value)
            ({ assignments = state.assignments } : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#name-1">CloudwatchEventApiDestination#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, Missing>, value: string) : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#description-1">CloudwatchEventApiDestination#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name>, value: string) : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#id-1">CloudwatchEventApiDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name>, value: string) : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_api_destination#invocation_rate_limit_per_second-1">CloudwatchEventApiDestination#invocation_rate_limit_per_second</a>.
        /// </summary>
        [<CustomOperation "invocation_rate_limit_per_second">]
        member _.InvocationRateLimitPerSecond(state: CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name>, value: double) : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.InvocationRateLimitPerSecond <- value)
            state : CloudwatchEventApiDestinationState<'ConnectionArn, 'HttpMethod, 'InvocationEndpoint, 'Name>

        member _.Run(state: CloudwatchEventApiDestinationState<Present, Present, Present, Present>) : aws.CloudwatchEventApiDestination.CloudwatchEventApiDestination =
            let config = aws.CloudwatchEventApiDestination.CloudwatchEventApiDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventApiDestination.CloudwatchEventApiDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventApiDestination: missing required arguments. Must call: connection_arn, http_method, invocation_endpoint, name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventApiDestinationState<_, _, _, _>) : aws.CloudwatchEventApiDestination.CloudwatchEventApiDestination =
            Unchecked.defaultof<aws.CloudwatchEventApiDestination.CloudwatchEventApiDestination>
