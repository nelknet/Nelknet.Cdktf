namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject> = { assignments: ResizeArray<aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition">aws_datapipeline_pipeline_definition</a>.
    /// </summary>
    type DatapipelinePipelineDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatapipelinePipelineDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatapipelinePipelineDefinitionState<Missing, Missing>)

        member _.Zero(()) : DatapipelinePipelineDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatapipelinePipelineDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#pipeline_id-1">DatapipelinePipelineDefinition#pipeline_id</a>.
        /// </summary>
        [<CustomOperation "pipeline_id">]
        member _.PipelineId(state: DatapipelinePipelineDefinitionState<Missing, 'PipelineObject>, value: string) : DatapipelinePipelineDefinitionState<Present, 'PipelineObject> =
            state.assignments.Add(fun config -> config.PipelineId <- value)
            ({ assignments = state.assignments } : DatapipelinePipelineDefinitionState<Present, 'PipelineObject>)

        /// <summary>
        /// pipeline_object block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#pipeline_object-1">DatapipelinePipelineDefinition#pipeline_object</a> Accepts: aws.IResolvable | aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinitionPipelineObject[]
        /// </summary>
        [<CustomOperation "pipeline_object">]
        member _.PipelineObject(state: DatapipelinePipelineDefinitionState<'PipelineId, Missing>, value: HashiCorp.Cdktf.IResolvable) : DatapipelinePipelineDefinitionState<'PipelineId, Present> =
            state.assignments.Add(fun config -> config.PipelineObject <- value)
            ({ assignments = state.assignments } : DatapipelinePipelineDefinitionState<'PipelineId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#id-1">DatapipelinePipelineDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject>, value: string) : DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject>

        /// <summary>
        /// parameter_object block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#parameter_object-1">DatapipelinePipelineDefinition#parameter_object</a> Accepts: aws.IResolvable | aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterObject[]
        /// </summary>
        [<CustomOperation "parameter_object">]
        member _.ParameterObject(state: DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject>, value: HashiCorp.Cdktf.IResolvable) : DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject> =
            state.assignments.Add(fun config -> config.ParameterObject <- value)
            state : DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject>

        /// <summary>
        /// parameter_value block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datapipeline_pipeline_definition#parameter_value-1">DatapipelinePipelineDefinition#parameter_value</a> Accepts: aws.IResolvable | aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinitionParameterValue[]
        /// </summary>
        [<CustomOperation "parameter_value">]
        member _.ParameterValue(state: DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject>, value: HashiCorp.Cdktf.IResolvable) : DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject> =
            state.assignments.Add(fun config -> config.ParameterValue <- value)
            state : DatapipelinePipelineDefinitionState<'PipelineId, 'PipelineObject>

        member _.Run(state: DatapipelinePipelineDefinitionState<Present, Present>) : aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinition =
            let config = aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datapipelinePipelineDefinition: missing required arguments. Must call: pipeline_id, pipeline_object.", 9999, IsError = true)>]
        member _.Run(_: DatapipelinePipelineDefinitionState<_, _>) : aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinition =
            Unchecked.defaultof<aws.DatapipelinePipelineDefinition.DatapipelinePipelineDefinition>
