namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderImagePipelineState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderImagePipeline.DataAwsImagebuilderImagePipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipeline">aws_imagebuilder_image_pipeline</a>.
    /// </summary>
    type DataAwsImagebuilderImagePipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderImagePipelineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderImagePipelineState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderImagePipelineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderImagePipelineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipeline#arn-1">DataAwsImagebuilderImagePipeline#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderImagePipelineState<Missing>, value: string) : DataAwsImagebuilderImagePipelineState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderImagePipelineState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipeline#id-1">DataAwsImagebuilderImagePipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderImagePipelineState<'Arn>, value: string) : DataAwsImagebuilderImagePipelineState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderImagePipelineState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipeline#tags-1">DataAwsImagebuilderImagePipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderImagePipelineState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderImagePipelineState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderImagePipelineState<'Arn>

        member _.Run(state: DataAwsImagebuilderImagePipelineState<Present>) : aws.DataAwsImagebuilderImagePipeline.DataAwsImagebuilderImagePipeline =
            let config = aws.DataAwsImagebuilderImagePipeline.DataAwsImagebuilderImagePipelineConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderImagePipeline.DataAwsImagebuilderImagePipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderImagePipeline: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderImagePipelineState<_>) : aws.DataAwsImagebuilderImagePipeline.DataAwsImagebuilderImagePipeline =
            Unchecked.defaultof<aws.DataAwsImagebuilderImagePipeline.DataAwsImagebuilderImagePipeline>
