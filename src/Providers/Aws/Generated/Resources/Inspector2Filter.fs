namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Inspector2FilterState<'Action, 'Name> = { assignments: ResizeArray<aws.Inspector2Filter.Inspector2FilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter">aws_inspector2_filter</a>.
    /// </summary>
    type Inspector2FilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Inspector2FilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Inspector2FilterState<Missing, Missing>)

        member _.Zero(()) : Inspector2FilterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Inspector2FilterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#action-1">Inspector2Filter#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: Inspector2FilterState<Missing, 'Name>, value: string) : Inspector2FilterState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : Inspector2FilterState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#name-1">Inspector2Filter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Inspector2FilterState<'Action, Missing>, value: string) : Inspector2FilterState<'Action, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Inspector2FilterState<'Action, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#description-1">Inspector2Filter#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Inspector2FilterState<'Action, 'Name>, value: string) : Inspector2FilterState<'Action, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Inspector2FilterState<'Action, 'Name>

        /// <summary>
        /// filter_criteria block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#filter_criteria-1">Inspector2Filter#filter_criteria</a> Accepts: aws.IResolvable | aws.Inspector2Filter.Inspector2FilterFilterCriteria[]
        /// </summary>
        [<CustomOperation "filter_criteria">]
        member _.FilterCriteria(state: Inspector2FilterState<'Action, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Inspector2FilterState<'Action, 'Name> =
            state.assignments.Add(fun config -> config.FilterCriteria <- value)
            state : Inspector2FilterState<'Action, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#reason-1">Inspector2Filter#reason</a>.
        /// </summary>
        [<CustomOperation "reason">]
        member _.Reason(state: Inspector2FilterState<'Action, 'Name>, value: string) : Inspector2FilterState<'Action, 'Name> =
            state.assignments.Add(fun config -> config.Reason <- value)
            state : Inspector2FilterState<'Action, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#tags-1">Inspector2Filter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Inspector2FilterState<'Action, 'Name>, value: seq<string * string>) : Inspector2FilterState<'Action, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Inspector2FilterState<'Action, 'Name>

        member _.Run(state: Inspector2FilterState<Present, Present>) : aws.Inspector2Filter.Inspector2Filter =
            let config = aws.Inspector2Filter.Inspector2FilterConfig()
            for setter in state.assignments do
                setter config
            aws.Inspector2Filter.Inspector2Filter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspector2Filter: missing required arguments. Must call: action, name.", 9999, IsError = true)>]
        member _.Run(_: Inspector2FilterState<_, _>) : aws.Inspector2Filter.Inspector2Filter =
            Unchecked.defaultof<aws.Inspector2Filter.Inspector2Filter>
