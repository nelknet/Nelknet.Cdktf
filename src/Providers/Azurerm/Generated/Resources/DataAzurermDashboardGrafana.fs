namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana">azurerm_dashboard_grafana</a>.
    /// </summary>
    type DataAzurermDashboardGrafanaBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDashboardGrafanaState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDashboardGrafanaState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDashboardGrafanaState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDashboardGrafanaState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#name-1">DataAzurermDashboardGrafana#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDashboardGrafanaState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDashboardGrafanaState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDashboardGrafanaState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#resource_group_name-1">DataAzurermDashboardGrafana#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDashboardGrafanaState<'Name, Missing>, value: string) : DataAzurermDashboardGrafanaState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDashboardGrafanaState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#id-1">DataAzurermDashboardGrafana#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#identity-1">DataAzurermDashboardGrafana#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaIdentity) : DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dashboard_grafana#timeouts-1">DataAzurermDashboardGrafana#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaTimeouts) : DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDashboardGrafanaState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDashboardGrafanaState<Present, Present>) : azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana =
            let config = azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafanaConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDashboardGrafana: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDashboardGrafanaState<_, _>) : azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana =
            Unchecked.defaultof<azurerm.DataAzurermDashboardGrafana.DataAzurermDashboardGrafana>
