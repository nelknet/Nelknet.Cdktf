namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type> = { assignments: ResizeArray<aws.ServicecatalogConstraint.ServicecatalogConstraintConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint">aws_servicecatalog_constraint</a>.
    /// </summary>
    type ServicecatalogConstraintBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogConstraintState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogConstraintState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServicecatalogConstraintState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogConstraintState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#parameters-1">ServicecatalogConstraint#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ServicecatalogConstraintState<Missing, 'PortfolioId, 'ProductId, 'Type>, value: string) : ServicecatalogConstraintState<Present, 'PortfolioId, 'ProductId, 'Type> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            ({ assignments = state.assignments } : ServicecatalogConstraintState<Present, 'PortfolioId, 'ProductId, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#portfolio_id-1">ServicecatalogConstraint#portfolio_id</a>.
        /// </summary>
        [<CustomOperation "portfolio_id">]
        member _.PortfolioId(state: ServicecatalogConstraintState<'Parameters, Missing, 'ProductId, 'Type>, value: string) : ServicecatalogConstraintState<'Parameters, Present, 'ProductId, 'Type> =
            state.assignments.Add(fun config -> config.PortfolioId <- value)
            ({ assignments = state.assignments } : ServicecatalogConstraintState<'Parameters, Present, 'ProductId, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#product_id-1">ServicecatalogConstraint#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ServicecatalogConstraintState<'Parameters, 'PortfolioId, Missing, 'Type>, value: string) : ServicecatalogConstraintState<'Parameters, 'PortfolioId, Present, 'Type> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ServicecatalogConstraintState<'Parameters, 'PortfolioId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#type-1">ServicecatalogConstraint#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, Missing>, value: string) : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#accept_language-1">ServicecatalogConstraint#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>, value: string) : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#description-1">ServicecatalogConstraint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>, value: string) : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#id-1">ServicecatalogConstraint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>, value: string) : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_constraint#timeouts-1">ServicecatalogConstraint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>, value: aws.ServicecatalogConstraint.ServicecatalogConstraintTimeouts) : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogConstraintState<'Parameters, 'PortfolioId, 'ProductId, 'Type>

        member _.Run(state: ServicecatalogConstraintState<Present, Present, Present, Present>) : aws.ServicecatalogConstraint.ServicecatalogConstraint =
            let config = aws.ServicecatalogConstraint.ServicecatalogConstraintConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogConstraint.ServicecatalogConstraint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogConstraint: missing required arguments. Must call: parameters, portfolio_id, product_id, type.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogConstraintState<_, _, _, _>) : aws.ServicecatalogConstraint.ServicecatalogConstraint =
            Unchecked.defaultof<aws.ServicecatalogConstraint.ServicecatalogConstraint>
