namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MarketplaceAgreementState<'Offer, 'Plan, 'Publisher> = { assignments: ResizeArray<azurerm.MarketplaceAgreement.MarketplaceAgreementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_agreement">azurerm_marketplace_agreement</a>.
    /// </summary>
    type MarketplaceAgreementBuilder(logicalId: string) =
        member _.Yield(_: unit) : MarketplaceAgreementState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MarketplaceAgreementState<Missing, Missing, Missing>)

        member _.Zero(()) : MarketplaceAgreementState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MarketplaceAgreementState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_agreement#offer-1">MarketplaceAgreement#offer</a>.
        /// </summary>
        [<CustomOperation "offer">]
        member _.Offer(state: MarketplaceAgreementState<Missing, 'Plan, 'Publisher>, value: string) : MarketplaceAgreementState<Present, 'Plan, 'Publisher> =
            state.assignments.Add(fun config -> config.Offer <- value)
            ({ assignments = state.assignments } : MarketplaceAgreementState<Present, 'Plan, 'Publisher>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_agreement#plan-1">MarketplaceAgreement#plan</a>.
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: MarketplaceAgreementState<'Offer, Missing, 'Publisher>, value: string) : MarketplaceAgreementState<'Offer, Present, 'Publisher> =
            state.assignments.Add(fun config -> config.Plan <- value)
            ({ assignments = state.assignments } : MarketplaceAgreementState<'Offer, Present, 'Publisher>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_agreement#publisher-1">MarketplaceAgreement#publisher</a>.
        /// </summary>
        [<CustomOperation "publisher">]
        member _.Publisher(state: MarketplaceAgreementState<'Offer, 'Plan, Missing>, value: string) : MarketplaceAgreementState<'Offer, 'Plan, Present> =
            state.assignments.Add(fun config -> config.Publisher <- value)
            ({ assignments = state.assignments } : MarketplaceAgreementState<'Offer, 'Plan, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_agreement#id-1">MarketplaceAgreement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MarketplaceAgreementState<'Offer, 'Plan, 'Publisher>, value: string) : MarketplaceAgreementState<'Offer, 'Plan, 'Publisher> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MarketplaceAgreementState<'Offer, 'Plan, 'Publisher>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/marketplace_agreement#timeouts-1">MarketplaceAgreement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MarketplaceAgreementState<'Offer, 'Plan, 'Publisher>, value: azurerm.MarketplaceAgreement.MarketplaceAgreementTimeouts) : MarketplaceAgreementState<'Offer, 'Plan, 'Publisher> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MarketplaceAgreementState<'Offer, 'Plan, 'Publisher>

        member _.Run(state: MarketplaceAgreementState<Present, Present, Present>) : azurerm.MarketplaceAgreement.MarketplaceAgreement =
            let config = azurerm.MarketplaceAgreement.MarketplaceAgreementConfig()
            for setter in state.assignments do
                setter config
            azurerm.MarketplaceAgreement.MarketplaceAgreement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.marketplaceAgreement: missing required arguments. Must call: offer, plan, publisher.", 9999, IsError = true)>]
        member _.Run(_: MarketplaceAgreementState<_, _, _>) : azurerm.MarketplaceAgreement.MarketplaceAgreement =
            Unchecked.defaultof<azurerm.MarketplaceAgreement.MarketplaceAgreement>
