namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> = { assignments: ResizeArray<azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack">azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack</a>.
    /// </summary>
    type PaloAltoNextGenerationFirewallVirtualHubLocalRulestackBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#name-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Missing, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: string) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Present, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Present, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#network_profile-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, Missing, 'ResourceGroupName, 'RulestackId>, value: azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfile) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, Present, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, Present, 'ResourceGroupName, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#resource_group_name-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, Missing, 'RulestackId>, value: string) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, Present, 'RulestackId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, Present, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#rulestack_id-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#rulestack_id</a>.
        /// </summary>
        [<CustomOperation "rulestack_id">]
        member _.RulestackId(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, Missing>, value: string) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RulestackId <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, Present>)

        /// <summary>
        /// destination_nat block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#destination_nat-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#destination_nat</a> Accepts: azurerm.IResolvable | azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNat[]
        /// </summary>
        [<CustomOperation "destination_nat">]
        member _.DestinationNat(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.DestinationNat <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// dns_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#dns_settings-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#dns_settings</a>
        /// </summary>
        [<CustomOperation "dns_settings">]
        member _.DnsSettings(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettings) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.DnsSettings <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#id-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: string) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#tags-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: seq<string * string>) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_local_rulestack#timeouts-1">PaloAltoNextGenerationFirewallVirtualHubLocalRulestack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeouts) : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        member _.Run(state: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<Present, Present, Present, Present>) : azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack =
            let config = azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestackConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoNextGenerationFirewallVirtualHubLocalRulestack: missing required arguments. Must call: name, network_profile, resource_group_name, rulestack_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoNextGenerationFirewallVirtualHubLocalRulestackState<_, _, _, _>) : azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack =
            Unchecked.defaultof<azurerm.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack.PaloAltoNextGenerationFirewallVirtualHubLocalRulestack>
