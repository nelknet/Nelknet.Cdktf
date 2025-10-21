namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLexIntentState<'Name> = { assignments: ResizeArray<aws.DataAwsLexIntent.DataAwsLexIntentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_intent">aws_lex_intent</a>.
    /// </summary>
    type DataAwsLexIntentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLexIntentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexIntentState<Missing>)

        member _.Zero(()) : DataAwsLexIntentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLexIntentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_intent#name-1">DataAwsLexIntent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLexIntentState<Missing>, value: string) : DataAwsLexIntentState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsLexIntentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_intent#id-1">DataAwsLexIntent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLexIntentState<'Name>, value: string) : DataAwsLexIntentState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLexIntentState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lex_intent#version-1">DataAwsLexIntent#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsLexIntentState<'Name>, value: string) : DataAwsLexIntentState<'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsLexIntentState<'Name>

        member _.Run(state: DataAwsLexIntentState<Present>) : aws.DataAwsLexIntent.DataAwsLexIntent =
            let config = aws.DataAwsLexIntent.DataAwsLexIntentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLexIntent.DataAwsLexIntent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLexIntent: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLexIntentState<_>) : aws.DataAwsLexIntent.DataAwsLexIntent =
            Unchecked.defaultof<aws.DataAwsLexIntent.DataAwsLexIntent>
