namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseSqlPool.SynapseSqlPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool">azurerm_synapse_sql_pool</a>.
    /// </summary>
    type SynapseSqlPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseSqlPoolState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseSqlPoolState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#name-1">SynapseSqlPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseSqlPoolState<Missing, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<Present, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolState<Present, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#sku_name-1">SynapseSqlPool#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: SynapseSqlPoolState<'Name, Missing, 'StorageAccountType, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<'Name, Present, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolState<'Name, Present, 'StorageAccountType, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#storage_account_type-1">SynapseSqlPool#storage_account_type</a>.
        /// </summary>
        [<CustomOperation "storage_account_type">]
        member _.StorageAccountType(state: SynapseSqlPoolState<'Name, 'SkuName, Missing, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<'Name, 'SkuName, Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountType <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolState<'Name, 'SkuName, Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#synapse_workspace_id-1">SynapseSqlPool#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, Missing>, value: string) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#collation-1">SynapseSqlPool#collation</a>.
        /// </summary>
        [<CustomOperation "collation">]
        member _.Collation(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Collation <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#create_mode-1">SynapseSqlPool#create_mode</a>.
        /// </summary>
        [<CustomOperation "create_mode">]
        member _.CreateMode(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.CreateMode <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#data_encrypted-1">SynapseSqlPool#data_encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_encrypted">]
        member _.DataEncrypted(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: bool) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.DataEncrypted <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#data_encrypted-1">SynapseSqlPool#data_encrypted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_encrypted">]
        member _.DataEncrypted(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.DataEncrypted <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#geo_backup_policy_enabled-1">SynapseSqlPool#geo_backup_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_backup_policy_enabled">]
        member _.GeoBackupPolicyEnabled(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: bool) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.GeoBackupPolicyEnabled <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#geo_backup_policy_enabled-1">SynapseSqlPool#geo_backup_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_backup_policy_enabled">]
        member _.GeoBackupPolicyEnabled(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.GeoBackupPolicyEnabled <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#id-1">SynapseSqlPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#recovery_database_id-1">SynapseSqlPool#recovery_database_id</a>.
        /// </summary>
        [<CustomOperation "recovery_database_id">]
        member _.RecoveryDatabaseId(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: string) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.RecoveryDatabaseId <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// restore block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#restore-1">SynapseSqlPool#restore</a>
        /// </summary>
        [<CustomOperation "restore">]
        member _.Restore(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: azurerm.SynapseSqlPool.SynapseSqlPoolRestore) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Restore <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#tags-1">SynapseSqlPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: seq<string * string>) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#timeouts-1">SynapseSqlPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>, value: azurerm.SynapseSqlPool.SynapseSqlPoolTimeouts) : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseSqlPoolState<'Name, 'SkuName, 'StorageAccountType, 'SynapseWorkspaceId>

        member _.Run(state: SynapseSqlPoolState<Present, Present, Present, Present>) : azurerm.SynapseSqlPool.SynapseSqlPool =
            let config = azurerm.SynapseSqlPool.SynapseSqlPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseSqlPool.SynapseSqlPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseSqlPool: missing required arguments. Must call: name, sku_name, storage_account_type, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseSqlPoolState<_, _, _, _>) : azurerm.SynapseSqlPool.SynapseSqlPool =
            Unchecked.defaultof<azurerm.SynapseSqlPool.SynapseSqlPool>
