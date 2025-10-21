namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank> = { assignments: ResizeArray<aws.GuarddutyFilter.GuarddutyFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter">aws_guardduty_filter</a>.
    /// </summary>
    type GuarddutyFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyFilterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyFilterState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyFilterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyFilterState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#action-1">GuarddutyFilter#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: GuarddutyFilterState<Missing, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>, value: string) : GuarddutyFilterState<Present, 'DetectorId, 'FindingCriteria, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : GuarddutyFilterState<Present, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#detector_id-1">GuarddutyFilter#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyFilterState<'Action, Missing, 'FindingCriteria, 'Name, 'Rank>, value: string) : GuarddutyFilterState<'Action, Present, 'FindingCriteria, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyFilterState<'Action, Present, 'FindingCriteria, 'Name, 'Rank>)

        /// <summary>
        /// finding_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#finding_criteria-1">GuarddutyFilter#finding_criteria</a>
        /// </summary>
        [<CustomOperation "finding_criteria">]
        member _.FindingCriteria(state: GuarddutyFilterState<'Action, 'DetectorId, Missing, 'Name, 'Rank>, value: aws.GuarddutyFilter.GuarddutyFilterFindingCriteria) : GuarddutyFilterState<'Action, 'DetectorId, Present, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.FindingCriteria <- value)
            ({ assignments = state.assignments } : GuarddutyFilterState<'Action, 'DetectorId, Present, 'Name, 'Rank>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#name-1">GuarddutyFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, Missing, 'Rank>, value: string) : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, Present, 'Rank> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, Present, 'Rank>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#rank-1">GuarddutyFilter#rank</a>.
        /// </summary>
        [<CustomOperation "rank">]
        member _.Rank(state: GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, Missing>, value: double) : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, Present> =
            state.assignments.Add(fun config -> config.Rank <- value)
            ({ assignments = state.assignments } : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#description-1">GuarddutyFilter#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>, value: string) : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#id-1">GuarddutyFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>, value: string) : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#tags-1">GuarddutyFilter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>, value: seq<string * string>) : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#tags_all-1">GuarddutyFilter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>, value: seq<string * string>) : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GuarddutyFilterState<'Action, 'DetectorId, 'FindingCriteria, 'Name, 'Rank>

        member _.Run(state: GuarddutyFilterState<Present, Present, Present, Present, Present>) : aws.GuarddutyFilter.GuarddutyFilter =
            let config = aws.GuarddutyFilter.GuarddutyFilterConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyFilter.GuarddutyFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyFilter: missing required arguments. Must call: action, detector_id, finding_criteria, name, rank.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyFilterState<_, _, _, _, _>) : aws.GuarddutyFilter.GuarddutyFilter =
            Unchecked.defaultof<aws.GuarddutyFilter.GuarddutyFilter>
