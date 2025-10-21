namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmServiceSettingState<'SettingId, 'SettingValue> = { assignments: ResizeArray<aws.SsmServiceSetting.SsmServiceSettingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_service_setting">aws_ssm_service_setting</a>.
    /// </summary>
    type SsmServiceSettingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmServiceSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmServiceSettingState<Missing, Missing>)

        member _.Zero(()) : SsmServiceSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmServiceSettingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_service_setting#setting_id-1">SsmServiceSetting#setting_id</a>.
        /// </summary>
        [<CustomOperation "setting_id">]
        member _.SettingId(state: SsmServiceSettingState<Missing, 'SettingValue>, value: string) : SsmServiceSettingState<Present, 'SettingValue> =
            state.assignments.Add(fun config -> config.SettingId <- value)
            ({ assignments = state.assignments } : SsmServiceSettingState<Present, 'SettingValue>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_service_setting#setting_value-1">SsmServiceSetting#setting_value</a>.
        /// </summary>
        [<CustomOperation "setting_value">]
        member _.SettingValue(state: SsmServiceSettingState<'SettingId, Missing>, value: string) : SsmServiceSettingState<'SettingId, Present> =
            state.assignments.Add(fun config -> config.SettingValue <- value)
            ({ assignments = state.assignments } : SsmServiceSettingState<'SettingId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_service_setting#id-1">SsmServiceSetting#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmServiceSettingState<'SettingId, 'SettingValue>, value: string) : SsmServiceSettingState<'SettingId, 'SettingValue> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmServiceSettingState<'SettingId, 'SettingValue>

        member _.Run(state: SsmServiceSettingState<Present, Present>) : aws.SsmServiceSetting.SsmServiceSetting =
            let config = aws.SsmServiceSetting.SsmServiceSettingConfig()
            for setter in state.assignments do
                setter config
            aws.SsmServiceSetting.SsmServiceSetting(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmServiceSetting: missing required arguments. Must call: setting_id, setting_value.", 9999, IsError = true)>]
        member _.Run(_: SsmServiceSettingState<_, _>) : aws.SsmServiceSetting.SsmServiceSetting =
            Unchecked.defaultof<aws.SsmServiceSetting.SsmServiceSetting>
