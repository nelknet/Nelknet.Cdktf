namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecommitRepositoryState<'RepositoryName> = { assignments: ResizeArray<aws.CodecommitRepository.CodecommitRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository">aws_codecommit_repository</a>.
    /// </summary>
    type CodecommitRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecommitRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : CodecommitRepositoryState<Missing>)

        member _.Zero(()) : CodecommitRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : CodecommitRepositoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#repository_name-1">CodecommitRepository#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: CodecommitRepositoryState<Missing>, value: string) : CodecommitRepositoryState<Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : CodecommitRepositoryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#default_branch-1">CodecommitRepository#default_branch</a>.
        /// </summary>
        [<CustomOperation "default_branch">]
        member _.DefaultBranch(state: CodecommitRepositoryState<'RepositoryName>, value: string) : CodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.DefaultBranch <- value)
            state : CodecommitRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#description-1">CodecommitRepository#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CodecommitRepositoryState<'RepositoryName>, value: string) : CodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CodecommitRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#id-1">CodecommitRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecommitRepositoryState<'RepositoryName>, value: string) : CodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecommitRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#kms_key_id-1">CodecommitRepository#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: CodecommitRepositoryState<'RepositoryName>, value: string) : CodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : CodecommitRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#tags-1">CodecommitRepository#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodecommitRepositoryState<'RepositoryName>, value: seq<string * string>) : CodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodecommitRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecommit_repository#tags_all-1">CodecommitRepository#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodecommitRepositoryState<'RepositoryName>, value: seq<string * string>) : CodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodecommitRepositoryState<'RepositoryName>

        member _.Run(state: CodecommitRepositoryState<Present>) : aws.CodecommitRepository.CodecommitRepository =
            let config = aws.CodecommitRepository.CodecommitRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.CodecommitRepository.CodecommitRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecommitRepository: missing required arguments. Must call: repository_name.", 9999, IsError = true)>]
        member _.Run(_: CodecommitRepositoryState<_>) : aws.CodecommitRepository.CodecommitRepository =
            Unchecked.defaultof<aws.CodecommitRepository.CodecommitRepository>
