namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentPromptState<'Name> = { assignments: ResizeArray<aws.BedrockagentPrompt.BedrockagentPromptConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt">aws_bedrockagent_prompt</a>.
    /// </summary>
    type BedrockagentPromptBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentPromptState<Missing> =
            ({ assignments = ResizeArray() } : BedrockagentPromptState<Missing>)

        member _.Zero(()) : BedrockagentPromptState<Missing> =
            ({ assignments = ResizeArray() } : BedrockagentPromptState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#name-1">BedrockagentPrompt#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BedrockagentPromptState<Missing>, value: string) : BedrockagentPromptState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BedrockagentPromptState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#customer_encryption_key_arn-1">BedrockagentPrompt#customer_encryption_key_arn</a>.
        /// </summary>
        [<CustomOperation "customer_encryption_key_arn">]
        member _.CustomerEncryptionKeyArn(state: BedrockagentPromptState<'Name>, value: string) : BedrockagentPromptState<'Name> =
            state.assignments.Add(fun config -> config.CustomerEncryptionKeyArn <- value)
            state : BedrockagentPromptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#default_variant-1">BedrockagentPrompt#default_variant</a>.
        /// </summary>
        [<CustomOperation "default_variant">]
        member _.DefaultVariant(state: BedrockagentPromptState<'Name>, value: string) : BedrockagentPromptState<'Name> =
            state.assignments.Add(fun config -> config.DefaultVariant <- value)
            state : BedrockagentPromptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#description-1">BedrockagentPrompt#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentPromptState<'Name>, value: string) : BedrockagentPromptState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockagentPromptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#tags-1">BedrockagentPrompt#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockagentPromptState<'Name>, value: seq<string * string>) : BedrockagentPromptState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockagentPromptState<'Name>

        /// <summary>
        /// variant block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#variant-1">BedrockagentPrompt#variant</a> Accepts: aws.IResolvable | aws.BedrockagentPrompt.BedrockagentPromptVariant[]
        /// </summary>
        [<CustomOperation "variant">]
        member _.Variant(state: BedrockagentPromptState<'Name>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentPromptState<'Name> =
            state.assignments.Add(fun config -> config.Variant <- value)
            state : BedrockagentPromptState<'Name>

        member _.Run(state: BedrockagentPromptState<Present>) : aws.BedrockagentPrompt.BedrockagentPrompt =
            let config = aws.BedrockagentPrompt.BedrockagentPromptConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentPrompt.BedrockagentPrompt(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentPrompt: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentPromptState<_>) : aws.BedrockagentPrompt.BedrockagentPrompt =
            Unchecked.defaultof<aws.BedrockagentPrompt.BedrockagentPrompt>
