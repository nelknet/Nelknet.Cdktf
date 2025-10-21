namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLexBotAliasState<'BotName, 'Name> = { assignments: ResizeArray<aws.DataAwsLexBotAlias.DataAwsLexBotAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot_alias">aws_lex_bot_alias</a>.
    /// </summary>
    type DataAwsLexBotAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLexBotAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexBotAliasState<Missing, Missing>)

        member _.Zero(()) : DataAwsLexBotAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexBotAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot_alias#bot_name-1">DataAwsLexBotAlias#bot_name</a>.
        /// </summary>
        [<CustomOperation "bot_name">]
        member _.BotName(state: DataAwsLexBotAliasState<Missing, 'Name>, value: string) : DataAwsLexBotAliasState<Present, 'Name> =
            state.assignments.Add(fun config -> config.BotName <- value)
            ({ assignments = state.assignments } : DataAwsLexBotAliasState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot_alias#name-1">DataAwsLexBotAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLexBotAliasState<'BotName, Missing>, value: string) : DataAwsLexBotAliasState<'BotName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsLexBotAliasState<'BotName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot_alias#id-1">DataAwsLexBotAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLexBotAliasState<'BotName, 'Name>, value: string) : DataAwsLexBotAliasState<'BotName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLexBotAliasState<'BotName, 'Name>

        member _.Run(state: DataAwsLexBotAliasState<Present, Present>) : aws.DataAwsLexBotAlias.DataAwsLexBotAlias =
            let config = aws.DataAwsLexBotAlias.DataAwsLexBotAliasConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLexBotAlias.DataAwsLexBotAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLexBotAlias: missing required arguments. Must call: bot_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLexBotAliasState<_, _>) : aws.DataAwsLexBotAlias.DataAwsLexBotAlias =
            Unchecked.defaultof<aws.DataAwsLexBotAlias.DataAwsLexBotAlias>
