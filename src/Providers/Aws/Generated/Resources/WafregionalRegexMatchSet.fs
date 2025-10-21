namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalRegexMatchSetState<'Name> = { assignments: ResizeArray<aws.WafregionalRegexMatchSet.WafregionalRegexMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set">aws_wafregional_regex_match_set</a>.
    /// </summary>
    type WafregionalRegexMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalRegexMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalRegexMatchSetState<Missing>)

        member _.Zero(()) : WafregionalRegexMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalRegexMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#name-1">WafregionalRegexMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalRegexMatchSetState<Missing>, value: string) : WafregionalRegexMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalRegexMatchSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#id-1">WafregionalRegexMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalRegexMatchSetState<'Name>, value: string) : WafregionalRegexMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalRegexMatchSetState<'Name>

        /// <summary>
        /// regex_match_tuple block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_regex_match_set#regex_match_tuple-1">WafregionalRegexMatchSet#regex_match_tuple</a> Accepts: aws.IResolvable | aws.WafregionalRegexMatchSet.WafregionalRegexMatchSetRegexMatchTuple[]
        /// </summary>
        [<CustomOperation "regex_match_tuple">]
        member _.RegexMatchTuple(state: WafregionalRegexMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalRegexMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.RegexMatchTuple <- value)
            state : WafregionalRegexMatchSetState<'Name>

        member _.Run(state: WafregionalRegexMatchSetState<Present>) : aws.WafregionalRegexMatchSet.WafregionalRegexMatchSet =
            let config = aws.WafregionalRegexMatchSet.WafregionalRegexMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalRegexMatchSet.WafregionalRegexMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalRegexMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalRegexMatchSetState<_>) : aws.WafregionalRegexMatchSet.WafregionalRegexMatchSet =
            Unchecked.defaultof<aws.WafregionalRegexMatchSet.WafregionalRegexMatchSet>
