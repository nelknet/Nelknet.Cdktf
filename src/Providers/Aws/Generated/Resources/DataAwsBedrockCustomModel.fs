namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockCustomModelState<'ModelId> = { assignments: ResizeArray<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_custom_model">aws_bedrock_custom_model</a>.
    /// </summary>
    type DataAwsBedrockCustomModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockCustomModelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockCustomModelState<Missing>)

        member _.Zero(()) : DataAwsBedrockCustomModelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockCustomModelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_custom_model#model_id-1">DataAwsBedrockCustomModel#model_id</a>.
        /// </summary>
        [<CustomOperation "model_id">]
        member _.ModelId(state: DataAwsBedrockCustomModelState<Missing>, value: string) : DataAwsBedrockCustomModelState<Present> =
            state.assignments.Add(fun config -> config.ModelId <- value)
            ({ assignments = state.assignments } : DataAwsBedrockCustomModelState<Present>)

        member _.Run(state: DataAwsBedrockCustomModelState<Present>) : aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel =
            let config = aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModelConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBedrockCustomModel: missing required arguments. Must call: model_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBedrockCustomModelState<_>) : aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel =
            Unchecked.defaultof<aws.DataAwsBedrockCustomModel.DataAwsBedrockCustomModel>
