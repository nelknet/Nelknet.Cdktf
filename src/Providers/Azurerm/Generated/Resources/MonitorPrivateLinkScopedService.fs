namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName> = { assignments: ResizeArray<azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service">azurerm_monitor_private_link_scoped_service</a>.
    /// </summary>
    type MonitorPrivateLinkScopedServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorPrivateLinkScopedServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorPrivateLinkScopedServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorPrivateLinkScopedServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorPrivateLinkScopedServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service#linked_resource_id-1">MonitorPrivateLinkScopedService#linked_resource_id</a>.
        /// </summary>
        [<CustomOperation "linked_resource_id">]
        member _.LinkedResourceId(state: MonitorPrivateLinkScopedServiceState<Missing, 'Name, 'ResourceGroupName, 'ScopeName>, value: string) : MonitorPrivateLinkScopedServiceState<Present, 'Name, 'ResourceGroupName, 'ScopeName> =
            state.assignments.Add(fun config -> config.LinkedResourceId <- value)
            ({ assignments = state.assignments } : MonitorPrivateLinkScopedServiceState<Present, 'Name, 'ResourceGroupName, 'ScopeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service#name-1">MonitorPrivateLinkScopedService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorPrivateLinkScopedServiceState<'LinkedResourceId, Missing, 'ResourceGroupName, 'ScopeName>, value: string) : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, Present, 'ResourceGroupName, 'ScopeName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, Present, 'ResourceGroupName, 'ScopeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service#resource_group_name-1">MonitorPrivateLinkScopedService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, Missing, 'ScopeName>, value: string) : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, Present, 'ScopeName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, Present, 'ScopeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service#scope_name-1">MonitorPrivateLinkScopedService#scope_name</a>.
        /// </summary>
        [<CustomOperation "scope_name">]
        member _.ScopeName(state: MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, Missing>, value: string) : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ScopeName <- value)
            ({ assignments = state.assignments } : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service#id-1">MonitorPrivateLinkScopedService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName>, value: string) : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scoped_service#timeouts-1">MonitorPrivateLinkScopedService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName>, value: azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedServiceTimeouts) : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorPrivateLinkScopedServiceState<'LinkedResourceId, 'Name, 'ResourceGroupName, 'ScopeName>

        member _.Run(state: MonitorPrivateLinkScopedServiceState<Present, Present, Present, Present>) : azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedService =
            let config = azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorPrivateLinkScopedService: missing required arguments. Must call: linked_resource_id, name, resource_group_name, scope_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorPrivateLinkScopedServiceState<_, _, _, _>) : azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedService =
            Unchecked.defaultof<azurerm.MonitorPrivateLinkScopedService.MonitorPrivateLinkScopedService>
