namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> = { assignments: ResizeArray<azurerm.MonitorMetricAlert.MonitorMetricAlertConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert">azurerm_monitor_metric_alert</a>.
    /// </summary>
    type MonitorMetricAlertBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorMetricAlertState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorMetricAlertState<Missing, Missing, Missing>)

        member _.Zero(()) : MonitorMetricAlertState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorMetricAlertState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#name-1">MonitorMetricAlert#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorMetricAlertState<Missing, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<Present, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorMetricAlertState<Present, 'ResourceGroupName, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#resource_group_name-1">MonitorMetricAlert#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorMetricAlertState<'Name, Missing, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, Present, 'Scopes> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorMetricAlertState<'Name, Present, 'Scopes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#scopes-1">MonitorMetricAlert#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, Missing>, value: seq<string>) : MonitorMetricAlertState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MonitorMetricAlertState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#action-1">MonitorMetricAlert#action</a> Accepts: azurerm.IResolvable | azurerm.MonitorMetricAlert.MonitorMetricAlertAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// application_insights_web_test_location_availability_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#application_insights_web_test_location_availability_criteria-1">MonitorMetricAlert#application_insights_web_test_location_availability_criteria</a>
        /// </summary>
        [<CustomOperation "application_insights_web_test_location_availability_criteria">]
        member _.ApplicationInsightsWebTestLocationAvailabilityCriteria(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorMetricAlert.MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.ApplicationInsightsWebTestLocationAvailabilityCriteria <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#auto_mitigate-1">MonitorMetricAlert#auto_mitigate</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_mitigate">]
        member _.AutoMitigate(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: bool) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.AutoMitigate <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#auto_mitigate-1">MonitorMetricAlert#auto_mitigate</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_mitigate">]
        member _.AutoMitigate(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.AutoMitigate <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#criteria-1">MonitorMetricAlert#criteria</a> Accepts: azurerm.IResolvable | azurerm.MonitorMetricAlert.MonitorMetricAlertCriteria[]
        /// </summary>
        [<CustomOperation "criteria">]
        member _.Criteria(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Criteria <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#description-1">MonitorMetricAlert#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// dynamic_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#dynamic_criteria-1">MonitorMetricAlert#dynamic_criteria</a>
        /// </summary>
        [<CustomOperation "dynamic_criteria">]
        member _.DynamicCriteria(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorMetricAlert.MonitorMetricAlertDynamicCriteria) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.DynamicCriteria <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#enabled-1">MonitorMetricAlert#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: bool) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#enabled-1">MonitorMetricAlert#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: HashiCorp.Cdktf.IResolvable) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#frequency-1">MonitorMetricAlert#frequency</a>.
        /// </summary>
        [<CustomOperation "frequency">]
        member _.Frequency(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Frequency <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#id-1">MonitorMetricAlert#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#severity-1">MonitorMetricAlert#severity</a>.
        /// </summary>
        [<CustomOperation "severity">]
        member _.Severity(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: double) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Severity <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#tags-1">MonitorMetricAlert#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: seq<string * string>) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#target_resource_location-1">MonitorMetricAlert#target_resource_location</a>
        /// </summary>
        [<CustomOperation "target_resource_location">]
        member _.TargetResourceLocation(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.TargetResourceLocation <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#target_resource_type-1">MonitorMetricAlert#target_resource_type</a>
        /// </summary>
        [<CustomOperation "target_resource_type">]
        member _.TargetResourceType(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.TargetResourceType <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#timeouts-1">MonitorMetricAlert#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: azurerm.MonitorMetricAlert.MonitorMetricAlertTimeouts) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#window_size-1">MonitorMetricAlert#window_size</a>.
        /// </summary>
        [<CustomOperation "window_size">]
        member _.WindowSize(state: MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>, value: string) : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes> =
            state.assignments.Add(fun config -> config.WindowSize <- value)
            state : MonitorMetricAlertState<'Name, 'ResourceGroupName, 'Scopes>

        member _.Run(state: MonitorMetricAlertState<Present, Present, Present>) : azurerm.MonitorMetricAlert.MonitorMetricAlert =
            let config = azurerm.MonitorMetricAlert.MonitorMetricAlertConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorMetricAlert.MonitorMetricAlert(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorMetricAlert: missing required arguments. Must call: name, resource_group_name, scopes.", 9999, IsError = true)>]
        member _.Run(_: MonitorMetricAlertState<_, _, _>) : azurerm.MonitorMetricAlert.MonitorMetricAlert =
            Unchecked.defaultof<azurerm.MonitorMetricAlert.MonitorMetricAlert>
