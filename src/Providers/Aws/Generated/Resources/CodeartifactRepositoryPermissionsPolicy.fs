namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository> = { assignments: ResizeArray<aws.CodeartifactRepositoryPermissionsPolicy.CodeartifactRepositoryPermissionsPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy">aws_codeartifact_repository_permissions_policy</a>.
    /// </summary>
    type CodeartifactRepositoryPermissionsPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeartifactRepositoryPermissionsPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeartifactRepositoryPermissionsPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : CodeartifactRepositoryPermissionsPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeartifactRepositoryPermissionsPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy#domain-1">CodeartifactRepositoryPermissionsPolicy#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: CodeartifactRepositoryPermissionsPolicyState<Missing, 'PolicyDocument, 'Repository>, value: string) : CodeartifactRepositoryPermissionsPolicyState<Present, 'PolicyDocument, 'Repository> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : CodeartifactRepositoryPermissionsPolicyState<Present, 'PolicyDocument, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy#policy_document-1">CodeartifactRepositoryPermissionsPolicy#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: CodeartifactRepositoryPermissionsPolicyState<'Domain, Missing, 'Repository>, value: string) : CodeartifactRepositoryPermissionsPolicyState<'Domain, Present, 'Repository> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : CodeartifactRepositoryPermissionsPolicyState<'Domain, Present, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy#repository-1">CodeartifactRepositoryPermissionsPolicy#repository</a>.
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, Missing>, value: string) : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, Present> =
            state.assignments.Add(fun config -> config.Repository <- value)
            ({ assignments = state.assignments } : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy#domain_owner-1">CodeartifactRepositoryPermissionsPolicy#domain_owner</a>.
        /// </summary>
        [<CustomOperation "domain_owner">]
        member _.DomainOwner(state: CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository>, value: string) : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository> =
            state.assignments.Add(fun config -> config.DomainOwner <- value)
            state : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy#id-1">CodeartifactRepositoryPermissionsPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository>, value: string) : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository_permissions_policy#policy_revision-1">CodeartifactRepositoryPermissionsPolicy#policy_revision</a>.
        /// </summary>
        [<CustomOperation "policy_revision">]
        member _.PolicyRevision(state: CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository>, value: string) : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository> =
            state.assignments.Add(fun config -> config.PolicyRevision <- value)
            state : CodeartifactRepositoryPermissionsPolicyState<'Domain, 'PolicyDocument, 'Repository>

        member _.Run(state: CodeartifactRepositoryPermissionsPolicyState<Present, Present, Present>) : aws.CodeartifactRepositoryPermissionsPolicy.CodeartifactRepositoryPermissionsPolicy =
            let config = aws.CodeartifactRepositoryPermissionsPolicy.CodeartifactRepositoryPermissionsPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CodeartifactRepositoryPermissionsPolicy.CodeartifactRepositoryPermissionsPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeartifactRepositoryPermissionsPolicy: missing required arguments. Must call: domain, policy_document, repository.", 9999, IsError = true)>]
        member _.Run(_: CodeartifactRepositoryPermissionsPolicyState<_, _, _>) : aws.CodeartifactRepositoryPermissionsPolicy.CodeartifactRepositoryPermissionsPolicy =
            Unchecked.defaultof<aws.CodeartifactRepositoryPermissionsPolicy.CodeartifactRepositoryPermissionsPolicy>
