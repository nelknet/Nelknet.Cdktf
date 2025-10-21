namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId> = { assignments: ResizeArray<azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service">azurerm_log_analytics_linked_service</a>.
    /// </summary>
    type LogAnalyticsLinkedServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsLinkedServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsLinkedServiceState<Missing, Missing>)

        member _.Zero(()) : LogAnalyticsLinkedServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsLinkedServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service#resource_group_name-1">LogAnalyticsLinkedService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsLinkedServiceState<Missing, 'WorkspaceId>, value: string) : LogAnalyticsLinkedServiceState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsLinkedServiceState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service#workspace_id-1">LogAnalyticsLinkedService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: LogAnalyticsLinkedServiceState<'ResourceGroupName, Missing>, value: string) : LogAnalyticsLinkedServiceState<'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : LogAnalyticsLinkedServiceState<'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service#id-1">LogAnalyticsLinkedService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>, value: string) : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service#read_access_id-1">LogAnalyticsLinkedService#read_access_id</a>.
        /// </summary>
        [<CustomOperation "read_access_id">]
        member _.ReadAccessId(state: LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>, value: string) : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ReadAccessId <- value)
            state : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service#timeouts-1">LogAnalyticsLinkedService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>, value: azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedServiceTimeouts) : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_linked_service#write_access_id-1">LogAnalyticsLinkedService#write_access_id</a>.
        /// </summary>
        [<CustomOperation "write_access_id">]
        member _.WriteAccessId(state: LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>, value: string) : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.WriteAccessId <- value)
            state : LogAnalyticsLinkedServiceState<'ResourceGroupName, 'WorkspaceId>

        member _.Run(state: LogAnalyticsLinkedServiceState<Present, Present>) : azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedService =
            let config = azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsLinkedService: missing required arguments. Must call: resource_group_name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsLinkedServiceState<_, _>) : azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedService =
            Unchecked.defaultof<azurerm.LogAnalyticsLinkedService.LogAnalyticsLinkedService>
