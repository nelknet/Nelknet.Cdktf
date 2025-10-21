namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> = { assignments: ResizeArray<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack">azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack</a>.
    /// </summary>
    type PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#name-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Missing, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Present, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Present, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#network_profile-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, Missing, 'ResourceGroupName, 'RulestackId>, value: azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfile) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, Present, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, Present, 'ResourceGroupName, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#resource_group_name-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, Missing, 'RulestackId>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, Present, 'RulestackId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, Present, 'RulestackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#rulestack_id-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#rulestack_id</a>.
        /// </summary>
        [<CustomOperation "rulestack_id">]
        member _.RulestackId(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, Missing>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RulestackId <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, Present>)

        /// <summary>
        /// destination_nat block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#destination_nat-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#destination_nat</a> Accepts: azurerm.IResolvable | azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNat[]
        /// </summary>
        [<CustomOperation "destination_nat">]
        member _.DestinationNat(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.DestinationNat <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// dns_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#dns_settings-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#dns_settings</a>
        /// </summary>
        [<CustomOperation "dns_settings">]
        member _.DnsSettings(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettings) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.DnsSettings <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#id-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#tags-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: seq<string * string>) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_local_rulestack#timeouts-1">PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>, value: azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeouts) : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<'Name, 'NetworkProfile, 'ResourceGroupName, 'RulestackId>

        member _.Run(state: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<Present, Present, Present, Present>) : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack =
            let config = azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoNextGenerationFirewallVirtualNetworkLocalRulestack: missing required arguments. Must call: name, network_profile, resource_group_name, rulestack_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackState<_, _, _, _>) : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack =
            Unchecked.defaultof<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack.PaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack>
