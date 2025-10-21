namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2RegexPatternSetState<'Scope> = { assignments: ResizeArray<aws.Wafv2RegexPatternSet.Wafv2RegexPatternSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set">aws_wafv2_regex_pattern_set</a>.
    /// </summary>
    type Wafv2RegexPatternSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2RegexPatternSetState<Missing> =
            ({ assignments = ResizeArray() } : Wafv2RegexPatternSetState<Missing>)

        member _.Zero(()) : Wafv2RegexPatternSetState<Missing> =
            ({ assignments = ResizeArray() } : Wafv2RegexPatternSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#scope-1">Wafv2RegexPatternSet#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: Wafv2RegexPatternSetState<Missing>, value: string) : Wafv2RegexPatternSetState<Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : Wafv2RegexPatternSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#description-1">Wafv2RegexPatternSet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Wafv2RegexPatternSetState<'Scope>, value: string) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Wafv2RegexPatternSetState<'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#id-1">Wafv2RegexPatternSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Wafv2RegexPatternSetState<'Scope>, value: string) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Wafv2RegexPatternSetState<'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#name-1">Wafv2RegexPatternSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Wafv2RegexPatternSetState<'Scope>, value: string) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Wafv2RegexPatternSetState<'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#name_prefix-1">Wafv2RegexPatternSet#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Wafv2RegexPatternSetState<'Scope>, value: string) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Wafv2RegexPatternSetState<'Scope>

        /// <summary>
        /// regular_expression block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#regular_expression-1">Wafv2RegexPatternSet#regular_expression</a> Accepts: aws.IResolvable | aws.Wafv2RegexPatternSet.Wafv2RegexPatternSetRegularExpression[]
        /// </summary>
        [<CustomOperation "regular_expression">]
        member _.RegularExpression(state: Wafv2RegexPatternSetState<'Scope>, value: HashiCorp.Cdktf.IResolvable) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.RegularExpression <- value)
            state : Wafv2RegexPatternSetState<'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#tags-1">Wafv2RegexPatternSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Wafv2RegexPatternSetState<'Scope>, value: seq<string * string>) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Wafv2RegexPatternSetState<'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_regex_pattern_set#tags_all-1">Wafv2RegexPatternSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Wafv2RegexPatternSetState<'Scope>, value: seq<string * string>) : Wafv2RegexPatternSetState<'Scope> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Wafv2RegexPatternSetState<'Scope>

        member _.Run(state: Wafv2RegexPatternSetState<Present>) : aws.Wafv2RegexPatternSet.Wafv2RegexPatternSet =
            let config = aws.Wafv2RegexPatternSet.Wafv2RegexPatternSetConfig()
            for setter in state.assignments do
                setter config
            aws.Wafv2RegexPatternSet.Wafv2RegexPatternSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2RegexPatternSet: missing required arguments. Must call: scope.", 9999, IsError = true)>]
        member _.Run(_: Wafv2RegexPatternSetState<_>) : aws.Wafv2RegexPatternSet.Wafv2RegexPatternSet =
            Unchecked.defaultof<aws.Wafv2RegexPatternSet.Wafv2RegexPatternSet>
