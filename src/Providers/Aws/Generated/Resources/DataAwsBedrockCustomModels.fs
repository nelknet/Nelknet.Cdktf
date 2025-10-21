namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockCustomModelsState = { assignments: ResizeArray<aws.DataAwsBedrockCustomModels.DataAwsBedrockCustomModelsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_custom_models">aws_bedrock_custom_models</a>.
    /// </summary>
    type DataAwsBedrockCustomModelsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockCustomModelsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsBedrockCustomModelsState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsBedrockCustomModelsState) : aws.DataAwsBedrockCustomModels.DataAwsBedrockCustomModels =
            let config = aws.DataAwsBedrockCustomModels.DataAwsBedrockCustomModelsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockCustomModels.DataAwsBedrockCustomModels(StackContext.get (), logicalId, config)
