namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlServerExtendedAuditingPolicyState<'ServerId> = { assignments: ResizeArray<azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy">azurerm_mssql_server_extended_auditing_policy</a>.
    /// </summary>
    type MssqlServerExtendedAuditingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlServerExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : MssqlServerExtendedAuditingPolicyState<Missing>)

        member _.Zero(()) : MssqlServerExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : MssqlServerExtendedAuditingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#server_id-1">MssqlServerExtendedAuditingPolicy#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlServerExtendedAuditingPolicyState<Missing>, value: string) : MssqlServerExtendedAuditingPolicyState<Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlServerExtendedAuditingPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#audit_actions_and_groups-1">MssqlServerExtendedAuditingPolicy#audit_actions_and_groups</a>.
        /// </summary>
        [<CustomOperation "audit_actions_and_groups">]
        member _.AuditActionsAndGroups(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: seq<string>) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.AuditActionsAndGroups <- (value |> Seq.toArray))
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#enabled-1">MssqlServerExtendedAuditingPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: bool) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#enabled-1">MssqlServerExtendedAuditingPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#id-1">MssqlServerExtendedAuditingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: string) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#log_monitoring_enabled-1">MssqlServerExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: bool) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#log_monitoring_enabled-1">MssqlServerExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#predicate_expression-1">MssqlServerExtendedAuditingPolicy#predicate_expression</a>.
        /// </summary>
        [<CustomOperation "predicate_expression">]
        member _.PredicateExpression(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: string) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.PredicateExpression <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#retention_in_days-1">MssqlServerExtendedAuditingPolicy#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: double) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#storage_account_access_key-1">MssqlServerExtendedAuditingPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: string) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#storage_account_access_key_is_secondary-1">MssqlServerExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: bool) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#storage_account_access_key_is_secondary-1">MssqlServerExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#storage_account_subscription_id-1">MssqlServerExtendedAuditingPolicy#storage_account_subscription_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_subscription_id">]
        member _.StorageAccountSubscriptionId(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: string) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountSubscriptionId <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#storage_endpoint-1">MssqlServerExtendedAuditingPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: string) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_extended_auditing_policy#timeouts-1">MssqlServerExtendedAuditingPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlServerExtendedAuditingPolicyState<'ServerId>, value: azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicyTimeouts) : MssqlServerExtendedAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlServerExtendedAuditingPolicyState<'ServerId>

        member _.Run(state: MssqlServerExtendedAuditingPolicyState<Present>) : azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicy =
            let config = azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlServerExtendedAuditingPolicy: missing required arguments. Must call: server_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlServerExtendedAuditingPolicyState<_>) : azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicy =
            Unchecked.defaultof<azurerm.MssqlServerExtendedAuditingPolicy.MssqlServerExtendedAuditingPolicy>
