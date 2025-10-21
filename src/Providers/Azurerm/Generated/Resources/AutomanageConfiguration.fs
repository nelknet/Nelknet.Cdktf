namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomanageConfiguration.AutomanageConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration">azurerm_automanage_configuration</a>.
    /// </summary>
    type AutomanageConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomanageConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomanageConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomanageConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomanageConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#location-1">AutomanageConfiguration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AutomanageConfigurationState<Missing, 'Name, 'ResourceGroupName>, value: string) : AutomanageConfigurationState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AutomanageConfigurationState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#name-1">AutomanageConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomanageConfigurationState<'Location, Missing, 'ResourceGroupName>, value: string) : AutomanageConfigurationState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomanageConfigurationState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#resource_group_name-1">AutomanageConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomanageConfigurationState<'Location, 'Name, Missing>, value: string) : AutomanageConfigurationState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomanageConfigurationState<'Location, 'Name, Present>)

        /// <summary>
        /// antimalware block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#antimalware-1">AutomanageConfiguration#antimalware</a>
        /// </summary>
        [<CustomOperation "antimalware">]
        member _.Antimalware(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AutomanageConfiguration.AutomanageConfigurationAntimalware) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Antimalware <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#automation_account_enabled-1">AutomanageConfiguration#automation_account_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automation_account_enabled">]
        member _.AutomationAccountEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#automation_account_enabled-1">AutomanageConfiguration#automation_account_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automation_account_enabled">]
        member _.AutomationAccountEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// azure_security_baseline block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#azure_security_baseline-1">AutomanageConfiguration#azure_security_baseline</a>
        /// </summary>
        [<CustomOperation "azure_security_baseline">]
        member _.AzureSecurityBaseline(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AutomanageConfiguration.AutomanageConfigurationAzureSecurityBaseline) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzureSecurityBaseline <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#backup-1">AutomanageConfiguration#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AutomanageConfiguration.AutomanageConfigurationBackup) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#boot_diagnostics_enabled-1">AutomanageConfiguration#boot_diagnostics_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "boot_diagnostics_enabled">]
        member _.BootDiagnosticsEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BootDiagnosticsEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#boot_diagnostics_enabled-1">AutomanageConfiguration#boot_diagnostics_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "boot_diagnostics_enabled">]
        member _.BootDiagnosticsEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BootDiagnosticsEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#defender_for_cloud_enabled-1">AutomanageConfiguration#defender_for_cloud_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "defender_for_cloud_enabled">]
        member _.DefenderForCloudEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefenderForCloudEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#defender_for_cloud_enabled-1">AutomanageConfiguration#defender_for_cloud_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "defender_for_cloud_enabled">]
        member _.DefenderForCloudEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefenderForCloudEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#guest_configuration_enabled-1">AutomanageConfiguration#guest_configuration_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "guest_configuration_enabled">]
        member _.GuestConfigurationEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GuestConfigurationEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#guest_configuration_enabled-1">AutomanageConfiguration#guest_configuration_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "guest_configuration_enabled">]
        member _.GuestConfigurationEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GuestConfigurationEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#id-1">AutomanageConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: string) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#log_analytics_enabled-1">AutomanageConfiguration#log_analytics_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_analytics_enabled">]
        member _.LogAnalyticsEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogAnalyticsEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#log_analytics_enabled-1">AutomanageConfiguration#log_analytics_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_analytics_enabled">]
        member _.LogAnalyticsEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogAnalyticsEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#status_change_alert_enabled-1">AutomanageConfiguration#status_change_alert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "status_change_alert_enabled">]
        member _.StatusChangeAlertEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StatusChangeAlertEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#status_change_alert_enabled-1">AutomanageConfiguration#status_change_alert_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "status_change_alert_enabled">]
        member _.StatusChangeAlertEnabled(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StatusChangeAlertEnabled <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#tags-1">AutomanageConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#timeouts-1">AutomanageConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AutomanageConfiguration.AutomanageConfigurationTimeouts) : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomanageConfigurationState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomanageConfigurationState<Present, Present, Present>) : azurerm.AutomanageConfiguration.AutomanageConfiguration =
            let config = azurerm.AutomanageConfiguration.AutomanageConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomanageConfiguration.AutomanageConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automanageConfiguration: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomanageConfigurationState<_, _, _>) : azurerm.AutomanageConfiguration.AutomanageConfiguration =
            Unchecked.defaultof<azurerm.AutomanageConfiguration.AutomanageConfiguration>
