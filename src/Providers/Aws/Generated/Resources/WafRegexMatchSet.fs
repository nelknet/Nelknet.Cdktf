namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafRegexMatchSetState<'Name> = { assignments: ResizeArray<aws.WafRegexMatchSet.WafRegexMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set">aws_waf_regex_match_set</a>.
    /// </summary>
    type WafRegexMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafRegexMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafRegexMatchSetState<Missing>)

        member _.Zero(()) : WafRegexMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafRegexMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set#name-1">WafRegexMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafRegexMatchSetState<Missing>, value: string) : WafRegexMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafRegexMatchSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set#id-1">WafRegexMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafRegexMatchSetState<'Name>, value: string) : WafRegexMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafRegexMatchSetState<'Name>

        /// <summary>
        /// regex_match_tuple block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_regex_match_set#regex_match_tuple-1">WafRegexMatchSet#regex_match_tuple</a> Accepts: aws.IResolvable | aws.WafRegexMatchSet.WafRegexMatchSetRegexMatchTuple[]
        /// </summary>
        [<CustomOperation "regex_match_tuple">]
        member _.RegexMatchTuple(state: WafRegexMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafRegexMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.RegexMatchTuple <- value)
            state : WafRegexMatchSetState<'Name>

        member _.Run(state: WafRegexMatchSetState<Present>) : aws.WafRegexMatchSet.WafRegexMatchSet =
            let config = aws.WafRegexMatchSet.WafRegexMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafRegexMatchSet.WafRegexMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafRegexMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafRegexMatchSetState<_>) : aws.WafRegexMatchSet.WafRegexMatchSet =
            Unchecked.defaultof<aws.WafRegexMatchSet.WafRegexMatchSet>
