namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafXssMatchSetState<'Name> = { assignments: ResizeArray<aws.WafXssMatchSet.WafXssMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set">aws_waf_xss_match_set</a>.
    /// </summary>
    type WafXssMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafXssMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafXssMatchSetState<Missing>)

        member _.Zero(()) : WafXssMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafXssMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#name-1">WafXssMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafXssMatchSetState<Missing>, value: string) : WafXssMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafXssMatchSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#id-1">WafXssMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafXssMatchSetState<'Name>, value: string) : WafXssMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafXssMatchSetState<'Name>

        /// <summary>
        /// xss_match_tuples block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#xss_match_tuples-1">WafXssMatchSet#xss_match_tuples</a> Accepts: aws.IResolvable | aws.WafXssMatchSet.WafXssMatchSetXssMatchTuples[]
        /// </summary>
        [<CustomOperation "xss_match_tuples">]
        member _.XssMatchTuples(state: WafXssMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafXssMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.XssMatchTuples <- value)
            state : WafXssMatchSetState<'Name>

        member _.Run(state: WafXssMatchSetState<Present>) : aws.WafXssMatchSet.WafXssMatchSet =
            let config = aws.WafXssMatchSet.WafXssMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafXssMatchSet.WafXssMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafXssMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafXssMatchSetState<_>) : aws.WafXssMatchSet.WafXssMatchSet =
            Unchecked.defaultof<aws.WafXssMatchSet.WafXssMatchSet>
