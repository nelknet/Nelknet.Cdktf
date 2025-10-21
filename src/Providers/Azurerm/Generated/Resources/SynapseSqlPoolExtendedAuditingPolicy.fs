namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> = { assignments: ResizeArray<azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy">azurerm_synapse_sql_pool_extended_auditing_policy</a>.
    /// </summary>
    type SynapseSqlPoolExtendedAuditingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseSqlPoolExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolExtendedAuditingPolicyState<Missing>)

        member _.Zero(()) : SynapseSqlPoolExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolExtendedAuditingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#sql_pool_id-1">SynapseSqlPoolExtendedAuditingPolicy#sql_pool_id</a>.
        /// </summary>
        [<CustomOperation "sql_pool_id">]
        member _.SqlPoolId(state: SynapseSqlPoolExtendedAuditingPolicyState<Missing>, value: string) : SynapseSqlPoolExtendedAuditingPolicyState<Present> =
            state.assignments.Add(fun config -> config.SqlPoolId <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolExtendedAuditingPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#id-1">SynapseSqlPoolExtendedAuditingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: string) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#log_monitoring_enabled-1">SynapseSqlPoolExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: bool) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#log_monitoring_enabled-1">SynapseSqlPoolExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#retention_in_days-1">SynapseSqlPoolExtendedAuditingPolicy#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: double) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#storage_account_access_key-1">SynapseSqlPoolExtendedAuditingPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: string) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#storage_account_access_key_is_secondary-1">SynapseSqlPoolExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: bool) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#storage_account_access_key_is_secondary-1">SynapseSqlPoolExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#storage_endpoint-1">SynapseSqlPoolExtendedAuditingPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: string) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_extended_auditing_policy#timeouts-1">SynapseSqlPoolExtendedAuditingPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>, value: azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicyTimeouts) : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseSqlPoolExtendedAuditingPolicyState<'SqlPoolId>

        member _.Run(state: SynapseSqlPoolExtendedAuditingPolicyState<Present>) : azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicy =
            let config = azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseSqlPoolExtendedAuditingPolicy: missing required arguments. Must call: sql_pool_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseSqlPoolExtendedAuditingPolicyState<_>) : azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicy =
            Unchecked.defaultof<azurerm.SynapseSqlPoolExtendedAuditingPolicy.SynapseSqlPoolExtendedAuditingPolicy>
