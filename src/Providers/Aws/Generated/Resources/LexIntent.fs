namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LexIntentState<'FulfillmentActivity, 'Name> = { assignments: ResizeArray<aws.LexIntent.LexIntentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent">aws_lex_intent</a>.
    /// </summary>
    type LexIntentBuilder(logicalId: string) =
        member _.Yield(_: unit) : LexIntentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LexIntentState<Missing, Missing>)

        member _.Zero(()) : LexIntentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LexIntentState<Missing, Missing>)

        /// <summary>
        /// fulfillment_activity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#fulfillment_activity-1">LexIntent#fulfillment_activity</a>
        /// </summary>
        [<CustomOperation "fulfillment_activity">]
        member _.FulfillmentActivity(state: LexIntentState<Missing, 'Name>, value: aws.LexIntent.LexIntentFulfillmentActivity) : LexIntentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.FulfillmentActivity <- value)
            ({ assignments = state.assignments } : LexIntentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#name-1">LexIntent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LexIntentState<'FulfillmentActivity, Missing>, value: string) : LexIntentState<'FulfillmentActivity, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LexIntentState<'FulfillmentActivity, Present>)

        /// <summary>
        /// conclusion_statement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#conclusion_statement-1">LexIntent#conclusion_statement</a>
        /// </summary>
        [<CustomOperation "conclusion_statement">]
        member _.ConclusionStatement(state: LexIntentState<'FulfillmentActivity, 'Name>, value: aws.LexIntent.LexIntentConclusionStatement) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.ConclusionStatement <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// confirmation_prompt block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#confirmation_prompt-1">LexIntent#confirmation_prompt</a>
        /// </summary>
        [<CustomOperation "confirmation_prompt">]
        member _.ConfirmationPrompt(state: LexIntentState<'FulfillmentActivity, 'Name>, value: aws.LexIntent.LexIntentConfirmationPrompt) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.ConfirmationPrompt <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#create_version-1">LexIntent#create_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_version">]
        member _.CreateVersion(state: LexIntentState<'FulfillmentActivity, 'Name>, value: bool) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.CreateVersion <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#create_version-1">LexIntent#create_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_version">]
        member _.CreateVersion(state: LexIntentState<'FulfillmentActivity, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.CreateVersion <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#description-1">LexIntent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LexIntentState<'FulfillmentActivity, 'Name>, value: string) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// dialog_code_hook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#dialog_code_hook-1">LexIntent#dialog_code_hook</a>
        /// </summary>
        [<CustomOperation "dialog_code_hook">]
        member _.DialogCodeHook(state: LexIntentState<'FulfillmentActivity, 'Name>, value: aws.LexIntent.LexIntentDialogCodeHook) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.DialogCodeHook <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// follow_up_prompt block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#follow_up_prompt-1">LexIntent#follow_up_prompt</a>
        /// </summary>
        [<CustomOperation "follow_up_prompt">]
        member _.FollowUpPrompt(state: LexIntentState<'FulfillmentActivity, 'Name>, value: aws.LexIntent.LexIntentFollowUpPrompt) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.FollowUpPrompt <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#id-1">LexIntent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LexIntentState<'FulfillmentActivity, 'Name>, value: string) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#parent_intent_signature-1">LexIntent#parent_intent_signature</a>.
        /// </summary>
        [<CustomOperation "parent_intent_signature">]
        member _.ParentIntentSignature(state: LexIntentState<'FulfillmentActivity, 'Name>, value: string) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.ParentIntentSignature <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// rejection_statement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#rejection_statement-1">LexIntent#rejection_statement</a>
        /// </summary>
        [<CustomOperation "rejection_statement">]
        member _.RejectionStatement(state: LexIntentState<'FulfillmentActivity, 'Name>, value: aws.LexIntent.LexIntentRejectionStatement) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.RejectionStatement <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#sample_utterances-1">LexIntent#sample_utterances</a>.
        /// </summary>
        [<CustomOperation "sample_utterances">]
        member _.SampleUtterances(state: LexIntentState<'FulfillmentActivity, 'Name>, value: seq<string>) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.SampleUtterances <- (value |> Seq.toArray))
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// slot block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot-1">LexIntent#slot</a> Accepts: aws.IResolvable | aws.LexIntent.LexIntentSlot[]
        /// </summary>
        [<CustomOperation "slot">]
        member _.Slot(state: LexIntentState<'FulfillmentActivity, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.Slot <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#timeouts-1">LexIntent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LexIntentState<'FulfillmentActivity, 'Name>, value: aws.LexIntent.LexIntentTimeouts) : LexIntentState<'FulfillmentActivity, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LexIntentState<'FulfillmentActivity, 'Name>

        member _.Run(state: LexIntentState<Present, Present>) : aws.LexIntent.LexIntent =
            let config = aws.LexIntent.LexIntentConfig()
            for setter in state.assignments do
                setter config
            aws.LexIntent.LexIntent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexIntent: missing required arguments. Must call: fulfillment_activity, name.", 9999, IsError = true)>]
        member _.Run(_: LexIntentState<_, _>) : aws.LexIntent.LexIntent =
            Unchecked.defaultof<aws.LexIntent.LexIntent>
