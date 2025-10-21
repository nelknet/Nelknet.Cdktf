namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> = { assignments: ResizeArray<azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy">azurerm_synapse_workspace_extended_auditing_policy</a>.
    /// </summary>
    type SynapseWorkspaceExtendedAuditingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseWorkspaceExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceExtendedAuditingPolicyState<Missing>)

        member _.Zero(()) : SynapseWorkspaceExtendedAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceExtendedAuditingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#synapse_workspace_id-1">SynapseWorkspaceExtendedAuditingPolicy#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseWorkspaceExtendedAuditingPolicyState<Missing>, value: string) : SynapseWorkspaceExtendedAuditingPolicyState<Present> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceExtendedAuditingPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#id-1">SynapseWorkspaceExtendedAuditingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: string) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#log_monitoring_enabled-1">SynapseWorkspaceExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: bool) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#log_monitoring_enabled-1">SynapseWorkspaceExtendedAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#retention_in_days-1">SynapseWorkspaceExtendedAuditingPolicy#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: double) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#storage_account_access_key-1">SynapseWorkspaceExtendedAuditingPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: string) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#storage_account_access_key_is_secondary-1">SynapseWorkspaceExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: bool) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#storage_account_access_key_is_secondary-1">SynapseWorkspaceExtendedAuditingPolicy#storage_account_access_key_is_secondary</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_account_access_key_is_secondary">]
        member _.StorageAccountAccessKeyIsSecondary(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKeyIsSecondary <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#storage_endpoint-1">SynapseWorkspaceExtendedAuditingPolicy#storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "storage_endpoint">]
        member _.StorageEndpoint(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: string) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.StorageEndpoint <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_extended_auditing_policy#timeouts-1">SynapseWorkspaceExtendedAuditingPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>, value: azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicyTimeouts) : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseWorkspaceExtendedAuditingPolicyState<'SynapseWorkspaceId>

        member _.Run(state: SynapseWorkspaceExtendedAuditingPolicyState<Present>) : azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicy =
            let config = azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseWorkspaceExtendedAuditingPolicy: missing required arguments. Must call: synapse_workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseWorkspaceExtendedAuditingPolicyState<_>) : azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicy =
            Unchecked.defaultof<azurerm.SynapseWorkspaceExtendedAuditingPolicy.SynapseWorkspaceExtendedAuditingPolicy>
