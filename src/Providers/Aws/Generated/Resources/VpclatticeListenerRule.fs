namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier> = { assignments: ResizeArray<aws.VpclatticeListenerRule.VpclatticeListenerRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule">aws_vpclattice_listener_rule</a>.
    /// </summary>
    type VpclatticeListenerRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeListenerRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeListenerRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VpclatticeListenerRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeListenerRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#action-1">VpclatticeListenerRule#action</a>
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: VpclatticeListenerRuleState<Missing, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>, value: aws.VpclatticeListenerRule.VpclatticeListenerRuleAction) : VpclatticeListenerRuleState<Present, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : VpclatticeListenerRuleState<Present, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#listener_identifier-1">VpclatticeListenerRule#listener_identifier</a>.
        /// </summary>
        [<CustomOperation "listener_identifier">]
        member _.ListenerIdentifier(state: VpclatticeListenerRuleState<'Action, Missing, 'Match, 'Name, 'Priority, 'ServiceIdentifier>, value: string) : VpclatticeListenerRuleState<'Action, Present, 'Match, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.ListenerIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeListenerRuleState<'Action, Present, 'Match, 'Name, 'Priority, 'ServiceIdentifier>)

        /// <summary>
        /// match block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#match-1">VpclatticeListenerRule#match</a>
        /// </summary>
        [<CustomOperation "match">]
        member _.Match(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, Missing, 'Name, 'Priority, 'ServiceIdentifier>, value: aws.VpclatticeListenerRule.VpclatticeListenerRuleMatch) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, Present, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Match <- value)
            ({ assignments = state.assignments } : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, Present, 'Name, 'Priority, 'ServiceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#name-1">VpclatticeListenerRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, Missing, 'Priority, 'ServiceIdentifier>, value: string) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, Present, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, Present, 'Priority, 'ServiceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#priority-1">VpclatticeListenerRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, Missing, 'ServiceIdentifier>, value: double) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, Present, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, Present, 'ServiceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#service_identifier-1">VpclatticeListenerRule#service_identifier</a>.
        /// </summary>
        [<CustomOperation "service_identifier">]
        member _.ServiceIdentifier(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, Missing>, value: string) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, Present> =
            state.assignments.Add(fun config -> config.ServiceIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#id-1">VpclatticeListenerRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>, value: string) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#tags-1">VpclatticeListenerRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>, value: seq<string * string>) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#tags_all-1">VpclatticeListenerRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>, value: seq<string * string>) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#timeouts-1">VpclatticeListenerRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>, value: aws.VpclatticeListenerRule.VpclatticeListenerRuleTimeouts) : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeListenerRuleState<'Action, 'ListenerIdentifier, 'Match, 'Name, 'Priority, 'ServiceIdentifier>

        member _.Run(state: VpclatticeListenerRuleState<Present, Present, Present, Present, Present, Present>) : aws.VpclatticeListenerRule.VpclatticeListenerRule =
            let config = aws.VpclatticeListenerRule.VpclatticeListenerRuleConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeListenerRule.VpclatticeListenerRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeListenerRule: missing required arguments. Must call: action, listener_identifier, match, name, priority, service_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeListenerRuleState<_, _, _, _, _, _>) : aws.VpclatticeListenerRule.VpclatticeListenerRule =
            Unchecked.defaultof<aws.VpclatticeListenerRule.VpclatticeListenerRule>
