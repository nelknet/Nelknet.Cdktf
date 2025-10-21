namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> = { assignments: ResizeArray<azurerm.FirewallNatRuleCollection.FirewallNatRuleCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection">azurerm_firewall_nat_rule_collection</a>.
    /// </summary>
    type FirewallNatRuleCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallNatRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallNatRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FirewallNatRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallNatRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#action-1">FirewallNatRuleCollection#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: FirewallNatRuleCollectionState<Missing, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNatRuleCollectionState<Present, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : FirewallNatRuleCollectionState<Present, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#azure_firewall_name-1">FirewallNatRuleCollection#azure_firewall_name</a>.
        /// </summary>
        [<CustomOperation "azure_firewall_name">]
        member _.AzureFirewallName(state: FirewallNatRuleCollectionState<'Action, Missing, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNatRuleCollectionState<'Action, Present, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.AzureFirewallName <- value)
            ({ assignments = state.assignments } : FirewallNatRuleCollectionState<'Action, Present, 'Name, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#name-1">FirewallNatRuleCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, Missing, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, Present, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, Present, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#priority-1">FirewallNatRuleCollection#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Missing, 'ResourceGroupName, 'Rule>, value: double) : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Present, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Present, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#resource_group_name-1">FirewallNatRuleCollection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Missing, 'Rule>, value: string) : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Present, 'Rule> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#rule-1">FirewallNatRuleCollection#rule</a> Accepts: azurerm.IResolvable | azurerm.FirewallNatRuleCollection.FirewallNatRuleCollectionRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#id-1">FirewallNatRuleCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_nat_rule_collection#timeouts-1">FirewallNatRuleCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: azurerm.FirewallNatRuleCollection.FirewallNatRuleCollectionTimeouts) : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FirewallNatRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>

        member _.Run(state: FirewallNatRuleCollectionState<Present, Present, Present, Present, Present, Present>) : azurerm.FirewallNatRuleCollection.FirewallNatRuleCollection =
            let config = azurerm.FirewallNatRuleCollection.FirewallNatRuleCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.FirewallNatRuleCollection.FirewallNatRuleCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.firewallNatRuleCollection: missing required arguments. Must call: action, azure_firewall_name, name, priority, resource_group_name, rule.", 9999, IsError = true)>]
        member _.Run(_: FirewallNatRuleCollectionState<_, _, _, _, _, _>) : azurerm.FirewallNatRuleCollection.FirewallNatRuleCollection =
            Unchecked.defaultof<azurerm.FirewallNatRuleCollection.FirewallNatRuleCollection>
