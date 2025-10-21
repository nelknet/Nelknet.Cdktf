namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig> = { assignments: ResizeArray<aws.SagemakerCodeRepository.SagemakerCodeRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository">aws_sagemaker_code_repository</a>.
    /// </summary>
    type SagemakerCodeRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerCodeRepositoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerCodeRepositoryState<Missing, Missing>)

        member _.Zero(()) : SagemakerCodeRepositoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerCodeRepositoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#code_repository_name-1">SagemakerCodeRepository#code_repository_name</a>.
        /// </summary>
        [<CustomOperation "code_repository_name">]
        member _.CodeRepositoryName(state: SagemakerCodeRepositoryState<Missing, 'GitConfig>, value: string) : SagemakerCodeRepositoryState<Present, 'GitConfig> =
            state.assignments.Add(fun config -> config.CodeRepositoryName <- value)
            ({ assignments = state.assignments } : SagemakerCodeRepositoryState<Present, 'GitConfig>)

        /// <summary>
        /// git_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#git_config-1">SagemakerCodeRepository#git_config</a>
        /// </summary>
        [<CustomOperation "git_config">]
        member _.GitConfig(state: SagemakerCodeRepositoryState<'CodeRepositoryName, Missing>, value: aws.SagemakerCodeRepository.SagemakerCodeRepositoryGitConfig) : SagemakerCodeRepositoryState<'CodeRepositoryName, Present> =
            state.assignments.Add(fun config -> config.GitConfig <- value)
            ({ assignments = state.assignments } : SagemakerCodeRepositoryState<'CodeRepositoryName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#id-1">SagemakerCodeRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig>, value: string) : SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#tags-1">SagemakerCodeRepository#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig>, value: seq<string * string>) : SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_code_repository#tags_all-1">SagemakerCodeRepository#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig>, value: seq<string * string>) : SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerCodeRepositoryState<'CodeRepositoryName, 'GitConfig>

        member _.Run(state: SagemakerCodeRepositoryState<Present, Present>) : aws.SagemakerCodeRepository.SagemakerCodeRepository =
            let config = aws.SagemakerCodeRepository.SagemakerCodeRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerCodeRepository.SagemakerCodeRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerCodeRepository: missing required arguments. Must call: code_repository_name, git_config.", 9999, IsError = true)>]
        member _.Run(_: SagemakerCodeRepositoryState<_, _>) : aws.SagemakerCodeRepository.SagemakerCodeRepository =
            Unchecked.defaultof<aws.SagemakerCodeRepository.SagemakerCodeRepository>
