namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName> = { assignments: ResizeArray<aws.DataAwsSagemakerPrebuiltEcrImage.DataAwsSagemakerPrebuiltEcrImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sagemaker_prebuilt_ecr_image">aws_sagemaker_prebuilt_ecr_image</a>.
    /// </summary>
    type DataAwsSagemakerPrebuiltEcrImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSagemakerPrebuiltEcrImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSagemakerPrebuiltEcrImageState<Missing>)

        member _.Zero(()) : DataAwsSagemakerPrebuiltEcrImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSagemakerPrebuiltEcrImageState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sagemaker_prebuilt_ecr_image#repository_name-1">DataAwsSagemakerPrebuiltEcrImage#repository_name</a>.
        /// </summary>
        [<CustomOperation "repository_name">]
        member _.RepositoryName(state: DataAwsSagemakerPrebuiltEcrImageState<Missing>, value: string) : DataAwsSagemakerPrebuiltEcrImageState<Present> =
            state.assignments.Add(fun config -> config.RepositoryName <- value)
            ({ assignments = state.assignments } : DataAwsSagemakerPrebuiltEcrImageState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sagemaker_prebuilt_ecr_image#dns_suffix-1">DataAwsSagemakerPrebuiltEcrImage#dns_suffix</a>.
        /// </summary>
        [<CustomOperation "dns_suffix">]
        member _.DnsSuffix(state: DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>, value: string) : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.DnsSuffix <- value)
            state : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sagemaker_prebuilt_ecr_image#id-1">DataAwsSagemakerPrebuiltEcrImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>, value: string) : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sagemaker_prebuilt_ecr_image#image_tag-1">DataAwsSagemakerPrebuiltEcrImage#image_tag</a>.
        /// </summary>
        [<CustomOperation "image_tag">]
        member _.ImageTag(state: DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>, value: string) : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.ImageTag <- value)
            state : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sagemaker_prebuilt_ecr_image#region-1">DataAwsSagemakerPrebuiltEcrImage#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>, value: string) : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName> =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsSagemakerPrebuiltEcrImageState<'RepositoryName>

        member _.Run(state: DataAwsSagemakerPrebuiltEcrImageState<Present>) : aws.DataAwsSagemakerPrebuiltEcrImage.DataAwsSagemakerPrebuiltEcrImage =
            let config = aws.DataAwsSagemakerPrebuiltEcrImage.DataAwsSagemakerPrebuiltEcrImageConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSagemakerPrebuiltEcrImage.DataAwsSagemakerPrebuiltEcrImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSagemakerPrebuiltEcrImage: missing required arguments. Must call: repository_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSagemakerPrebuiltEcrImageState<_>) : aws.DataAwsSagemakerPrebuiltEcrImage.DataAwsSagemakerPrebuiltEcrImage =
            Unchecked.defaultof<aws.DataAwsSagemakerPrebuiltEcrImage.DataAwsSagemakerPrebuiltEcrImage>
