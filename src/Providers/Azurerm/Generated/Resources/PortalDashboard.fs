namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PortalDashboard.PortalDashboardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard">azurerm_portal_dashboard</a>.
    /// </summary>
    type PortalDashboardBuilder(logicalId: string) =
        member _.Yield(_: unit) : PortalDashboardState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PortalDashboardState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PortalDashboardState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PortalDashboardState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#dashboard_properties-1">PortalDashboard#dashboard_properties</a>.
        /// </summary>
        [<CustomOperation "dashboard_properties">]
        member _.DashboardProperties(state: PortalDashboardState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : PortalDashboardState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DashboardProperties <- value)
            ({ assignments = state.assignments } : PortalDashboardState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#location-1">PortalDashboard#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PortalDashboardState<'DashboardProperties, Missing, 'Name, 'ResourceGroupName>, value: string) : PortalDashboardState<'DashboardProperties, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PortalDashboardState<'DashboardProperties, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#name-1">PortalDashboard#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PortalDashboardState<'DashboardProperties, 'Location, Missing, 'ResourceGroupName>, value: string) : PortalDashboardState<'DashboardProperties, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PortalDashboardState<'DashboardProperties, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#resource_group_name-1">PortalDashboard#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PortalDashboardState<'DashboardProperties, 'Location, 'Name, Missing>, value: string) : PortalDashboardState<'DashboardProperties, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PortalDashboardState<'DashboardProperties, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#id-1">PortalDashboard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName>, value: string) : PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#tags-1">PortalDashboard#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_dashboard#timeouts-1">PortalDashboard#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.PortalDashboard.PortalDashboardTimeouts) : PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PortalDashboardState<'DashboardProperties, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: PortalDashboardState<Present, Present, Present, Present>) : azurerm.PortalDashboard.PortalDashboard =
            let config = azurerm.PortalDashboard.PortalDashboardConfig()
            for setter in state.assignments do
                setter config
            azurerm.PortalDashboard.PortalDashboard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.portalDashboard: missing required arguments. Must call: dashboard_properties, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PortalDashboardState<_, _, _, _>) : azurerm.PortalDashboard.PortalDashboard =
            Unchecked.defaultof<azurerm.PortalDashboard.PortalDashboard>
