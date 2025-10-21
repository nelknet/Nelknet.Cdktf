namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPortalDashboardState<'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard">azurerm_portal_dashboard</a>.
    /// </summary>
    type DataAzurermPortalDashboardBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPortalDashboardState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPortalDashboardState<Missing>)

        member _.Zero(()) : DataAzurermPortalDashboardState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPortalDashboardState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#resource_group_name-1">DataAzurermPortalDashboard#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPortalDashboardState<Missing>, value: string) : DataAzurermPortalDashboardState<Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPortalDashboardState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#dashboard_properties-1">DataAzurermPortalDashboard#dashboard_properties</a>.
        /// </summary>
        [<CustomOperation "dashboard_properties">]
        member _.DashboardProperties(state: DataAzurermPortalDashboardState<'ResourceGroupName>, value: string) : DataAzurermPortalDashboardState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DashboardProperties <- value)
            state : DataAzurermPortalDashboardState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#display_name-1">DataAzurermPortalDashboard#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermPortalDashboardState<'ResourceGroupName>, value: string) : DataAzurermPortalDashboardState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermPortalDashboardState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#id-1">DataAzurermPortalDashboard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPortalDashboardState<'ResourceGroupName>, value: string) : DataAzurermPortalDashboardState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPortalDashboardState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#name-1">DataAzurermPortalDashboard#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPortalDashboardState<'ResourceGroupName>, value: string) : DataAzurermPortalDashboardState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermPortalDashboardState<'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#timeouts-1">DataAzurermPortalDashboard#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPortalDashboardState<'ResourceGroupName>, value: azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboardTimeouts) : DataAzurermPortalDashboardState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPortalDashboardState<'ResourceGroupName>

        member _.Run(state: DataAzurermPortalDashboardState<Present>) : azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboard =
            let config = azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboardConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPortalDashboard: missing required arguments. Must call: resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPortalDashboardState<_>) : azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboard =
            Unchecked.defaultof<azurerm.DataAzurermPortalDashboard.DataAzurermPortalDashboard>
