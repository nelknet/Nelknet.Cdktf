namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> = { assignments: ResizeArray<aws.BedrockGuardrail.BedrockGuardrailConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail">aws_bedrock_guardrail</a>.
    /// </summary>
    type BedrockGuardrailBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockGuardrailState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockGuardrailState<Missing, Missing, Missing>)

        member _.Zero(()) : BedrockGuardrailState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockGuardrailState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#blocked_input_messaging-1">BedrockGuardrail#blocked_input_messaging</a>.
        /// </summary>
        [<CustomOperation "blocked_input_messaging">]
        member _.BlockedInputMessaging(state: BedrockGuardrailState<Missing, 'BlockedOutputsMessaging, 'Name>, value: string) : BedrockGuardrailState<Present, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.BlockedInputMessaging <- value)
            ({ assignments = state.assignments } : BedrockGuardrailState<Present, 'BlockedOutputsMessaging, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#blocked_outputs_messaging-1">BedrockGuardrail#blocked_outputs_messaging</a>.
        /// </summary>
        [<CustomOperation "blocked_outputs_messaging">]
        member _.BlockedOutputsMessaging(state: BedrockGuardrailState<'BlockedInputMessaging, Missing, 'Name>, value: string) : BedrockGuardrailState<'BlockedInputMessaging, Present, 'Name> =
            state.assignments.Add(fun config -> config.BlockedOutputsMessaging <- value)
            ({ assignments = state.assignments } : BedrockGuardrailState<'BlockedInputMessaging, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#name-1">BedrockGuardrail#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, Missing>, value: string) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, Present>)

        /// <summary>
        /// content_policy_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#content_policy_config-1">BedrockGuardrail#content_policy_config</a> Accepts: aws.IResolvable | aws.BedrockGuardrail.BedrockGuardrailContentPolicyConfig[]
        /// </summary>
        [<CustomOperation "content_policy_config">]
        member _.ContentPolicyConfig(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.ContentPolicyConfig <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// contextual_grounding_policy_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#contextual_grounding_policy_config-1">BedrockGuardrail#contextual_grounding_policy_config</a> Accepts: aws.IResolvable | aws.BedrockGuardrail.BedrockGuardrailContextualGroundingPolicyConfig[]
        /// </summary>
        [<CustomOperation "contextual_grounding_policy_config">]
        member _.ContextualGroundingPolicyConfig(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.ContextualGroundingPolicyConfig <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#description-1">BedrockGuardrail#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: string) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#kms_key_arn-1">BedrockGuardrail#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: string) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// sensitive_information_policy_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#sensitive_information_policy_config-1">BedrockGuardrail#sensitive_information_policy_config</a> Accepts: aws.IResolvable | aws.BedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfig[]
        /// </summary>
        [<CustomOperation "sensitive_information_policy_config">]
        member _.SensitiveInformationPolicyConfig(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.SensitiveInformationPolicyConfig <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#tags-1">BedrockGuardrail#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: seq<string * string>) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#timeouts-1">BedrockGuardrail#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: aws.BedrockGuardrail.BedrockGuardrailTimeouts) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// topic_policy_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#topic_policy_config-1">BedrockGuardrail#topic_policy_config</a> Accepts: aws.IResolvable | aws.BedrockGuardrail.BedrockGuardrailTopicPolicyConfig[]
        /// </summary>
        [<CustomOperation "topic_policy_config">]
        member _.TopicPolicyConfig(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.TopicPolicyConfig <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        /// <summary>
        /// word_policy_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#word_policy_config-1">BedrockGuardrail#word_policy_config</a> Accepts: aws.IResolvable | aws.BedrockGuardrail.BedrockGuardrailWordPolicyConfig[]
        /// </summary>
        [<CustomOperation "word_policy_config">]
        member _.WordPolicyConfig(state: BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name> =
            state.assignments.Add(fun config -> config.WordPolicyConfig <- value)
            state : BedrockGuardrailState<'BlockedInputMessaging, 'BlockedOutputsMessaging, 'Name>

        member _.Run(state: BedrockGuardrailState<Present, Present, Present>) : aws.BedrockGuardrail.BedrockGuardrail =
            let config = aws.BedrockGuardrail.BedrockGuardrailConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockGuardrail.BedrockGuardrail(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockGuardrail: missing required arguments. Must call: blocked_input_messaging, blocked_outputs_messaging, name.", 9999, IsError = true)>]
        member _.Run(_: BedrockGuardrailState<_, _, _>) : aws.BedrockGuardrail.BedrockGuardrail =
            Unchecked.defaultof<aws.BedrockGuardrail.BedrockGuardrail>
