namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWorkspacesImageState<'ImageId> = { assignments: ResizeArray<aws.DataAwsWorkspacesImage.DataAwsWorkspacesImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_image">aws_workspaces_image</a>.
    /// </summary>
    type DataAwsWorkspacesImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWorkspacesImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWorkspacesImageState<Missing>)

        member _.Zero(()) : DataAwsWorkspacesImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWorkspacesImageState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_image#image_id-1">DataAwsWorkspacesImage#image_id</a>.
        /// </summary>
        [<CustomOperation "image_id">]
        member _.ImageId(state: DataAwsWorkspacesImageState<Missing>, value: string) : DataAwsWorkspacesImageState<Present> =
            state.assignments.Add(fun config -> config.ImageId <- value)
            ({ assignments = state.assignments } : DataAwsWorkspacesImageState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_image#id-1">DataAwsWorkspacesImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWorkspacesImageState<'ImageId>, value: string) : DataAwsWorkspacesImageState<'ImageId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWorkspacesImageState<'ImageId>

        member _.Run(state: DataAwsWorkspacesImageState<Present>) : aws.DataAwsWorkspacesImage.DataAwsWorkspacesImage =
            let config = aws.DataAwsWorkspacesImage.DataAwsWorkspacesImageConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWorkspacesImage.DataAwsWorkspacesImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWorkspacesImage: missing required arguments. Must call: image_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWorkspacesImageState<_>) : aws.DataAwsWorkspacesImage.DataAwsWorkspacesImage =
            Unchecked.defaultof<aws.DataAwsWorkspacesImage.DataAwsWorkspacesImage>
