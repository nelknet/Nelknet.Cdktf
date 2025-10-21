namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventRuleState = { assignments: ResizeArray<aws.CloudwatchEventRule.CloudwatchEventRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule">aws_cloudwatch_event_rule</a>.
    /// </summary>
    type CloudwatchEventRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventRuleState =
            { assignments = ResizeArray() }

        member _.Zero(()) : CloudwatchEventRuleState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#description-1">CloudwatchEventRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#event_bus_name-1">CloudwatchEventRule#event_bus_name</a>.
        /// </summary>
        [<CustomOperation "event_bus_name">]
        member _.EventBusName(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.EventBusName <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#event_pattern-1">CloudwatchEventRule#event_pattern</a>.
        /// </summary>
        [<CustomOperation "event_pattern">]
        member _.EventPattern(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.EventPattern <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#force_destroy-1">CloudwatchEventRule#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: CloudwatchEventRuleState, value: bool) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#force_destroy-1">CloudwatchEventRule#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: CloudwatchEventRuleState, value: HashiCorp.Cdktf.IResolvable) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#id-1">CloudwatchEventRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#is_enabled-1">CloudwatchEventRule#is_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_enabled">]
        member _.IsEnabled(state: CloudwatchEventRuleState, value: bool) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.IsEnabled <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#is_enabled-1">CloudwatchEventRule#is_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_enabled">]
        member _.IsEnabled(state: CloudwatchEventRuleState, value: HashiCorp.Cdktf.IResolvable) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.IsEnabled <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#name-1">CloudwatchEventRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#name_prefix-1">CloudwatchEventRule#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#role_arn-1">CloudwatchEventRule#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#schedule_expression-1">CloudwatchEventRule#schedule_expression</a>.
        /// </summary>
        [<CustomOperation "schedule_expression">]
        member _.ScheduleExpression(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.ScheduleExpression <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#state-1">CloudwatchEventRule#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: CloudwatchEventRuleState, value: string) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.State <- value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#tags-1">CloudwatchEventRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchEventRuleState, value: seq<string * string>) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchEventRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_rule#tags_all-1">CloudwatchEventRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchEventRuleState, value: seq<string * string>) : CloudwatchEventRuleState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchEventRuleState

        member _.Run(state: CloudwatchEventRuleState) : aws.CloudwatchEventRule.CloudwatchEventRule =
            let config = aws.CloudwatchEventRule.CloudwatchEventRuleConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventRule.CloudwatchEventRule(StackContext.get (), logicalId, config)
