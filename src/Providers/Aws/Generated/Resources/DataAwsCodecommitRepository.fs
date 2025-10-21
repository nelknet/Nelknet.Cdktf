namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodecommitRepositoryState<'RepositoryName> = { assignments: ResizeArray<aws.DataAwsCodecommitRepository.DataAwsCodecommitRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecommit_repository">aws_codecommit_repository</a>.
    /// </summary>
    type DataAwsCodecommitRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodecommitRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodecommitRepositoryState<Missing>)

        member _.Zero(()) : DataAwsCodecommitRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodecommitRepositoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecommit_repository#repository_name-1">DataAwsCodecommitRepository#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: DataAwsCodecommitRepositoryState<Missing>, value: string) : DataAwsCodecommitRepositoryState<Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : DataAwsCodecommitRepositoryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecommit_repository#id-1">DataAwsCodecommitRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCodecommitRepositoryState<'RepositoryName>, value: string) : DataAwsCodecommitRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCodecommitRepositoryState<'RepositoryName>

        member _.Run(state: DataAwsCodecommitRepositoryState<Present>) : aws.DataAwsCodecommitRepository.DataAwsCodecommitRepository =
            let config = aws.DataAwsCodecommitRepository.DataAwsCodecommitRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodecommitRepository.DataAwsCodecommitRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodecommitRepository: missing required arguments. Must call: repository_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodecommitRepositoryState<_>) : aws.DataAwsCodecommitRepository.DataAwsCodecommitRepository =
            Unchecked.defaultof<aws.DataAwsCodecommitRepository.DataAwsCodecommitRepository>
