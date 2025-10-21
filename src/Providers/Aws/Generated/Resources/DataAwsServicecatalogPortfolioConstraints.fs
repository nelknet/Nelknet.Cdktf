namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId> = { assignments: ResizeArray<aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraintsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints">aws_servicecatalog_portfolio_constraints</a>.
    /// </summary>
    type DataAwsServicecatalogPortfolioConstraintsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogPortfolioConstraintsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogPortfolioConstraintsState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogPortfolioConstraintsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogPortfolioConstraintsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints#portfolio_id-1">DataAwsServicecatalogPortfolioConstraints#portfolio_id</a>.
        /// </summary>
        [<CustomOperation "portfolio_id">]
        member _.PortfolioId(state: DataAwsServicecatalogPortfolioConstraintsState<Missing>, value: string) : DataAwsServicecatalogPortfolioConstraintsState<Present> =
            state.assignments.Add(fun config -> config.PortfolioId <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogPortfolioConstraintsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints#accept_language-1">DataAwsServicecatalogPortfolioConstraints#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>, value: string) : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints#id-1">DataAwsServicecatalogPortfolioConstraints#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>, value: string) : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints#product_id-1">DataAwsServicecatalogPortfolioConstraints#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>, value: string) : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            state : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints#timeouts-1">DataAwsServicecatalogPortfolioConstraints#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>, value: aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraintsTimeouts) : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsServicecatalogPortfolioConstraintsState<'PortfolioId>

        member _.Run(state: DataAwsServicecatalogPortfolioConstraintsState<Present>) : aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraints =
            let config = aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraintsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraints(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogPortfolioConstraints: missing required arguments. Must call: portfolio_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogPortfolioConstraintsState<_>) : aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraints =
            Unchecked.defaultof<aws.DataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraints>
