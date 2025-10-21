namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafByteMatchSetState<'Name> = { assignments: ResizeArray<aws.WafByteMatchSet.WafByteMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set">aws_waf_byte_match_set</a>.
    /// </summary>
    type WafByteMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafByteMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafByteMatchSetState<Missing>)

        member _.Zero(()) : WafByteMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafByteMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#name-1">WafByteMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafByteMatchSetState<Missing>, value: string) : WafByteMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafByteMatchSetState<Present>)

        /// <summary>
        /// byte_match_tuples block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#byte_match_tuples-1">WafByteMatchSet#byte_match_tuples</a> Accepts: aws.IResolvable | aws.WafByteMatchSet.WafByteMatchSetByteMatchTuples[]
        /// </summary>
        [<CustomOperation "byte_match_tuples">]
        member _.ByteMatchTuples(state: WafByteMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafByteMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.ByteMatchTuples <- value)
            state : WafByteMatchSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_byte_match_set#id-1">WafByteMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafByteMatchSetState<'Name>, value: string) : WafByteMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafByteMatchSetState<'Name>

        member _.Run(state: WafByteMatchSetState<Present>) : aws.WafByteMatchSet.WafByteMatchSet =
            let config = aws.WafByteMatchSet.WafByteMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafByteMatchSet.WafByteMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafByteMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafByteMatchSetState<_>) : aws.WafByteMatchSet.WafByteMatchSet =
            Unchecked.defaultof<aws.WafByteMatchSet.WafByteMatchSet>
