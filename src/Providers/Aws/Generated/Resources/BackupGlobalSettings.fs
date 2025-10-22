namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupGlobalSettingsState<'GlobalSettings> = { assignments: ResizeArray<aws.BackupGlobalSettings.BackupGlobalSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_global_settings">aws_backup_global_settings</a>.
    /// </summary>
    type BackupGlobalSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupGlobalSettingsState<Missing> =
            ({ assignments = ResizeArray() } : BackupGlobalSettingsState<Missing>)

        member _.Zero(()) : BackupGlobalSettingsState<Missing> =
            ({ assignments = ResizeArray() } : BackupGlobalSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_global_settings#global_settings-1">BackupGlobalSettings#global_settings</a>.
        /// </summary>
        [<CustomOperation "global_settings">]
        member _.GlobalSettings(state: BackupGlobalSettingsState<Missing>, value: seq<string * string>) : BackupGlobalSettingsState<Present> =
            state.assignments.Add(fun config -> config.GlobalSettings <- dict value)
            ({ assignments = state.assignments } : BackupGlobalSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_global_settings#id-1">BackupGlobalSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupGlobalSettingsState<'GlobalSettings>, value: string) : BackupGlobalSettingsState<'GlobalSettings> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupGlobalSettingsState<'GlobalSettings>

        member _.Run(state: BackupGlobalSettingsState<Present>) : aws.BackupGlobalSettings.BackupGlobalSettings =
            let config = aws.BackupGlobalSettings.BackupGlobalSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.BackupGlobalSettings.BackupGlobalSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupGlobalSettings: missing required arguments. Must call: global_settings.", 9999, IsError = true)>]
        member _.Run(_: BackupGlobalSettingsState<_>) : aws.BackupGlobalSettings.BackupGlobalSettings =
            Unchecked.defaultof<aws.BackupGlobalSettings.BackupGlobalSettings>
