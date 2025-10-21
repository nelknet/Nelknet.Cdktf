namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogPortfolioState<'Name, 'ProviderName> = { assignments: ResizeArray<aws.ServicecatalogPortfolio.ServicecatalogPortfolioConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio">aws_servicecatalog_portfolio</a>.
    /// </summary>
    type ServicecatalogPortfolioBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogPortfolioState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogPortfolioState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogPortfolioState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogPortfolioState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#name-1">ServicecatalogPortfolio#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogPortfolioState<Missing, 'ProviderName>, value: string) : ServicecatalogPortfolioState<Present, 'ProviderName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicecatalogPortfolioState<Present, 'ProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#provider_name-1">ServicecatalogPortfolio#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: ServicecatalogPortfolioState<'Name, Missing>, value: string) : ServicecatalogPortfolioState<'Name, Present> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            ({ assignments = state.assignments } : ServicecatalogPortfolioState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#description-1">ServicecatalogPortfolio#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogPortfolioState<'Name, 'ProviderName>, value: string) : ServicecatalogPortfolioState<'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogPortfolioState<'Name, 'ProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#id-1">ServicecatalogPortfolio#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogPortfolioState<'Name, 'ProviderName>, value: string) : ServicecatalogPortfolioState<'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogPortfolioState<'Name, 'ProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#tags-1">ServicecatalogPortfolio#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicecatalogPortfolioState<'Name, 'ProviderName>, value: seq<string * string>) : ServicecatalogPortfolioState<'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicecatalogPortfolioState<'Name, 'ProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#tags_all-1">ServicecatalogPortfolio#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServicecatalogPortfolioState<'Name, 'ProviderName>, value: seq<string * string>) : ServicecatalogPortfolioState<'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServicecatalogPortfolioState<'Name, 'ProviderName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio#timeouts-1">ServicecatalogPortfolio#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogPortfolioState<'Name, 'ProviderName>, value: aws.ServicecatalogPortfolio.ServicecatalogPortfolioTimeouts) : ServicecatalogPortfolioState<'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogPortfolioState<'Name, 'ProviderName>

        member _.Run(state: ServicecatalogPortfolioState<Present, Present>) : aws.ServicecatalogPortfolio.ServicecatalogPortfolio =
            let config = aws.ServicecatalogPortfolio.ServicecatalogPortfolioConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogPortfolio.ServicecatalogPortfolio(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogPortfolio: missing required arguments. Must call: name, provider_name.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogPortfolioState<_, _>) : aws.ServicecatalogPortfolio.ServicecatalogPortfolio =
            Unchecked.defaultof<aws.ServicecatalogPortfolio.ServicecatalogPortfolio>
