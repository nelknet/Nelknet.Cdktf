namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockFoundationModelState<'ModelId> = { assignments: ResizeArray<aws.DataAwsBedrockFoundationModel.DataAwsBedrockFoundationModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_model">aws_bedrock_foundation_model</a>.
    /// </summary>
    type DataAwsBedrockFoundationModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockFoundationModelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockFoundationModelState<Missing>)

        member _.Zero(()) : DataAwsBedrockFoundationModelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockFoundationModelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_foundation_model#model_id-1">DataAwsBedrockFoundationModel#model_id</a>.
        /// </summary>
        [<CustomOperation "model_id">]
        member _.ModelId(state: DataAwsBedrockFoundationModelState<Missing>, value: string) : DataAwsBedrockFoundationModelState<Present> =
            state.assignments.Add(fun config -> config.ModelId <- value)
            ({ assignments = state.assignments } : DataAwsBedrockFoundationModelState<Present>)

        member _.Run(state: DataAwsBedrockFoundationModelState<Present>) : aws.DataAwsBedrockFoundationModel.DataAwsBedrockFoundationModel =
            let config = aws.DataAwsBedrockFoundationModel.DataAwsBedrockFoundationModelConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockFoundationModel.DataAwsBedrockFoundationModel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBedrockFoundationModel: missing required arguments. Must call: model_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBedrockFoundationModelState<_>) : aws.DataAwsBedrockFoundationModel.DataAwsBedrockFoundationModel =
            Unchecked.defaultof<aws.DataAwsBedrockFoundationModel.DataAwsBedrockFoundationModel>
