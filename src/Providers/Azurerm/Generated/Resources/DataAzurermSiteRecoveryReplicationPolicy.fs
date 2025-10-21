namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy">azurerm_site_recovery_replication_policy</a>.
    /// </summary>
    type DataAzurermSiteRecoveryReplicationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSiteRecoveryReplicationPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryReplicationPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSiteRecoveryReplicationPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryReplicationPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy#name-1">DataAzurermSiteRecoveryReplicationPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSiteRecoveryReplicationPolicyState<Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryReplicationPolicyState<Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryReplicationPolicyState<Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy#recovery_vault_name-1">DataAzurermSiteRecoveryReplicationPolicy#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: DataAzurermSiteRecoveryReplicationPolicyState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryReplicationPolicyState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryReplicationPolicyState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy#resource_group_name-1">DataAzurermSiteRecoveryReplicationPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, Missing>, value: string) : DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy#id-1">DataAzurermSiteRecoveryReplicationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy#timeouts-1">DataAzurermSiteRecoveryReplicationPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicyTimeouts) : DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSiteRecoveryReplicationPolicyState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: DataAzurermSiteRecoveryReplicationPolicyState<Present, Present, Present>) : azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicy =
            let config = azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSiteRecoveryReplicationPolicy: missing required arguments. Must call: name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSiteRecoveryReplicationPolicyState<_, _, _>) : azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicy =
            Unchecked.defaultof<azurerm.DataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicy>
