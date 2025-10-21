namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2FindingsFilterState<'Action, 'FindingCriteria> = { assignments: ResizeArray<aws.Macie2FindingsFilter.Macie2FindingsFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter">aws_macie2_findings_filter</a>.
    /// </summary>
    type Macie2FindingsFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2FindingsFilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Macie2FindingsFilterState<Missing, Missing>)

        member _.Zero(()) : Macie2FindingsFilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Macie2FindingsFilterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#action-1">Macie2FindingsFilter#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: Macie2FindingsFilterState<Missing, 'FindingCriteria>, value: string) : Macie2FindingsFilterState<Present, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : Macie2FindingsFilterState<Present, 'FindingCriteria>)

        /// <summary>
        /// finding_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#finding_criteria-1">Macie2FindingsFilter#finding_criteria</a>
        /// </summary>
        [<CustomOperation "finding_criteria">]
        member _.FindingCriteria(state: Macie2FindingsFilterState<'Action, Missing>, value: aws.Macie2FindingsFilter.Macie2FindingsFilterFindingCriteria) : Macie2FindingsFilterState<'Action, Present> =
            state.assignments.Add(fun config -> config.FindingCriteria <- value)
            ({ assignments = state.assignments } : Macie2FindingsFilterState<'Action, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#description-1">Macie2FindingsFilter#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: string) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#id-1">Macie2FindingsFilter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: string) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#name-1">Macie2FindingsFilter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: string) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#name_prefix-1">Macie2FindingsFilter#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: string) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#position-1">Macie2FindingsFilter#position</a>.
        /// </summary>
        [<CustomOperation "position">]
        member _.Position(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: double) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Position <- value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#tags-1">Macie2FindingsFilter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: seq<string * string>) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#tags_all-1">Macie2FindingsFilter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: seq<string * string>) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#timeouts-1">Macie2FindingsFilter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Macie2FindingsFilterState<'Action, 'FindingCriteria>, value: aws.Macie2FindingsFilter.Macie2FindingsFilterTimeouts) : Macie2FindingsFilterState<'Action, 'FindingCriteria> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Macie2FindingsFilterState<'Action, 'FindingCriteria>

        member _.Run(state: Macie2FindingsFilterState<Present, Present>) : aws.Macie2FindingsFilter.Macie2FindingsFilter =
            let config = aws.Macie2FindingsFilter.Macie2FindingsFilterConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2FindingsFilter.Macie2FindingsFilter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.macie2FindingsFilter: missing required arguments. Must call: action, finding_criteria.", 9999, IsError = true)>]
        member _.Run(_: Macie2FindingsFilterState<_, _>) : aws.Macie2FindingsFilter.Macie2FindingsFilter =
            Unchecked.defaultof<aws.Macie2FindingsFilter.Macie2FindingsFilter>
