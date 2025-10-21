namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> = { assignments: ResizeArray<azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection">azurerm_firewall_network_rule_collection</a>.
    /// </summary>
    type FirewallNetworkRuleCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallNetworkRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallNetworkRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FirewallNetworkRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallNetworkRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#action-1">FirewallNetworkRuleCollection#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: FirewallNetworkRuleCollectionState<Missing, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNetworkRuleCollectionState<Present, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : FirewallNetworkRuleCollectionState<Present, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#azure_firewall_name-1">FirewallNetworkRuleCollection#azure_firewall_name</a>.
        /// </summary>
        [<CustomOperation "azure_firewall_name">]
        member _.AzureFirewallName(state: FirewallNetworkRuleCollectionState<'Action, Missing, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNetworkRuleCollectionState<'Action, Present, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.AzureFirewallName <- value)
            ({ assignments = state.assignments } : FirewallNetworkRuleCollectionState<'Action, Present, 'Name, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#name-1">FirewallNetworkRuleCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, Missing, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, Present, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, Present, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#priority-1">FirewallNetworkRuleCollection#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Missing, 'ResourceGroupName, 'Rule>, value: double) : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Present, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Present, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#resource_group_name-1">FirewallNetworkRuleCollection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Missing, 'Rule>, value: string) : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Present, 'Rule> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#rule-1">FirewallNetworkRuleCollection#rule</a> Accepts: azurerm.IResolvable | azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollectionRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#id-1">FirewallNetworkRuleCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_network_rule_collection#timeouts-1">FirewallNetworkRuleCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollectionTimeouts) : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FirewallNetworkRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>

        member _.Run(state: FirewallNetworkRuleCollectionState<Present, Present, Present, Present, Present, Present>) : azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollection =
            let config = azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.firewallNetworkRuleCollection: missing required arguments. Must call: action, azure_firewall_name, name, priority, resource_group_name, rule.", 9999, IsError = true)>]
        member _.Run(_: FirewallNetworkRuleCollectionState<_, _, _, _, _, _>) : azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollection =
            Unchecked.defaultof<azurerm.FirewallNetworkRuleCollection.FirewallNetworkRuleCollection>
