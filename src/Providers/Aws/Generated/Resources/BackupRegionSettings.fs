namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupRegionSettingsState<'ResourceTypeOptInPreference> = { assignments: ResizeArray<aws.BackupRegionSettings.BackupRegionSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_region_settings">aws_backup_region_settings</a>.
    /// </summary>
    type BackupRegionSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupRegionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : BackupRegionSettingsState<Missing>)

        member _.Zero(()) : BackupRegionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : BackupRegionSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_region_settings#resource_type_opt_in_preference-1">BackupRegionSettings#resource_type_opt_in_preference</a>.
        /// </summary>
        [<CustomOperation "resource_type_opt_in_preference">]
        member _.ResourceTypeOptInPreference(state: BackupRegionSettingsState<Missing>, value: seq<string * obj>) : BackupRegionSettingsState<Present> =
            state.assignments.Add(fun config -> config.ResourceTypeOptInPreference <- dict value)
            ({ assignments = state.assignments } : BackupRegionSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_region_settings#id-1">BackupRegionSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupRegionSettingsState<'ResourceTypeOptInPreference>, value: string) : BackupRegionSettingsState<'ResourceTypeOptInPreference> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupRegionSettingsState<'ResourceTypeOptInPreference>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_region_settings#resource_type_management_preference-1">BackupRegionSettings#resource_type_management_preference</a>.
        /// </summary>
        [<CustomOperation "resource_type_management_preference">]
        member _.ResourceTypeManagementPreference(state: BackupRegionSettingsState<'ResourceTypeOptInPreference>, value: seq<string * obj>) : BackupRegionSettingsState<'ResourceTypeOptInPreference> =
            state.assignments.Add(fun config -> config.ResourceTypeManagementPreference <- dict value)
            state : BackupRegionSettingsState<'ResourceTypeOptInPreference>

        member _.Run(state: BackupRegionSettingsState<Present>) : aws.BackupRegionSettings.BackupRegionSettings =
            let config = aws.BackupRegionSettings.BackupRegionSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.BackupRegionSettings.BackupRegionSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupRegionSettings: missing required arguments. Must call: resource_type_opt_in_preference.", 9999, IsError = true)>]
        member _.Run(_: BackupRegionSettingsState<_>) : aws.BackupRegionSettings.BackupRegionSettings =
            Unchecked.defaultof<aws.BackupRegionSettings.BackupRegionSettings>
