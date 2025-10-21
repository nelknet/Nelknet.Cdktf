namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> = { assignments: ResizeArray<azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection">azurerm_firewall_application_rule_collection</a>.
    /// </summary>
    type FirewallApplicationRuleCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallApplicationRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallApplicationRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FirewallApplicationRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallApplicationRuleCollectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#action-1">FirewallApplicationRuleCollection#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: FirewallApplicationRuleCollectionState<Missing, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallApplicationRuleCollectionState<Present, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : FirewallApplicationRuleCollectionState<Present, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#azure_firewall_name-1">FirewallApplicationRuleCollection#azure_firewall_name</a>.
        /// </summary>
        [<CustomOperation "azure_firewall_name">]
        member _.AzureFirewallName(state: FirewallApplicationRuleCollectionState<'Action, Missing, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallApplicationRuleCollectionState<'Action, Present, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.AzureFirewallName <- value)
            ({ assignments = state.assignments } : FirewallApplicationRuleCollectionState<'Action, Present, 'Name, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#name-1">FirewallApplicationRuleCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, Missing, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, Present, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, Present, 'Priority, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#priority-1">FirewallApplicationRuleCollection#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Missing, 'ResourceGroupName, 'Rule>, value: double) : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Present, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, Present, 'ResourceGroupName, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#resource_group_name-1">FirewallApplicationRuleCollection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Missing, 'Rule>, value: string) : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Present, 'Rule> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#rule-1">FirewallApplicationRuleCollection#rule</a> Accepts: azurerm.IResolvable | azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollectionRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#id-1">FirewallApplicationRuleCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: string) : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#timeouts-1">FirewallApplicationRuleCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>, value: azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollectionTimeouts) : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FirewallApplicationRuleCollectionState<'Action, 'AzureFirewallName, 'Name, 'Priority, 'ResourceGroupName, 'Rule>

        member _.Run(state: FirewallApplicationRuleCollectionState<Present, Present, Present, Present, Present, Present>) : azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollection =
            let config = azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.firewallApplicationRuleCollection: missing required arguments. Must call: action, azure_firewall_name, name, priority, resource_group_name, rule.", 9999, IsError = true)>]
        member _.Run(_: FirewallApplicationRuleCollectionState<_, _, _, _, _, _>) : azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollection =
            Unchecked.defaultof<azurerm.FirewallApplicationRuleCollection.FirewallApplicationRuleCollection>
