namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> = { assignments: ResizeArray<azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy">azurerm_synapse_sql_pool_security_alert_policy</a>.
    /// </summary>
    type SynapseSqlPoolSecurityAlertPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseSqlPoolSecurityAlertPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolSecurityAlertPolicyState<Missing, Missing>)

        member _.Zero(()) : SynapseSqlPoolSecurityAlertPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseSqlPoolSecurityAlertPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#policy_state-1">SynapseSqlPoolSecurityAlertPolicy#policy_state</a>.
        /// </summary>
        [<CustomOperation "policy_state">]
        member _.PolicyState(state: SynapseSqlPoolSecurityAlertPolicyState<Missing, 'SqlPoolId>, value: string) : SynapseSqlPoolSecurityAlertPolicyState<Present, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.PolicyState <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolSecurityAlertPolicyState<Present, 'SqlPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#sql_pool_id-1">SynapseSqlPoolSecurityAlertPolicy#sql_pool_id</a>.
        /// </summary>
        [<CustomOperation "sql_pool_id">]
        member _.SqlPoolId(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, Missing>, value: string) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, Present> =
            state.assignments.Add(fun config -> config.SqlPoolId <- value)
            ({ assignments = state.assignments } : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#disabled_alerts-1">SynapseSqlPoolSecurityAlertPolicy#disabled_alerts</a>.
        /// </summary>
        [<CustomOperation "disabled_alerts">]
        member _.DisabledAlerts(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: seq<string>) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.DisabledAlerts <- (value |> Seq.toArray))
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_account_admins_enabled-1">SynapseSqlPoolSecurityAlertPolicy#email_account_admins_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins_enabled">]
        member _.EmailAccountAdminsEnabled(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: bool) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.EmailAccountAdminsEnabled <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_account_admins_enabled-1">SynapseSqlPoolSecurityAlertPolicy#email_account_admins_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins_enabled">]
        member _.EmailAccountAdminsEnabled(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: HashiCorp.Cdktf.IResolvable) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.EmailAccountAdminsEnabled <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#email_addresses-1">SynapseSqlPoolSecurityAlertPolicy#email_addresses</a>.
        /// </summary>
        [<CustomOperation "email_addresses">]
        member _.EmailAddresses(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: seq<string>) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.EmailAddresses <- (value |> Seq.toArray))
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#id-1">SynapseSqlPoolSecurityAlertPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: string) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#retention_days-1">SynapseSqlPoolSecurityAlertPolicy#retention_days</a>.
        /// </summary>
        [<CustomOperation "retention_days">]
        member _.RetentionDays(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: double) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.RetentionDays <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#storage_account_access_key-1">SynapseSqlPoolSecurityAlertPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: string) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#storage_endpoint-1">SynapseSqlPoolSecurityAlertPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: string) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool_security_alert_policy#timeouts-1">SynapseSqlPoolSecurityAlertPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>, value: azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyTimeouts) : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseSqlPoolSecurityAlertPolicyState<'PolicyState, 'SqlPoolId>

        member _.Run(state: SynapseSqlPoolSecurityAlertPolicyState<Present, Present>) : azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicy =
            let config = azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseSqlPoolSecurityAlertPolicy: missing required arguments. Must call: policy_state, sql_pool_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseSqlPoolSecurityAlertPolicyState<_, _>) : azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicy =
            Unchecked.defaultof<azurerm.SynapseSqlPoolSecurityAlertPolicy.SynapseSqlPoolSecurityAlertPolicy>
