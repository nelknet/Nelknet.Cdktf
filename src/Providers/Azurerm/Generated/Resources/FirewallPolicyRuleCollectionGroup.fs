namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority> = { assignments: ResizeArray<azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group">azurerm_firewall_policy_rule_collection_group</a>.
    /// </summary>
    type FirewallPolicyRuleCollectionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallPolicyRuleCollectionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallPolicyRuleCollectionGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : FirewallPolicyRuleCollectionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallPolicyRuleCollectionGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#firewall_policy_id-1">FirewallPolicyRuleCollectionGroup#firewall_policy_id</a>.
        /// </summary>
        [<CustomOperation "firewall_policy_id">]
        member _.FirewallPolicyId(state: FirewallPolicyRuleCollectionGroupState<Missing, 'Name, 'Priority>, value: string) : FirewallPolicyRuleCollectionGroupState<Present, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.FirewallPolicyId <- value)
            ({ assignments = state.assignments } : FirewallPolicyRuleCollectionGroupState<Present, 'Name, 'Priority>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#name-1">FirewallPolicyRuleCollectionGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, Missing, 'Priority>, value: string) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, Present, 'Priority> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, Present, 'Priority>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#priority-1">FirewallPolicyRuleCollectionGroup#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, Missing>, value: double) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, Present>)

        /// <summary>
        /// application_rule_collection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#application_rule_collection-1">FirewallPolicyRuleCollectionGroup#application_rule_collection</a> Accepts: azurerm.IResolvable | azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupApplicationRuleCollection[]
        /// </summary>
        [<CustomOperation "application_rule_collection">]
        member _.ApplicationRuleCollection(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>, value: HashiCorp.Cdktf.IResolvable) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.ApplicationRuleCollection <- value)
            state : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#id-1">FirewallPolicyRuleCollectionGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>, value: string) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>

        /// <summary>
        /// nat_rule_collection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#nat_rule_collection-1">FirewallPolicyRuleCollectionGroup#nat_rule_collection</a> Accepts: azurerm.IResolvable | azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupNatRuleCollection[]
        /// </summary>
        [<CustomOperation "nat_rule_collection">]
        member _.NatRuleCollection(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>, value: HashiCorp.Cdktf.IResolvable) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.NatRuleCollection <- value)
            state : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>

        /// <summary>
        /// network_rule_collection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#network_rule_collection-1">FirewallPolicyRuleCollectionGroup#network_rule_collection</a> Accepts: azurerm.IResolvable | azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupNetworkRuleCollection[]
        /// </summary>
        [<CustomOperation "network_rule_collection">]
        member _.NetworkRuleCollection(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>, value: HashiCorp.Cdktf.IResolvable) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.NetworkRuleCollection <- value)
            state : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy_rule_collection_group#timeouts-1">FirewallPolicyRuleCollectionGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>, value: azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupTimeouts) : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FirewallPolicyRuleCollectionGroupState<'FirewallPolicyId, 'Name, 'Priority>

        member _.Run(state: FirewallPolicyRuleCollectionGroupState<Present, Present, Present>) : azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroup =
            let config = azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.firewallPolicyRuleCollectionGroup: missing required arguments. Must call: firewall_policy_id, name, priority.", 9999, IsError = true)>]
        member _.Run(_: FirewallPolicyRuleCollectionGroupState<_, _, _>) : azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroup =
            Unchecked.defaultof<azurerm.FirewallPolicyRuleCollectionGroup.FirewallPolicyRuleCollectionGroup>
