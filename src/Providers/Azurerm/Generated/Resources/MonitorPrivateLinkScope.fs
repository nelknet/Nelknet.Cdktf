namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope">azurerm_monitor_private_link_scope</a>.
    /// </summary>
    type MonitorPrivateLinkScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorPrivateLinkScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorPrivateLinkScopeState<Missing, Missing>)

        member _.Zero(()) : MonitorPrivateLinkScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorPrivateLinkScopeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#name-1">MonitorPrivateLinkScope#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorPrivateLinkScopeState<Missing, 'ResourceGroupName>, value: string) : MonitorPrivateLinkScopeState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorPrivateLinkScopeState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#resource_group_name-1">MonitorPrivateLinkScope#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorPrivateLinkScopeState<'Name, Missing>, value: string) : MonitorPrivateLinkScopeState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorPrivateLinkScopeState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#id-1">MonitorPrivateLinkScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>, value: string) : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#ingestion_access_mode-1">MonitorPrivateLinkScope#ingestion_access_mode</a>.
        /// </summary>
        [<CustomOperation "ingestion_access_mode">]
        member _.IngestionAccessMode(state: MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>, value: string) : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IngestionAccessMode <- value)
            state : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#query_access_mode-1">MonitorPrivateLinkScope#query_access_mode</a>.
        /// </summary>
        [<CustomOperation "query_access_mode">]
        member _.QueryAccessMode(state: MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>, value: string) : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.QueryAccessMode <- value)
            state : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#tags-1">MonitorPrivateLinkScope#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>, value: seq<string * string>) : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_private_link_scope#timeouts-1">MonitorPrivateLinkScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>, value: azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScopeTimeouts) : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorPrivateLinkScopeState<'Name, 'ResourceGroupName>

        member _.Run(state: MonitorPrivateLinkScopeState<Present, Present>) : azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScope =
            let config = azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorPrivateLinkScope: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorPrivateLinkScopeState<_, _>) : azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScope =
            Unchecked.defaultof<azurerm.MonitorPrivateLinkScope.MonitorPrivateLinkScope>
