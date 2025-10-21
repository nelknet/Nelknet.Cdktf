namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BudgetsBudgetState<'BudgetType, 'TimeUnit> = { assignments: ResizeArray<aws.BudgetsBudget.BudgetsBudgetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget">aws_budgets_budget</a>.
    /// </summary>
    type BudgetsBudgetBuilder(logicalId: string) =
        member _.Yield(_: unit) : BudgetsBudgetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BudgetsBudgetState<Missing, Missing>)

        member _.Zero(()) : BudgetsBudgetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BudgetsBudgetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#budget_type-1">BudgetsBudget#budget_type</a>.
        /// </summary>
        [<CustomOperation "budget_type">]
        member _.BudgetType(state: BudgetsBudgetState<Missing, 'TimeUnit>, value: string) : BudgetsBudgetState<Present, 'TimeUnit> =
            state.assignments.Add(fun config -> config.BudgetType <- value)
            ({ assignments = state.assignments } : BudgetsBudgetState<Present, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#time_unit-1">BudgetsBudget#time_unit</a>.
        /// </summary>
        [<CustomOperation "time_unit">]
        member _.TimeUnit(state: BudgetsBudgetState<'BudgetType, Missing>, value: string) : BudgetsBudgetState<'BudgetType, Present> =
            state.assignments.Add(fun config -> config.TimeUnit <- value)
            ({ assignments = state.assignments } : BudgetsBudgetState<'BudgetType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#account_id-1">BudgetsBudget#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// auto_adjust_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#auto_adjust_data-1">BudgetsBudget#auto_adjust_data</a>
        /// </summary>
        [<CustomOperation "auto_adjust_data">]
        member _.AutoAdjustData(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: aws.BudgetsBudget.BudgetsBudgetAutoAdjustData) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.AutoAdjustData <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// cost_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#cost_filter-1">BudgetsBudget#cost_filter</a> Accepts: aws.IResolvable | aws.BudgetsBudget.BudgetsBudgetCostFilter[]
        /// </summary>
        [<CustomOperation "cost_filter">]
        member _.CostFilter(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: HashiCorp.Cdktf.IResolvable) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.CostFilter <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// cost_types block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#cost_types-1">BudgetsBudget#cost_types</a>
        /// </summary>
        [<CustomOperation "cost_types">]
        member _.CostTypes(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: aws.BudgetsBudget.BudgetsBudgetCostTypes) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.CostTypes <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#id-1">BudgetsBudget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#limit_amount-1">BudgetsBudget#limit_amount</a>.
        /// </summary>
        [<CustomOperation "limit_amount">]
        member _.LimitAmount(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.LimitAmount <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#limit_unit-1">BudgetsBudget#limit_unit</a>.
        /// </summary>
        [<CustomOperation "limit_unit">]
        member _.LimitUnit(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.LimitUnit <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#name-1">BudgetsBudget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#name_prefix-1">BudgetsBudget#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#notification-1">BudgetsBudget#notification</a> Accepts: aws.IResolvable | aws.BudgetsBudget.BudgetsBudgetNotification[]
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: HashiCorp.Cdktf.IResolvable) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Notification <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// planned_limit block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#planned_limit-1">BudgetsBudget#planned_limit</a> Accepts: aws.IResolvable | aws.BudgetsBudget.BudgetsBudgetPlannedLimit[]
        /// </summary>
        [<CustomOperation "planned_limit">]
        member _.PlannedLimit(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: HashiCorp.Cdktf.IResolvable) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.PlannedLimit <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#tags-1">BudgetsBudget#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: seq<string * string>) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#tags_all-1">BudgetsBudget#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: seq<string * string>) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#time_period_end-1">BudgetsBudget#time_period_end</a>.
        /// </summary>
        [<CustomOperation "time_period_end">]
        member _.TimePeriodEnd(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.TimePeriodEnd <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/budgets_budget#time_period_start-1">BudgetsBudget#time_period_start</a>.
        /// </summary>
        [<CustomOperation "time_period_start">]
        member _.TimePeriodStart(state: BudgetsBudgetState<'BudgetType, 'TimeUnit>, value: string) : BudgetsBudgetState<'BudgetType, 'TimeUnit> =
            state.assignments.Add(fun config -> config.TimePeriodStart <- value)
            state : BudgetsBudgetState<'BudgetType, 'TimeUnit>

        member _.Run(state: BudgetsBudgetState<Present, Present>) : aws.BudgetsBudget.BudgetsBudget =
            let config = aws.BudgetsBudget.BudgetsBudgetConfig()
            for setter in state.assignments do
                setter config
            aws.BudgetsBudget.BudgetsBudget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.budgetsBudget: missing required arguments. Must call: budget_type, time_unit.", 9999, IsError = true)>]
        member _.Run(_: BudgetsBudgetState<_, _>) : aws.BudgetsBudget.BudgetsBudget =
            Unchecked.defaultof<aws.BudgetsBudget.BudgetsBudget>
