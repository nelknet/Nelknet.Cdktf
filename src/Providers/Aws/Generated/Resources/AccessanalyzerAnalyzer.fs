namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AccessanalyzerAnalyzerState<'AnalyzerName> = { assignments: ResizeArray<aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer">aws_accessanalyzer_analyzer</a>.
    /// </summary>
    type AccessanalyzerAnalyzerBuilder(logicalId: string) =
        member _.Yield(_: unit) : AccessanalyzerAnalyzerState<Missing> =
            ({ assignments = ResizeArray() } : AccessanalyzerAnalyzerState<Missing>)

        member _.Zero(()) : AccessanalyzerAnalyzerState<Missing> =
            ({ assignments = ResizeArray() } : AccessanalyzerAnalyzerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#analyzer_name-1">AccessanalyzerAnalyzer#analyzer_name</a>.
        /// </summary>
        [<CustomOperation "analyzer_name">]
        member _.AnalyzerName(state: AccessanalyzerAnalyzerState<Missing>, value: string) : AccessanalyzerAnalyzerState<Present> =
            state.assignments.Add(fun config -> config.AnalyzerName <- value)
            ({ assignments = state.assignments } : AccessanalyzerAnalyzerState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#configuration-1">AccessanalyzerAnalyzer#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: AccessanalyzerAnalyzerState<'AnalyzerName>, value: aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfiguration) : AccessanalyzerAnalyzerState<'AnalyzerName> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : AccessanalyzerAnalyzerState<'AnalyzerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#id-1">AccessanalyzerAnalyzer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AccessanalyzerAnalyzerState<'AnalyzerName>, value: string) : AccessanalyzerAnalyzerState<'AnalyzerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AccessanalyzerAnalyzerState<'AnalyzerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#tags-1">AccessanalyzerAnalyzer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AccessanalyzerAnalyzerState<'AnalyzerName>, value: seq<string * string>) : AccessanalyzerAnalyzerState<'AnalyzerName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AccessanalyzerAnalyzerState<'AnalyzerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#tags_all-1">AccessanalyzerAnalyzer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AccessanalyzerAnalyzerState<'AnalyzerName>, value: seq<string * string>) : AccessanalyzerAnalyzerState<'AnalyzerName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AccessanalyzerAnalyzerState<'AnalyzerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_analyzer#type-1">AccessanalyzerAnalyzer#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AccessanalyzerAnalyzerState<'AnalyzerName>, value: string) : AccessanalyzerAnalyzerState<'AnalyzerName> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : AccessanalyzerAnalyzerState<'AnalyzerName>

        member _.Run(state: AccessanalyzerAnalyzerState<Present>) : aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzer =
            let config = aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzerConfig()
            for setter in state.assignments do
                setter config
            aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.accessanalyzerAnalyzer: missing required arguments. Must call: analyzer_name.", 9999, IsError = true)>]
        member _.Run(_: AccessanalyzerAnalyzerState<_>) : aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzer =
            Unchecked.defaultof<aws.AccessanalyzerAnalyzer.AccessanalyzerAnalyzer>
