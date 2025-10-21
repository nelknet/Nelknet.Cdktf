namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn> = { assignments: ResizeArray<aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association">aws_servicecatalog_principal_portfolio_association</a>.
    /// </summary>
    type ServicecatalogPrincipalPortfolioAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogPrincipalPortfolioAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogPrincipalPortfolioAssociationState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogPrincipalPortfolioAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogPrincipalPortfolioAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association#portfolio_id-1">ServicecatalogPrincipalPortfolioAssociation#portfolio_id</a>.
        /// </summary>
        [<CustomOperation "portfolio_id">]
        member _.PortfolioId(state: ServicecatalogPrincipalPortfolioAssociationState<Missing, 'PrincipalArn>, value: string) : ServicecatalogPrincipalPortfolioAssociationState<Present, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.PortfolioId <- value)
            ({ assignments = state.assignments } : ServicecatalogPrincipalPortfolioAssociationState<Present, 'PrincipalArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association#principal_arn-1">ServicecatalogPrincipalPortfolioAssociation#principal_arn</a>.
        /// </summary>
        [<CustomOperation "principal_arn">]
        member _.PrincipalArn(state: ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, Missing>, value: string) : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, Present> =
            state.assignments.Add(fun config -> config.PrincipalArn <- value)
            ({ assignments = state.assignments } : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association#accept_language-1">ServicecatalogPrincipalPortfolioAssociation#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>, value: string) : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association#id-1">ServicecatalogPrincipalPortfolioAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>, value: string) : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association#principal_type-1">ServicecatalogPrincipalPortfolioAssociation#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>, value: string) : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            state : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_principal_portfolio_association#timeouts-1">ServicecatalogPrincipalPortfolioAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>, value: aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociationTimeouts) : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogPrincipalPortfolioAssociationState<'PortfolioId, 'PrincipalArn>

        member _.Run(state: ServicecatalogPrincipalPortfolioAssociationState<Present, Present>) : aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociation =
            let config = aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogPrincipalPortfolioAssociation: missing required arguments. Must call: portfolio_id, principal_arn.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogPrincipalPortfolioAssociationState<_, _>) : aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociation =
            Unchecked.defaultof<aws.ServicecatalogPrincipalPortfolioAssociation.ServicecatalogPrincipalPortfolioAssociation>
