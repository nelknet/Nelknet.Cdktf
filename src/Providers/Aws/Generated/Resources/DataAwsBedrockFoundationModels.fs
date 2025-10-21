namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockFoundationModelsState = { assignments: ResizeArray<aws.DataAwsBedrockFoundationModels.DataAwsBedrockFoundationModelsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_models">aws_bedrock_foundation_models</a>.
    /// </summary>
    type DataAwsBedrockFoundationModelsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockFoundationModelsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsBedrockFoundationModelsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_models#by_customization_type-1">DataAwsBedrockFoundationModels#by_customization_type</a>.
        /// </summary>
        [<CustomOperation "by_customization_type">]
        member _.ByCustomizationType(state: DataAwsBedrockFoundationModelsState, value: string) : DataAwsBedrockFoundationModelsState =
            state.assignments.Add(fun config -> config.ByCustomizationType <- value)
            state : DataAwsBedrockFoundationModelsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_models#by_inference_type-1">DataAwsBedrockFoundationModels#by_inference_type</a>.
        /// </summary>
        [<CustomOperation "by_inference_type">]
        member _.ByInferenceType(state: DataAwsBedrockFoundationModelsState, value: string) : DataAwsBedrockFoundationModelsState =
            state.assignments.Add(fun config -> config.ByInferenceType <- value)
            state : DataAwsBedrockFoundationModelsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_models#by_output_modality-1">DataAwsBedrockFoundationModels#by_output_modality</a>.
        /// </summary>
        [<CustomOperation "by_output_modality">]
        member _.ByOutputModality(state: DataAwsBedrockFoundationModelsState, value: string) : DataAwsBedrockFoundationModelsState =
            state.assignments.Add(fun config -> config.ByOutputModality <- value)
            state : DataAwsBedrockFoundationModelsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_models#by_provider-1">DataAwsBedrockFoundationModels#by_provider</a>.
        /// </summary>
        [<CustomOperation "by_provider">]
        member _.ByProvider(state: DataAwsBedrockFoundationModelsState, value: string) : DataAwsBedrockFoundationModelsState =
            state.assignments.Add(fun config -> config.ByProvider <- value)
            state : DataAwsBedrockFoundationModelsState

        member _.Run(state: DataAwsBedrockFoundationModelsState) : aws.DataAwsBedrockFoundationModels.DataAwsBedrockFoundationModels =
            let config = aws.DataAwsBedrockFoundationModels.DataAwsBedrockFoundationModelsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockFoundationModels.DataAwsBedrockFoundationModels(StackContext.get (), logicalId, config)
