namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument> = { assignments: ResizeArray<aws.CodeartifactDomainPermissionsPolicy.CodeartifactDomainPermissionsPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain_permissions_policy">aws_codeartifact_domain_permissions_policy</a>.
    /// </summary>
    type CodeartifactDomainPermissionsPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeartifactDomainPermissionsPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeartifactDomainPermissionsPolicyState<Missing, Missing>)

        member _.Zero(()) : CodeartifactDomainPermissionsPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeartifactDomainPermissionsPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain_permissions_policy#domain-1">CodeartifactDomainPermissionsPolicy#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: CodeartifactDomainPermissionsPolicyState<Missing, 'PolicyDocument>, value: string) : CodeartifactDomainPermissionsPolicyState<Present, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : CodeartifactDomainPermissionsPolicyState<Present, 'PolicyDocument>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain_permissions_policy#policy_document-1">CodeartifactDomainPermissionsPolicy#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: CodeartifactDomainPermissionsPolicyState<'Domain, Missing>, value: string) : CodeartifactDomainPermissionsPolicyState<'Domain, Present> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : CodeartifactDomainPermissionsPolicyState<'Domain, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain_permissions_policy#domain_owner-1">CodeartifactDomainPermissionsPolicy#domain_owner</a>.
        /// </summary>
        [<CustomOperation "domain_owner">]
        member _.DomainOwner(state: CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument>, value: string) : CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.DomainOwner <- value)
            state : CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain_permissions_policy#id-1">CodeartifactDomainPermissionsPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument>, value: string) : CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_domain_permissions_policy#policy_revision-1">CodeartifactDomainPermissionsPolicy#policy_revision</a>.
        /// </summary>
        [<CustomOperation "policy_revision">]
        member _.PolicyRevision(state: CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument>, value: string) : CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.PolicyRevision <- value)
            state : CodeartifactDomainPermissionsPolicyState<'Domain, 'PolicyDocument>

        member _.Run(state: CodeartifactDomainPermissionsPolicyState<Present, Present>) : aws.CodeartifactDomainPermissionsPolicy.CodeartifactDomainPermissionsPolicy =
            let config = aws.CodeartifactDomainPermissionsPolicy.CodeartifactDomainPermissionsPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CodeartifactDomainPermissionsPolicy.CodeartifactDomainPermissionsPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeartifactDomainPermissionsPolicy: missing required arguments. Must call: domain, policy_document.", 9999, IsError = true)>]
        member _.Run(_: CodeartifactDomainPermissionsPolicyState<_, _>) : aws.CodeartifactDomainPermissionsPolicy.CodeartifactDomainPermissionsPolicy =
            Unchecked.defaultof<aws.CodeartifactDomainPermissionsPolicy.CodeartifactDomainPermissionsPolicy>
