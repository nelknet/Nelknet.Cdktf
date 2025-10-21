namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderImagePipelinesState = { assignments: ResizeArray<aws.DataAwsImagebuilderImagePipelines.DataAwsImagebuilderImagePipelinesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipelines">aws_imagebuilder_image_pipelines</a>.
    /// </summary>
    type DataAwsImagebuilderImagePipelinesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderImagePipelinesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsImagebuilderImagePipelinesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipelines#filter-1">DataAwsImagebuilderImagePipelines#filter</a> Accepts: aws.IResolvable | aws.DataAwsImagebuilderImagePipelines.DataAwsImagebuilderImagePipelinesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsImagebuilderImagePipelinesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsImagebuilderImagePipelinesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsImagebuilderImagePipelinesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipelines#id-1">DataAwsImagebuilderImagePipelines#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderImagePipelinesState, value: string) : DataAwsImagebuilderImagePipelinesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderImagePipelinesState

        member _.Run(state: DataAwsImagebuilderImagePipelinesState) : aws.DataAwsImagebuilderImagePipelines.DataAwsImagebuilderImagePipelines =
            let config = aws.DataAwsImagebuilderImagePipelines.DataAwsImagebuilderImagePipelinesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderImagePipelines.DataAwsImagebuilderImagePipelines(StackContext.get (), logicalId, config)
