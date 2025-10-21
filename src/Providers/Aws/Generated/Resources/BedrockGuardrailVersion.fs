namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockGuardrailVersionState<'GuardrailArn> = { assignments: ResizeArray<aws.BedrockGuardrailVersion.BedrockGuardrailVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail_version">aws_bedrock_guardrail_version</a>.
    /// </summary>
    type BedrockGuardrailVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockGuardrailVersionState<Missing> =
            ({ assignments = ResizeArray() } : BedrockGuardrailVersionState<Missing>)

        member _.Zero(()) : BedrockGuardrailVersionState<Missing> =
            ({ assignments = ResizeArray() } : BedrockGuardrailVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail_version#guardrail_arn-1">BedrockGuardrailVersion#guardrail_arn</a>.
        /// </summary>
        [<CustomOperation "guardrail_arn">]
        member _.GuardrailArn(state: BedrockGuardrailVersionState<Missing>, value: string) : BedrockGuardrailVersionState<Present> =
            state.assignments.Add(fun config -> config.GuardrailArn <- value)
            ({ assignments = state.assignments } : BedrockGuardrailVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail_version#description-1">BedrockGuardrailVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockGuardrailVersionState<'GuardrailArn>, value: string) : BedrockGuardrailVersionState<'GuardrailArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockGuardrailVersionState<'GuardrailArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail_version#skip_destroy-1">BedrockGuardrailVersion#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: BedrockGuardrailVersionState<'GuardrailArn>, value: bool) : BedrockGuardrailVersionState<'GuardrailArn> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : BedrockGuardrailVersionState<'GuardrailArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail_version#skip_destroy-1">BedrockGuardrailVersion#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: BedrockGuardrailVersionState<'GuardrailArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockGuardrailVersionState<'GuardrailArn> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : BedrockGuardrailVersionState<'GuardrailArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail_version#timeouts-1">BedrockGuardrailVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockGuardrailVersionState<'GuardrailArn>, value: aws.BedrockGuardrailVersion.BedrockGuardrailVersionTimeouts) : BedrockGuardrailVersionState<'GuardrailArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockGuardrailVersionState<'GuardrailArn>

        member _.Run(state: BedrockGuardrailVersionState<Present>) : aws.BedrockGuardrailVersion.BedrockGuardrailVersion =
            let config = aws.BedrockGuardrailVersion.BedrockGuardrailVersionConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockGuardrailVersion.BedrockGuardrailVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockGuardrailVersion: missing required arguments. Must call: guardrail_arn.", 9999, IsError = true)>]
        member _.Run(_: BedrockGuardrailVersionState<_>) : aws.BedrockGuardrailVersion.BedrockGuardrailVersion =
            Unchecked.defaultof<aws.BedrockGuardrailVersion.BedrockGuardrailVersion>
