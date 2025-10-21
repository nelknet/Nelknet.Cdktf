namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn> = { assignments: ResizeArray<aws.ApprunnerCustomDomainAssociation.ApprunnerCustomDomainAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_custom_domain_association">aws_apprunner_custom_domain_association</a>.
    /// </summary>
    type ApprunnerCustomDomainAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerCustomDomainAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerCustomDomainAssociationState<Missing, Missing>)

        member _.Zero(()) : ApprunnerCustomDomainAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerCustomDomainAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_custom_domain_association#domain_name-1">ApprunnerCustomDomainAssociation#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ApprunnerCustomDomainAssociationState<Missing, 'ServiceArn>, value: string) : ApprunnerCustomDomainAssociationState<Present, 'ServiceArn> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ApprunnerCustomDomainAssociationState<Present, 'ServiceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_custom_domain_association#service_arn-1">ApprunnerCustomDomainAssociation#service_arn</a>.
        /// </summary>
        [<CustomOperation "service_arn">]
        member _.ServiceArn(state: ApprunnerCustomDomainAssociationState<'DomainName, Missing>, value: string) : ApprunnerCustomDomainAssociationState<'DomainName, Present> =
            state.assignments.Add(fun config -> config.ServiceArn <- value)
            ({ assignments = state.assignments } : ApprunnerCustomDomainAssociationState<'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_custom_domain_association#enable_www_subdomain-1">ApprunnerCustomDomainAssociation#enable_www_subdomain</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_www_subdomain">]
        member _.EnableWwwSubdomain(state: ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn>, value: bool) : ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn> =
            state.assignments.Add(fun config -> config.EnableWwwSubdomain <- value)
            state : ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_custom_domain_association#enable_www_subdomain-1">ApprunnerCustomDomainAssociation#enable_www_subdomain</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_www_subdomain">]
        member _.EnableWwwSubdomain(state: ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn>, value: HashiCorp.Cdktf.IResolvable) : ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn> =
            state.assignments.Add(fun config -> config.EnableWwwSubdomain <- value)
            state : ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_custom_domain_association#id-1">ApprunnerCustomDomainAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn>, value: string) : ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerCustomDomainAssociationState<'DomainName, 'ServiceArn>

        member _.Run(state: ApprunnerCustomDomainAssociationState<Present, Present>) : aws.ApprunnerCustomDomainAssociation.ApprunnerCustomDomainAssociation =
            let config = aws.ApprunnerCustomDomainAssociation.ApprunnerCustomDomainAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerCustomDomainAssociation.ApprunnerCustomDomainAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerCustomDomainAssociation: missing required arguments. Must call: domain_name, service_arn.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerCustomDomainAssociationState<_, _>) : aws.ApprunnerCustomDomainAssociation.ApprunnerCustomDomainAssociation =
            Unchecked.defaultof<aws.ApprunnerCustomDomainAssociation.ApprunnerCustomDomainAssociation>
