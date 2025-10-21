namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource> = { assignments: ResizeArray<aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule">aws_codestarnotifications_notification_rule</a>.
    /// </summary>
    type CodestarnotificationsNotificationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodestarnotificationsNotificationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodestarnotificationsNotificationRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodestarnotificationsNotificationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodestarnotificationsNotificationRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#detail_type-1">CodestarnotificationsNotificationRule#detail_type</a>.
        /// </summary>
        [<CustomOperation "detail_type">]
        member _.DetailType(state: CodestarnotificationsNotificationRuleState<Missing, 'EventTypeIds, 'Name, 'Resource>, value: string) : CodestarnotificationsNotificationRuleState<Present, 'EventTypeIds, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.DetailType <- value)
            ({ assignments = state.assignments } : CodestarnotificationsNotificationRuleState<Present, 'EventTypeIds, 'Name, 'Resource>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#event_type_ids-1">CodestarnotificationsNotificationRule#event_type_ids</a>.
        /// </summary>
        [<CustomOperation "event_type_ids">]
        member _.EventTypeIds(state: CodestarnotificationsNotificationRuleState<'DetailType, Missing, 'Name, 'Resource>, value: seq<string>) : CodestarnotificationsNotificationRuleState<'DetailType, Present, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.EventTypeIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CodestarnotificationsNotificationRuleState<'DetailType, Present, 'Name, 'Resource>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#name-1">CodestarnotificationsNotificationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, Missing, 'Resource>, value: string) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, Present, 'Resource> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, Present, 'Resource>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#resource-1">CodestarnotificationsNotificationRule#resource</a>.
        /// </summary>
        [<CustomOperation "resource">]
        member _.Resource(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, Missing>, value: string) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, Present> =
            state.assignments.Add(fun config -> config.Resource <- value)
            ({ assignments = state.assignments } : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#id-1">CodestarnotificationsNotificationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>, value: string) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#status-1">CodestarnotificationsNotificationRule#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>, value: string) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#tags-1">CodestarnotificationsNotificationRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>, value: seq<string * string>) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#tags_all-1">CodestarnotificationsNotificationRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>, value: seq<string * string>) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarnotifications_notification_rule#target-1">CodestarnotificationsNotificationRule#target</a> Accepts: aws.IResolvable | aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRuleTarget[]
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>, value: HashiCorp.Cdktf.IResolvable) : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource> =
            state.assignments.Add(fun config -> config.Target <- value)
            state : CodestarnotificationsNotificationRuleState<'DetailType, 'EventTypeIds, 'Name, 'Resource>

        member _.Run(state: CodestarnotificationsNotificationRuleState<Present, Present, Present, Present>) : aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRule =
            let config = aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRuleConfig()
            for setter in state.assignments do
                setter config
            aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codestarnotificationsNotificationRule: missing required arguments. Must call: detail_type, event_type_ids, name, resource.", 9999, IsError = true)>]
        member _.Run(_: CodestarnotificationsNotificationRuleState<_, _, _, _>) : aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRule =
            Unchecked.defaultof<aws.CodestarnotificationsNotificationRule.CodestarnotificationsNotificationRule>
