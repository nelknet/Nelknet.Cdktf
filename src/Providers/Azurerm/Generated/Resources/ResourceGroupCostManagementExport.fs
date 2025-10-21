namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> = { assignments: ResizeArray<azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export">azurerm_resource_group_cost_management_export</a>.
    /// </summary>
    type ResourceGroupCostManagementExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ResourceGroupCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupCostManagementExportState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// export_data_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#export_data_options-1">ResourceGroupCostManagementExport#export_data_options</a>
        /// </summary>
        [<CustomOperation "export_data_options">]
        member _.ExportDataOptions(state: ResourceGroupCostManagementExportState<Missing, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExportExportDataOptions) : ResourceGroupCostManagementExportState<Present, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ExportDataOptions <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<Present, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>)

        /// <summary>
        /// export_data_storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#export_data_storage_location-1">ResourceGroupCostManagementExport#export_data_storage_location</a>
        /// </summary>
        [<CustomOperation "export_data_storage_location">]
        member _.ExportDataStorageLocation(state: ResourceGroupCostManagementExportState<'ExportDataOptions, Missing, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExportExportDataStorageLocation) : ResourceGroupCostManagementExportState<'ExportDataOptions, Present, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ExportDataStorageLocation <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<'ExportDataOptions, Present, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#name-1">ResourceGroupCostManagementExport#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, Missing, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: string) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, Present, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, Present, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#recurrence_period_end_date-1">ResourceGroupCostManagementExport#recurrence_period_end_date</a>.
        /// </summary>
        [<CustomOperation "recurrence_period_end_date">]
        member _.RecurrencePeriodEndDate(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Missing, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: string) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Present, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.RecurrencePeriodEndDate <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, Present, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#recurrence_period_start_date-1">ResourceGroupCostManagementExport#recurrence_period_start_date</a>.
        /// </summary>
        [<CustomOperation "recurrence_period_start_date">]
        member _.RecurrencePeriodStartDate(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Missing, 'RecurrenceType, 'ResourceGroupId>, value: string) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Present, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.RecurrencePeriodStartDate <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, Present, 'RecurrenceType, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#recurrence_type-1">ResourceGroupCostManagementExport#recurrence_type</a>.
        /// </summary>
        [<CustomOperation "recurrence_type">]
        member _.RecurrenceType(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Missing, 'ResourceGroupId>, value: string) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Present, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.RecurrenceType <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, Present, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#resource_group_id-1">ResourceGroupCostManagementExport#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, Missing>, value: string) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#active-1">ResourceGroupCostManagementExport#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: bool) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#active-1">ResourceGroupCostManagementExport#active</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#id-1">ResourceGroupCostManagementExport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: string) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_export#timeouts-1">ResourceGroupCostManagementExport#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>, value: azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExportTimeouts) : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupCostManagementExportState<'ExportDataOptions, 'ExportDataStorageLocation, 'Name, 'RecurrencePeriodEndDate, 'RecurrencePeriodStartDate, 'RecurrenceType, 'ResourceGroupId>

        member _.Run(state: ResourceGroupCostManagementExportState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExport =
            let config = azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExportConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroupCostManagementExport: missing required arguments. Must call: export_data_options, export_data_storage_location, name, recurrence_period_end_date, recurrence_period_start_date, recurrence_type, resource_group_id.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupCostManagementExportState<_, _, _, _, _, _, _>) : azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExport =
            Unchecked.defaultof<azurerm.ResourceGroupCostManagementExport.ResourceGroupCostManagementExport>
