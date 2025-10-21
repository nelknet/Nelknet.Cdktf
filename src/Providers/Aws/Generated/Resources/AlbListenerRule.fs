namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AlbListenerRuleState<'Action, 'Condition, 'ListenerArn> = { assignments: ResizeArray<aws.AlbListenerRule.AlbListenerRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule">aws_alb_listener_rule</a>.
    /// </summary>
    type AlbListenerRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AlbListenerRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbListenerRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : AlbListenerRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbListenerRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#action-1">AlbListenerRule#action</a> Accepts: aws.IResolvable | aws.AlbListenerRule.AlbListenerRuleAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: AlbListenerRuleState<Missing, 'Condition, 'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : AlbListenerRuleState<Present, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : AlbListenerRuleState<Present, 'Condition, 'ListenerArn>)

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#condition-1">AlbListenerRule#condition</a> Accepts: aws.IResolvable | aws.AlbListenerRule.AlbListenerRuleCondition[]
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: AlbListenerRuleState<'Action, Missing, 'ListenerArn>, value: HashiCorp.Cdktf.IResolvable) : AlbListenerRuleState<'Action, Present, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Condition <- value)
            ({ assignments = state.assignments } : AlbListenerRuleState<'Action, Present, 'ListenerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#listener_arn-1">AlbListenerRule#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: AlbListenerRuleState<'Action, 'Condition, Missing>, value: string) : AlbListenerRuleState<'Action, 'Condition, Present> =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            ({ assignments = state.assignments } : AlbListenerRuleState<'Action, 'Condition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#id-1">AlbListenerRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: string) : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#priority-1">AlbListenerRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: double) : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#tags-1">AlbListenerRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: seq<string * string>) : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_rule#tags_all-1">AlbListenerRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>, value: seq<string * string>) : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AlbListenerRuleState<'Action, 'Condition, 'ListenerArn>

        member _.Run(state: AlbListenerRuleState<Present, Present, Present>) : aws.AlbListenerRule.AlbListenerRule =
            let config = aws.AlbListenerRule.AlbListenerRuleConfig()
            for setter in state.assignments do
                setter config
            aws.AlbListenerRule.AlbListenerRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.albListenerRule: missing required arguments. Must call: action, condition, listener_arn.", 9999, IsError = true)>]
        member _.Run(_: AlbListenerRuleState<_, _, _>) : aws.AlbListenerRule.AlbListenerRule =
            Unchecked.defaultof<aws.AlbListenerRule.AlbListenerRule>
