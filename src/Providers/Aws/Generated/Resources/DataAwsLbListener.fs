namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbListenerState = { assignments: ResizeArray<aws.DataAwsLbListener.DataAwsLbListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener">aws_lb_listener</a>.
    /// </summary>
    type DataAwsLbListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbListenerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbListenerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#arn-1">DataAwsLbListener#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLbListenerState, value: string) : DataAwsLbListenerState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsLbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#id-1">DataAwsLbListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLbListenerState, value: string) : DataAwsLbListenerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#load_balancer_arn-1">DataAwsLbListener#load_balancer_arn</a>.
        /// </summary>
        [<CustomOperation "load_balancer_arn">]
        member _.LoadBalancerArn(state: DataAwsLbListenerState, value: string) : DataAwsLbListenerState =
            state.assignments.Add(fun config -> config.LoadBalancerArn <- value)
            state : DataAwsLbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#port-1">DataAwsLbListener#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: DataAwsLbListenerState, value: double) : DataAwsLbListenerState =
            state.assignments.Add(fun config -> config.Port <- value)
            state : DataAwsLbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#tags-1">DataAwsLbListener#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLbListenerState, value: seq<string * string>) : DataAwsLbListenerState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLbListenerState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#timeouts-1">DataAwsLbListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsLbListenerState, value: aws.DataAwsLbListener.DataAwsLbListenerTimeouts) : DataAwsLbListenerState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsLbListenerState

        member _.Run(state: DataAwsLbListenerState) : aws.DataAwsLbListener.DataAwsLbListener =
            let config = aws.DataAwsLbListener.DataAwsLbListenerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLbListener.DataAwsLbListener(StackContext.get (), logicalId, config)
