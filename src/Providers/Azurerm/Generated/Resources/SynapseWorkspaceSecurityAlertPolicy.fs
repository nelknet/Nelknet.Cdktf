namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy">azurerm_synapse_workspace_security_alert_policy</a>.
    /// </summary>
    type SynapseWorkspaceSecurityAlertPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseWorkspaceSecurityAlertPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceSecurityAlertPolicyState<Missing, Missing>)

        member _.Zero(()) : SynapseWorkspaceSecurityAlertPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceSecurityAlertPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#policy_state-1">SynapseWorkspaceSecurityAlertPolicy#policy_state</a>.
        /// </summary>
        [<CustomOperation "policy_state">]
        member _.PolicyState(state: SynapseWorkspaceSecurityAlertPolicyState<Missing, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceSecurityAlertPolicyState<Present, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.PolicyState <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceSecurityAlertPolicyState<Present, 'SynapseWorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#synapse_workspace_id-1">SynapseWorkspaceSecurityAlertPolicy#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, Missing>, value: string) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#disabled_alerts-1">SynapseWorkspaceSecurityAlertPolicy#disabled_alerts</a>.
        /// </summary>
        [<CustomOperation "disabled_alerts">]
        member _.DisabledAlerts(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: seq<string>) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.DisabledAlerts <- (value |> Seq.toArray))
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#email_account_admins_enabled-1">SynapseWorkspaceSecurityAlertPolicy#email_account_admins_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins_enabled">]
        member _.EmailAccountAdminsEnabled(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: bool) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.EmailAccountAdminsEnabled <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#email_account_admins_enabled-1">SynapseWorkspaceSecurityAlertPolicy#email_account_admins_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "email_account_admins_enabled">]
        member _.EmailAccountAdminsEnabled(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.EmailAccountAdminsEnabled <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#email_addresses-1">SynapseWorkspaceSecurityAlertPolicy#email_addresses</a>.
        /// </summary>
        [<CustomOperation "email_addresses">]
        member _.EmailAddresses(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: seq<string>) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.EmailAddresses <- (value |> Seq.toArray))
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#id-1">SynapseWorkspaceSecurityAlertPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#retention_days-1">SynapseWorkspaceSecurityAlertPolicy#retention_days</a>.
        /// </summary>
        [<CustomOperation "retention_days">]
        member _.RetentionDays(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: double) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.RetentionDays <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#storage_account_access_key-1">SynapseWorkspaceSecurityAlertPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#storage_endpoint-1">SynapseWorkspaceSecurityAlertPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: string) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_security_alert_policy#timeouts-1">SynapseWorkspaceSecurityAlertPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>, value: azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicyTimeouts) : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseWorkspaceSecurityAlertPolicyState<'PolicyState, 'SynapseWorkspaceId>

        member _.Run(state: SynapseWorkspaceSecurityAlertPolicyState<Present, Present>) : azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicy =
            let config = azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseWorkspaceSecurityAlertPolicy: missing required arguments. Must call: policy_state, synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseWorkspaceSecurityAlertPolicyState<_, _>) : azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicy =
            Unchecked.defaultof<azurerm.SynapseWorkspaceSecurityAlertPolicy.SynapseWorkspaceSecurityAlertPolicy>
