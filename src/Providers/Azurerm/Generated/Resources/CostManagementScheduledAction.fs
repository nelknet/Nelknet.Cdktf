namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> = { assignments: ResizeArray<azurerm.CostManagementScheduledAction.CostManagementScheduledActionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action">azurerm_cost_management_scheduled_action</a>.
    /// </summary>
    type CostManagementScheduledActionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CostManagementScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CostManagementScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CostManagementScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CostManagementScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#display_name-1">CostManagementScheduledAction#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: CostManagementScheduledActionState<Missing, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<Present, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<Present, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#email_addresses-1">CostManagementScheduledAction#email_addresses</a>.
        /// </summary>
        [<CustomOperation "email_addresses">]
        member _.EmailAddresses(state: CostManagementScheduledActionState<'DisplayName, Missing, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: seq<string>) : CostManagementScheduledActionState<'DisplayName, Present, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.EmailAddresses <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, Present, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#email_address_sender-1">CostManagementScheduledAction#email_address_sender</a>.
        /// </summary>
        [<CustomOperation "email_address_sender">]
        member _.EmailAddressSender(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, Missing, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, Present, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.EmailAddressSender <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, Present, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#email_subject-1">CostManagementScheduledAction#email_subject</a>.
        /// </summary>
        [<CustomOperation "email_subject">]
        member _.EmailSubject(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, Missing, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, Present, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.EmailSubject <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, Present, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#end_date-1">CostManagementScheduledAction#end_date</a>.
        /// </summary>
        [<CustomOperation "end_date">]
        member _.EndDate(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, Missing, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, Present, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.EndDate <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, Present, 'Frequency, 'Name, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#frequency-1">CostManagementScheduledAction#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, Missing, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, Present, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, Present, 'Name, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#name-1">CostManagementScheduledAction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, Missing, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, Present, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, Present, 'StartDate, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#start_date-1">CostManagementScheduledAction#start_date</a>.
        /// </summary>
        [<CustomOperation "start_date">]
        member _.StartDate(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, Missing, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, Present, 'ViewId> =
            state.assignments.Add(fun config -> config.StartDate <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, Present, 'ViewId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#view_id-1">CostManagementScheduledAction#view_id</a>.
        /// </summary>
        [<CustomOperation "view_id">]
        member _.ViewId(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, Missing>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, Present> =
            state.assignments.Add(fun config -> config.ViewId <- value)
            ({ assignments = state.assignments } : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#day_of_month-1">CostManagementScheduledAction#day_of_month</a>.
        /// </summary>
        [<CustomOperation "day_of_month">]
        member _.DayOfMonth(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: double) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.DayOfMonth <- value)
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#days_of_week-1">CostManagementScheduledAction#days_of_week</a>.
        /// </summary>
        [<CustomOperation "days_of_week">]
        member _.DaysOfWeek(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: seq<string>) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.DaysOfWeek <- (value |> Seq.toArray))
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#hour_of_day-1">CostManagementScheduledAction#hour_of_day</a>.
        /// </summary>
        [<CustomOperation "hour_of_day">]
        member _.HourOfDay(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: double) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.HourOfDay <- value)
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#id-1">CostManagementScheduledAction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#message-1">CostManagementScheduledAction#message</a>.
        /// </summary>
        [<CustomOperation "message">]
        member _.Message(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: string) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.Message <- value)
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#timeouts-1">CostManagementScheduledAction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: azurerm.CostManagementScheduledAction.CostManagementScheduledActionTimeouts) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cost_management_scheduled_action#weeks_of_month-1">CostManagementScheduledAction#weeks_of_month</a>.
        /// </summary>
        [<CustomOperation "weeks_of_month">]
        member _.WeeksOfMonth(state: CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>, value: seq<string>) : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId> =
            state.assignments.Add(fun config -> config.WeeksOfMonth <- (value |> Seq.toArray))
            state : CostManagementScheduledActionState<'DisplayName, 'EmailAddresses, 'EmailAddressSender, 'EmailSubject, 'EndDate, 'Frequency, 'Name, 'StartDate, 'ViewId>

        member _.Run(state: CostManagementScheduledActionState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.CostManagementScheduledAction.CostManagementScheduledAction =
            let config = azurerm.CostManagementScheduledAction.CostManagementScheduledActionConfig()
            for setter in state.assignments do
                setter config
            azurerm.CostManagementScheduledAction.CostManagementScheduledAction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.costManagementScheduledAction: missing required arguments. Must call: display_name, email_addresses, email_address_sender, email_subject, end_date, frequency, name, start_date, view_id.", 9999, IsError = true)>]
        member _.Run(_: CostManagementScheduledActionState<_, _, _, _, _, _, _, _, _>) : azurerm.CostManagementScheduledAction.CostManagementScheduledAction =
            Unchecked.defaultof<azurerm.CostManagementScheduledAction.CostManagementScheduledAction>
