namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key">azurerm_databricks_workspace_root_dbfs_customer_managed_key</a>.
    /// </summary>
    type DatabricksWorkspaceRootDbfsCustomerManagedKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Missing, Missing>)

        member _.Zero(()) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#key_vault_key_id-1">DatabricksWorkspaceRootDbfsCustomerManagedKey#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Missing, 'WorkspaceId>, value: string) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#workspace_id-1">DatabricksWorkspaceRootDbfsCustomerManagedKey#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, Missing>, value: string) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#id-1">DatabricksWorkspaceRootDbfsCustomerManagedKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>, value: string) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#key_vault_id-1">DatabricksWorkspaceRootDbfsCustomerManagedKey#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>, value: string) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            state : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_root_dbfs_customer_managed_key#timeouts-1">DatabricksWorkspaceRootDbfsCustomerManagedKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>, value: azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyTimeouts) : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabricksWorkspaceRootDbfsCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>

        member _.Run(state: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<Present, Present>) : azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey =
            let config = azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databricksWorkspaceRootDbfsCustomerManagedKey: missing required arguments. Must call: key_vault_key_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DatabricksWorkspaceRootDbfsCustomerManagedKeyState<_, _>) : azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey =
            Unchecked.defaultof<azurerm.DatabricksWorkspaceRootDbfsCustomerManagedKey.DatabricksWorkspaceRootDbfsCustomerManagedKey>
