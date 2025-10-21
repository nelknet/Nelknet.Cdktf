namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogPortfolioState<'Id> = { assignments: ResizeArray<aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolioConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio">aws_servicecatalog_portfolio</a>.
    /// </summary>
    type DataAwsServicecatalogPortfolioBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogPortfolioState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogPortfolioState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogPortfolioState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogPortfolioState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#id-1">DataAwsServicecatalogPortfolio#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogPortfolioState<Missing>, value: string) : DataAwsServicecatalogPortfolioState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogPortfolioState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#accept_language-1">DataAwsServicecatalogPortfolio#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: DataAwsServicecatalogPortfolioState<'Id>, value: string) : DataAwsServicecatalogPortfolioState<'Id> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : DataAwsServicecatalogPortfolioState<'Id>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#tags-1">DataAwsServicecatalogPortfolio#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsServicecatalogPortfolioState<'Id>, value: seq<string * string>) : DataAwsServicecatalogPortfolioState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsServicecatalogPortfolioState<'Id>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#timeouts-1">DataAwsServicecatalogPortfolio#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsServicecatalogPortfolioState<'Id>, value: aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolioTimeouts) : DataAwsServicecatalogPortfolioState<'Id> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsServicecatalogPortfolioState<'Id>

        member _.Run(state: DataAwsServicecatalogPortfolioState<Present>) : aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolio =
            let config = aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolioConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolio(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogPortfolio: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogPortfolioState<_>) : aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolio =
            Unchecked.defaultof<aws.DataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolio>
