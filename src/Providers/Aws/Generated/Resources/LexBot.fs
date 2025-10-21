namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> = { assignments: ResizeArray<aws.LexBot.LexBotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot">aws_lex_bot</a>.
    /// </summary>
    type LexBotBuilder(logicalId: string) =
        member _.Yield(_: unit) : LexBotState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LexBotState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LexBotState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LexBotState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// abort_statement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#abort_statement-1">LexBot#abort_statement</a>
        /// </summary>
        [<CustomOperation "abort_statement">]
        member _.AbortStatement(state: LexBotState<Missing, 'ChildDirected, 'Intent, 'Name>, value: aws.LexBot.LexBotAbortStatement) : LexBotState<Present, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.AbortStatement <- value)
            ({ assignments = state.assignments } : LexBotState<Present, 'ChildDirected, 'Intent, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#child_directed-1">LexBot#child_directed</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "child_directed">]
        member _.ChildDirected(state: LexBotState<'AbortStatement, Missing, 'Intent, 'Name>, value: bool) : LexBotState<'AbortStatement, Present, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.ChildDirected <- value)
            ({ assignments = state.assignments } : LexBotState<'AbortStatement, Present, 'Intent, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#child_directed-1">LexBot#child_directed</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "child_directed">]
        member _.ChildDirected(state: LexBotState<'AbortStatement, Missing, 'Intent, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexBotState<'AbortStatement, Present, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.ChildDirected <- value)
            ({ assignments = state.assignments } : LexBotState<'AbortStatement, Present, 'Intent, 'Name>)

        /// <summary>
        /// intent block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent-1">LexBot#intent</a> Accepts: aws.IResolvable | aws.LexBot.LexBotIntent[]
        /// </summary>
        [<CustomOperation "intent">]
        member _.Intent(state: LexBotState<'AbortStatement, 'ChildDirected, Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexBotState<'AbortStatement, 'ChildDirected, Present, 'Name> =
            state.assignments.Add(fun config -> config.Intent <- value)
            ({ assignments = state.assignments } : LexBotState<'AbortStatement, 'ChildDirected, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#name-1">LexBot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, Missing>, value: string) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, Present>)

        /// <summary>
        /// clarification_prompt block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#clarification_prompt-1">LexBot#clarification_prompt</a>
        /// </summary>
        [<CustomOperation "clarification_prompt">]
        member _.ClarificationPrompt(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: aws.LexBot.LexBotClarificationPrompt) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.ClarificationPrompt <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#create_version-1">LexBot#create_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_version">]
        member _.CreateVersion(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: bool) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.CreateVersion <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#create_version-1">LexBot#create_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_version">]
        member _.CreateVersion(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.CreateVersion <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#description-1">LexBot#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: string) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#detect_sentiment-1">LexBot#detect_sentiment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "detect_sentiment">]
        member _.DetectSentiment(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: bool) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.DetectSentiment <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#detect_sentiment-1">LexBot#detect_sentiment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "detect_sentiment">]
        member _.DetectSentiment(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.DetectSentiment <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#enable_model_improvements-1">LexBot#enable_model_improvements</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_model_improvements">]
        member _.EnableModelImprovements(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: bool) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.EnableModelImprovements <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#enable_model_improvements-1">LexBot#enable_model_improvements</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_model_improvements">]
        member _.EnableModelImprovements(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.EnableModelImprovements <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#id-1">LexBot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: string) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#idle_session_ttl_in_seconds-1">LexBot#idle_session_ttl_in_seconds</a>.
        /// </summary>
        [<CustomOperation "idle_session_ttl_in_seconds">]
        member _.IdleSessionTtlInSeconds(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: double) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.IdleSessionTtlInSeconds <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#locale-1">LexBot#locale</a>.
        /// </summary>
        [<CustomOperation "locale">]
        member _.Locale(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: string) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.Locale <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#nlu_intent_confidence_threshold-1">LexBot#nlu_intent_confidence_threshold</a>.
        /// </summary>
        [<CustomOperation "nlu_intent_confidence_threshold">]
        member _.NluIntentConfidenceThreshold(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: double) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.NluIntentConfidenceThreshold <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#process_behavior-1">LexBot#process_behavior</a>.
        /// </summary>
        [<CustomOperation "process_behavior">]
        member _.ProcessBehavior(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: string) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.ProcessBehavior <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#timeouts-1">LexBot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: aws.LexBot.LexBotTimeouts) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#voice_id-1">LexBot#voice_id</a>.
        /// </summary>
        [<CustomOperation "voice_id">]
        member _.VoiceId(state: LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>, value: string) : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name> =
            state.assignments.Add(fun config -> config.VoiceId <- value)
            state : LexBotState<'AbortStatement, 'ChildDirected, 'Intent, 'Name>

        member _.Run(state: LexBotState<Present, Present, Present, Present>) : aws.LexBot.LexBot =
            let config = aws.LexBot.LexBotConfig()
            for setter in state.assignments do
                setter config
            aws.LexBot.LexBot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexBot: missing required arguments. Must call: abort_statement, child_directed, intent, name.", 9999, IsError = true)>]
        member _.Run(_: LexBotState<_, _, _, _>) : aws.LexBot.LexBot =
            Unchecked.defaultof<aws.LexBot.LexBot>
