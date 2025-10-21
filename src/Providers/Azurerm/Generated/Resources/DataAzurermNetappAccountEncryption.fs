namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappAccountEncryptionState<'NetappAccountId> = { assignments: ResizeArray<azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption">azurerm_netapp_account_encryption</a>.
    /// </summary>
    type DataAzurermNetappAccountEncryptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappAccountEncryptionState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappAccountEncryptionState<Missing>)

        member _.Zero(()) : DataAzurermNetappAccountEncryptionState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappAccountEncryptionState<Missing>)

        /// <summary>
        /// The ID of the NetApp Account where encryption will be set. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#netapp_account_id-1">DataAzurermNetappAccountEncryption#netapp_account_id</a>
        /// </summary>
        [<CustomOperation "netapp_account_id">]
        member _.NetappAccountId(state: DataAzurermNetappAccountEncryptionState<Missing>, value: string) : DataAzurermNetappAccountEncryptionState<Present> =
            state.assignments.Add(fun config -> config.NetappAccountId <- value)
            ({ assignments = state.assignments } : DataAzurermNetappAccountEncryptionState<Present>)

        /// <summary>
        /// The versionless encryption key url. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#encryption_key-1">DataAzurermNetappAccountEncryption#encryption_key</a>
        /// </summary>
        [<CustomOperation "encryption_key">]
        member _.EncryptionKey(state: DataAzurermNetappAccountEncryptionState<'NetappAccountId>, value: string) : DataAzurermNetappAccountEncryptionState<'NetappAccountId> =
            state.assignments.Add(fun config -> config.EncryptionKey <- value)
            state : DataAzurermNetappAccountEncryptionState<'NetappAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#id-1">DataAzurermNetappAccountEncryption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappAccountEncryptionState<'NetappAccountId>, value: string) : DataAzurermNetappAccountEncryptionState<'NetappAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappAccountEncryptionState<'NetappAccountId>

        /// <summary>
        /// The Principal ID of the System Assigned Identity to use for encryption. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#system_assigned_identity_principal_id-1">DataAzurermNetappAccountEncryption#system_assigned_identity_principal_id</a>
        /// </summary>
        [<CustomOperation "system_assigned_identity_principal_id">]
        member _.SystemAssignedIdentityPrincipalId(state: DataAzurermNetappAccountEncryptionState<'NetappAccountId>, value: string) : DataAzurermNetappAccountEncryptionState<'NetappAccountId> =
            state.assignments.Add(fun config -> config.SystemAssignedIdentityPrincipalId <- value)
            state : DataAzurermNetappAccountEncryptionState<'NetappAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#timeouts-1">DataAzurermNetappAccountEncryption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappAccountEncryptionState<'NetappAccountId>, value: azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeouts) : DataAzurermNetappAccountEncryptionState<'NetappAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappAccountEncryptionState<'NetappAccountId>

        /// <summary>
        /// The resource ID of the User Assigned Identity to use for encryption. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#user_assigned_identity_id-1">DataAzurermNetappAccountEncryption#user_assigned_identity_id</a>
        /// </summary>
        [<CustomOperation "user_assigned_identity_id">]
        member _.UserAssignedIdentityId(state: DataAzurermNetappAccountEncryptionState<'NetappAccountId>, value: string) : DataAzurermNetappAccountEncryptionState<'NetappAccountId> =
            state.assignments.Add(fun config -> config.UserAssignedIdentityId <- value)
            state : DataAzurermNetappAccountEncryptionState<'NetappAccountId>

        member _.Run(state: DataAzurermNetappAccountEncryptionState<Present>) : azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption =
            let config = azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappAccountEncryption: missing required arguments. Must call: netapp_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappAccountEncryptionState<_>) : azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption =
            Unchecked.defaultof<azurerm.DataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryption>
