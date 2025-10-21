namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbListenerRuleState = { assignments: ResizeArray<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule">aws_lb_listener_rule</a>.
    /// </summary>
    type DataAwsLbListenerRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbListenerRuleState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbListenerRuleState =
            { assignments = ResizeArray() }

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#action-1">DataAwsLbListenerRule#action</a> Accepts: aws.IResolvable | aws.DataAwsLbListenerRule.DataAwsLbListenerRuleAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: DataAwsLbListenerRuleState, value: HashiCorp.Cdktf.IResolvable) : DataAwsLbListenerRuleState =
            state.assignments.Add(fun config -> config.Action <- value)
            state : DataAwsLbListenerRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#arn-1">DataAwsLbListenerRule#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLbListenerRuleState, value: string) : DataAwsLbListenerRuleState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsLbListenerRuleState

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#condition-1">DataAwsLbListenerRule#condition</a> Accepts: aws.IResolvable | aws.DataAwsLbListenerRule.DataAwsLbListenerRuleCondition[]
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: DataAwsLbListenerRuleState, value: HashiCorp.Cdktf.IResolvable) : DataAwsLbListenerRuleState =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : DataAwsLbListenerRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#listener_arn-1">DataAwsLbListenerRule#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: DataAwsLbListenerRuleState, value: string) : DataAwsLbListenerRuleState =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            state : DataAwsLbListenerRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#priority-1">DataAwsLbListenerRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: DataAwsLbListenerRuleState, value: double) : DataAwsLbListenerRuleState =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : DataAwsLbListenerRuleState

        member _.Run(state: DataAwsLbListenerRuleState) : aws.DataAwsLbListenerRule.DataAwsLbListenerRule =
            let config = aws.DataAwsLbListenerRule.DataAwsLbListenerRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLbListenerRule.DataAwsLbListenerRule(StackContext.get (), logicalId, config)
