namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockInferenceProfileState<'InferenceProfileId> = { assignments: ResizeArray<aws.DataAwsBedrockInferenceProfile.DataAwsBedrockInferenceProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_inference_profile">aws_bedrock_inference_profile</a>.
    /// </summary>
    type DataAwsBedrockInferenceProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockInferenceProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockInferenceProfileState<Missing>)

        member _.Zero(()) : DataAwsBedrockInferenceProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBedrockInferenceProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_inference_profile#inference_profile_id-1">DataAwsBedrockInferenceProfile#inference_profile_id</a>.
        /// </summary>
        [<CustomOperation "inference_profile_id">]
        member _.InferenceProfileId(state: DataAwsBedrockInferenceProfileState<Missing>, value: string) : DataAwsBedrockInferenceProfileState<Present> =
            state.assignments.Add(fun config -> config.InferenceProfileId <- value)
            ({ assignments = state.assignments } : DataAwsBedrockInferenceProfileState<Present>)

        member _.Run(state: DataAwsBedrockInferenceProfileState<Present>) : aws.DataAwsBedrockInferenceProfile.DataAwsBedrockInferenceProfile =
            let config = aws.DataAwsBedrockInferenceProfile.DataAwsBedrockInferenceProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockInferenceProfile.DataAwsBedrockInferenceProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBedrockInferenceProfile: missing required arguments. Must call: inference_profile_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBedrockInferenceProfileState<_>) : aws.DataAwsBedrockInferenceProfile.DataAwsBedrockInferenceProfile =
            Unchecked.defaultof<aws.DataAwsBedrockInferenceProfile.DataAwsBedrockInferenceProfile>
