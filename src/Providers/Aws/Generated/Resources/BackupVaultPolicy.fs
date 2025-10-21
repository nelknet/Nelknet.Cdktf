namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupVaultPolicyState<'BackupVaultName, 'Policy> = { assignments: ResizeArray<aws.BackupVaultPolicy.BackupVaultPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_policy">aws_backup_vault_policy</a>.
    /// </summary>
    type BackupVaultPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupVaultPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupVaultPolicyState<Missing, Missing>)

        member _.Zero(()) : BackupVaultPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupVaultPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_policy#backup_vault_name-1">BackupVaultPolicy#backup_vault_name</a>.
        /// </summary>
        [<CustomOperation "backup_vault_name">]
        member _.BackupVaultName(state: BackupVaultPolicyState<Missing, 'Policy>, value: string) : BackupVaultPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.BackupVaultName <- value)
            ({ assignments = state.assignments } : BackupVaultPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_policy#policy-1">BackupVaultPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: BackupVaultPolicyState<'BackupVaultName, Missing>, value: string) : BackupVaultPolicyState<'BackupVaultName, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : BackupVaultPolicyState<'BackupVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault_policy#id-1">BackupVaultPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupVaultPolicyState<'BackupVaultName, 'Policy>, value: string) : BackupVaultPolicyState<'BackupVaultName, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupVaultPolicyState<'BackupVaultName, 'Policy>

        member _.Run(state: BackupVaultPolicyState<Present, Present>) : aws.BackupVaultPolicy.BackupVaultPolicy =
            let config = aws.BackupVaultPolicy.BackupVaultPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.BackupVaultPolicy.BackupVaultPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupVaultPolicy: missing required arguments. Must call: backup_vault_name, policy.", 9999, IsError = true)>]
        member _.Run(_: BackupVaultPolicyState<_, _>) : aws.BackupVaultPolicy.BackupVaultPolicy =
            Unchecked.defaultof<aws.BackupVaultPolicy.BackupVaultPolicy>
