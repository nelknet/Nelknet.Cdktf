namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeartifactRepositoryState<'Domain, 'Repository> = { assignments: ResizeArray<aws.CodeartifactRepository.CodeartifactRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository">aws_codeartifact_repository</a>.
    /// </summary>
    type CodeartifactRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeartifactRepositoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeartifactRepositoryState<Missing, Missing>)

        member _.Zero(()) : CodeartifactRepositoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeartifactRepositoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#domain-1">CodeartifactRepository#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: CodeartifactRepositoryState<Missing, 'Repository>, value: string) : CodeartifactRepositoryState<Present, 'Repository> =
            state.assignments.Add(fun config -> config.Domain <- value)
            ({ assignments = state.assignments } : CodeartifactRepositoryState<Present, 'Repository>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#repository-1">CodeartifactRepository#repository</a>.
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: CodeartifactRepositoryState<'Domain, Missing>, value: string) : CodeartifactRepositoryState<'Domain, Present> =
            state.assignments.Add(fun config -> config.Repository <- value)
            ({ assignments = state.assignments } : CodeartifactRepositoryState<'Domain, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#description-1">CodeartifactRepository#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: string) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#domain_owner-1">CodeartifactRepository#domain_owner</a>.
        /// </summary>
        [<CustomOperation "domain_owner">]
        member _.DomainOwner(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: string) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.DomainOwner <- value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        /// <summary>
        /// external_connections block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#external_connections-1">CodeartifactRepository#external_connections</a>
        /// </summary>
        [<CustomOperation "external_connections">]
        member _.ExternalConnections(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: aws.CodeartifactRepository.CodeartifactRepositoryExternalConnections) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.ExternalConnections <- value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#id-1">CodeartifactRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: string) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#tags-1">CodeartifactRepository#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: seq<string * string>) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#tags_all-1">CodeartifactRepository#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: seq<string * string>) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        /// <summary>
        /// upstream block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#upstream-1">CodeartifactRepository#upstream</a> Accepts: aws.IResolvable | aws.CodeartifactRepository.CodeartifactRepositoryUpstream[]
        /// </summary>
        [<CustomOperation "upstream">]
        member _.Upstream(state: CodeartifactRepositoryState<'Domain, 'Repository>, value: HashiCorp.Cdktf.IResolvable) : CodeartifactRepositoryState<'Domain, 'Repository> =
            state.assignments.Add(fun config -> config.Upstream <- value)
            state : CodeartifactRepositoryState<'Domain, 'Repository>

        member _.Run(state: CodeartifactRepositoryState<Present, Present>) : aws.CodeartifactRepository.CodeartifactRepository =
            let config = aws.CodeartifactRepository.CodeartifactRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.CodeartifactRepository.CodeartifactRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeartifactRepository: missing required arguments. Must call: domain, repository.", 9999, IsError = true)>]
        member _.Run(_: CodeartifactRepositoryState<_, _>) : aws.CodeartifactRepository.CodeartifactRepository =
            Unchecked.defaultof<aws.CodeartifactRepository.CodeartifactRepository>
