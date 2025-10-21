namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> = { assignments: ResizeArray<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view">azurerm_resource_group_cost_management_view</a>.
    /// </summary>
    type ResourceGroupCostManagementViewBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ResourceGroupCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#accumulated-1">ResourceGroupCostManagementView#accumulated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accumulated">]
        member _.Accumulated(state: ResourceGroupCostManagementViewState<Missing, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: bool) : ResourceGroupCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Accumulated <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#accumulated-1">ResourceGroupCostManagementView#accumulated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accumulated">]
        member _.Accumulated(state: ResourceGroupCostManagementViewState<Missing, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Accumulated <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#chart_type-1">ResourceGroupCostManagementView#chart_type</a>.
        /// </summary>
        [<CustomOperation "chart_type">]
        member _.ChartType(state: ResourceGroupCostManagementViewState<'Accumulated, Missing, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, Present, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.ChartType <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, Present, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// dataset block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#dataset-1">ResourceGroupCostManagementView#dataset</a>
        /// </summary>
        [<CustomOperation "dataset">]
        member _.Dataset(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, Missing, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewDataset) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, Present, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Dataset <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, Present, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#display_name-1">ResourceGroupCostManagementView#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, Missing, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, Present, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, Present, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#name-1">ResourceGroupCostManagementView#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, Missing, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, Present, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, Present, 'ReportType, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#report_type-1">ResourceGroupCostManagementView#report_type</a>.
        /// </summary>
        [<CustomOperation "report_type">]
        member _.ReportType(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, Missing, 'ResourceGroupId, 'Timeframe>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, Present, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.ReportType <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, Present, 'ResourceGroupId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#resource_group_id-1">ResourceGroupCostManagementView#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, Missing, 'Timeframe>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, Present, 'Timeframe> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, Present, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#timeframe-1">ResourceGroupCostManagementView#timeframe</a>.
        /// </summary>
        [<CustomOperation "timeframe">]
        member _.Timeframe(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, Missing>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, Present> =
            state.assignments.Add(fun config -> config.Timeframe <- value)
            ({ assignments = state.assignments } : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#id-1">ResourceGroupCostManagementView#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: string) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>

        /// <summary>
        /// kpi block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#kpi-1">ResourceGroupCostManagementView#kpi</a> Accepts: azurerm.IResolvable | azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewKpi[]
        /// </summary>
        [<CustomOperation "kpi">]
        member _.Kpi(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Kpi <- value)
            state : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>

        /// <summary>
        /// pivot block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#pivot-1">ResourceGroupCostManagementView#pivot</a> Accepts: azurerm.IResolvable | azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewPivot[]
        /// </summary>
        [<CustomOperation "pivot">]
        member _.Pivot(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Pivot <- value)
            state : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_cost_management_view#timeouts-1">ResourceGroupCostManagementView#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>, value: azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewTimeouts) : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'ResourceGroupId, 'Timeframe>

        member _.Run(state: ResourceGroupCostManagementViewState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView =
            let config = azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementViewConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroupCostManagementView: missing required arguments. Must call: accumulated, chart_type, dataset, display_name, name, report_type, resource_group_id, timeframe.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupCostManagementViewState<_, _, _, _, _, _, _, _>) : azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView =
            Unchecked.defaultof<azurerm.ResourceGroupCostManagementView.ResourceGroupCostManagementView>
