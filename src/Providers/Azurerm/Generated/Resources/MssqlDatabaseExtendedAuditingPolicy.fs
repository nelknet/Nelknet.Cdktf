namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> = { assignments: ResizeArray<azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy">azurerm_mssql_database_extended_auditing_policy</a>.
    /// </summary>
    type MssqlDatabaseExtendedAuditingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlDatabaseExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : MssqlDatabaseExtendedAuditingPolicyState<Missing>)

        member _.Zero(()) : MssqlDatabaseExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : MssqlDatabaseExtendedAuditingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#database_id-1">MssqlDatabaseExtendedAuditingPolicy#database_id</a>.
        /// </summary>
        [<CustomOperation "database_id">]
        member _.DatabaseId(state: MssqlDatabaseExtendedAuditingPolicyState<Missing>, value: string) : MssqlDatabaseExtendedAuditingPolicyState<Present> =
            state.assignments.Add(fun config -> config.DatabaseId <- value)
            ({ assignments = state.assignments } : MssqlDatabaseExtendedAuditingPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#enabled-1">MssqlDatabaseExtendedAuditingPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: bool) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#enabled-1">MssqlDatabaseExtendedAuditingPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#id-1">MssqlDatabaseExtendedAuditingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: string) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#log_monitoring_enabled-1">MssqlDatabaseExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: bool) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#log_monitoring_enabled-1">MssqlDatabaseExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#retention_in_days-1">MssqlDatabaseExtendedAuditingPolicy#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: double) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#storage_account_access_key-1">MssqlDatabaseExtendedAuditingPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: string) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#storage_account_access_key_is_secondary-1">MssqlDatabaseExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: bool) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#storage_account_access_key_is_secondary-1">MssqlDatabaseExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#storage_endpoint-1">MssqlDatabaseExtendedAuditingPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: string) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database_extended_auditing_policy#timeouts-1">MssqlDatabaseExtendedAuditingPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>, value: azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicyTimeouts) : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlDatabaseExtendedAuditingPolicyState<'DatabaseId>

        member _.Run(state: MssqlDatabaseExtendedAuditingPolicyState<Present>) : azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicy =
            let config = azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlDatabaseExtendedAuditingPolicy: missing required arguments. Must call: database_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlDatabaseExtendedAuditingPolicyState<_>) : azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicy =
            Unchecked.defaultof<azurerm.MssqlDatabaseExtendedAuditingPolicy.MssqlDatabaseExtendedAuditingPolicy>
