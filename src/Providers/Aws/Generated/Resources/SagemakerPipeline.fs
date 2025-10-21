namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> = { assignments: ResizeArray<aws.SagemakerPipeline.SagemakerPipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline">aws_sagemaker_pipeline</a>.
    /// </summary>
    type SagemakerPipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerPipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerPipelineState<Missing, Missing>)

        member _.Zero(()) : SagemakerPipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerPipelineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#pipeline_display_name-1">SagemakerPipeline#pipeline_display_name</a>.
        /// </summary>
        [<CustomOperation "pipeline_display_name">]
        member _.PipelineDisplayName(state: SagemakerPipelineState<Missing, 'PipelineName>, value: string) : SagemakerPipelineState<Present, 'PipelineName> =
            state.assignments.Add(fun config -> config.PipelineDisplayName <- value)
            ({ assignments = state.assignments } : SagemakerPipelineState<Present, 'PipelineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#pipeline_name-1">SagemakerPipeline#pipeline_name</a>.
        /// </summary>
        [<CustomOperation "pipeline_name">]
        member _.PipelineName(state: SagemakerPipelineState<'PipelineDisplayName, Missing>, value: string) : SagemakerPipelineState<'PipelineDisplayName, Present> =
            state.assignments.Add(fun config -> config.PipelineName <- value)
            ({ assignments = state.assignments } : SagemakerPipelineState<'PipelineDisplayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#id-1">SagemakerPipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: string) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// parallelism_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#parallelism_configuration-1">SagemakerPipeline#parallelism_configuration</a>
        /// </summary>
        [<CustomOperation "parallelism_configuration">]
        member _.ParallelismConfiguration(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: aws.SagemakerPipeline.SagemakerPipelineParallelismConfiguration) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.ParallelismConfiguration <- value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#pipeline_definition-1">SagemakerPipeline#pipeline_definition</a>.
        /// </summary>
        [<CustomOperation "pipeline_definition">]
        member _.PipelineDefinition(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: string) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.PipelineDefinition <- value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// pipeline_definition_s3_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#pipeline_definition_s3_location-1">SagemakerPipeline#pipeline_definition_s3_location</a>
        /// </summary>
        [<CustomOperation "pipeline_definition_s3_location">]
        member _.PipelineDefinitionS3Location(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: aws.SagemakerPipeline.SagemakerPipelinePipelineDefinitionS3Location) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.PipelineDefinitionS3Location <- value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#pipeline_description-1">SagemakerPipeline#pipeline_description</a>.
        /// </summary>
        [<CustomOperation "pipeline_description">]
        member _.PipelineDescription(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: string) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.PipelineDescription <- value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#role_arn-1">SagemakerPipeline#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: string) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#tags-1">SagemakerPipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: seq<string * string>) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#tags_all-1">SagemakerPipeline#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>, value: seq<string * string>) : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerPipelineState<'PipelineDisplayName, 'PipelineName>

        member _.Run(state: SagemakerPipelineState<Present, Present>) : aws.SagemakerPipeline.SagemakerPipeline =
            let config = aws.SagemakerPipeline.SagemakerPipelineConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerPipeline.SagemakerPipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerPipeline: missing required arguments. Must call: pipeline_display_name, pipeline_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerPipelineState<_, _>) : aws.SagemakerPipeline.SagemakerPipeline =
            Unchecked.defaultof<aws.SagemakerPipeline.SagemakerPipeline>
