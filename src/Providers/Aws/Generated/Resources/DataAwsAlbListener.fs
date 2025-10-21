namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAlbListenerState = { assignments: ResizeArray<aws.DataAwsAlbListener.DataAwsAlbListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener">aws_alb_listener</a>.
    /// </summary>
    type DataAwsAlbListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAlbListenerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAlbListenerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#arn-1">DataAwsAlbListener#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsAlbListenerState, value: string) : DataAwsAlbListenerState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsAlbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#id-1">DataAwsAlbListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAlbListenerState, value: string) : DataAwsAlbListenerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAlbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#load_balancer_arn-1">DataAwsAlbListener#load_balancer_arn</a>.
        /// </summary>
        [<CustomOperation "load_balancer_arn">]
        member _.LoadBalancerArn(state: DataAwsAlbListenerState, value: string) : DataAwsAlbListenerState =
            state.assignments.Add(fun config -> config.LoadBalancerArn <- value)
            state : DataAwsAlbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#port-1">DataAwsAlbListener#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: DataAwsAlbListenerState, value: double) : DataAwsAlbListenerState =
            state.assignments.Add(fun config -> config.Port <- value)
            state : DataAwsAlbListenerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#tags-1">DataAwsAlbListener#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAlbListenerState, value: seq<string * string>) : DataAwsAlbListenerState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAlbListenerState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#timeouts-1">DataAwsAlbListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAlbListenerState, value: aws.DataAwsAlbListener.DataAwsAlbListenerTimeouts) : DataAwsAlbListenerState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAlbListenerState

        member _.Run(state: DataAwsAlbListenerState) : aws.DataAwsAlbListener.DataAwsAlbListener =
            let config = aws.DataAwsAlbListener.DataAwsAlbListenerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAlbListener.DataAwsAlbListener(StackContext.get (), logicalId, config)
