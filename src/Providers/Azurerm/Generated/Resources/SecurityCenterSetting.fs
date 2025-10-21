namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterSettingState<'Enabled, 'SettingName> = { assignments: ResizeArray<azurerm.SecurityCenterSetting.SecurityCenterSettingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_setting">azurerm_security_center_setting</a>.
    /// </summary>
    type SecurityCenterSettingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterSettingState<Missing, Missing>)

        member _.Zero(()) : SecurityCenterSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterSettingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_setting#enabled-1">SecurityCenterSetting#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SecurityCenterSettingState<Missing, 'SettingName>, value: bool) : SecurityCenterSettingState<Present, 'SettingName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : SecurityCenterSettingState<Present, 'SettingName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_setting#enabled-1">SecurityCenterSetting#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SecurityCenterSettingState<Missing, 'SettingName>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterSettingState<Present, 'SettingName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : SecurityCenterSettingState<Present, 'SettingName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_setting#setting_name-1">SecurityCenterSetting#setting_name</a>.
        /// </summary>
        [<CustomOperation "setting_name">]
        member _.SettingName(state: SecurityCenterSettingState<'Enabled, Missing>, value: string) : SecurityCenterSettingState<'Enabled, Present> =
            state.assignments.Add(fun config -> config.SettingName <- value)
            ({ assignments = state.assignments } : SecurityCenterSettingState<'Enabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_setting#id-1">SecurityCenterSetting#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterSettingState<'Enabled, 'SettingName>, value: string) : SecurityCenterSettingState<'Enabled, 'SettingName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterSettingState<'Enabled, 'SettingName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_setting#timeouts-1">SecurityCenterSetting#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterSettingState<'Enabled, 'SettingName>, value: azurerm.SecurityCenterSetting.SecurityCenterSettingTimeouts) : SecurityCenterSettingState<'Enabled, 'SettingName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterSettingState<'Enabled, 'SettingName>

        member _.Run(state: SecurityCenterSettingState<Present, Present>) : azurerm.SecurityCenterSetting.SecurityCenterSetting =
            let config = azurerm.SecurityCenterSetting.SecurityCenterSettingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterSetting.SecurityCenterSetting(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterSetting: missing required arguments. Must call: enabled, setting_name.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterSettingState<_, _>) : azurerm.SecurityCenterSetting.SecurityCenterSetting =
            Unchecked.defaultof<azurerm.SecurityCenterSetting.SecurityCenterSetting>
