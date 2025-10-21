namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorDiagnosticCategoriesState<'ResourceId> = { assignments: ResizeArray<azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategoriesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_diagnostic_categories">azurerm_monitor_diagnostic_categories</a>.
    /// </summary>
    type DataAzurermMonitorDiagnosticCategoriesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorDiagnosticCategoriesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorDiagnosticCategoriesState<Missing>)

        member _.Zero(()) : DataAzurermMonitorDiagnosticCategoriesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorDiagnosticCategoriesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_diagnostic_categories#resource_id-1">DataAzurermMonitorDiagnosticCategories#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: DataAzurermMonitorDiagnosticCategoriesState<Missing>, value: string) : DataAzurermMonitorDiagnosticCategoriesState<Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorDiagnosticCategoriesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_diagnostic_categories#id-1">DataAzurermMonitorDiagnosticCategories#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorDiagnosticCategoriesState<'ResourceId>, value: string) : DataAzurermMonitorDiagnosticCategoriesState<'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorDiagnosticCategoriesState<'ResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_diagnostic_categories#timeouts-1">DataAzurermMonitorDiagnosticCategories#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorDiagnosticCategoriesState<'ResourceId>, value: azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategoriesTimeouts) : DataAzurermMonitorDiagnosticCategoriesState<'ResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorDiagnosticCategoriesState<'ResourceId>

        member _.Run(state: DataAzurermMonitorDiagnosticCategoriesState<Present>) : azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategories =
            let config = azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategoriesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategories(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorDiagnosticCategories: missing required arguments. Must call: resource_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorDiagnosticCategoriesState<_>) : azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategories =
            Unchecked.defaultof<azurerm.DataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategories>
