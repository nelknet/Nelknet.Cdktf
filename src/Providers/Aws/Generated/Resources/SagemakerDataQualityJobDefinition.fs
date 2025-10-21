namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> = { assignments: ResizeArray<aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition">aws_sagemaker_data_quality_job_definition</a>.
    /// </summary>
    type SagemakerDataQualityJobDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerDataQualityJobDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDataQualityJobDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerDataQualityJobDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerDataQualityJobDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// data_quality_app_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_app_specification-1">SagemakerDataQualityJobDefinition#data_quality_app_specification</a>
        /// </summary>
        [<CustomOperation "data_quality_app_specification">]
        member _.DataQualityAppSpecification(state: SagemakerDataQualityJobDefinitionState<Missing, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityAppSpecification) : SagemakerDataQualityJobDefinitionState<Present, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.DataQualityAppSpecification <- value)
            ({ assignments = state.assignments } : SagemakerDataQualityJobDefinitionState<Present, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>)

        /// <summary>
        /// data_quality_job_input block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_job_input-1">SagemakerDataQualityJobDefinition#data_quality_job_input</a>
        /// </summary>
        [<CustomOperation "data_quality_job_input">]
        member _.DataQualityJobInput(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, Missing, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobInput) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, Present, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.DataQualityJobInput <- value)
            ({ assignments = state.assignments } : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, Present, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>)

        /// <summary>
        /// data_quality_job_output_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_job_output_config-1">SagemakerDataQualityJobDefinition#data_quality_job_output_config</a>
        /// </summary>
        [<CustomOperation "data_quality_job_output_config">]
        member _.DataQualityJobOutputConfig(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, Missing, 'JobResources, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobOutputConfig) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, Present, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.DataQualityJobOutputConfig <- value)
            ({ assignments = state.assignments } : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, Present, 'JobResources, 'RoleArn>)

        /// <summary>
        /// job_resources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#job_resources-1">SagemakerDataQualityJobDefinition#job_resources</a>
        /// </summary>
        [<CustomOperation "job_resources">]
        member _.JobResources(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, Missing, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResources) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.JobResources <- value)
            ({ assignments = state.assignments } : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#role_arn-1">SagemakerDataQualityJobDefinition#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, Missing>, value: string) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, Present>)

        /// <summary>
        /// data_quality_baseline_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#data_quality_baseline_config-1">SagemakerDataQualityJobDefinition#data_quality_baseline_config</a>
        /// </summary>
        [<CustomOperation "data_quality_baseline_config">]
        member _.DataQualityBaselineConfig(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfig) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.DataQualityBaselineConfig <- value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#id-1">SagemakerDataQualityJobDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: string) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#name-1">SagemakerDataQualityJobDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: string) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        /// <summary>
        /// network_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#network_config-1">SagemakerDataQualityJobDefinition#network_config</a>
        /// </summary>
        [<CustomOperation "network_config">]
        member _.NetworkConfig(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionNetworkConfig) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.NetworkConfig <- value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        /// <summary>
        /// stopping_condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#stopping_condition-1">SagemakerDataQualityJobDefinition#stopping_condition</a>
        /// </summary>
        [<CustomOperation "stopping_condition">]
        member _.StoppingCondition(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionStoppingCondition) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.StoppingCondition <- value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#tags-1">SagemakerDataQualityJobDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: seq<string * string>) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#tags_all-1">SagemakerDataQualityJobDefinition#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>, value: seq<string * string>) : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerDataQualityJobDefinitionState<'DataQualityAppSpecification, 'DataQualityJobInput, 'DataQualityJobOutputConfig, 'JobResources, 'RoleArn>

        member _.Run(state: SagemakerDataQualityJobDefinitionState<Present, Present, Present, Present, Present>) : aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinition =
            let config = aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerDataQualityJobDefinition: missing required arguments. Must call: data_quality_app_specification, data_quality_job_input, data_quality_job_output_config, job_resources, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerDataQualityJobDefinitionState<_, _, _, _, _>) : aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinition =
            Unchecked.defaultof<aws.SagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinition>
