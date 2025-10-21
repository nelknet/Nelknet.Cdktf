namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> = { assignments: ResizeArray<aws.BudgetsBudgetAction.BudgetsBudgetActionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action">aws_budgets_budget_action</a>.
    /// </summary>
    type BudgetsBudgetActionBuilder(logicalId: string) =
        member _.Yield(_: unit) : BudgetsBudgetActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BudgetsBudgetActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BudgetsBudgetActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BudgetsBudgetActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// action_threshold block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_threshold-1">BudgetsBudgetAction#action_threshold</a>
        /// </summary>
        [<CustomOperation "action_threshold">]
        member _.ActionThreshold(state: BudgetsBudgetActionState<Missing, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: aws.BudgetsBudgetAction.BudgetsBudgetActionActionThreshold) : BudgetsBudgetActionState<Present, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.ActionThreshold <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<Present, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#action_type-1">BudgetsBudgetAction#action_type</a>.
        /// </summary>
        [<CustomOperation "action_type">]
        member _.ActionType(state: BudgetsBudgetActionState<'ActionThreshold, Missing, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, Present, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.ActionType <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, Present, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#approval_model-1">BudgetsBudgetAction#approval_model</a>.
        /// </summary>
        [<CustomOperation "approval_model">]
        member _.ApprovalModel(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, Missing, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, Present, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.ApprovalModel <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, Present, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#budget_name-1">BudgetsBudgetAction#budget_name</a>.
        /// </summary>
        [<CustomOperation "budget_name">]
        member _.BudgetName(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, Missing, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, Present, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.BudgetName <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, Present, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>)

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#definition-1">BudgetsBudgetAction#definition</a>
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, Missing, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: aws.BudgetsBudgetAction.BudgetsBudgetActionDefinition) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, Present, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.Definition <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, Present, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#execution_role_arn-1">BudgetsBudgetAction#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, Missing, 'NotificationType, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, Present, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, Present, 'NotificationType, 'Subscriber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#notification_type-1">BudgetsBudgetAction#notification_type</a>.
        /// </summary>
        [<CustomOperation "notification_type">]
        member _.NotificationType(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, Missing, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, Present, 'Subscriber> =
            state.assignments.Add(fun config -> config.NotificationType <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, Present, 'Subscriber>)

        /// <summary>
        /// subscriber block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#subscriber-1">BudgetsBudgetAction#subscriber</a> Accepts: aws.IResolvable | aws.BudgetsBudgetAction.BudgetsBudgetActionSubscriber[]
        /// </summary>
        [<CustomOperation "subscriber">]
        member _.Subscriber(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, Missing>, value: HashiCorp.Cdktf.IResolvable) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, Present> =
            state.assignments.Add(fun config -> config.Subscriber <- value)
            ({ assignments = state.assignments } : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#account_id-1">BudgetsBudgetAction#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#id-1">BudgetsBudgetAction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: string) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#tags-1">BudgetsBudgetAction#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: seq<string * string>) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#tags_all-1">BudgetsBudgetAction#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: seq<string * string>) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget_action#timeouts-1">BudgetsBudgetAction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>, value: aws.BudgetsBudgetAction.BudgetsBudgetActionTimeouts) : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BudgetsBudgetActionState<'ActionThreshold, 'ActionType, 'ApprovalModel, 'BudgetName, 'Definition, 'ExecutionRoleArn, 'NotificationType, 'Subscriber>

        member _.Run(state: BudgetsBudgetActionState<Present, Present, Present, Present, Present, Present, Present, Present>) : aws.BudgetsBudgetAction.BudgetsBudgetAction =
            let config = aws.BudgetsBudgetAction.BudgetsBudgetActionConfig()
            for setter in state.assignments do
                setter config
            aws.BudgetsBudgetAction.BudgetsBudgetAction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.budgetsBudgetAction: missing required arguments. Must call: action_threshold, action_type, approval_model, budget_name, definition, execution_role_arn, notification_type, subscriber.", 9999, IsError = true)>]
        member _.Run(_: BudgetsBudgetActionState<_, _, _, _, _, _, _, _>) : aws.BudgetsBudgetAction.BudgetsBudgetAction =
            Unchecked.defaultof<aws.BudgetsBudgetAction.BudgetsBudgetAction>
