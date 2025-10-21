namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubInsightState<'Filters, 'GroupByAttribute, 'Name> = { assignments: ResizeArray<aws.SecurityhubInsight.SecurityhubInsightConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight">aws_securityhub_insight</a>.
    /// </summary>
    type SecurityhubInsightBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubInsightState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubInsightState<Missing, Missing, Missing>)

        member _.Zero(()) : SecurityhubInsightState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubInsightState<Missing, Missing, Missing>)

        /// <summary>
        /// filters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#filters-1">SecurityhubInsight#filters</a>
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: SecurityhubInsightState<Missing, 'GroupByAttribute, 'Name>, value: aws.SecurityhubInsight.SecurityhubInsightFilters) : SecurityhubInsightState<Present, 'GroupByAttribute, 'Name> =
            state.assignments.Add(fun config -> config.Filters <- value)
            ({ assignments = state.assignments } : SecurityhubInsightState<Present, 'GroupByAttribute, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#group_by_attribute-1">SecurityhubInsight#group_by_attribute</a>.
        /// </summary>
        [<CustomOperation "group_by_attribute">]
        member _.GroupByAttribute(state: SecurityhubInsightState<'Filters, Missing, 'Name>, value: string) : SecurityhubInsightState<'Filters, Present, 'Name> =
            state.assignments.Add(fun config -> config.GroupByAttribute <- value)
            ({ assignments = state.assignments } : SecurityhubInsightState<'Filters, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#name-1">SecurityhubInsight#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecurityhubInsightState<'Filters, 'GroupByAttribute, Missing>, value: string) : SecurityhubInsightState<'Filters, 'GroupByAttribute, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SecurityhubInsightState<'Filters, 'GroupByAttribute, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#id-1">SecurityhubInsight#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubInsightState<'Filters, 'GroupByAttribute, 'Name>, value: string) : SecurityhubInsightState<'Filters, 'GroupByAttribute, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubInsightState<'Filters, 'GroupByAttribute, 'Name>

        member _.Run(state: SecurityhubInsightState<Present, Present, Present>) : aws.SecurityhubInsight.SecurityhubInsight =
            let config = aws.SecurityhubInsight.SecurityhubInsightConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubInsight.SecurityhubInsight(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubInsight: missing required arguments. Must call: filters, group_by_attribute, name.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubInsightState<_, _, _>) : aws.SecurityhubInsight.SecurityhubInsight =
            Unchecked.defaultof<aws.SecurityhubInsight.SecurityhubInsight>
