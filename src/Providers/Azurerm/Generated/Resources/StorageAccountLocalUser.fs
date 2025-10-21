namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageAccountLocalUserState<'Name, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageAccountLocalUser.StorageAccountLocalUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user">azurerm_storage_account_local_user</a>.
    /// </summary>
    type StorageAccountLocalUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageAccountLocalUserState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountLocalUserState<Missing, Missing>)

        member _.Zero(()) : StorageAccountLocalUserState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountLocalUserState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#name-1">StorageAccountLocalUser#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageAccountLocalUserState<Missing, 'StorageAccountId>, value: string) : StorageAccountLocalUserState<Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageAccountLocalUserState<Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#storage_account_id-1">StorageAccountLocalUser#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageAccountLocalUserState<'Name, Missing>, value: string) : StorageAccountLocalUserState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageAccountLocalUserState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#home_directory-1">StorageAccountLocalUser#home_directory</a>.
        /// </summary>
        [<CustomOperation "home_directory">]
        member _.HomeDirectory(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: string) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.HomeDirectory <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#id-1">StorageAccountLocalUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: string) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// permission_scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#permission_scope-1">StorageAccountLocalUser#permission_scope</a> Accepts: azurerm.IResolvable | azurerm.StorageAccountLocalUser.StorageAccountLocalUserPermissionScope[]
        /// </summary>
        [<CustomOperation "permission_scope">]
        member _.PermissionScope(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.PermissionScope <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// ssh_authorized_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#ssh_authorized_key-1">StorageAccountLocalUser#ssh_authorized_key</a> Accepts: azurerm.IResolvable | azurerm.StorageAccountLocalUser.StorageAccountLocalUserSshAuthorizedKey[]
        /// </summary>
        [<CustomOperation "ssh_authorized_key">]
        member _.SshAuthorizedKey(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SshAuthorizedKey <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#ssh_key_enabled-1">StorageAccountLocalUser#ssh_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssh_key_enabled">]
        member _.SshKeyEnabled(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: bool) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SshKeyEnabled <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#ssh_key_enabled-1">StorageAccountLocalUser#ssh_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssh_key_enabled">]
        member _.SshKeyEnabled(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SshKeyEnabled <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#ssh_password_enabled-1">StorageAccountLocalUser#ssh_password_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssh_password_enabled">]
        member _.SshPasswordEnabled(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: bool) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SshPasswordEnabled <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#ssh_password_enabled-1">StorageAccountLocalUser#ssh_password_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssh_password_enabled">]
        member _.SshPasswordEnabled(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SshPasswordEnabled <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_local_user#timeouts-1">StorageAccountLocalUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageAccountLocalUserState<'Name, 'StorageAccountId>, value: azurerm.StorageAccountLocalUser.StorageAccountLocalUserTimeouts) : StorageAccountLocalUserState<'Name, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageAccountLocalUserState<'Name, 'StorageAccountId>

        member _.Run(state: StorageAccountLocalUserState<Present, Present>) : azurerm.StorageAccountLocalUser.StorageAccountLocalUser =
            let config = azurerm.StorageAccountLocalUser.StorageAccountLocalUserConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageAccountLocalUser.StorageAccountLocalUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageAccountLocalUser: missing required arguments. Must call: name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageAccountLocalUserState<_, _>) : azurerm.StorageAccountLocalUser.StorageAccountLocalUser =
            Unchecked.defaultof<azurerm.StorageAccountLocalUser.StorageAccountLocalUser>
