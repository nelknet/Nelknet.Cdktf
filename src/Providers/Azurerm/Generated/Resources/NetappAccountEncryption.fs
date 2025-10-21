namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId> = { assignments: ResizeArray<azurerm.NetappAccountEncryption.NetappAccountEncryptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption">azurerm_netapp_account_encryption</a>.
    /// </summary>
    type NetappAccountEncryptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappAccountEncryptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappAccountEncryptionState<Missing, Missing>)

        member _.Zero(()) : NetappAccountEncryptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappAccountEncryptionState<Missing, Missing>)

        /// <summary>
        /// The versionless encryption key url. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption#encryption_key-1">NetappAccountEncryption#encryption_key</a>
        /// </summary>
        [<CustomOperation "encryption_key">]
        member _.EncryptionKey(state: NetappAccountEncryptionState<Missing, 'NetappAccountId>, value: string) : NetappAccountEncryptionState<Present, 'NetappAccountId> =
            state.assignments.Add(fun config -> config.EncryptionKey <- value)
            ({ assignments = state.assignments } : NetappAccountEncryptionState<Present, 'NetappAccountId>)

        /// <summary>
        /// The ID of the NetApp Account where encryption will be set. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption#netapp_account_id-1">NetappAccountEncryption#netapp_account_id</a>
        /// </summary>
        [<CustomOperation "netapp_account_id">]
        member _.NetappAccountId(state: NetappAccountEncryptionState<'EncryptionKey, Missing>, value: string) : NetappAccountEncryptionState<'EncryptionKey, Present> =
            state.assignments.Add(fun config -> config.NetappAccountId <- value)
            ({ assignments = state.assignments } : NetappAccountEncryptionState<'EncryptionKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption#id-1">NetappAccountEncryption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>, value: string) : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>

        /// <summary>
        /// The Principal ID of the System Assigned Identity to use for encryption. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption#system_assigned_identity_principal_id-1">NetappAccountEncryption#system_assigned_identity_principal_id</a>
        /// </summary>
        [<CustomOperation "system_assigned_identity_principal_id">]
        member _.SystemAssignedIdentityPrincipalId(state: NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>, value: string) : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId> =
            state.assignments.Add(fun config -> config.SystemAssignedIdentityPrincipalId <- value)
            state : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption#timeouts-1">NetappAccountEncryption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>, value: azurerm.NetappAccountEncryption.NetappAccountEncryptionTimeouts) : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>

        /// <summary>
        /// The resource ID of the User Assigned Identity to use for encryption. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account_encryption#user_assigned_identity_id-1">NetappAccountEncryption#user_assigned_identity_id</a>
        /// </summary>
        [<CustomOperation "user_assigned_identity_id">]
        member _.UserAssignedIdentityId(state: NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>, value: string) : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId> =
            state.assignments.Add(fun config -> config.UserAssignedIdentityId <- value)
            state : NetappAccountEncryptionState<'EncryptionKey, 'NetappAccountId>

        member _.Run(state: NetappAccountEncryptionState<Present, Present>) : azurerm.NetappAccountEncryption.NetappAccountEncryption =
            let config = azurerm.NetappAccountEncryption.NetappAccountEncryptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappAccountEncryption.NetappAccountEncryption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappAccountEncryption: missing required arguments. Must call: encryption_key, netapp_account_id.", 9999, IsError = true)>]
        member _.Run(_: NetappAccountEncryptionState<_, _>) : azurerm.NetappAccountEncryption.NetappAccountEncryption =
            Unchecked.defaultof<azurerm.NetappAccountEncryption.NetappAccountEncryption>
