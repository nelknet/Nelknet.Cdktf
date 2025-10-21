namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> = { assignments: ResizeArray<azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export">azurerm_billing_account_cost_management_export</a>.
    /// </summary>
    type BillingAccountCostManagementExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : BillingAccountCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BillingAccountCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BillingAccountCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BillingAccountCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#billing_account_id-1">BillingAccountCostManagementExport#billing_account_id</a>.
        /// </summary>
        [<CustomOperation "billing_account_id">]
        member _.BillingAccountId(state: BillingAccountCostManagementExportState<Missing, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: string) : BillingAccountCostManagementExportState<Present, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.BillingAccountId <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<Present, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>)

        /// <summary>
        /// export_data_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#export_data_options-1">BillingAccountCostManagementExport#export_data_options</a>
        /// </summary>
        [<CustomOperation "export_data_options">]
        member _.ExportDataOptions(state: BillingAccountCostManagementExportState<'BillingAccountId, Missing, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptions) : BillingAccountCostManagementExportState<'BillingAccountId, Present, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.ExportDataOptions <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<'BillingAccountId, Present, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>)

        /// <summary>
        /// export_data_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#export_data_storage_location-1">BillingAccountCostManagementExport#export_data_storage_location</a>
        /// </summary>
        [<CustomOperation "export_data_storage_location">]
        member _.ExportDataStorageLocation(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, Missing, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, Present, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.ExportDataStorageLocation <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, Present, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#name-1">BillingAccountCostManagementExport#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, Missing, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: string) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, Present, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, Present, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#recurrence_period_end_date-1">BillingAccountCostManagementExport#recurrence_period_end_date</a>.
        /// </summary>
        [<CustomOperation "recurrence_period_end_date">]
        member _.RecurrencePeriodEndDate(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Missing, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: string) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Present, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.RecurrencePeriodEndDate <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Present, 'RecurrencePeriodStartDate, 'RecurrenceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#recurrence_period_start_date-1">BillingAccountCostManagementExport#recurrence_period_start_date</a>.
        /// </summary>
        [<CustomOperation "recurrence_period_start_date">]
        member _.RecurrencePeriodStartDate(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Missing, 'RecurrenceType>, value: string) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Present, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.RecurrencePeriodStartDate <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Present, 'RecurrenceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#recurrence_type-1">BillingAccountCostManagementExport#recurrence_type</a>.
        /// </summary>
        [<CustomOperation "recurrence_type">]
        member _.RecurrenceType(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Missing>, value: string) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Present> =
            state.assignments.Add(fun config -> config.RecurrenceType <- value)
            ({ assignments = state.assignments } : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#active-1">BillingAccountCostManagementExport#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: bool) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#active-1">BillingAccountCostManagementExport#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: HashiCorp.Cdktf.IResolvable) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#id-1">BillingAccountCostManagementExport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: string) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/billing_account_cost_management_export#timeouts-1">BillingAccountCostManagementExport#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>, value: azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportTimeouts) : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BillingAccountCostManagementExportState<'BillingAccountId, 'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType>

        member _.Run(state: BillingAccountCostManagementExportState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport =
            let config = azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExportConfig()
            for setter in state.assignments do
                setter config
            azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.billingAccountCostManagementExport: missing required arguments. Must call: billing_account_id, export_data_options, export_data_storage_location, name, recurrence_period_end_date, recurrence_period_start_date, recurrence_type.", 9999, IsError = true)>]
        member _.Run(_: BillingAccountCostManagementExportState<_, _, _, _, _, _, _>) : azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport =
            Unchecked.defaultof<azurerm.BillingAccountCostManagementExport.BillingAccountCostManagementExport>
