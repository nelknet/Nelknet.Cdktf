namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrAccountSettingState<'Name, 'Value> = { assignments: ResizeArray<aws.EcrAccountSetting.EcrAccountSettingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_account_setting">aws_ecr_account_setting</a>.
    /// </summary>
    type EcrAccountSettingBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrAccountSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrAccountSettingState<Missing, Missing>)

        member _.Zero(()) : EcrAccountSettingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcrAccountSettingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_account_setting#name-1">EcrAccountSetting#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EcrAccountSettingState<Missing, 'Value>, value: string) : EcrAccountSettingState<Present, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EcrAccountSettingState<Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_account_setting#value-1">EcrAccountSetting#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: EcrAccountSettingState<'Name, Missing>, value: string) : EcrAccountSettingState<'Name, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : EcrAccountSettingState<'Name, Present>)

        member _.Run(state: EcrAccountSettingState<Present, Present>) : aws.EcrAccountSetting.EcrAccountSetting =
            let config = aws.EcrAccountSetting.EcrAccountSettingConfig()
            for setter in state.assignments do
                setter config
            aws.EcrAccountSetting.EcrAccountSetting(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrAccountSetting: missing required arguments. Must call: name, value.", 9999, IsError = true)>]
        member _.Run(_: EcrAccountSettingState<_, _>) : aws.EcrAccountSetting.EcrAccountSetting =
            Unchecked.defaultof<aws.EcrAccountSetting.EcrAccountSetting>
