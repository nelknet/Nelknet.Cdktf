namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLexBotState<'Name> = { assignments: ResizeArray<aws.DataAwsLexBot.DataAwsLexBotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot">aws_lex_bot</a>.
    /// </summary>
    type DataAwsLexBotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLexBotState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexBotState<Missing>)

        member _.Zero(()) : DataAwsLexBotState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexBotState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot#name-1">DataAwsLexBot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLexBotState<Missing>, value: string) : DataAwsLexBotState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsLexBotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot#id-1">DataAwsLexBot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLexBotState<'Name>, value: string) : DataAwsLexBotState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLexBotState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_bot#version-1">DataAwsLexBot#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsLexBotState<'Name>, value: string) : DataAwsLexBotState<'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsLexBotState<'Name>

        member _.Run(state: DataAwsLexBotState<Present>) : aws.DataAwsLexBot.DataAwsLexBot =
            let config = aws.DataAwsLexBot.DataAwsLexBotConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLexBot.DataAwsLexBot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLexBot: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLexBotState<_>) : aws.DataAwsLexBot.DataAwsLexBot =
            Unchecked.defaultof<aws.DataAwsLexBot.DataAwsLexBot>
