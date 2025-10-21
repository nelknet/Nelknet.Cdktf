namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CeCostCategoryState<'Name, 'Rule, 'RuleVersion> = { assignments: ResizeArray<aws.CeCostCategory.CeCostCategoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category">aws_ce_cost_category</a>.
    /// </summary>
    type CeCostCategoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : CeCostCategoryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CeCostCategoryState<Missing, Missing, Missing>)

        member _.Zero(()) : CeCostCategoryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CeCostCategoryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#name-1">CeCostCategory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CeCostCategoryState<Missing, 'Rule, 'RuleVersion>, value: string) : CeCostCategoryState<Present, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CeCostCategoryState<Present, 'Rule, 'RuleVersion>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#rule-1">CeCostCategory#rule</a> Accepts: aws.IResolvable | aws.CeCostCategory.CeCostCategoryRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: CeCostCategoryState<'Name, Missing, 'RuleVersion>, value: HashiCorp.Cdktf.IResolvable) : CeCostCategoryState<'Name, Present, 'RuleVersion> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : CeCostCategoryState<'Name, Present, 'RuleVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#rule_version-1">CeCostCategory#rule_version</a>.
        /// </summary>
        [<CustomOperation "rule_version">]
        member _.RuleVersion(state: CeCostCategoryState<'Name, 'Rule, Missing>, value: string) : CeCostCategoryState<'Name, 'Rule, Present> =
            state.assignments.Add(fun config -> config.RuleVersion <- value)
            ({ assignments = state.assignments } : CeCostCategoryState<'Name, 'Rule, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#default_value-1">CeCostCategory#default_value</a>.
        /// </summary>
        [<CustomOperation "default_value">]
        member _.DefaultValue(state: CeCostCategoryState<'Name, 'Rule, 'RuleVersion>, value: string) : CeCostCategoryState<'Name, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.DefaultValue <- value)
            state : CeCostCategoryState<'Name, 'Rule, 'RuleVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#effective_start-1">CeCostCategory#effective_start</a>.
        /// </summary>
        [<CustomOperation "effective_start">]
        member _.EffectiveStart(state: CeCostCategoryState<'Name, 'Rule, 'RuleVersion>, value: string) : CeCostCategoryState<'Name, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.EffectiveStart <- value)
            state : CeCostCategoryState<'Name, 'Rule, 'RuleVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#id-1">CeCostCategory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CeCostCategoryState<'Name, 'Rule, 'RuleVersion>, value: string) : CeCostCategoryState<'Name, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CeCostCategoryState<'Name, 'Rule, 'RuleVersion>

        /// <summary>
        /// split_charge_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#split_charge_rule-1">CeCostCategory#split_charge_rule</a> Accepts: aws.IResolvable | aws.CeCostCategory.CeCostCategorySplitChargeRule[]
        /// </summary>
        [<CustomOperation "split_charge_rule">]
        member _.SplitChargeRule(state: CeCostCategoryState<'Name, 'Rule, 'RuleVersion>, value: HashiCorp.Cdktf.IResolvable) : CeCostCategoryState<'Name, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.SplitChargeRule <- value)
            state : CeCostCategoryState<'Name, 'Rule, 'RuleVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags-1">CeCostCategory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CeCostCategoryState<'Name, 'Rule, 'RuleVersion>, value: seq<string * string>) : CeCostCategoryState<'Name, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CeCostCategoryState<'Name, 'Rule, 'RuleVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ce_cost_category#tags_all-1">CeCostCategory#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CeCostCategoryState<'Name, 'Rule, 'RuleVersion>, value: seq<string * string>) : CeCostCategoryState<'Name, 'Rule, 'RuleVersion> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CeCostCategoryState<'Name, 'Rule, 'RuleVersion>

        member _.Run(state: CeCostCategoryState<Present, Present, Present>) : aws.CeCostCategory.CeCostCategory =
            let config = aws.CeCostCategory.CeCostCategoryConfig()
            for setter in state.assignments do
                setter config
            aws.CeCostCategory.CeCostCategory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ceCostCategory: missing required arguments. Must call: name, rule, rule_version.", 9999, IsError = true)>]
        member _.Run(_: CeCostCategoryState<_, _, _>) : aws.CeCostCategory.CeCostCategory =
            Unchecked.defaultof<aws.CeCostCategory.CeCostCategory>
