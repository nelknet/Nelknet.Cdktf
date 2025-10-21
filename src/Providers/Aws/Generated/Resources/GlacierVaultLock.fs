namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName> = { assignments: ResizeArray<aws.GlacierVaultLock.GlacierVaultLockConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock">aws_glacier_vault_lock</a>.
    /// </summary>
    type GlacierVaultLockBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlacierVaultLockState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlacierVaultLockState<Missing, Missing, Missing>)

        member _.Zero(()) : GlacierVaultLockState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlacierVaultLockState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#complete_lock-1">GlacierVaultLock#complete_lock</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "complete_lock">]
        member _.CompleteLock(state: GlacierVaultLockState<Missing, 'Policy, 'VaultName>, value: bool) : GlacierVaultLockState<Present, 'Policy, 'VaultName> =
            state.assignments.Add(fun config -> config.CompleteLock <- value)
            ({ assignments = state.assignments } : GlacierVaultLockState<Present, 'Policy, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#complete_lock-1">GlacierVaultLock#complete_lock</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "complete_lock">]
        member _.CompleteLock(state: GlacierVaultLockState<Missing, 'Policy, 'VaultName>, value: HashiCorp.Cdktf.IResolvable) : GlacierVaultLockState<Present, 'Policy, 'VaultName> =
            state.assignments.Add(fun config -> config.CompleteLock <- value)
            ({ assignments = state.assignments } : GlacierVaultLockState<Present, 'Policy, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#policy-1">GlacierVaultLock#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: GlacierVaultLockState<'CompleteLock, Missing, 'VaultName>, value: string) : GlacierVaultLockState<'CompleteLock, Present, 'VaultName> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : GlacierVaultLockState<'CompleteLock, Present, 'VaultName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#vault_name-1">GlacierVaultLock#vault_name</a>.
        /// </summary>
        [<CustomOperation "vault_name">]
        member _.VaultName(state: GlacierVaultLockState<'CompleteLock, 'Policy, Missing>, value: string) : GlacierVaultLockState<'CompleteLock, 'Policy, Present> =
            state.assignments.Add(fun config -> config.VaultName <- value)
            ({ assignments = state.assignments } : GlacierVaultLockState<'CompleteLock, 'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#id-1">GlacierVaultLock#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName>, value: string) : GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#ignore_deletion_error-1">GlacierVaultLock#ignore_deletion_error</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_deletion_error">]
        member _.IgnoreDeletionError(state: GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName>, value: bool) : GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName> =
            state.assignments.Add(fun config -> config.IgnoreDeletionError <- value)
            state : GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault_lock#ignore_deletion_error-1">GlacierVaultLock#ignore_deletion_error</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_deletion_error">]
        member _.IgnoreDeletionError(state: GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName>, value: HashiCorp.Cdktf.IResolvable) : GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName> =
            state.assignments.Add(fun config -> config.IgnoreDeletionError <- value)
            state : GlacierVaultLockState<'CompleteLock, 'Policy, 'VaultName>

        member _.Run(state: GlacierVaultLockState<Present, Present, Present>) : aws.GlacierVaultLock.GlacierVaultLock =
            let config = aws.GlacierVaultLock.GlacierVaultLockConfig()
            for setter in state.assignments do
                setter config
            aws.GlacierVaultLock.GlacierVaultLock(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glacierVaultLock: missing required arguments. Must call: complete_lock, policy, vault_name.", 9999, IsError = true)>]
        member _.Run(_: GlacierVaultLockState<_, _, _>) : aws.GlacierVaultLock.GlacierVaultLock =
            Unchecked.defaultof<aws.GlacierVaultLock.GlacierVaultLock>
