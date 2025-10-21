namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EfsBackupPolicyState<'BackupPolicy, 'FileSystemId> = { assignments: ResizeArray<aws.EfsBackupPolicy.EfsBackupPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy">aws_efs_backup_policy</a>.
    /// </summary>
    type EfsBackupPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EfsBackupPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsBackupPolicyState<Missing, Missing>)

        member _.Zero(()) : EfsBackupPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsBackupPolicyState<Missing, Missing>)

        /// <summary>
        /// backup_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy#backup_policy-1">EfsBackupPolicy#backup_policy</a>
        /// </summary>
        [<CustomOperation "backup_policy">]
        member _.BackupPolicy(state: EfsBackupPolicyState<Missing, 'FileSystemId>, value: aws.EfsBackupPolicy.EfsBackupPolicyBackupPolicy) : EfsBackupPolicyState<Present, 'FileSystemId> =
            state.assignments.Add(fun config -> config.BackupPolicy <- value)
            ({ assignments = state.assignments } : EfsBackupPolicyState<Present, 'FileSystemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy#file_system_id-1">EfsBackupPolicy#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: EfsBackupPolicyState<'BackupPolicy, Missing>, value: string) : EfsBackupPolicyState<'BackupPolicy, Present> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : EfsBackupPolicyState<'BackupPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy#id-1">EfsBackupPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EfsBackupPolicyState<'BackupPolicy, 'FileSystemId>, value: string) : EfsBackupPolicyState<'BackupPolicy, 'FileSystemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EfsBackupPolicyState<'BackupPolicy, 'FileSystemId>

        member _.Run(state: EfsBackupPolicyState<Present, Present>) : aws.EfsBackupPolicy.EfsBackupPolicy =
            let config = aws.EfsBackupPolicy.EfsBackupPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EfsBackupPolicy.EfsBackupPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.efsBackupPolicy: missing required arguments. Must call: backup_policy, file_system_id.", 9999, IsError = true)>]
        member _.Run(_: EfsBackupPolicyState<_, _>) : aws.EfsBackupPolicy.EfsBackupPolicy =
            Unchecked.defaultof<aws.EfsBackupPolicy.EfsBackupPolicy>
