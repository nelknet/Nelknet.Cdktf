namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBedrockInferenceProfilesState = { assignments: ResizeArray<aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrock_inference_profiles">aws_bedrock_inference_profiles</a>.
    /// </summary>
    type DataAwsBedrockInferenceProfilesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBedrockInferenceProfilesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsBedrockInferenceProfilesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsBedrockInferenceProfilesState) : aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfiles =
            let config = aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfilesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBedrockInferenceProfiles.DataAwsBedrockInferenceProfiles(StackContext.get (), logicalId, config)
