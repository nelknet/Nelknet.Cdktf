namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, 'RuleName> = { assignments: ResizeArray<aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule">aws_accessanalyzer_archive_rule</a>.
    /// </summary>
    type AccessanalyzerArchiveRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AccessanalyzerArchiveRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AccessanalyzerArchiveRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : AccessanalyzerArchiveRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AccessanalyzerArchiveRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#analyzer_name-1">AccessanalyzerArchiveRule#analyzer_name</a>.
        /// </summary>
        [<CustomOperation "analyzer_name">]
        member _.AnalyzerName(state: AccessanalyzerArchiveRuleState<Missing, 'Filter, 'RuleName>, value: string) : AccessanalyzerArchiveRuleState<Present, 'Filter, 'RuleName> =
            state.assignments.Add(fun config -> config.AnalyzerName <- value)
            ({ assignments = state.assignments } : AccessanalyzerArchiveRuleState<Present, 'Filter, 'RuleName>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#filter-1">AccessanalyzerArchiveRule#filter</a> Accepts: aws.IResolvable | aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRuleFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: AccessanalyzerArchiveRuleState<'AnalyzerName, Missing, 'RuleName>, value: HashiCorp.Cdktf.IResolvable) : AccessanalyzerArchiveRuleState<'AnalyzerName, Present, 'RuleName> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : AccessanalyzerArchiveRuleState<'AnalyzerName, Present, 'RuleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#rule_name-1">AccessanalyzerArchiveRule#rule_name</a>.
        /// </summary>
        [<CustomOperation "rule_name">]
        member _.RuleName(state: AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, Missing>, value: string) : AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, Present> =
            state.assignments.Add(fun config -> config.RuleName <- value)
            ({ assignments = state.assignments } : AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/accessanalyzer_archive_rule#id-1">AccessanalyzerArchiveRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, 'RuleName>, value: string) : AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, 'RuleName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AccessanalyzerArchiveRuleState<'AnalyzerName, 'Filter, 'RuleName>

        member _.Run(state: AccessanalyzerArchiveRuleState<Present, Present, Present>) : aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRule =
            let config = aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRuleConfig()
            for setter in state.assignments do
                setter config
            aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.accessanalyzerArchiveRule: missing required arguments. Must call: analyzer_name, filter, rule_name.", 9999, IsError = true)>]
        member _.Run(_: AccessanalyzerArchiveRuleState<_, _, _>) : aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRule =
            Unchecked.defaultof<aws.AccessanalyzerArchiveRule.AccessanalyzerArchiveRule>
