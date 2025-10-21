namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatapipelinePipelineState<'Name> = { assignments: ResizeArray<aws.DatapipelinePipeline.DatapipelinePipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline">aws_datapipeline_pipeline</a>.
    /// </summary>
    type DatapipelinePipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatapipelinePipelineState<Missing> =
            ({ assignments = ResizeArray() } : DatapipelinePipelineState<Missing>)

        member _.Zero(()) : DatapipelinePipelineState<Missing> =
            ({ assignments = ResizeArray() } : DatapipelinePipelineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline#name-1">DatapipelinePipeline#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatapipelinePipelineState<Missing>, value: string) : DatapipelinePipelineState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatapipelinePipelineState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline#description-1">DatapipelinePipeline#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatapipelinePipelineState<'Name>, value: string) : DatapipelinePipelineState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatapipelinePipelineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline#id-1">DatapipelinePipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatapipelinePipelineState<'Name>, value: string) : DatapipelinePipelineState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatapipelinePipelineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline#tags-1">DatapipelinePipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatapipelinePipelineState<'Name>, value: seq<string * string>) : DatapipelinePipelineState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatapipelinePipelineState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline#tags_all-1">DatapipelinePipeline#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatapipelinePipelineState<'Name>, value: seq<string * string>) : DatapipelinePipelineState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatapipelinePipelineState<'Name>

        member _.Run(state: DatapipelinePipelineState<Present>) : aws.DatapipelinePipeline.DatapipelinePipeline =
            let config = aws.DatapipelinePipeline.DatapipelinePipelineConfig()
            for setter in state.assignments do
                setter config
            aws.DatapipelinePipeline.DatapipelinePipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datapipelinePipeline: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DatapipelinePipelineState<_>) : aws.DatapipelinePipeline.DatapipelinePipeline =
            Unchecked.defaultof<aws.DatapipelinePipeline.DatapipelinePipeline>
