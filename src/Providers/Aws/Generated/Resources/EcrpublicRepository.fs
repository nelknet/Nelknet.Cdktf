namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrpublicRepositoryState<'RepositoryName> = { assignments: ResizeArray<aws.EcrpublicRepository.EcrpublicRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository">aws_ecrpublic_repository</a>.
    /// </summary>
    type EcrpublicRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrpublicRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : EcrpublicRepositoryState<Missing>)

        member _.Zero(()) : EcrpublicRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : EcrpublicRepositoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#repository_name-1">EcrpublicRepository#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: EcrpublicRepositoryState<Missing>, value: string) : EcrpublicRepositoryState<Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : EcrpublicRepositoryState<Present>)

        /// <summary>
        /// catalog_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#catalog_data-1">EcrpublicRepository#catalog_data</a>
        /// </summary>
        [<CustomOperation "catalog_data">]
        member _.CatalogData(state: EcrpublicRepositoryState<'RepositoryName>, value: aws.EcrpublicRepository.EcrpublicRepositoryCatalogData) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.CatalogData <- value)
            state : EcrpublicRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#force_destroy-1">EcrpublicRepository#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: EcrpublicRepositoryState<'RepositoryName>, value: bool) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : EcrpublicRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#force_destroy-1">EcrpublicRepository#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: EcrpublicRepositoryState<'RepositoryName>, value: HashiCorp.Cdktf.IResolvable) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : EcrpublicRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#id-1">EcrpublicRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrpublicRepositoryState<'RepositoryName>, value: string) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrpublicRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#tags-1">EcrpublicRepository#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcrpublicRepositoryState<'RepositoryName>, value: seq<string * string>) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcrpublicRepositoryState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#tags_all-1">EcrpublicRepository#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcrpublicRepositoryState<'RepositoryName>, value: seq<string * string>) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcrpublicRepositoryState<'RepositoryName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#timeouts-1">EcrpublicRepository#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EcrpublicRepositoryState<'RepositoryName>, value: aws.EcrpublicRepository.EcrpublicRepositoryTimeouts) : EcrpublicRepositoryState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EcrpublicRepositoryState<'RepositoryName>

        member _.Run(state: EcrpublicRepositoryState<Present>) : aws.EcrpublicRepository.EcrpublicRepository =
            let config = aws.EcrpublicRepository.EcrpublicRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.EcrpublicRepository.EcrpublicRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrpublicRepository: missing required arguments. Must call: repository_name.", 9999, IsError = true)>]
        member _.Run(_: EcrpublicRepositoryState<_>) : aws.EcrpublicRepository.EcrpublicRepository =
            Unchecked.defaultof<aws.EcrpublicRepository.EcrpublicRepository>
