namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueDataQualityRulesetState<'Name, 'Ruleset> = { assignments: ResizeArray<aws.GlueDataQualityRuleset.GlueDataQualityRulesetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset">aws_glue_data_quality_ruleset</a>.
    /// </summary>
    type GlueDataQualityRulesetBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueDataQualityRulesetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueDataQualityRulesetState<Missing, Missing>)

        member _.Zero(()) : GlueDataQualityRulesetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueDataQualityRulesetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#name-1">GlueDataQualityRuleset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueDataQualityRulesetState<Missing, 'Ruleset>, value: string) : GlueDataQualityRulesetState<Present, 'Ruleset> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueDataQualityRulesetState<Present, 'Ruleset>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#ruleset-1">GlueDataQualityRuleset#ruleset</a>.
        /// </summary>
        [<CustomOperation "ruleset">]
        member _.Ruleset(state: GlueDataQualityRulesetState<'Name, Missing>, value: string) : GlueDataQualityRulesetState<'Name, Present> =
            state.assignments.Add(fun config -> config.Ruleset <- value)
            ({ assignments = state.assignments } : GlueDataQualityRulesetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#description-1">GlueDataQualityRuleset#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueDataQualityRulesetState<'Name, 'Ruleset>, value: string) : GlueDataQualityRulesetState<'Name, 'Ruleset> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueDataQualityRulesetState<'Name, 'Ruleset>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#id-1">GlueDataQualityRuleset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueDataQualityRulesetState<'Name, 'Ruleset>, value: string) : GlueDataQualityRulesetState<'Name, 'Ruleset> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueDataQualityRulesetState<'Name, 'Ruleset>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#tags-1">GlueDataQualityRuleset#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueDataQualityRulesetState<'Name, 'Ruleset>, value: seq<string * string>) : GlueDataQualityRulesetState<'Name, 'Ruleset> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueDataQualityRulesetState<'Name, 'Ruleset>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#tags_all-1">GlueDataQualityRuleset#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueDataQualityRulesetState<'Name, 'Ruleset>, value: seq<string * string>) : GlueDataQualityRulesetState<'Name, 'Ruleset> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueDataQualityRulesetState<'Name, 'Ruleset>

        /// <summary>
        /// target_table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_quality_ruleset#target_table-1">GlueDataQualityRuleset#target_table</a>
        /// </summary>
        [<CustomOperation "target_table">]
        member _.TargetTable(state: GlueDataQualityRulesetState<'Name, 'Ruleset>, value: aws.GlueDataQualityRuleset.GlueDataQualityRulesetTargetTable) : GlueDataQualityRulesetState<'Name, 'Ruleset> =
            state.assignments.Add(fun config -> config.TargetTable <- value)
            state : GlueDataQualityRulesetState<'Name, 'Ruleset>

        member _.Run(state: GlueDataQualityRulesetState<Present, Present>) : aws.GlueDataQualityRuleset.GlueDataQualityRuleset =
            let config = aws.GlueDataQualityRuleset.GlueDataQualityRulesetConfig()
            for setter in state.assignments do
                setter config
            aws.GlueDataQualityRuleset.GlueDataQualityRuleset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueDataQualityRuleset: missing required arguments. Must call: name, ruleset.", 9999, IsError = true)>]
        member _.Run(_: GlueDataQualityRulesetState<_, _>) : aws.GlueDataQualityRuleset.GlueDataQualityRuleset =
            Unchecked.defaultof<aws.GlueDataQualityRuleset.GlueDataQualityRuleset>
