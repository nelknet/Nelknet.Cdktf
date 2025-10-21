namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerImageState<'ImageName, 'RoleArn> = { assignments: ResizeArray<aws.SagemakerImage.SagemakerImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image">aws_sagemaker_image</a>.
    /// </summary>
    type SagemakerImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerImageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerImageState<Missing, Missing>)

        member _.Zero(()) : SagemakerImageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerImageState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#image_name-1">SagemakerImage#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: SagemakerImageState<Missing, 'RoleArn>, value: string) : SagemakerImageState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            ({ assignments = state.assignments } : SagemakerImageState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#role_arn-1">SagemakerImage#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerImageState<'ImageName, Missing>, value: string) : SagemakerImageState<'ImageName, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerImageState<'ImageName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#description-1">SagemakerImage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SagemakerImageState<'ImageName, 'RoleArn>, value: string) : SagemakerImageState<'ImageName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SagemakerImageState<'ImageName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#display_name-1">SagemakerImage#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SagemakerImageState<'ImageName, 'RoleArn>, value: string) : SagemakerImageState<'ImageName, 'RoleArn> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SagemakerImageState<'ImageName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#id-1">SagemakerImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerImageState<'ImageName, 'RoleArn>, value: string) : SagemakerImageState<'ImageName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerImageState<'ImageName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#tags-1">SagemakerImage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerImageState<'ImageName, 'RoleArn>, value: seq<string * string>) : SagemakerImageState<'ImageName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerImageState<'ImageName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_image#tags_all-1">SagemakerImage#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerImageState<'ImageName, 'RoleArn>, value: seq<string * string>) : SagemakerImageState<'ImageName, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerImageState<'ImageName, 'RoleArn>

        member _.Run(state: SagemakerImageState<Present, Present>) : aws.SagemakerImage.SagemakerImage =
            let config = aws.SagemakerImage.SagemakerImageConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerImage.SagemakerImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerImage: missing required arguments. Must call: image_name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerImageState<_, _>) : aws.SagemakerImage.SagemakerImage =
            Unchecked.defaultof<aws.SagemakerImage.SagemakerImage>
