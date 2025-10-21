namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId> = { assignments: ResizeArray<azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault_resource_guard_association">azurerm_recovery_services_vault_resource_guard_association</a>.
    /// </summary>
    type RecoveryServicesVaultResourceGuardAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RecoveryServicesVaultResourceGuardAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RecoveryServicesVaultResourceGuardAssociationState<Missing, Missing>)

        member _.Zero(()) : RecoveryServicesVaultResourceGuardAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RecoveryServicesVaultResourceGuardAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault_resource_guard_association#resource_guard_id-1">RecoveryServicesVaultResourceGuardAssociation#resource_guard_id</a>.
        /// </summary>
        [<CustomOperation "resource_guard_id">]
        member _.ResourceGuardId(state: RecoveryServicesVaultResourceGuardAssociationState<Missing, 'VaultId>, value: string) : RecoveryServicesVaultResourceGuardAssociationState<Present, 'VaultId> =
            state.assignments.Add(fun config -> config.ResourceGuardId <- value)
            ({ assignments = state.assignments } : RecoveryServicesVaultResourceGuardAssociationState<Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault_resource_guard_association#vault_id-1">RecoveryServicesVaultResourceGuardAssociation#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, Missing>, value: string) : RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault_resource_guard_association#id-1">RecoveryServicesVaultResourceGuardAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId>, value: string) : RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault_resource_guard_association#timeouts-1">RecoveryServicesVaultResourceGuardAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId>, value: azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociationTimeouts) : RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RecoveryServicesVaultResourceGuardAssociationState<'ResourceGuardId, 'VaultId>

        member _.Run(state: RecoveryServicesVaultResourceGuardAssociationState<Present, Present>) : azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociation =
            let config = azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.recoveryServicesVaultResourceGuardAssociation: missing required arguments. Must call: resource_guard_id, vault_id.", 9999, IsError = true)>]
        member _.Run(_: RecoveryServicesVaultResourceGuardAssociationState<_, _>) : azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociation =
            Unchecked.defaultof<azurerm.RecoveryServicesVaultResourceGuardAssociation.RecoveryServicesVaultResourceGuardAssociation>
