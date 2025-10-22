namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupVaultState<'Name> = { assignments: ResizeArray<aws.BackupVault.BackupVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault">aws_backup_vault</a>.
    /// </summary>
    type BackupVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupVaultState<Missing> =
            ({ assignments = ResizeArray() } : BackupVaultState<Missing>)

        member _.Zero(()) : BackupVaultState<Missing> =
            ({ assignments = ResizeArray() } : BackupVaultState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#name-1">BackupVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupVaultState<Missing>, value: string) : BackupVaultState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupVaultState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#force_destroy-1">BackupVault#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: BackupVaultState<'Name>, value: bool) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : BackupVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#force_destroy-1">BackupVault#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: BackupVaultState<'Name>, value: HashiCorp.Cdktf.IResolvable) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : BackupVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#id-1">BackupVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupVaultState<'Name>, value: string) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#kms_key_arn-1">BackupVault#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: BackupVaultState<'Name>, value: string) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : BackupVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#tags-1">BackupVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BackupVaultState<'Name>, value: seq<string * string>) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BackupVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#tags_all-1">BackupVault#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BackupVaultState<'Name>, value: seq<string * string>) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BackupVaultState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_vault#timeouts-1">BackupVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BackupVaultState<'Name>, value: aws.BackupVault.BackupVaultTimeouts) : BackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BackupVaultState<'Name>

        member _.Run(state: BackupVaultState<Present>) : aws.BackupVault.BackupVault =
            let config = aws.BackupVault.BackupVaultConfig()
            for setter in state.assignments do
                setter config
            aws.BackupVault.BackupVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupVault: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: BackupVaultState<_>) : aws.BackupVault.BackupVault =
            Unchecked.defaultof<aws.BackupVault.BackupVault>
