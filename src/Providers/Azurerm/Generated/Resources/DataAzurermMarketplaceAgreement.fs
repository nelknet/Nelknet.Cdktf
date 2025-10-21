namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher> = { assignments: ResizeArray<azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement">azurerm_marketplace_agreement</a>.
    /// </summary>
    type DataAzurermMarketplaceAgreementBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMarketplaceAgreementState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMarketplaceAgreementState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermMarketplaceAgreementState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMarketplaceAgreementState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#offer-1">DataAzurermMarketplaceAgreement#offer</a>.
        /// </summary>
        [<CustomOperation "offer">]
        member _.Offer(state: DataAzurermMarketplaceAgreementState<Missing, 'Plan, 'Publisher>, value: string) : DataAzurermMarketplaceAgreementState<Present, 'Plan, 'Publisher> =
            state.assignments.Add(fun config -> config.Offer <- value)
            ({ assignments = state.assignments } : DataAzurermMarketplaceAgreementState<Present, 'Plan, 'Publisher>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#plan-1">DataAzurermMarketplaceAgreement#plan</a>.
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: DataAzurermMarketplaceAgreementState<'Offer, Missing, 'Publisher>, value: string) : DataAzurermMarketplaceAgreementState<'Offer, Present, 'Publisher> =
            state.assignments.Add(fun config -> config.Plan <- value)
            ({ assignments = state.assignments } : DataAzurermMarketplaceAgreementState<'Offer, Present, 'Publisher>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#publisher-1">DataAzurermMarketplaceAgreement#publisher</a>.
        /// </summary>
        [<CustomOperation "publisher">]
        member _.Publisher(state: DataAzurermMarketplaceAgreementState<'Offer, 'Plan, Missing>, value: string) : DataAzurermMarketplaceAgreementState<'Offer, 'Plan, Present> =
            state.assignments.Add(fun config -> config.Publisher <- value)
            ({ assignments = state.assignments } : DataAzurermMarketplaceAgreementState<'Offer, 'Plan, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#id-1">DataAzurermMarketplaceAgreement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher>, value: string) : DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#timeouts-1">DataAzurermMarketplaceAgreement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher>, value: azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreementTimeouts) : DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMarketplaceAgreementState<'Offer, 'Plan, 'Publisher>

        member _.Run(state: DataAzurermMarketplaceAgreementState<Present, Present, Present>) : azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreement =
            let config = azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreementConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMarketplaceAgreement: missing required arguments. Must call: offer, plan, publisher.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMarketplaceAgreementState<_, _, _>) : azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreement =
            Unchecked.defaultof<azurerm.DataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreement>
