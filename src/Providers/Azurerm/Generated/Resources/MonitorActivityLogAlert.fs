namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> = { assignments: ResizeArray<azurerm.MonitorActivityLogAlert.MonitorActivityLogAlertConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert">azurerm_monitor_activity_log_alert</a>.
    /// </summary>
    type MonitorActivityLogAlertBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorActivityLogAlertState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorActivityLogAlertState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MonitorActivityLogAlertState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorActivityLogAlertState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#criteria-1">MonitorActivityLogAlert#criteria</a>
        /// </summary>
        [<CustomOperation "criteria">]
        member _.Criteria(state: MonitorActivityLogAlertState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorActivityLogAlert.MonitorActivityLogAlertCriteria) : MonitorActivityLogAlertState<Present, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Criteria <- value)
            ({ assignments = state.assignments } : MonitorActivityLogAlertState<Present, 'Location, 'Name, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#location-1">MonitorActivityLogAlert#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorActivityLogAlertState<'Criteria, Missing, 'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorActivityLogAlertState<'Criteria, Present, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorActivityLogAlertState<'Criteria, Present, 'Name, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#name-1">MonitorActivityLogAlert#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorActivityLogAlertState<'Criteria, 'Location, Missing, 'ResourceGroupName, 'Scopes>, value: string) : MonitorActivityLogAlertState<'Criteria, 'Location, Present, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorActivityLogAlertState<'Criteria, 'Location, Present, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#resource_group_name-1">MonitorActivityLogAlert#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, Missing, 'Scopes>, value: string) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, Present, 'Scopes> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, Present, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#scopes-1">MonitorActivityLogAlert#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, Missing>, value: seq<string>) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#action-1">MonitorActivityLogAlert#action</a> Accepts: azurerm.IResolvable | azurerm.MonitorActivityLogAlert.MonitorActivityLogAlertAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#description-1">MonitorActivityLogAlert#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#enabled-1">MonitorActivityLogAlert#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: bool) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#enabled-1">MonitorActivityLogAlert#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#id-1">MonitorActivityLogAlert#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#tags-1">MonitorActivityLogAlert#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: seq<string * string>) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#timeouts-1">MonitorActivityLogAlert#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorActivityLogAlert.MonitorActivityLogAlertTimeouts) : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorActivityLogAlertState<'Criteria, 'Location, 'Name, 'ResourceGroupName, 'Scopes>

        member _.Run(state: MonitorActivityLogAlertState<Present, Present, Present, Present, Present>) : azurerm.MonitorActivityLogAlert.MonitorActivityLogAlert =
            let config = azurerm.MonitorActivityLogAlert.MonitorActivityLogAlertConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorActivityLogAlert.MonitorActivityLogAlert(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorActivityLogAlert: missing required arguments. Must call: criteria, location, name, resource_group_name, scopes.", 9999, IsError = true)>]
        member _.Run(_: MonitorActivityLogAlertState<_, _, _, _, _>) : azurerm.MonitorActivityLogAlert.MonitorActivityLogAlert =
            Unchecked.defaultof<azurerm.MonitorActivityLogAlert.MonitorActivityLogAlert>
