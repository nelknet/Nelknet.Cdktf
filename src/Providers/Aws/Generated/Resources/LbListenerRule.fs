namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbListenerRuleState<'Action, 'Condition, 'ListenerArn> = { assignments: ResizeArray<aws.LbListenerRule.LbListenerRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule">aws_lb_listener_rule</a>.
    /// </summary>
    type LbListenerRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbListenerRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbListenerRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : LbListenerRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbListenerRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#action-1">LbListenerRule#action</a> Accepts: aws.IResolvable | aws.LbListenerRule.LbListenerRuleAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: LbListenerRuleState<Missing, 'Condition, 'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : LbListenerRuleState<Present, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : LbListenerRuleState<Present, 'Condition, 'ListenerArn>)

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#condition-1">LbListenerRule#condition</a> Accepts: aws.IResolvable | aws.LbListenerRule.LbListenerRuleCondition[]
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: LbListenerRuleState<'Action, Missing, 'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : LbListenerRuleState<'Action, Present, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Condition <- value)
            ({ assignments = state.assignments } : LbListenerRuleState<'Action, Present, 'ListenerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#listener_arn-1">LbListenerRule#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: LbListenerRuleState<'Action, 'Condition, Missing>, value: string) : LbListenerRuleState<'Action, 'Condition, Present> =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            ({ assignments = state.assignments } : LbListenerRuleState<'Action, 'Condition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#id-1">LbListenerRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: string) : LbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#priority-1">LbListenerRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: LbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: double) : LbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : LbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#tags-1">LbListenerRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: seq<string * string>) : LbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_rule#tags_all-1">LbListenerRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: seq<string * string>) : LbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        member _.Run(state: LbListenerRuleState<Present, Present, Present>) : aws.LbListenerRule.LbListenerRule =
            let config = aws.LbListenerRule.LbListenerRuleConfig()
            for setter in state.assignments do
                setter config
            aws.LbListenerRule.LbListenerRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbListenerRule: missing required arguments. Must call: action, condition, listener_arn.", 9999, IsError = true)>]
        member _.Run(_: LbListenerRuleState<_, _, _>) : aws.LbListenerRule.LbListenerRule =
            Unchecked.defaultof<aws.LbListenerRule.LbListenerRule>
