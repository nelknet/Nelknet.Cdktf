namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled> = { assignments: ResizeArray<azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration">azurerm_datadog_monitor_sso_configuration</a>.
    /// </summary>
    type DatadogMonitorSsoConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatadogMonitorSsoConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatadogMonitorSsoConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : DatadogMonitorSsoConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatadogMonitorSsoConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration#datadog_monitor_id-1">DatadogMonitorSsoConfiguration#datadog_monitor_id</a>.
        /// </summary>
        [<CustomOperation "datadog_monitor_id">]
        member _.DatadogMonitorId(state: DatadogMonitorSsoConfigurationState<Missing, 'EnterpriseApplicationId, 'SingleSignOnEnabled>, value: string) : DatadogMonitorSsoConfigurationState<Present, 'EnterpriseApplicationId, 'SingleSignOnEnabled> =
            state.assignments.Add(fun config -> config.DatadogMonitorId <- value)
            ({ assignments = state.assignments } : DatadogMonitorSsoConfigurationState<Present, 'EnterpriseApplicationId, 'SingleSignOnEnabled>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration#enterprise_application_id-1">DatadogMonitorSsoConfiguration#enterprise_application_id</a>.
        /// </summary>
        [<CustomOperation "enterprise_application_id">]
        member _.EnterpriseApplicationId(state: DatadogMonitorSsoConfigurationState<'DatadogMonitorId, Missing, 'SingleSignOnEnabled>, value: string) : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, Present, 'SingleSignOnEnabled> =
            state.assignments.Add(fun config -> config.EnterpriseApplicationId <- value)
            ({ assignments = state.assignments } : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, Present, 'SingleSignOnEnabled>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration#single_sign_on_enabled-1">DatadogMonitorSsoConfiguration#single_sign_on_enabled</a>.
        /// </summary>
        [<CustomOperation "single_sign_on_enabled">]
        member _.SingleSignOnEnabled(state: DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, Missing>, value: string) : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, Present> =
            state.assignments.Add(fun config -> config.SingleSignOnEnabled <- value)
            ({ assignments = state.assignments } : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration#id-1">DatadogMonitorSsoConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled>, value: string) : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration#name-1">DatadogMonitorSsoConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled>, value: string) : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor_sso_configuration#timeouts-1">DatadogMonitorSsoConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled>, value: azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfigurationTimeouts) : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatadogMonitorSsoConfigurationState<'DatadogMonitorId, 'EnterpriseApplicationId, 'SingleSignOnEnabled>

        member _.Run(state: DatadogMonitorSsoConfigurationState<Present, Present, Present>) : azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfiguration =
            let config = azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.datadogMonitorSsoConfiguration: missing required arguments. Must call: datadog_monitor_id, enterprise_application_id, single_sign_on_enabled.", 9999, IsError = true)>]
        member _.Run(_: DatadogMonitorSsoConfigurationState<_, _, _>) : azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfiguration =
            Unchecked.defaultof<azurerm.DatadogMonitorSsoConfiguration.DatadogMonitorSsoConfiguration>
