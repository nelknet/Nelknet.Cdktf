namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> = { assignments: ResizeArray<azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group">azurerm_consumption_budget_resource_group</a>.
    /// </summary>
    type ConsumptionBudgetResourceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConsumptionBudgetResourceGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConsumptionBudgetResourceGroupState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConsumptionBudgetResourceGroupState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConsumptionBudgetResourceGroupState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#amount-1">ConsumptionBudgetResourceGroup#amount</a>.
        /// </summary>
        [<CustomOperation "amount">]
        member _.Amount(state: ConsumptionBudgetResourceGroupState<Missing, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: double) : ConsumptionBudgetResourceGroupState<Present, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Amount <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetResourceGroupState<Present, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#name-1">ConsumptionBudgetResourceGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConsumptionBudgetResourceGroupState<'Amount, Missing, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: string) : ConsumptionBudgetResourceGroupState<'Amount, Present, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetResourceGroupState<'Amount, Present, 'Notification, 'ResourceGroupId, 'TimePeriod>)

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#notification-1">ConsumptionBudgetResourceGroup#notification</a> Accepts: azurerm.IResolvable | azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotification[]
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, Missing, 'ResourceGroupId, 'TimePeriod>, value: HashiCorp.Cdktf.IResolvable) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, Present, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Notification <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetResourceGroupState<'Amount, 'Name, Present, 'ResourceGroupId, 'TimePeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#resource_group_id-1">ConsumptionBudgetResourceGroup#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, Missing, 'TimePeriod>, value: string) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, Present, 'TimePeriod> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, Present, 'TimePeriod>)

        /// <summary>
        /// time_period block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#time_period-1">ConsumptionBudgetResourceGroup#time_period</a>
        /// </summary>
        [<CustomOperation "time_period">]
        member _.TimePeriod(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, Missing>, value: azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriod) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, Present> =
            state.assignments.Add(fun config -> config.TimePeriod <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#etag-1">ConsumptionBudgetResourceGroup#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: string) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#filter-1">ConsumptionBudgetResourceGroup#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#id-1">ConsumptionBudgetResourceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: string) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#time_grain-1">ConsumptionBudgetResourceGroup#time_grain</a>.
        /// </summary>
        [<CustomOperation "time_grain">]
        member _.TimeGrain(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: string) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.TimeGrain <- value)
            state : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_resource_group#timeouts-1">ConsumptionBudgetResourceGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>, value: azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeouts) : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConsumptionBudgetResourceGroupState<'Amount, 'Name, 'Notification, 'ResourceGroupId, 'TimePeriod>

        member _.Run(state: ConsumptionBudgetResourceGroupState<Present, Present, Present, Present, Present>) : azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup =
            let config = azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.consumptionBudgetResourceGroup: missing required arguments. Must call: amount, name, notification, resource_group_id, time_period.", 9999, IsError = true)>]
        member _.Run(_: ConsumptionBudgetResourceGroupState<_, _, _, _, _>) : azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup =
            Unchecked.defaultof<azurerm.ConsumptionBudgetResourceGroup.ConsumptionBudgetResourceGroup>
