namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderImageState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderImage.DataAwsImagebuilderImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image">aws_imagebuilder_image</a>.
    /// </summary>
    type DataAwsImagebuilderImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderImageState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderImageState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image#arn-1">DataAwsImagebuilderImage#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderImageState<Missing>, value: string) : DataAwsImagebuilderImageState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderImageState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image#id-1">DataAwsImagebuilderImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderImageState<'Arn>, value: string) : DataAwsImagebuilderImageState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderImageState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image#tags-1">DataAwsImagebuilderImage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderImageState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderImageState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderImageState<'Arn>

        member _.Run(state: DataAwsImagebuilderImageState<Present>) : aws.DataAwsImagebuilderImage.DataAwsImagebuilderImage =
            let config = aws.DataAwsImagebuilderImage.DataAwsImagebuilderImageConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderImage.DataAwsImagebuilderImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderImage: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderImageState<_>) : aws.DataAwsImagebuilderImage.DataAwsImagebuilderImage =
            Unchecked.defaultof<aws.DataAwsImagebuilderImage.DataAwsImagebuilderImage>
