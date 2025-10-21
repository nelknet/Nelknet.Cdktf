namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafRegexPatternSetState<'Name> = { assignments: ResizeArray<aws.WafRegexPatternSet.WafRegexPatternSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_pattern_set">aws_waf_regex_pattern_set</a>.
    /// </summary>
    type WafRegexPatternSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafRegexPatternSetState<Missing> =
            ({ assignments = ResizeArray() } : WafRegexPatternSetState<Missing>)

        member _.Zero(()) : WafRegexPatternSetState<Missing> =
            ({ assignments = ResizeArray() } : WafRegexPatternSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_pattern_set#name-1">WafRegexPatternSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafRegexPatternSetState<Missing>, value: string) : WafRegexPatternSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafRegexPatternSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_pattern_set#id-1">WafRegexPatternSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafRegexPatternSetState<'Name>, value: string) : WafRegexPatternSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafRegexPatternSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_pattern_set#regex_pattern_strings-1">WafRegexPatternSet#regex_pattern_strings</a>.
        /// </summary>
        [<CustomOperation "regex_pattern_strings">]
        member _.RegexPatternStrings(state: WafRegexPatternSetState<'Name>, value: seq<string>) : WafRegexPatternSetState<'Name> =
            state.assignments.Add(fun config -> config.RegexPatternStrings <- (value |> Seq.toArray))
            state : WafRegexPatternSetState<'Name>

        member _.Run(state: WafRegexPatternSetState<Present>) : aws.WafRegexPatternSet.WafRegexPatternSet =
            let config = aws.WafRegexPatternSet.WafRegexPatternSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafRegexPatternSet.WafRegexPatternSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafRegexPatternSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafRegexPatternSetState<_>) : aws.WafRegexPatternSet.WafRegexPatternSet =
            Unchecked.defaultof<aws.WafRegexPatternSet.WafRegexPatternSet>
