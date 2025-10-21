namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafSqlInjectionMatchSetState<'Name> = { assignments: ResizeArray<aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_sql_injection_match_set">aws_waf_sql_injection_match_set</a>.
    /// </summary>
    type WafSqlInjectionMatchSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafSqlInjectionMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafSqlInjectionMatchSetState<Missing>)

        member _.Zero(()) : WafSqlInjectionMatchSetState<Missing> =
            ({ assignments = ResizeArray() } : WafSqlInjectionMatchSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_sql_injection_match_set#name-1">WafSqlInjectionMatchSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafSqlInjectionMatchSetState<Missing>, value: string) : WafSqlInjectionMatchSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafSqlInjectionMatchSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_sql_injection_match_set#id-1">WafSqlInjectionMatchSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafSqlInjectionMatchSetState<'Name>, value: string) : WafSqlInjectionMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafSqlInjectionMatchSetState<'Name>

        /// <summary>
        /// sql_injection_match_tuples block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_sql_injection_match_set#sql_injection_match_tuples-1">WafSqlInjectionMatchSet#sql_injection_match_tuples</a> Accepts: aws.IResolvable | aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSetSqlInjectionMatchTuples[]
        /// </summary>
        [<CustomOperation "sql_injection_match_tuples">]
        member _.SqlInjectionMatchTuples(state: WafSqlInjectionMatchSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafSqlInjectionMatchSetState<'Name> =
            state.assignments.Add(fun config -> config.SqlInjectionMatchTuples <- value)
            state : WafSqlInjectionMatchSetState<'Name>

        member _.Run(state: WafSqlInjectionMatchSetState<Present>) : aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSet =
            let config = aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSetConfig()
            for setter in state.assignments do
                setter config
            aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafSqlInjectionMatchSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafSqlInjectionMatchSetState<_>) : aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSet =
            Unchecked.defaultof<aws.WafSqlInjectionMatchSet.WafSqlInjectionMatchSet>
