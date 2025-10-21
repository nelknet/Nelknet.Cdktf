namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list">azurerm_palo_alto_local_rulestack_prefix_list</a>.
    /// </summary>
    type PaloAltoLocalRulestackPrefixListBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackPrefixListState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackPrefixListState<Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackPrefixListState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackPrefixListState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#name-1">PaloAltoLocalRulestackPrefixList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoLocalRulestackPrefixListState<Missing, 'PrefixList, 'RulestackId>, value: string) : PaloAltoLocalRulestackPrefixListState<Present, 'PrefixList, 'RulestackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackPrefixListState<Present, 'PrefixList, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#prefix_list-1">PaloAltoLocalRulestackPrefixList#prefix_list</a>.
        /// </summary>
        [<CustomOperation "prefix_list">]
        member _.PrefixList(state: PaloAltoLocalRulestackPrefixListState<'Name, Missing, 'RulestackId>, value: seq<string>) : PaloAltoLocalRulestackPrefixListState<'Name, Present, 'RulestackId> =
            state.assignments.Add(fun config -> config.PrefixList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PaloAltoLocalRulestackPrefixListState<'Name, Present, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#rulestack_id-1">PaloAltoLocalRulestackPrefixList#rulestack_id</a>.
        /// </summary>
        [<CustomOperation "rulestack_id">]
        member _.RulestackId(state: PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, Missing>, value: string) : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, Present> =
            state.assignments.Add(fun config -> config.RulestackId <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#audit_comment-1">PaloAltoLocalRulestackPrefixList#audit_comment</a>.
        /// </summary>
        [<CustomOperation "audit_comment">]
        member _.AuditComment(state: PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>, value: string) : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId> =
            state.assignments.Add(fun config -> config.AuditComment <- value)
            state : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#description-1">PaloAltoLocalRulestackPrefixList#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>, value: string) : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#id-1">PaloAltoLocalRulestackPrefixList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>, value: string) : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_prefix_list#timeouts-1">PaloAltoLocalRulestackPrefixList#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>, value: azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixListTimeouts) : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackPrefixListState<'Name, 'PrefixList, 'RulestackId>

        member _.Run(state: PaloAltoLocalRulestackPrefixListState<Present, Present, Present>) : azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixList =
            let config = azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixListConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestackPrefixList: missing required arguments. Must call: name, prefix_list, rulestack_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackPrefixListState<_, _, _>) : azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixList =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestackPrefixList.PaloAltoLocalRulestackPrefixList>
