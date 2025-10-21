namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafv2RegexPatternSetState<'Name, 'Scope> = { assignments: ResizeArray<aws.DataAwsWafv2RegexPatternSet.DataAwsWafv2RegexPatternSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_regex_pattern_set">aws_wafv2_regex_pattern_set</a>.
    /// </summary>
    type DataAwsWafv2RegexPatternSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafv2RegexPatternSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2RegexPatternSetState<Missing, Missing>)

        member _.Zero(()) : DataAwsWafv2RegexPatternSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2RegexPatternSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_regex_pattern_set#name-1">DataAwsWafv2RegexPatternSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafv2RegexPatternSetState<Missing, 'Scope>, value: string) : DataAwsWafv2RegexPatternSetState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafv2RegexPatternSetState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_regex_pattern_set#scope-1">DataAwsWafv2RegexPatternSet#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAwsWafv2RegexPatternSetState<'Name, Missing>, value: string) : DataAwsWafv2RegexPatternSetState<'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : DataAwsWafv2RegexPatternSetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_regex_pattern_set#id-1">DataAwsWafv2RegexPatternSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafv2RegexPatternSetState<'Name, 'Scope>, value: string) : DataAwsWafv2RegexPatternSetState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafv2RegexPatternSetState<'Name, 'Scope>

        member _.Run(state: DataAwsWafv2RegexPatternSetState<Present, Present>) : aws.DataAwsWafv2RegexPatternSet.DataAwsWafv2RegexPatternSet =
            let config = aws.DataAwsWafv2RegexPatternSet.DataAwsWafv2RegexPatternSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafv2RegexPatternSet.DataAwsWafv2RegexPatternSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafv2RegexPatternSet: missing required arguments. Must call: name, scope.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafv2RegexPatternSetState<_, _>) : aws.DataAwsWafv2RegexPatternSet.DataAwsWafv2RegexPatternSet =
            Unchecked.defaultof<aws.DataAwsWafv2RegexPatternSet.DataAwsWafv2RegexPatternSet>
