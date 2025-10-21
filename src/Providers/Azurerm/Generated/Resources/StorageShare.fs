namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageShareState<'Name, 'Quota, 'StorageAccountName> = { assignments: ResizeArray<azurerm.StorageShare.StorageShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share">azurerm_storage_share</a>.
    /// </summary>
    type StorageShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageShareState<Missing, Missing, Missing>)

        member _.Zero(()) : StorageShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageShareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#name-1">StorageShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageShareState<Missing, 'Quota, 'StorageAccountName>, value: string) : StorageShareState<Present, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageShareState<Present, 'Quota, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#quota-1">StorageShare#quota</a>.
        /// </summary>
        [<CustomOperation "quota">]
        member _.Quota(state: StorageShareState<'Name, Missing, 'StorageAccountName>, value: double) : StorageShareState<'Name, Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Quota <- value)
            ({ assignments = state.assignments } : StorageShareState<'Name, Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#storage_account_name-1">StorageShare#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: StorageShareState<'Name, 'Quota, Missing>, value: string) : StorageShareState<'Name, 'Quota, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : StorageShareState<'Name, 'Quota, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#access_tier-1">StorageShare#access_tier</a>.
        /// </summary>
        [<CustomOperation "access_tier">]
        member _.AccessTier(state: StorageShareState<'Name, 'Quota, 'StorageAccountName>, value: string) : StorageShareState<'Name, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.AccessTier <- value)
            state : StorageShareState<'Name, 'Quota, 'StorageAccountName>

        /// <summary>
        /// acl block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#acl-1">StorageShare#acl</a> Accepts: azurerm.IResolvable | azurerm.StorageShare.StorageShareAcl[]
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: StorageShareState<'Name, 'Quota, 'StorageAccountName>, value: HashiCorp.Cdktf.IResolvable) : StorageShareState<'Name, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : StorageShareState<'Name, 'Quota, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#enabled_protocol-1">StorageShare#enabled_protocol</a>.
        /// </summary>
        [<CustomOperation "enabled_protocol">]
        member _.EnabledProtocol(state: StorageShareState<'Name, 'Quota, 'StorageAccountName>, value: string) : StorageShareState<'Name, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.EnabledProtocol <- value)
            state : StorageShareState<'Name, 'Quota, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#id-1">StorageShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageShareState<'Name, 'Quota, 'StorageAccountName>, value: string) : StorageShareState<'Name, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageShareState<'Name, 'Quota, 'StorageAccountName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#metadata-1">StorageShare#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: StorageShareState<'Name, 'Quota, 'StorageAccountName>, value: seq<string * string>) : StorageShareState<'Name, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : StorageShareState<'Name, 'Quota, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#timeouts-1">StorageShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageShareState<'Name, 'Quota, 'StorageAccountName>, value: azurerm.StorageShare.StorageShareTimeouts) : StorageShareState<'Name, 'Quota, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageShareState<'Name, 'Quota, 'StorageAccountName>

        member _.Run(state: StorageShareState<Present, Present, Present>) : azurerm.StorageShare.StorageShare =
            let config = azurerm.StorageShare.StorageShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageShare.StorageShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageShare: missing required arguments. Must call: name, quota, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: StorageShareState<_, _, _>) : azurerm.StorageShare.StorageShare =
            Unchecked.defaultof<azurerm.StorageShare.StorageShare>
