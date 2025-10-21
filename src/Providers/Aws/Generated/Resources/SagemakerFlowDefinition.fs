namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> = { assignments: ResizeArray<aws.SagemakerFlowDefinition.SagemakerFlowDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition">aws_sagemaker_flow_definition</a>.
    /// </summary>
    type SagemakerFlowDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerFlowDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerFlowDefinitionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerFlowDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerFlowDefinitionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#flow_definition_name-1">SagemakerFlowDefinition#flow_definition_name</a>.
        /// </summary>
        [<CustomOperation "flow_definition_name">]
        member _.FlowDefinitionName(state: SagemakerFlowDefinitionState<Missing, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>, value: string) : SagemakerFlowDefinitionState<Present, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.FlowDefinitionName <- value)
            ({ assignments = state.assignments } : SagemakerFlowDefinitionState<Present, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>)

        /// <summary>
        /// human_loop_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_config-1">SagemakerFlowDefinition#human_loop_config</a>
        /// </summary>
        [<CustomOperation "human_loop_config">]
        member _.HumanLoopConfig(state: SagemakerFlowDefinitionState<'FlowDefinitionName, Missing, 'OutputConfig, 'RoleArn>, value: aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig) : SagemakerFlowDefinitionState<'FlowDefinitionName, Present, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.HumanLoopConfig <- value)
            ({ assignments = state.assignments } : SagemakerFlowDefinitionState<'FlowDefinitionName, Present, 'OutputConfig, 'RoleArn>)

        /// <summary>
        /// output_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#output_config-1">SagemakerFlowDefinition#output_config</a>
        /// </summary>
        [<CustomOperation "output_config">]
        member _.OutputConfig(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, Missing, 'RoleArn>, value: aws.SagemakerFlowDefinition.SagemakerFlowDefinitionOutputConfig) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.OutputConfig <- value)
            ({ assignments = state.assignments } : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#role_arn-1">SagemakerFlowDefinition#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, Missing>, value: string) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, Present>)

        /// <summary>
        /// human_loop_activation_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_activation_config-1">SagemakerFlowDefinition#human_loop_activation_config</a>
        /// </summary>
        [<CustomOperation "human_loop_activation_config">]
        member _.HumanLoopActivationConfig(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>, value: aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfig) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.HumanLoopActivationConfig <- value)
            state : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// human_loop_request_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_request_source-1">SagemakerFlowDefinition#human_loop_request_source</a>
        /// </summary>
        [<CustomOperation "human_loop_request_source">]
        member _.HumanLoopRequestSource(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>, value: aws.SagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSource) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.HumanLoopRequestSource <- value)
            state : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#id-1">SagemakerFlowDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>, value: string) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#tags-1">SagemakerFlowDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>, value: seq<string * string>) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#tags_all-1">SagemakerFlowDefinition#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>, value: seq<string * string>) : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerFlowDefinitionState<'FlowDefinitionName, 'HumanLoopConfig, 'OutputConfig, 'RoleArn>

        member _.Run(state: SagemakerFlowDefinitionState<Present, Present, Present, Present>) : aws.SagemakerFlowDefinition.SagemakerFlowDefinition =
            let config = aws.SagemakerFlowDefinition.SagemakerFlowDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerFlowDefinition.SagemakerFlowDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerFlowDefinition: missing required arguments. Must call: flow_definition_name, human_loop_config, output_config, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerFlowDefinitionState<_, _, _, _>) : aws.SagemakerFlowDefinition.SagemakerFlowDefinition =
            Unchecked.defaultof<aws.SagemakerFlowDefinition.SagemakerFlowDefinition>
