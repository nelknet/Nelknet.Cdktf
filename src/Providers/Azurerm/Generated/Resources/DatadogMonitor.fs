namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> = { assignments: ResizeArray<azurerm.DatadogMonitor.DatadogMonitorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor">azurerm_datadog_monitor</a>.
    /// </summary>
    type DatadogMonitorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatadogMonitorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatadogMonitorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatadogMonitorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatadogMonitorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// datadog_organization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#datadog_organization-1">DatadogMonitor#datadog_organization</a>
        /// </summary>
        [<CustomOperation "datadog_organization">]
        member _.DatadogOrganization(state: DatadogMonitorState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: azurerm.DatadogMonitor.DatadogMonitorDatadogOrganization) : DatadogMonitorState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.DatadogOrganization <- value)
            ({ assignments = state.assignments } : DatadogMonitorState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#location-1">DatadogMonitor#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DatadogMonitorState<'DatadogOrganization, Missing, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: string) : DatadogMonitorState<'DatadogOrganization, Present, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DatadogMonitorState<'DatadogOrganization, Present, 'Name, 'ResourceGroupName, 'SkuName, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#name-1">DatadogMonitor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatadogMonitorState<'DatadogOrganization, 'Location, Missing, 'ResourceGroupName, 'SkuName, 'User>, value: string) : DatadogMonitorState<'DatadogOrganization, 'Location, Present, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatadogMonitorState<'DatadogOrganization, 'Location, Present, 'ResourceGroupName, 'SkuName, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#resource_group_name-1">DatadogMonitor#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, Missing, 'SkuName, 'User>, value: string) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, Present, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, Present, 'SkuName, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#sku_name-1">DatadogMonitor#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, Missing, 'User>, value: string) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, Present, 'User> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, Present, 'User>)

        /// <summary>
        /// user block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#user-1">DatadogMonitor#user</a>
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing>, value: azurerm.DatadogMonitor.DatadogMonitorUser) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#id-1">DatadogMonitor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: string) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#identity-1">DatadogMonitor#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: azurerm.DatadogMonitor.DatadogMonitorIdentity) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#monitoring_enabled-1">DatadogMonitor#monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "monitoring_enabled">]
        member _.MonitoringEnabled(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: bool) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.MonitoringEnabled <- value)
            state : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#monitoring_enabled-1">DatadogMonitor#monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "monitoring_enabled">]
        member _.MonitoringEnabled(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: HashiCorp.Cdktf.IResolvable) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.MonitoringEnabled <- value)
            state : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#tags-1">DatadogMonitor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: seq<string * string>) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#timeouts-1">DatadogMonitor#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>, value: azurerm.DatadogMonitor.DatadogMonitorTimeouts) : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatadogMonitorState<'DatadogOrganization, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'User>

        member _.Run(state: DatadogMonitorState<Present, Present, Present, Present, Present, Present>) : azurerm.DatadogMonitor.DatadogMonitor =
            let config = azurerm.DatadogMonitor.DatadogMonitorConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatadogMonitor.DatadogMonitor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.datadogMonitor: missing required arguments. Must call: datadog_organization, location, name, resource_group_name, sku_name, user.", 9999, IsError = true)>]
        member _.Run(_: DatadogMonitorState<_, _, _, _, _, _>) : azurerm.DatadogMonitor.DatadogMonitor =
            Unchecked.defaultof<azurerm.DatadogMonitor.DatadogMonitor>
