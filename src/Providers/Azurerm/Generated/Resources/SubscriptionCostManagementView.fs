namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> = { assignments: ResizeArray<azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view">azurerm_subscription_cost_management_view</a>.
    /// </summary>
    type SubscriptionCostManagementViewBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SubscriptionCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionCostManagementViewState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#accumulated-1">SubscriptionCostManagementView#accumulated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accumulated">]
        member _.Accumulated(state: SubscriptionCostManagementViewState<Missing, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: bool) : SubscriptionCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Accumulated <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#accumulated-1">SubscriptionCostManagementView#accumulated</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accumulated">]
        member _.Accumulated(state: SubscriptionCostManagementViewState<Missing, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Accumulated <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<Present, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#chart_type-1">SubscriptionCostManagementView#chart_type</a>.
        /// </summary>
        [<CustomOperation "chart_type">]
        member _.ChartType(state: SubscriptionCostManagementViewState<'Accumulated, Missing, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: string) : SubscriptionCostManagementViewState<'Accumulated, Present, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.ChartType <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, Present, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// dataset block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#dataset-1">SubscriptionCostManagementView#dataset</a>
        /// </summary>
        [<CustomOperation "dataset">]
        member _.Dataset(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, Missing, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewDataset) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, Present, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Dataset <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, Present, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#display_name-1">SubscriptionCostManagementView#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, Missing, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: string) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, Present, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, Present, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#name-1">SubscriptionCostManagementView#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, Missing, 'ReportType, 'SubscriptionId, 'Timeframe>, value: string) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, Present, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, Present, 'ReportType, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#report_type-1">SubscriptionCostManagementView#report_type</a>.
        /// </summary>
        [<CustomOperation "report_type">]
        member _.ReportType(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, Missing, 'SubscriptionId, 'Timeframe>, value: string) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, Present, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.ReportType <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, Present, 'SubscriptionId, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#subscription_id-1">SubscriptionCostManagementView#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, Missing, 'Timeframe>, value: string) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, Present, 'Timeframe> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, Present, 'Timeframe>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#timeframe-1">SubscriptionCostManagementView#timeframe</a>.
        /// </summary>
        [<CustomOperation "timeframe">]
        member _.Timeframe(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, Missing>, value: string) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, Present> =
            state.assignments.Add(fun config -> config.Timeframe <- value)
            ({ assignments = state.assignments } : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#id-1">SubscriptionCostManagementView#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: string) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>

        /// <summary>
        /// kpi block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#kpi-1">SubscriptionCostManagementView#kpi</a> Accepts: azurerm.IResolvable | azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewKpi[]
        /// </summary>
        [<CustomOperation "kpi">]
        member _.Kpi(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Kpi <- value)
            state : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>

        /// <summary>
        /// pivot block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#pivot-1">SubscriptionCostManagementView#pivot</a> Accepts: azurerm.IResolvable | azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewPivot[]
        /// </summary>
        [<CustomOperation "pivot">]
        member _.Pivot(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Pivot <- value)
            state : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_view#timeouts-1">SubscriptionCostManagementView#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>, value: azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewTimeouts) : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionCostManagementViewState<'Accumulated, 'ChartType, 'Dataset, 'DisplayName, 'Name, 'ReportType, 'SubscriptionId, 'Timeframe>

        member _.Run(state: SubscriptionCostManagementViewState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.SubscriptionCostManagementView.SubscriptionCostManagementView =
            let config = azurerm.SubscriptionCostManagementView.SubscriptionCostManagementViewConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubscriptionCostManagementView.SubscriptionCostManagementView(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscriptionCostManagementView: missing required arguments. Must call: accumulated, chart_type, dataset, display_name, name, report_type, subscription_id, timeframe.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionCostManagementViewState<_, _, _, _, _, _, _, _>) : azurerm.SubscriptionCostManagementView.SubscriptionCostManagementView =
            Unchecked.defaultof<azurerm.SubscriptionCostManagementView.SubscriptionCostManagementView>
