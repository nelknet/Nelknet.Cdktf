namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId> = { assignments: ResizeArray<azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_services_vault_hyperv_site">azurerm_site_recovery_services_vault_hyperv_site</a>.
    /// </summary>
    type SiteRecoveryServicesVaultHypervSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryServicesVaultHypervSiteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryServicesVaultHypervSiteState<Missing, Missing>)

        member _.Zero(()) : SiteRecoveryServicesVaultHypervSiteState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryServicesVaultHypervSiteState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_services_vault_hyperv_site#name-1">SiteRecoveryServicesVaultHypervSite#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryServicesVaultHypervSiteState<Missing, 'RecoveryVaultId>, value: string) : SiteRecoveryServicesVaultHypervSiteState<Present, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryServicesVaultHypervSiteState<Present, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_services_vault_hyperv_site#recovery_vault_id-1">SiteRecoveryServicesVaultHypervSite#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryServicesVaultHypervSiteState<'Name, Missing>, value: string) : SiteRecoveryServicesVaultHypervSiteState<'Name, Present> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryServicesVaultHypervSiteState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_services_vault_hyperv_site#id-1">SiteRecoveryServicesVaultHypervSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId>, value: string) : SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_services_vault_hyperv_site#timeouts-1">SiteRecoveryServicesVaultHypervSite#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId>, value: azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSiteTimeouts) : SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryServicesVaultHypervSiteState<'Name, 'RecoveryVaultId>

        member _.Run(state: SiteRecoveryServicesVaultHypervSiteState<Present, Present>) : azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSite =
            let config = azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSiteConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryServicesVaultHypervSite: missing required arguments. Must call: name, recovery_vault_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryServicesVaultHypervSiteState<_, _>) : azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSite =
            Unchecked.defaultof<azurerm.SiteRecoveryServicesVaultHypervSite.SiteRecoveryServicesVaultHypervSite>
