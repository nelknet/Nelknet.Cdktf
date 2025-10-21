namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName> = { assignments: ResizeArray<aws.CodecatalystSourceRepository.CodecatalystSourceRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository">aws_codecatalyst_source_repository</a>.
    /// </summary>
    type CodecatalystSourceRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodecatalystSourceRepositoryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecatalystSourceRepositoryState<Missing, Missing, Missing>)

        member _.Zero(()) : CodecatalystSourceRepositoryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodecatalystSourceRepositoryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository#name-1">CodecatalystSourceRepository#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodecatalystSourceRepositoryState<Missing, 'ProjectName, 'SpaceName>, value: string) : CodecatalystSourceRepositoryState<Present, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodecatalystSourceRepositoryState<Present, 'ProjectName, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository#project_name-1">CodecatalystSourceRepository#project_name</a>.
        /// </summary>
        [<CustomOperation "project_name">]
        member _.ProjectName(state: CodecatalystSourceRepositoryState<'Name, Missing, 'SpaceName>, value: string) : CodecatalystSourceRepositoryState<'Name, Present, 'SpaceName> =
            state.assignments.Add(fun config -> config.ProjectName <- value)
            ({ assignments = state.assignments } : CodecatalystSourceRepositoryState<'Name, Present, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository#space_name-1">CodecatalystSourceRepository#space_name</a>.
        /// </summary>
        [<CustomOperation "space_name">]
        member _.SpaceName(state: CodecatalystSourceRepositoryState<'Name, 'ProjectName, Missing>, value: string) : CodecatalystSourceRepositoryState<'Name, 'ProjectName, Present> =
            state.assignments.Add(fun config -> config.SpaceName <- value)
            ({ assignments = state.assignments } : CodecatalystSourceRepositoryState<'Name, 'ProjectName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository#description-1">CodecatalystSourceRepository#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName>, value: string) : CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository#id-1">CodecatalystSourceRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName>, value: string) : CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_source_repository#timeouts-1">CodecatalystSourceRepository#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName>, value: aws.CodecatalystSourceRepository.CodecatalystSourceRepositoryTimeouts) : CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodecatalystSourceRepositoryState<'Name, 'ProjectName, 'SpaceName>

        member _.Run(state: CodecatalystSourceRepositoryState<Present, Present, Present>) : aws.CodecatalystSourceRepository.CodecatalystSourceRepository =
            let config = aws.CodecatalystSourceRepository.CodecatalystSourceRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.CodecatalystSourceRepository.CodecatalystSourceRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codecatalystSourceRepository: missing required arguments. Must call: name, project_name, space_name.", 9999, IsError = true)>]
        member _.Run(_: CodecatalystSourceRepositoryState<_, _, _>) : aws.CodecatalystSourceRepository.CodecatalystSourceRepository =
            Unchecked.defaultof<aws.CodecatalystSourceRepository.CodecatalystSourceRepository>
