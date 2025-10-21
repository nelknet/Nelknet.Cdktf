namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/log_analytics_workspace">azurerm_log_analytics_workspace</a>.
    /// </summary>
    type DataAzurermLogAnalyticsWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLogAnalyticsWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogAnalyticsWorkspaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLogAnalyticsWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogAnalyticsWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/log_analytics_workspace#name-1">DataAzurermLogAnalyticsWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLogAnalyticsWorkspaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLogAnalyticsWorkspaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLogAnalyticsWorkspaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/log_analytics_workspace#resource_group_name-1">DataAzurermLogAnalyticsWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLogAnalyticsWorkspaceState<'Name, Missing>, value: string) : DataAzurermLogAnalyticsWorkspaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLogAnalyticsWorkspaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/log_analytics_workspace#id-1">DataAzurermLogAnalyticsWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/log_analytics_workspace#timeouts-1">DataAzurermLogAnalyticsWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspaceTimeouts) : DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLogAnalyticsWorkspaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLogAnalyticsWorkspaceState<Present, Present>) : azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspace =
            let config = azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLogAnalyticsWorkspace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLogAnalyticsWorkspaceState<_, _>) : azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspace =
            Unchecked.defaultof<azurerm.DataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspace>
