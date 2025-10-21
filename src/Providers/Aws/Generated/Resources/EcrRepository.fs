namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrRepositoryState<'Name> = { assignments: ResizeArray<aws.EcrRepository.EcrRepositoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository">aws_ecr_repository</a>.
    /// </summary>
    type EcrRepositoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : EcrRepositoryState<Missing>)

        member _.Zero(()) : EcrRepositoryState<Missing> =
            ({ assignments = ResizeArray() } : EcrRepositoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#name-1">EcrRepository#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EcrRepositoryState<Missing>, value: string) : EcrRepositoryState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EcrRepositoryState<Present>)

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#encryption_configuration-1">EcrRepository#encryption_configuration</a> Accepts: aws.IResolvable | aws.EcrRepository.EcrRepositoryEncryptionConfiguration[]
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: EcrRepositoryState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#force_delete-1">EcrRepository#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: EcrRepositoryState<'Name>, value: bool) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#force_delete-1">EcrRepository#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: EcrRepositoryState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#id-1">EcrRepository#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrRepositoryState<'Name>, value: string) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// image_scanning_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#image_scanning_configuration-1">EcrRepository#image_scanning_configuration</a>
        /// </summary>
        [<CustomOperation "image_scanning_configuration">]
        member _.ImageScanningConfiguration(state: EcrRepositoryState<'Name>, value: aws.EcrRepository.EcrRepositoryImageScanningConfiguration) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.ImageScanningConfiguration <- value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#image_tag_mutability-1">EcrRepository#image_tag_mutability</a>.
        /// </summary>
        [<CustomOperation "image_tag_mutability">]
        member _.ImageTagMutability(state: EcrRepositoryState<'Name>, value: string) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.ImageTagMutability <- value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#tags-1">EcrRepository#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcrRepositoryState<'Name>, value: seq<string * string>) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#tags_all-1">EcrRepository#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcrRepositoryState<'Name>, value: seq<string * string>) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcrRepositoryState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#timeouts-1">EcrRepository#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EcrRepositoryState<'Name>, value: aws.EcrRepository.EcrRepositoryTimeouts) : EcrRepositoryState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EcrRepositoryState<'Name>

        member _.Run(state: EcrRepositoryState<Present>) : aws.EcrRepository.EcrRepository =
            let config = aws.EcrRepository.EcrRepositoryConfig()
            for setter in state.assignments do
                setter config
            aws.EcrRepository.EcrRepository(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrRepository: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: EcrRepositoryState<_>) : aws.EcrRepository.EcrRepository =
            Unchecked.defaultof<aws.EcrRepository.EcrRepository>
