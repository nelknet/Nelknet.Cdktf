namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId> = { assignments: ResizeArray<azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list">azurerm_palo_alto_local_rulestack_fqdn_list</a>.
    /// </summary>
    type PaloAltoLocalRulestackFqdnListBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoLocalRulestackFqdnListState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackFqdnListState<Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoLocalRulestackFqdnListState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoLocalRulestackFqdnListState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#fully_qualified_domain_names-1">PaloAltoLocalRulestackFqdnList#fully_qualified_domain_names</a>.
        /// </summary>
        [<CustomOperation "fully_qualified_domain_names">]
        member _.FullyQualifiedDomainNames(state: PaloAltoLocalRulestackFqdnListState<Missing, 'Name, 'RulestackId>, value: seq<string>) : PaloAltoLocalRulestackFqdnListState<Present, 'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.FullyQualifiedDomainNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PaloAltoLocalRulestackFqdnListState<Present, 'Name, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#name-1">PaloAltoLocalRulestackFqdnList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, Missing, 'RulestackId>, value: string) : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, Present, 'RulestackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, Present, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#rulestack_id-1">PaloAltoLocalRulestackFqdnList#rulestack_id</a>.
        /// </summary>
        [<CustomOperation "rulestack_id">]
        member _.RulestackId(state: PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, Missing>, value: string) : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, Present> =
            state.assignments.Add(fun config -> config.RulestackId <- value)
            ({ assignments = state.assignments } : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#audit_comment-1">PaloAltoLocalRulestackFqdnList#audit_comment</a>.
        /// </summary>
        [<CustomOperation "audit_comment">]
        member _.AuditComment(state: PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.AuditComment <- value)
            state : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#description-1">PaloAltoLocalRulestackFqdnList#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#id-1">PaloAltoLocalRulestackFqdnList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>, value: string) : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_fqdn_list#timeouts-1">PaloAltoLocalRulestackFqdnList#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>, value: azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnListTimeouts) : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoLocalRulestackFqdnListState<'FullyQualifiedDomainNames, 'Name, 'RulestackId>

        member _.Run(state: PaloAltoLocalRulestackFqdnListState<Present, Present, Present>) : azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnList =
            let config = azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnListConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoLocalRulestackFqdnList: missing required arguments. Must call: fully_qualified_domain_names, name, rulestack_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoLocalRulestackFqdnListState<_, _, _>) : azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnList =
            Unchecked.defaultof<azurerm.PaloAltoLocalRulestackFqdnList.PaloAltoLocalRulestackFqdnList>
