namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalRegexPatternSetState<'Name> = { assignments: ResizeArray<aws.WafregionalRegexPatternSet.WafregionalRegexPatternSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_pattern_set">aws_wafregional_regex_pattern_set</a>.
    /// </summary>
    type WafregionalRegexPatternSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalRegexPatternSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalRegexPatternSetState<Missing>)

        member _.Zero(()) : WafregionalRegexPatternSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalRegexPatternSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_pattern_set#name-1">WafregionalRegexPatternSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalRegexPatternSetState<Missing>, value: string) : WafregionalRegexPatternSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalRegexPatternSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_pattern_set#id-1">WafregionalRegexPatternSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalRegexPatternSetState<'Name>, value: string) : WafregionalRegexPatternSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalRegexPatternSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_pattern_set#regex_pattern_strings-1">WafregionalRegexPatternSet#regex_pattern_strings</a>.
        /// </summary>
        [<CustomOperation "regex_pattern_strings">]
        member _.RegexPatternStrings(state: WafregionalRegexPatternSetState<'Name>, value: seq<string>) : WafregionalRegexPatternSetState<'Name> =
            state.assignments.Add(fun config -> config.RegexPatternStrings <- (value |> Seq.toArray))
            state : WafregionalRegexPatternSetState<'Name>

        member _.Run(state: WafregionalRegexPatternSetState<Present>) : aws.WafregionalRegexPatternSet.WafregionalRegexPatternSet =
            let config = aws.WafregionalRegexPatternSet.WafregionalRegexPatternSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalRegexPatternSet.WafregionalRegexPatternSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalRegexPatternSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalRegexPatternSetState<_>) : aws.WafregionalRegexPatternSet.WafregionalRegexPatternSet =
            Unchecked.defaultof<aws.WafregionalRegexPatternSet.WafregionalRegexPatternSet>
