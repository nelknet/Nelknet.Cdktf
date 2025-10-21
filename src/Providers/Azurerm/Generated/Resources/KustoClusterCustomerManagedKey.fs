namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId> = { assignments: ResizeArray<azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key">azurerm_kusto_cluster_customer_managed_key</a>.
    /// </summary>
    type KustoClusterCustomerManagedKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoClusterCustomerManagedKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterCustomerManagedKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : KustoClusterCustomerManagedKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterCustomerManagedKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#cluster_id-1">KustoClusterCustomerManagedKey#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: KustoClusterCustomerManagedKeyState<Missing, 'KeyName, 'KeyVaultId>, value: string) : KustoClusterCustomerManagedKeyState<Present, 'KeyName, 'KeyVaultId> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : KustoClusterCustomerManagedKeyState<Present, 'KeyName, 'KeyVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#key_name-1">KustoClusterCustomerManagedKey#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: KustoClusterCustomerManagedKeyState<'ClusterId, Missing, 'KeyVaultId>, value: string) : KustoClusterCustomerManagedKeyState<'ClusterId, Present, 'KeyVaultId> =
            state.assignments.Add(fun config -> config.KeyName <- value)
            ({ assignments = state.assignments } : KustoClusterCustomerManagedKeyState<'ClusterId, Present, 'KeyVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#key_vault_id-1">KustoClusterCustomerManagedKey#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, Missing>, value: string) : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, Present> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#id-1">KustoClusterCustomerManagedKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>, value: string) : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#key_version-1">KustoClusterCustomerManagedKey#key_version</a>.
        /// </summary>
        [<CustomOperation "key_version">]
        member _.KeyVersion(state: KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>, value: string) : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId> =
            state.assignments.Add(fun config -> config.KeyVersion <- value)
            state : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#timeouts-1">KustoClusterCustomerManagedKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>, value: azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKeyTimeouts) : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_customer_managed_key#user_identity-1">KustoClusterCustomerManagedKey#user_identity</a>.
        /// </summary>
        [<CustomOperation "user_identity">]
        member _.UserIdentity(state: KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>, value: string) : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId> =
            state.assignments.Add(fun config -> config.UserIdentity <- value)
            state : KustoClusterCustomerManagedKeyState<'ClusterId, 'KeyName, 'KeyVaultId>

        member _.Run(state: KustoClusterCustomerManagedKeyState<Present, Present, Present>) : azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKey =
            let config = azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoClusterCustomerManagedKey: missing required arguments. Must call: cluster_id, key_name, key_vault_id.", 9999, IsError = true)>]
        member _.Run(_: KustoClusterCustomerManagedKeyState<_, _, _>) : azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKey =
            Unchecked.defaultof<azurerm.KustoClusterCustomerManagedKey.KustoClusterCustomerManagedKey>
