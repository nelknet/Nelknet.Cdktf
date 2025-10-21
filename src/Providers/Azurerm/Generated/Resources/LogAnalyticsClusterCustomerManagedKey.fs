namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId> = { assignments: ResizeArray<azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster_customer_managed_key">azurerm_log_analytics_cluster_customer_managed_key</a>.
    /// </summary>
    type LogAnalyticsClusterCustomerManagedKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsClusterCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsClusterCustomerManagedKeyState<Missing, Missing>)

        member _.Zero(()) : LogAnalyticsClusterCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsClusterCustomerManagedKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster_customer_managed_key#key_vault_key_id-1">LogAnalyticsClusterCustomerManagedKey#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: LogAnalyticsClusterCustomerManagedKeyState<Missing, 'LogAnalyticsClusterId>, value: string) : LogAnalyticsClusterCustomerManagedKeyState<Present, 'LogAnalyticsClusterId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            ({ assignments = state.assignments } : LogAnalyticsClusterCustomerManagedKeyState<Present, 'LogAnalyticsClusterId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster_customer_managed_key#log_analytics_cluster_id-1">LogAnalyticsClusterCustomerManagedKey#log_analytics_cluster_id</a>.
        /// </summary>
        [<CustomOperation "log_analytics_cluster_id">]
        member _.LogAnalyticsClusterId(state: LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, Missing>, value: string) : LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, Present> =
            state.assignments.Add(fun config -> config.LogAnalyticsClusterId <- value)
            ({ assignments = state.assignments } : LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster_customer_managed_key#id-1">LogAnalyticsClusterCustomerManagedKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId>, value: string) : LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster_customer_managed_key#timeouts-1">LogAnalyticsClusterCustomerManagedKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId>, value: azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKeyTimeouts) : LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsClusterCustomerManagedKeyState<'KeyVaultKeyId, 'LogAnalyticsClusterId>

        member _.Run(state: LogAnalyticsClusterCustomerManagedKeyState<Present, Present>) : azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKey =
            let config = azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsClusterCustomerManagedKey: missing required arguments. Must call: key_vault_key_id, log_analytics_cluster_id.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsClusterCustomerManagedKeyState<_, _>) : azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKey =
            Unchecked.defaultof<azurerm.LogAnalyticsClusterCustomerManagedKey.LogAnalyticsClusterCustomerManagedKey>
