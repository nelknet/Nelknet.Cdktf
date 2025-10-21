namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncDomainNameApiAssociationState<'ApiId, 'DomainName> = { assignments: ResizeArray<aws.AppsyncDomainNameApiAssociation.AppsyncDomainNameApiAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name_api_association">aws_appsync_domain_name_api_association</a>.
    /// </summary>
    type AppsyncDomainNameApiAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncDomainNameApiAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncDomainNameApiAssociationState<Missing, Missing>)

        member _.Zero(()) : AppsyncDomainNameApiAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppsyncDomainNameApiAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name_api_association#api_id-1">AppsyncDomainNameApiAssociation#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncDomainNameApiAssociationState<Missing, 'DomainName>, value: string) : AppsyncDomainNameApiAssociationState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncDomainNameApiAssociationState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name_api_association#domain_name-1">AppsyncDomainNameApiAssociation#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: AppsyncDomainNameApiAssociationState<'ApiId, Missing>, value: string) : AppsyncDomainNameApiAssociationState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : AppsyncDomainNameApiAssociationState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_domain_name_api_association#id-1">AppsyncDomainNameApiAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncDomainNameApiAssociationState<'ApiId, 'DomainName>, value: string) : AppsyncDomainNameApiAssociationState<'ApiId, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncDomainNameApiAssociationState<'ApiId, 'DomainName>

        member _.Run(state: AppsyncDomainNameApiAssociationState<Present, Present>) : aws.AppsyncDomainNameApiAssociation.AppsyncDomainNameApiAssociation =
            let config = aws.AppsyncDomainNameApiAssociation.AppsyncDomainNameApiAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncDomainNameApiAssociation.AppsyncDomainNameApiAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncDomainNameApiAssociation: missing required arguments. Must call: api_id, domain_name.", 9999, IsError = true)>]
        member _.Run(_: AppsyncDomainNameApiAssociationState<_, _>) : aws.AppsyncDomainNameApiAssociation.AppsyncDomainNameApiAssociation =
            Unchecked.defaultof<aws.AppsyncDomainNameApiAssociation.AppsyncDomainNameApiAssociation>
