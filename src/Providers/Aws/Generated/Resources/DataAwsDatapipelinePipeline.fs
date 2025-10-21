namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDatapipelinePipelineState<'PipelineId> = { assignments: ResizeArray<aws.DataAwsDatapipelinePipeline.DataAwsDatapipelinePipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline">aws_datapipeline_pipeline</a>.
    /// </summary>
    type DataAwsDatapipelinePipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDatapipelinePipelineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDatapipelinePipelineState<Missing>)

        member _.Zero(()) : DataAwsDatapipelinePipelineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDatapipelinePipelineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline#pipeline_id-1">DataAwsDatapipelinePipeline#pipeline_id</a>.
        /// </summary>
        [<CustomOperation "pipeline_id">]
        member _.PipelineId(state: DataAwsDatapipelinePipelineState<Missing>, value: string) : DataAwsDatapipelinePipelineState<Present> =
            state.assignments.Add(fun config -> config.PipelineId <- value)
            ({ assignments = state.assignments } : DataAwsDatapipelinePipelineState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline#id-1">DataAwsDatapipelinePipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDatapipelinePipelineState<'PipelineId>, value: string) : DataAwsDatapipelinePipelineState<'PipelineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDatapipelinePipelineState<'PipelineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline#tags-1">DataAwsDatapipelinePipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDatapipelinePipelineState<'PipelineId>, value: seq<string * string>) : DataAwsDatapipelinePipelineState<'PipelineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDatapipelinePipelineState<'PipelineId>

        member _.Run(state: DataAwsDatapipelinePipelineState<Present>) : aws.DataAwsDatapipelinePipeline.DataAwsDatapipelinePipeline =
            let config = aws.DataAwsDatapipelinePipeline.DataAwsDatapipelinePipelineConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDatapipelinePipeline.DataAwsDatapipelinePipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDatapipelinePipeline: missing required arguments. Must call: pipeline_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDatapipelinePipelineState<_>) : aws.DataAwsDatapipelinePipeline.DataAwsDatapipelinePipeline =
            Unchecked.defaultof<aws.DataAwsDatapipelinePipeline.DataAwsDatapipelinePipeline>
