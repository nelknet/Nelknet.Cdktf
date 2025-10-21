namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId> = { assignments: ResizeArray<aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association">aws_servicecatalog_product_portfolio_association</a>.
    /// </summary>
    type ServicecatalogProductPortfolioAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogProductPortfolioAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProductPortfolioAssociationState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogProductPortfolioAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProductPortfolioAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association#portfolio_id-1">ServicecatalogProductPortfolioAssociation#portfolio_id</a>.
        /// </summary>
        [<CustomOperation "portfolio_id">]
        member _.PortfolioId(state: ServicecatalogProductPortfolioAssociationState<Missing, 'ProductId>, value: string) : ServicecatalogProductPortfolioAssociationState<Present, 'ProductId> =
            state.assignments.Add(fun config -> config.PortfolioId <- value)
            ({ assignments = state.assignments } : ServicecatalogProductPortfolioAssociationState<Present, 'ProductId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association#product_id-1">ServicecatalogProductPortfolioAssociation#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ServicecatalogProductPortfolioAssociationState<'PortfolioId, Missing>, value: string) : ServicecatalogProductPortfolioAssociationState<'PortfolioId, Present> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ServicecatalogProductPortfolioAssociationState<'PortfolioId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association#accept_language-1">ServicecatalogProductPortfolioAssociation#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>, value: string) : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association#id-1">ServicecatalogProductPortfolioAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>, value: string) : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association#source_portfolio_id-1">ServicecatalogProductPortfolioAssociation#source_portfolio_id</a>.
        /// </summary>
        [<CustomOperation "source_portfolio_id">]
        member _.SourcePortfolioId(state: ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>, value: string) : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId> =
            state.assignments.Add(fun config -> config.SourcePortfolioId <- value)
            state : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product_portfolio_association#timeouts-1">ServicecatalogProductPortfolioAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>, value: aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociationTimeouts) : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogProductPortfolioAssociationState<'PortfolioId, 'ProductId>

        member _.Run(state: ServicecatalogProductPortfolioAssociationState<Present, Present>) : aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociation =
            let config = aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogProductPortfolioAssociation: missing required arguments. Must call: portfolio_id, product_id.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogProductPortfolioAssociationState<_, _>) : aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociation =
            Unchecked.defaultof<aws.ServicecatalogProductPortfolioAssociation.ServicecatalogProductPortfolioAssociation>
