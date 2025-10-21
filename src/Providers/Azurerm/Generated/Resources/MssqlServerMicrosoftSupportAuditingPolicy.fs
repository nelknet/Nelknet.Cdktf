namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> = { assignments: ResizeArray<azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy">azurerm_mssql_server_microsoft_support_auditing_policy</a>.
    /// </summary>
    type MssqlServerMicrosoftSupportAuditingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlServerMicrosoftSupportAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : MssqlServerMicrosoftSupportAuditingPolicyState<Missing>)

        member _.Zero(()) : MssqlServerMicrosoftSupportAuditingPolicyState<Missing> =
            ({ assignments = ResizeArray() } : MssqlServerMicrosoftSupportAuditingPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#server_id-1">MssqlServerMicrosoftSupportAuditingPolicy#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlServerMicrosoftSupportAuditingPolicyState<Missing>, value: string) : MssqlServerMicrosoftSupportAuditingPolicyState<Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlServerMicrosoftSupportAuditingPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#blob_storage_endpoint-1">MssqlServerMicrosoftSupportAuditingPolicy#blob_storage_endpoint</a>.
        /// </summary>
        [<CustomOperation "blob_storage_endpoint">]
        member _.BlobStorageEndpoint(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: string) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.BlobStorageEndpoint <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#enabled-1">MssqlServerMicrosoftSupportAuditingPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: bool) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#enabled-1">MssqlServerMicrosoftSupportAuditingPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#id-1">MssqlServerMicrosoftSupportAuditingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: string) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#log_monitoring_enabled-1">MssqlServerMicrosoftSupportAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: bool) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#log_monitoring_enabled-1">MssqlServerMicrosoftSupportAuditingPolicy#log_monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_monitoring_enabled">]
        member _.LogMonitoringEnabled(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.LogMonitoringEnabled <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#storage_account_access_key-1">MssqlServerMicrosoftSupportAuditingPolicy#storage_account_access_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_access_key">]
        member _.StorageAccountAccessKey(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: string) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountAccessKey <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#storage_account_subscription_id-1">MssqlServerMicrosoftSupportAuditingPolicy#storage_account_subscription_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_subscription_id">]
        member _.StorageAccountSubscriptionId(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: string) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountSubscriptionId <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_microsoft_support_auditing_policy#timeouts-1">MssqlServerMicrosoftSupportAuditingPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>, value: azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicyTimeouts) : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlServerMicrosoftSupportAuditingPolicyState<'ServerId>

        member _.Run(state: MssqlServerMicrosoftSupportAuditingPolicyState<Present>) : azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicy =
            let config = azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlServerMicrosoftSupportAuditingPolicy: missing required arguments. Must call: server_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlServerMicrosoftSupportAuditingPolicyState<_>) : azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicy =
            Unchecked.defaultof<azurerm.MssqlServerMicrosoftSupportAuditingPolicy.MssqlServerMicrosoftSupportAuditingPolicy>
