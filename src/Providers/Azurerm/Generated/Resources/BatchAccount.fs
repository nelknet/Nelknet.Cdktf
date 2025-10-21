namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchAccountState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.BatchAccount.BatchAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account">azurerm_batch_account</a>.
    /// </summary>
    type BatchAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : BatchAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#location-1">BatchAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BatchAccountState<Missing, 'Name, 'ResourceGroupName>, value: string) : BatchAccountState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BatchAccountState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#name-1">BatchAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchAccountState<'Location, Missing, 'ResourceGroupName>, value: string) : BatchAccountState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchAccountState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#resource_group_name-1">BatchAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BatchAccountState<'Location, 'Name, Missing>, value: string) : BatchAccountState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BatchAccountState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#allowed_authentication_modes-1">BatchAccount#allowed_authentication_modes</a>.
        /// </summary>
        [<CustomOperation "allowed_authentication_modes">]
        member _.AllowedAuthenticationModes(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowedAuthenticationModes <- (value |> Seq.toArray))
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#encryption-1">BatchAccount#encryption</a>. Accepts: azurerm.IResolvable | azurerm.BatchAccount.BatchAccountEncryption[]
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#id-1">BatchAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#identity-1">BatchAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.BatchAccount.BatchAccountIdentity) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// key_vault_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#key_vault_reference-1">BatchAccount#key_vault_reference</a>
        /// </summary>
        [<CustomOperation "key_vault_reference">]
        member _.KeyVaultReference(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.BatchAccount.BatchAccountKeyVaultReference) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultReference <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#network_profile-1">BatchAccount#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.BatchAccount.BatchAccountNetworkProfile) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#pool_allocation_mode-1">BatchAccount#pool_allocation_mode</a>.
        /// </summary>
        [<CustomOperation "pool_allocation_mode">]
        member _.PoolAllocationMode(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PoolAllocationMode <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#public_network_access_enabled-1">BatchAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: bool) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#public_network_access_enabled-1">BatchAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#storage_account_authentication_mode-1">BatchAccount#storage_account_authentication_mode</a>.
        /// </summary>
        [<CustomOperation "storage_account_authentication_mode">]
        member _.StorageAccountAuthenticationMode(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccountAuthenticationMode <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#storage_account_id-1">BatchAccount#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#storage_account_node_identity-1">BatchAccount#storage_account_node_identity</a>.
        /// </summary>
        [<CustomOperation "storage_account_node_identity">]
        member _.StorageAccountNodeIdentity(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageAccountNodeIdentity <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#tags-1">BatchAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#timeouts-1">BatchAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BatchAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.BatchAccount.BatchAccountTimeouts) : BatchAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BatchAccountState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: BatchAccountState<Present, Present, Present>) : azurerm.BatchAccount.BatchAccount =
            let config = azurerm.BatchAccount.BatchAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.BatchAccount.BatchAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.batchAccount: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: BatchAccountState<_, _, _>) : azurerm.BatchAccount.BatchAccount =
            Unchecked.defaultof<azurerm.BatchAccount.BatchAccount>
