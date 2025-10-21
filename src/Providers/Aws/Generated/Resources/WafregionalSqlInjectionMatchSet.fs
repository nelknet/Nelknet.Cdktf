namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalSqlInjectionMatchSetState<'Name> = { assignments: ResizeArray<aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_sql_injection_match_set">aws_wafregional_sql_injection_match_set</a>.
    /// </summary>
    type WafregionalSqlInjectionMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalSqlInjectionMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalSqlInjectionMatchSetState<Missing>)

        member _.Zero(()) : WafregionalSqlInjectionMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalSqlInjectionMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_sql_injection_match_set#name-1">WafregionalSqlInjectionMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalSqlInjectionMatchSetState<Missing>, value: string) : WafregionalSqlInjectionMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalSqlInjectionMatchSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_sql_injection_match_set#id-1">WafregionalSqlInjectionMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalSqlInjectionMatchSetState<'Name>, value: string) : WafregionalSqlInjectionMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalSqlInjectionMatchSetState<'Name>

        /// <summary>
        /// sql_injection_match_tuple block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_sql_injection_match_set#sql_injection_match_tuple-1">WafregionalSqlInjectionMatchSet#sql_injection_match_tuple</a> Accepts: aws.IResolvable | aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSetSqlInjectionMatchTuple[]
        /// </summary>
        [<CustomOperation "sql_injection_match_tuple">]
        member _.SqlInjectionMatchTuple(state: WafregionalSqlInjectionMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalSqlInjectionMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.SqlInjectionMatchTuple <- value)
            state : WafregionalSqlInjectionMatchSetState<'Name>

        member _.Run(state: WafregionalSqlInjectionMatchSetState<Present>) : aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSet =
            let config = aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalSqlInjectionMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalSqlInjectionMatchSetState<_>) : aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSet =
            Unchecked.defaultof<aws.WafregionalSqlInjectionMatchSet.WafregionalSqlInjectionMatchSet>
