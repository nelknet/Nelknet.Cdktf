namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerServicecatalogPortfolioStatusState<'Status> = { assignments: ResizeArray<aws.SagemakerServicecatalogPortfolioStatus.SagemakerServicecatalogPortfolioStatusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_servicecatalog_portfolio_status">aws_sagemaker_servicecatalog_portfolio_status</a>.
    /// </summary>
    type SagemakerServicecatalogPortfolioStatusBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerServicecatalogPortfolioStatusState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerServicecatalogPortfolioStatusState<Missing>)

        member _.Zero(()) : SagemakerServicecatalogPortfolioStatusState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerServicecatalogPortfolioStatusState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_servicecatalog_portfolio_status#status-1">SagemakerServicecatalogPortfolioStatus#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: SagemakerServicecatalogPortfolioStatusState<Missing>, value: string) : SagemakerServicecatalogPortfolioStatusState<Present> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : SagemakerServicecatalogPortfolioStatusState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_servicecatalog_portfolio_status#id-1">SagemakerServicecatalogPortfolioStatus#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerServicecatalogPortfolioStatusState<'Status>, value: string) : SagemakerServicecatalogPortfolioStatusState<'Status> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerServicecatalogPortfolioStatusState<'Status>

        member _.Run(state: SagemakerServicecatalogPortfolioStatusState<Present>) : aws.SagemakerServicecatalogPortfolioStatus.SagemakerServicecatalogPortfolioStatus =
            let config = aws.SagemakerServicecatalogPortfolioStatus.SagemakerServicecatalogPortfolioStatusConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerServicecatalogPortfolioStatus.SagemakerServicecatalogPortfolioStatus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerServicecatalogPortfolioStatus: missing required arguments. Must call: status.", 9999, IsError = true)>]
        member _.Run(_: SagemakerServicecatalogPortfolioStatusState<_>) : aws.SagemakerServicecatalogPortfolioStatus.SagemakerServicecatalogPortfolioStatus =
            Unchecked.defaultof<aws.SagemakerServicecatalogPortfolioStatus.SagemakerServicecatalogPortfolioStatus>
