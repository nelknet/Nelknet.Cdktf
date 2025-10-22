namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName> = { assignments: ResizeArray<aws.BackupRestoreTestingSelection.BackupRestoreTestingSelectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection">aws_backup_restore_testing_selection</a>.
    /// </summary>
    type BackupRestoreTestingSelectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupRestoreTestingSelectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupRestoreTestingSelectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BackupRestoreTestingSelectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupRestoreTestingSelectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#iam_role_arn-1">BackupRestoreTestingSelection#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: BackupRestoreTestingSelectionState<Missing, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>, value: string) : BackupRestoreTestingSelectionState<Present, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : BackupRestoreTestingSelectionState<Present, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#name-1">BackupRestoreTestingSelection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupRestoreTestingSelectionState<'IamRoleArn, Missing, 'ProtectedResourceType, 'RestoreTestingPlanName>, value: string) : BackupRestoreTestingSelectionState<'IamRoleArn, Present, 'ProtectedResourceType, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupRestoreTestingSelectionState<'IamRoleArn, Present, 'ProtectedResourceType, 'RestoreTestingPlanName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#protected_resource_type-1">BackupRestoreTestingSelection#protected_resource_type</a>.
        /// </summary>
        [<CustomOperation "protected_resource_type">]
        member _.ProtectedResourceType(state: BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, Missing, 'RestoreTestingPlanName>, value: string) : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, Present, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.ProtectedResourceType <- value)
            ({ assignments = state.assignments } : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, Present, 'RestoreTestingPlanName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#restore_testing_plan_name-1">BackupRestoreTestingSelection#restore_testing_plan_name</a>.
        /// </summary>
        [<CustomOperation "restore_testing_plan_name">]
        member _.RestoreTestingPlanName(state: BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, Missing>, value: string) : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, Present> =
            state.assignments.Add(fun config -> config.RestoreTestingPlanName <- value)
            ({ assignments = state.assignments } : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#protected_resource_arns-1">BackupRestoreTestingSelection#protected_resource_arns</a>.
        /// </summary>
        [<CustomOperation "protected_resource_arns">]
        member _.ProtectedResourceArns(state: BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>, value: seq<string>) : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.ProtectedResourceArns <- (value |> Seq.toArray))
            state : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>

        /// <summary>
        /// protected_resource_conditions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#protected_resource_conditions-1">BackupRestoreTestingSelection#protected_resource_conditions</a> Accepts: aws.IResolvable | aws.BackupRestoreTestingSelection.BackupRestoreTestingSelectionProtectedResourceConditions[]
        /// </summary>
        [<CustomOperation "protected_resource_conditions">]
        member _.ProtectedResourceConditions(state: BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>, value: HashiCorp.Cdktf.IResolvable) : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.ProtectedResourceConditions <- value)
            state : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#restore_metadata_overrides-1">BackupRestoreTestingSelection#restore_metadata_overrides</a>.
        /// </summary>
        [<CustomOperation "restore_metadata_overrides">]
        member _.RestoreMetadataOverrides(state: BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>, value: seq<string * string>) : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.RestoreMetadataOverrides <- dict value)
            state : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_restore_testing_selection#validation_window_hours-1">BackupRestoreTestingSelection#validation_window_hours</a>.
        /// </summary>
        [<CustomOperation "validation_window_hours">]
        member _.ValidationWindowHours(state: BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>, value: double) : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName> =
            state.assignments.Add(fun config -> config.ValidationWindowHours <- value)
            state : BackupRestoreTestingSelectionState<'IamRoleArn, 'Name, 'ProtectedResourceType, 'RestoreTestingPlanName>

        member _.Run(state: BackupRestoreTestingSelectionState<Present, Present, Present, Present>) : aws.BackupRestoreTestingSelection.BackupRestoreTestingSelection =
            let config = aws.BackupRestoreTestingSelection.BackupRestoreTestingSelectionConfig()
            for setter in state.assignments do
                setter config
            aws.BackupRestoreTestingSelection.BackupRestoreTestingSelection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupRestoreTestingSelection: missing required arguments. Must call: iam_role_arn, name, protected_resource_type, restore_testing_plan_name.", 9999, IsError = true)>]
        member _.Run(_: BackupRestoreTestingSelectionState<_, _, _, _>) : aws.BackupRestoreTestingSelection.BackupRestoreTestingSelection =
            Unchecked.defaultof<aws.BackupRestoreTestingSelection.BackupRestoreTestingSelection>
