namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_customer_managed_key">azurerm_databricks_workspace_customer_managed_key</a>.
    /// </summary>
    type DatabricksWorkspaceCustomerManagedKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabricksWorkspaceCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksWorkspaceCustomerManagedKeyState<Missing, Missing>)

        member _.Zero(()) : DatabricksWorkspaceCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksWorkspaceCustomerManagedKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_customer_managed_key#key_vault_key_id-1">DatabricksWorkspaceCustomerManagedKey#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: DatabricksWorkspaceCustomerManagedKeyState<Missing, 'WorkspaceId>, value: string) : DatabricksWorkspaceCustomerManagedKeyState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceCustomerManagedKeyState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_customer_managed_key#workspace_id-1">DatabricksWorkspaceCustomerManagedKey#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, Missing>, value: string) : DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_customer_managed_key#id-1">DatabricksWorkspaceCustomerManagedKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>, value: string) : DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace_customer_managed_key#timeouts-1">DatabricksWorkspaceCustomerManagedKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>, value: azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKeyTimeouts) : DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabricksWorkspaceCustomerManagedKeyState<'KeyVaultKeyId, 'WorkspaceId>

        member _.Run(state: DatabricksWorkspaceCustomerManagedKeyState<Present, Present>) : azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKey =
            let config = azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databricksWorkspaceCustomerManagedKey: missing required arguments. Must call: key_vault_key_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DatabricksWorkspaceCustomerManagedKeyState<_, _>) : azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKey =
            Unchecked.defaultof<azurerm.DatabricksWorkspaceCustomerManagedKey.DatabricksWorkspaceCustomerManagedKey>
