namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockInferenceProfileState<'Name> = { assignments: ResizeArray<aws.BedrockInferenceProfile.BedrockInferenceProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile">aws_bedrock_inference_profile</a>.
    /// </summary>
    type BedrockInferenceProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockInferenceProfileState<Missing> =
            ({ assignments = ResizeArray() } : BedrockInferenceProfileState<Missing>)

        member _.Zero(()) : BedrockInferenceProfileState<Missing> =
            ({ assignments = ResizeArray() } : BedrockInferenceProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#name-1">BedrockInferenceProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BedrockInferenceProfileState<Missing>, value: string) : BedrockInferenceProfileState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BedrockInferenceProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#description-1">BedrockInferenceProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockInferenceProfileState<'Name>, value: string) : BedrockInferenceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockInferenceProfileState<'Name>

        /// <summary>
        /// model_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#model_source-1">BedrockInferenceProfile#model_source</a> Accepts: aws.IResolvable | aws.BedrockInferenceProfile.BedrockInferenceProfileModelSource[]
        /// </summary>
        [<CustomOperation "model_source">]
        member _.ModelSource(state: BedrockInferenceProfileState<'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockInferenceProfileState<'Name> =
            state.assignments.Add(fun config -> config.ModelSource <- value)
            state : BedrockInferenceProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#tags-1">BedrockInferenceProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockInferenceProfileState<'Name>, value: seq<string * string>) : BedrockInferenceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockInferenceProfileState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#timeouts-1">BedrockInferenceProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockInferenceProfileState<'Name>, value: aws.BedrockInferenceProfile.BedrockInferenceProfileTimeouts) : BedrockInferenceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockInferenceProfileState<'Name>

        member _.Run(state: BedrockInferenceProfileState<Present>) : aws.BedrockInferenceProfile.BedrockInferenceProfile =
            let config = aws.BedrockInferenceProfile.BedrockInferenceProfileConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockInferenceProfile.BedrockInferenceProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockInferenceProfile: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: BedrockInferenceProfileState<_>) : aws.BedrockInferenceProfile.BedrockInferenceProfile =
            Unchecked.defaultof<aws.BedrockInferenceProfile.BedrockInferenceProfile>
