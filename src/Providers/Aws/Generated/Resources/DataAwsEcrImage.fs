namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrImageState<'RepositoryName> = { assignments: ResizeArray<aws.DataAwsEcrImage.DataAwsEcrImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image">aws_ecr_image</a>.
    /// </summary>
    type DataAwsEcrImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrImageState<Missing>)

        member _.Zero(()) : DataAwsEcrImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcrImageState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#repository_name-1">DataAwsEcrImage#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: DataAwsEcrImageState<Missing>, value: string) : DataAwsEcrImageState<Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : DataAwsEcrImageState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#id-1">DataAwsEcrImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcrImageState<'RepositoryName>, value: string) : DataAwsEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#image_digest-1">DataAwsEcrImage#image_digest</a>.
        /// </summary>
        [<CustomOperation "image_digest">]
        member _.ImageDigest(state: DataAwsEcrImageState<'RepositoryName>, value: string) : DataAwsEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.ImageDigest <- value)
            state : DataAwsEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#image_tag-1">DataAwsEcrImage#image_tag</a>.
        /// </summary>
        [<CustomOperation "image_tag">]
        member _.ImageTag(state: DataAwsEcrImageState<'RepositoryName>, value: string) : DataAwsEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.ImageTag <- value)
            state : DataAwsEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#most_recent-1">DataAwsEcrImage#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEcrImageState<'RepositoryName>, value: bool) : DataAwsEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#most_recent-1">DataAwsEcrImage#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEcrImageState<'RepositoryName>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_image#registry_id-1">DataAwsEcrImage#registry_id</a>.
        /// </summary>
        [<CustomOperation "registry_id">]
        member _.RegistryId(state: DataAwsEcrImageState<'RepositoryName>, value: string) : DataAwsEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.RegistryId <- value)
            state : DataAwsEcrImageState<'RepositoryName>

        member _.Run(state: DataAwsEcrImageState<Present>) : aws.DataAwsEcrImage.DataAwsEcrImage =
            let config = aws.DataAwsEcrImage.DataAwsEcrImageConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrImage.DataAwsEcrImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcrImage: missing required arguments. Must call: repository_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcrImageState<_>) : aws.DataAwsEcrImage.DataAwsEcrImage =
            Unchecked.defaultof<aws.DataAwsEcrImage.DataAwsEcrImage>
