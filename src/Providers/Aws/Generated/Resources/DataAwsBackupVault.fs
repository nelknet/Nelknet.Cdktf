namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBackupVaultState<'Name> = { assignments: ResizeArray<aws.DataAwsBackupVault.DataAwsBackupVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_vault">aws_backup_vault</a>.
    /// </summary>
    type DataAwsBackupVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBackupVaultState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupVaultState<Missing>)

        member _.Zero(()) : DataAwsBackupVaultState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupVaultState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_vault#name-1">DataAwsBackupVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsBackupVaultState<Missing>, value: string) : DataAwsBackupVaultState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsBackupVaultState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_vault#id-1">DataAwsBackupVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBackupVaultState<'Name>, value: string) : DataAwsBackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBackupVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_vault#tags-1">DataAwsBackupVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBackupVaultState<'Name>, value: seq<string * string>) : DataAwsBackupVaultState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBackupVaultState<'Name>

        member _.Run(state: DataAwsBackupVaultState<Present>) : aws.DataAwsBackupVault.DataAwsBackupVault =
            let config = aws.DataAwsBackupVault.DataAwsBackupVaultConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBackupVault.DataAwsBackupVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBackupVault: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBackupVaultState<_>) : aws.DataAwsBackupVault.DataAwsBackupVault =
            Unchecked.defaultof<aws.DataAwsBackupVault.DataAwsBackupVault>
