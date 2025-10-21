namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> = { assignments: ResizeArray<azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group">azurerm_consumption_budget_management_group</a>.
    /// </summary>
    type ConsumptionBudgetManagementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConsumptionBudgetManagementGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConsumptionBudgetManagementGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConsumptionBudgetManagementGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConsumptionBudgetManagementGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#amount-1">ConsumptionBudgetManagementGroup#amount</a>.
        /// </summary>
        [<CustomOperation "amount">]
        member _.Amount(state: ConsumptionBudgetManagementGroupState<Missing, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>, value: double) : ConsumptionBudgetManagementGroupState<Present, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Amount <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetManagementGroupState<Present, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#management_group_id-1">ConsumptionBudgetManagementGroup#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ConsumptionBudgetManagementGroupState<'Amount, Missing, 'Name, 'Notification, 'TimePeriod>, value: string) : ConsumptionBudgetManagementGroupState<'Amount, Present, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetManagementGroupState<'Amount, Present, 'Name, 'Notification, 'TimePeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#name-1">ConsumptionBudgetManagementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, Missing, 'Notification, 'TimePeriod>, value: string) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, Present, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, Present, 'Notification, 'TimePeriod>)

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#notification-1">ConsumptionBudgetManagementGroup#notification</a> Accepts: azurerm.IResolvable | azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupNotification[]
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, Missing, 'TimePeriod>, value: HashiCorp.Cdktf.IResolvable) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, Present, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Notification <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, Present, 'TimePeriod>)

        /// <summary>
        /// time_period block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#time_period-1">ConsumptionBudgetManagementGroup#time_period</a>
        /// </summary>
        [<CustomOperation "time_period">]
        member _.TimePeriod(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, Missing>, value: azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupTimePeriod) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, Present> =
            state.assignments.Add(fun config -> config.TimePeriod <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#etag-1">ConsumptionBudgetManagementGroup#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>, value: string) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#filter-1">ConsumptionBudgetManagementGroup#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>, value: azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupFilter) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#id-1">ConsumptionBudgetManagementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>, value: string) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#time_grain-1">ConsumptionBudgetManagementGroup#time_grain</a>.
        /// </summary>
        [<CustomOperation "time_grain">]
        member _.TimeGrain(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>, value: string) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.TimeGrain <- value)
            state : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_management_group#timeouts-1">ConsumptionBudgetManagementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>, value: azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupTimeouts) : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConsumptionBudgetManagementGroupState<'Amount, 'ManagementGroupId, 'Name, 'Notification, 'TimePeriod>

        member _.Run(state: ConsumptionBudgetManagementGroupState<Present, Present, Present, Present, Present>) : azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroup =
            let config = azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.consumptionBudgetManagementGroup: missing required arguments. Must call: amount, management_group_id, name, notification, time_period.", 9999, IsError = true)>]
        member _.Run(_: ConsumptionBudgetManagementGroupState<_, _, _, _, _>) : azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroup =
            Unchecked.defaultof<azurerm.ConsumptionBudgetManagementGroup.ConsumptionBudgetManagementGroup>
