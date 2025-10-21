namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrRepositoryState<'Name> = { assignments: ResizeArray<aws.DataAwsEcrRepository.DataAwsEcrRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository">aws_ecr_repository</a>.
    /// </summary>
    type DataAwsEcrRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrRepositoryState<Missing>)

        member _.Zero(()) : DataAwsEcrRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrRepositoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository#name-1">DataAwsEcrRepository#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsEcrRepositoryState<Missing>, value: string) : DataAwsEcrRepositoryState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsEcrRepositoryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository#id-1">DataAwsEcrRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcrRepositoryState<'Name>, value: string) : DataAwsEcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository#registry_id-1">DataAwsEcrRepository#registry_id</a>.
        /// </summary>
        [<CustomOperation "registry_id">]
        member _.RegistryId(state: DataAwsEcrRepositoryState<'Name>, value: string) : DataAwsEcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.RegistryId <- value)
            state : DataAwsEcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repository#tags-1">DataAwsEcrRepository#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEcrRepositoryState<'Name>, value: seq<string * string>) : DataAwsEcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEcrRepositoryState<'Name>

        member _.Run(state: DataAwsEcrRepositoryState<Present>) : aws.DataAwsEcrRepository.DataAwsEcrRepository =
            let config = aws.DataAwsEcrRepository.DataAwsEcrRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrRepository.DataAwsEcrRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcrRepository: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcrRepositoryState<_>) : aws.DataAwsEcrRepository.DataAwsEcrRepository =
            Unchecked.defaultof<aws.DataAwsEcrRepository.DataAwsEcrRepository>
