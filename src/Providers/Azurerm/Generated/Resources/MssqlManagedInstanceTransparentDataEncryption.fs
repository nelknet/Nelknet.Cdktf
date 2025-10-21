namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId> = { assignments: ResizeArray<azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption">azurerm_mssql_managed_instance_transparent_data_encryption</a>.
    /// </summary>
    type MssqlManagedInstanceTransparentDataEncryptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlManagedInstanceTransparentDataEncryptionState<Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceTransparentDataEncryptionState<Missing>)

        member _.Zero(()) : MssqlManagedInstanceTransparentDataEncryptionState<Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceTransparentDataEncryptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption#managed_instance_id-1">MssqlManagedInstanceTransparentDataEncryption#managed_instance_id</a>.
        /// </summary>
        [<CustomOperation "managed_instance_id">]
        member _.ManagedInstanceId(state: MssqlManagedInstanceTransparentDataEncryptionState<Missing>, value: string) : MssqlManagedInstanceTransparentDataEncryptionState<Present> =
            state.assignments.Add(fun config -> config.ManagedInstanceId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceTransparentDataEncryptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption#auto_rotation_enabled-1">MssqlManagedInstanceTransparentDataEncryption#auto_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_rotation_enabled">]
        member _.AutoRotationEnabled(state: MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>, value: bool) : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId> =
            state.assignments.Add(fun config -> config.AutoRotationEnabled <- value)
            state : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption#auto_rotation_enabled-1">MssqlManagedInstanceTransparentDataEncryption#auto_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_rotation_enabled">]
        member _.AutoRotationEnabled(state: MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId> =
            state.assignments.Add(fun config -> config.AutoRotationEnabled <- value)
            state : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption#id-1">MssqlManagedInstanceTransparentDataEncryption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>, value: string) : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption#key_vault_key_id-1">MssqlManagedInstanceTransparentDataEncryption#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>, value: string) : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_transparent_data_encryption#timeouts-1">MssqlManagedInstanceTransparentDataEncryption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>, value: azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryptionTimeouts) : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlManagedInstanceTransparentDataEncryptionState<'ManagedInstanceId>

        member _.Run(state: MssqlManagedInstanceTransparentDataEncryptionState<Present>) : azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryption =
            let config = azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlManagedInstanceTransparentDataEncryption: missing required arguments. Must call: managed_instance_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlManagedInstanceTransparentDataEncryptionState<_>) : azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryption =
            Unchecked.defaultof<azurerm.MssqlManagedInstanceTransparentDataEncryption.MssqlManagedInstanceTransparentDataEncryption>
