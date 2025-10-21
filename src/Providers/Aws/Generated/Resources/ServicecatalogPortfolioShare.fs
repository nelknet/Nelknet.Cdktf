namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> = { assignments: ResizeArray<aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share">aws_servicecatalog_portfolio_share</a>.
    /// </summary>
    type ServicecatalogPortfolioShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogPortfolioShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogPortfolioShareState<Missing, Missing, Missing>)

        member _.Zero(()) : ServicecatalogPortfolioShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogPortfolioShareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#portfolio_id-1">ServicecatalogPortfolioShare#portfolio_id</a>.
        /// </summary>
        [<CustomOperation "portfolio_id">]
        member _.PortfolioId(state: ServicecatalogPortfolioShareState<Missing, 'PrincipalId, 'Type>, value: string) : ServicecatalogPortfolioShareState<Present, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.PortfolioId <- value)
            ({ assignments = state.assignments } : ServicecatalogPortfolioShareState<Present, 'PrincipalId, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#principal_id-1">ServicecatalogPortfolioShare#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: ServicecatalogPortfolioShareState<'PortfolioId, Missing, 'Type>, value: string) : ServicecatalogPortfolioShareState<'PortfolioId, Present, 'Type> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : ServicecatalogPortfolioShareState<'PortfolioId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#type-1">ServicecatalogPortfolioShare#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, Missing>, value: string) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#accept_language-1">ServicecatalogPortfolioShare#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: string) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#id-1">ServicecatalogPortfolioShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: string) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#share_principals-1">ServicecatalogPortfolioShare#share_principals</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "share_principals">]
        member _.SharePrincipals(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: bool) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.SharePrincipals <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#share_principals-1">ServicecatalogPortfolioShare#share_principals</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "share_principals">]
        member _.SharePrincipals(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.SharePrincipals <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#share_tag_options-1">ServicecatalogPortfolioShare#share_tag_options</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "share_tag_options">]
        member _.ShareTagOptions(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: bool) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.ShareTagOptions <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#share_tag_options-1">ServicecatalogPortfolioShare#share_tag_options</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "share_tag_options">]
        member _.ShareTagOptions(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.ShareTagOptions <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#timeouts-1">ServicecatalogPortfolioShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShareTimeouts) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#wait_for_acceptance-1">ServicecatalogPortfolioShare#wait_for_acceptance</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_acceptance">]
        member _.WaitForAcceptance(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: bool) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.WaitForAcceptance <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_portfolio_share#wait_for_acceptance-1">ServicecatalogPortfolioShare#wait_for_acceptance</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_acceptance">]
        member _.WaitForAcceptance(state: ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type> =
            state.assignments.Add(fun config -> config.WaitForAcceptance <- value)
            state : ServicecatalogPortfolioShareState<'PortfolioId, 'PrincipalId, 'Type>

        member _.Run(state: ServicecatalogPortfolioShareState<Present, Present, Present>) : aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShare =
            let config = aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShareConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogPortfolioShare: missing required arguments. Must call: portfolio_id, principal_id, type.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogPortfolioShareState<_, _, _>) : aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShare =
            Unchecked.defaultof<aws.ServicecatalogPortfolioShare.ServicecatalogPortfolioShare>
