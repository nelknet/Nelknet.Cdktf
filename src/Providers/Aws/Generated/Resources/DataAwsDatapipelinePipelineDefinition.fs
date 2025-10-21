namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDatapipelinePipelineDefinitionState<'PipelineId> = { assignments: ResizeArray<aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline_definition">aws_datapipeline_pipeline_definition</a>.
    /// </summary>
    type DataAwsDatapipelinePipelineDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDatapipelinePipelineDefinitionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDatapipelinePipelineDefinitionState<Missing>)

        member _.Zero(()) : DataAwsDatapipelinePipelineDefinitionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDatapipelinePipelineDefinitionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline_definition#pipeline_id-1">DataAwsDatapipelinePipelineDefinition#pipeline_id</a>.
        /// </summary>
        [<CustomOperation "pipeline_id">]
        member _.PipelineId(state: DataAwsDatapipelinePipelineDefinitionState<Missing>, value: string) : DataAwsDatapipelinePipelineDefinitionState<Present> =
            state.assignments.Add(fun config -> config.PipelineId <- value)
            ({ assignments = state.assignments } : DataAwsDatapipelinePipelineDefinitionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline_definition#id-1">DataAwsDatapipelinePipelineDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDatapipelinePipelineDefinitionState<'PipelineId>, value: string) : DataAwsDatapipelinePipelineDefinitionState<'PipelineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDatapipelinePipelineDefinitionState<'PipelineId>

        /// <summary>
        /// parameter_value block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datapipeline_pipeline_definition#parameter_value-1">DataAwsDatapipelinePipelineDefinition#parameter_value</a> Accepts: aws.IResolvable | aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinitionParameterValue[]
        /// </summary>
        [<CustomOperation "parameter_value">]
        member _.ParameterValue(state: DataAwsDatapipelinePipelineDefinitionState<'PipelineId>, value: HashiCorp.Cdktf.IResolvable) : DataAwsDatapipelinePipelineDefinitionState<'PipelineId> =
            state.assignments.Add(fun config -> config.ParameterValue <- value)
            state : DataAwsDatapipelinePipelineDefinitionState<'PipelineId>

        member _.Run(state: DataAwsDatapipelinePipelineDefinitionState<Present>) : aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinition =
            let config = aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDatapipelinePipelineDefinition: missing required arguments. Must call: pipeline_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDatapipelinePipelineDefinitionState<_>) : aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinition =
            Unchecked.defaultof<aws.DataAwsDatapipelinePipelineDefinition.DataAwsDatapipelinePipelineDefinition>
