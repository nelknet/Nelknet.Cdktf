namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> = { assignments: ResizeArray<azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export">azurerm_subscription_cost_management_export</a>.
    /// </summary>
    type SubscriptionCostManagementExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SubscriptionCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// export_data_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#export_data_options-1">SubscriptionCostManagementExport#export_data_options</a>
        /// </summary>
        [<CustomOperation "export_data_options">]
        member _.ExportDataOptions(state: SubscriptionCostManagementExportState<Missing, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions) : SubscriptionCostManagementExportState<Present, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ExportDataOptions <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<Present, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>)

        /// <summary>
        /// export_data_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#export_data_storage_location-1">SubscriptionCostManagementExport#export_data_storage_location</a>
        /// </summary>
        [<CustomOperation "export_data_storage_location">]
        member _.ExportDataStorageLocation(state: SubscriptionCostManagementExportState<'ExportDataOptions, Missing, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation) : SubscriptionCostManagementExportState<'ExportDataOptions, Present, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ExportDataStorageLocation <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<'ExportDataOptions, Present, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#name-1">SubscriptionCostManagementExport#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, Missing, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: string) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, Present, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, Present, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#recurrence_period_end_date-1">SubscriptionCostManagementExport#recurrence_period_end_date</a>.
        /// </summary>
        [<CustomOperation "recurrence_period_end_date">]
        member _.RecurrencePeriodEndDate(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Missing, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: string) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Present, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.RecurrencePeriodEndDate <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Present, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#recurrence_period_start_date-1">SubscriptionCostManagementExport#recurrence_period_start_date</a>.
        /// </summary>
        [<CustomOperation "recurrence_period_start_date">]
        member _.RecurrencePeriodStartDate(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Missing, 'RecurrenceType, 'SubscriptionId>, value: string) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Present, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.RecurrencePeriodStartDate <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Present, 'RecurrenceType, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#recurrence_type-1">SubscriptionCostManagementExport#recurrence_type</a>.
        /// </summary>
        [<CustomOperation "recurrence_type">]
        member _.RecurrenceType(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Missing, 'SubscriptionId>, value: string) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.RecurrenceType <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#subscription_id-1">SubscriptionCostManagementExport#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, Missing>, value: string) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#active-1">SubscriptionCostManagementExport#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: bool) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#active-1">SubscriptionCostManagementExport#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#id-1">SubscriptionCostManagementExport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: string) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#timeouts-1">SubscriptionCostManagementExport#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>, value: azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportTimeouts) : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'SubscriptionId>

        member _.Run(state: SubscriptionCostManagementExportState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport =
            let config = azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExportConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscriptionCostManagementExport: missing required arguments. Must call: export_data_options, export_data_storage_location, name, recurrence_period_end_date, recurrence_period_start_date, recurrence_type, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionCostManagementExportState<_, _, _, _, _, _, _>) : azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport =
            Unchecked.defaultof<azurerm.SubscriptionCostManagementExport.SubscriptionCostManagementExport>
