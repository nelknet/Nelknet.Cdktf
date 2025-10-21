namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalByteMatchSetState<'Name> = { assignments: ResizeArray<aws.WafregionalByteMatchSet.WafregionalByteMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set">aws_wafregional_byte_match_set</a>.
    /// </summary>
    type WafregionalByteMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalByteMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalByteMatchSetState<Missing>)

        member _.Zero(()) : WafregionalByteMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalByteMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#name-1">WafregionalByteMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalByteMatchSetState<Missing>, value: string) : WafregionalByteMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalByteMatchSetState<Present>)

        /// <summary>
        /// byte_match_tuples block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#byte_match_tuples-1">WafregionalByteMatchSet#byte_match_tuples</a> Accepts: aws.IResolvable | aws.WafregionalByteMatchSet.WafregionalByteMatchSetByteMatchTuples[]
        /// </summary>
        [<CustomOperation "byte_match_tuples">]
        member _.ByteMatchTuples(state: WafregionalByteMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalByteMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.ByteMatchTuples <- value)
            state : WafregionalByteMatchSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_byte_match_set#id-1">WafregionalByteMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalByteMatchSetState<'Name>, value: string) : WafregionalByteMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalByteMatchSetState<'Name>

        member _.Run(state: WafregionalByteMatchSetState<Present>) : aws.WafregionalByteMatchSet.WafregionalByteMatchSet =
            let config = aws.WafregionalByteMatchSet.WafregionalByteMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalByteMatchSet.WafregionalByteMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalByteMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalByteMatchSetState<_>) : aws.WafregionalByteMatchSet.WafregionalByteMatchSet =
            Unchecked.defaultof<aws.WafregionalByteMatchSet.WafregionalByteMatchSet>
