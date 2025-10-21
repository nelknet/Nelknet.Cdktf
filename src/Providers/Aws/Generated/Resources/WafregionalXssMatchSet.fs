namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalXssMatchSetState<'Name> = { assignments: ResizeArray<aws.WafregionalXssMatchSet.WafregionalXssMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set">aws_wafregional_xss_match_set</a>.
    /// </summary>
    type WafregionalXssMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalXssMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalXssMatchSetState<Missing>)

        member _.Zero(()) : WafregionalXssMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalXssMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#name-1">WafregionalXssMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalXssMatchSetState<Missing>, value: string) : WafregionalXssMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalXssMatchSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#id-1">WafregionalXssMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalXssMatchSetState<'Name>, value: string) : WafregionalXssMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalXssMatchSetState<'Name>

        /// <summary>
        /// xss_match_tuple block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_xss_match_set#xss_match_tuple-1">WafregionalXssMatchSet#xss_match_tuple</a> Accepts: aws.IResolvable | aws.WafregionalXssMatchSet.WafregionalXssMatchSetXssMatchTuple[]
        /// </summary>
        [<CustomOperation "xss_match_tuple">]
        member _.XssMatchTuple(state: WafregionalXssMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalXssMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.XssMatchTuple <- value)
            state : WafregionalXssMatchSetState<'Name>

        member _.Run(state: WafregionalXssMatchSetState<Present>) : aws.WafregionalXssMatchSet.WafregionalXssMatchSet =
            let config = aws.WafregionalXssMatchSet.WafregionalXssMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalXssMatchSet.WafregionalXssMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalXssMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalXssMatchSetState<_>) : aws.WafregionalXssMatchSet.WafregionalXssMatchSet =
            Unchecked.defaultof<aws.WafregionalXssMatchSet.WafregionalXssMatchSet>
