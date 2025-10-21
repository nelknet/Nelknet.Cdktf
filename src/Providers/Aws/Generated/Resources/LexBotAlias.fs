namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LexBotAliasState<'BotName, 'BotVersion, 'Name> = { assignments: ResizeArray<aws.LexBotAlias.LexBotAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias">aws_lex_bot_alias</a>.
    /// </summary>
    type LexBotAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : LexBotAliasState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LexBotAliasState<Missing, Missing, Missing>)

        member _.Zero(()) : LexBotAliasState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LexBotAliasState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#bot_name-1">LexBotAlias#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: LexBotAliasState<Missing, 'BotVersion, 'Name>, value: string) : LexBotAliasState<Present, 'BotVersion, 'Name> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : LexBotAliasState<Present, 'BotVersion, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#bot_version-1">LexBotAlias#bot_version</a>.
        /// </summary>
        [<CustomOperation "bot_version">]
        member _.BotVersion(state: LexBotAliasState<'BotName, Missing, 'Name>, value: string) : LexBotAliasState<'BotName, Present, 'Name> =
            state.assignments.Add(fun config -> config.BotVersion <- value)
            ({ assignments = state.assignments } : LexBotAliasState<'BotName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#name-1">LexBotAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LexBotAliasState<'BotName, 'BotVersion, Missing>, value: string) : LexBotAliasState<'BotName, 'BotVersion, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LexBotAliasState<'BotName, 'BotVersion, Present>)

        /// <summary>
        /// conversation_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#conversation_logs-1">LexBotAlias#conversation_logs</a>
        /// </summary>
        [<CustomOperation "conversation_logs">]
        member _.ConversationLogs(state: LexBotAliasState<'BotName, 'BotVersion, 'Name>, value: aws.LexBotAlias.LexBotAliasConversationLogs) : LexBotAliasState<'BotName, 'BotVersion, 'Name> =
            state.assignments.Add(fun config -> config.ConversationLogs <- value)
            state : LexBotAliasState<'BotName, 'BotVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#description-1">LexBotAlias#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LexBotAliasState<'BotName, 'BotVersion, 'Name>, value: string) : LexBotAliasState<'BotName, 'BotVersion, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LexBotAliasState<'BotName, 'BotVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#id-1">LexBotAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LexBotAliasState<'BotName, 'BotVersion, 'Name>, value: string) : LexBotAliasState<'BotName, 'BotVersion, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LexBotAliasState<'BotName, 'BotVersion, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#timeouts-1">LexBotAlias#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LexBotAliasState<'BotName, 'BotVersion, 'Name>, value: aws.LexBotAlias.LexBotAliasTimeouts) : LexBotAliasState<'BotName, 'BotVersion, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LexBotAliasState<'BotName, 'BotVersion, 'Name>

        member _.Run(state: LexBotAliasState<Present, Present, Present>) : aws.LexBotAlias.LexBotAlias =
            let config = aws.LexBotAlias.LexBotAliasConfig()
            for setter in state.assignments do
                setter config
            aws.LexBotAlias.LexBotAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lexBotAlias: missing required arguments. Must call: bot_name, bot_version, name.", 9999, IsError = true)>]
        member _.Run(_: LexBotAliasState<_, _, _>) : aws.LexBotAlias.LexBotAlias =
            Unchecked.defaultof<aws.LexBotAlias.LexBotAlias>
