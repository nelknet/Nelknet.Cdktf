namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> = { assignments: ResizeArray<aws.OsisPipeline.OsisPipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline">aws_osis_pipeline</a>.
    /// </summary>
    type OsisPipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : OsisPipelineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OsisPipelineState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OsisPipelineState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OsisPipelineState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#max_units-1">OsisPipeline#max_units</a>.
        /// </summary>
        [<CustomOperation "max_units">]
        member _.MaxUnits(state: OsisPipelineState<Missing, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: double) : OsisPipelineState<Present, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.MaxUnits <- value)
            ({ assignments = state.assignments } : OsisPipelineState<Present, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#min_units-1">OsisPipeline#min_units</a>.
        /// </summary>
        [<CustomOperation "min_units">]
        member _.MinUnits(state: OsisPipelineState<'MaxUnits, Missing, 'PipelineConfigurationBody, 'PipelineName>, value: double) : OsisPipelineState<'MaxUnits, Present, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.MinUnits <- value)
            ({ assignments = state.assignments } : OsisPipelineState<'MaxUnits, Present, 'PipelineConfigurationBody, 'PipelineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#pipeline_configuration_body-1">OsisPipeline#pipeline_configuration_body</a>.
        /// </summary>
        [<CustomOperation "pipeline_configuration_body">]
        member _.PipelineConfigurationBody(state: OsisPipelineState<'MaxUnits, 'MinUnits, Missing, 'PipelineName>, value: string) : OsisPipelineState<'MaxUnits, 'MinUnits, Present, 'PipelineName> =
            state.assignments.Add(fun config -> config.PipelineConfigurationBody <- value)
            ({ assignments = state.assignments } : OsisPipelineState<'MaxUnits, 'MinUnits, Present, 'PipelineName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#pipeline_name-1">OsisPipeline#pipeline_name</a>.
        /// </summary>
        [<CustomOperation "pipeline_name">]
        member _.PipelineName(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, Missing>, value: string) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, Present> =
            state.assignments.Add(fun config -> config.PipelineName <- value)
            ({ assignments = state.assignments } : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, Present>)

        /// <summary>
        /// buffer_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#buffer_options-1">OsisPipeline#buffer_options</a> Accepts: aws.IResolvable | aws.OsisPipeline.OsisPipelineBufferOptions[]
        /// </summary>
        [<CustomOperation "buffer_options">]
        member _.BufferOptions(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: HashiCorp.Cdktf.IResolvable) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.BufferOptions <- value)
            state : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>

        /// <summary>
        /// encryption_at_rest_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#encryption_at_rest_options-1">OsisPipeline#encryption_at_rest_options</a> Accepts: aws.IResolvable | aws.OsisPipeline.OsisPipelineEncryptionAtRestOptions[]
        /// </summary>
        [<CustomOperation "encryption_at_rest_options">]
        member _.EncryptionAtRestOptions(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: HashiCorp.Cdktf.IResolvable) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.EncryptionAtRestOptions <- value)
            state : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>

        /// <summary>
        /// log_publishing_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#log_publishing_options-1">OsisPipeline#log_publishing_options</a> Accepts: aws.IResolvable | aws.OsisPipeline.OsisPipelineLogPublishingOptions[]
        /// </summary>
        [<CustomOperation "log_publishing_options">]
        member _.LogPublishingOptions(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: HashiCorp.Cdktf.IResolvable) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.LogPublishingOptions <- value)
            state : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#tags-1">OsisPipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: seq<string * string>) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#timeouts-1">OsisPipeline#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: aws.OsisPipeline.OsisPipelineTimeouts) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>

        /// <summary>
        /// vpc_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#vpc_options-1">OsisPipeline#vpc_options</a> Accepts: aws.IResolvable | aws.OsisPipeline.OsisPipelineVpcOptions[]
        /// </summary>
        [<CustomOperation "vpc_options">]
        member _.VpcOptions(state: OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>, value: HashiCorp.Cdktf.IResolvable) : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName> =
            state.assignments.Add(fun config -> config.VpcOptions <- value)
            state : OsisPipelineState<'MaxUnits, 'MinUnits, 'PipelineConfigurationBody, 'PipelineName>

        member _.Run(state: OsisPipelineState<Present, Present, Present, Present>) : aws.OsisPipeline.OsisPipeline =
            let config = aws.OsisPipeline.OsisPipelineConfig()
            for setter in state.assignments do
                setter config
            aws.OsisPipeline.OsisPipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.osisPipeline: missing required arguments. Must call: max_units, min_units, pipeline_configuration_body, pipeline_name.", 9999, IsError = true)>]
        member _.Run(_: OsisPipelineState<_, _, _, _>) : aws.OsisPipeline.OsisPipeline =
            Unchecked.defaultof<aws.OsisPipeline.OsisPipeline>
