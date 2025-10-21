namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy">azurerm_firewall_policy</a>.
    /// </summary>
    type DataAzurermFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFirewallPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermFirewallPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy#name-1">DataAzurermFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermFirewallPolicyState<Missing, 'ResourceGroupName>, value: string) : DataAzurermFirewallPolicyState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermFirewallPolicyState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy#resource_group_name-1">DataAzurermFirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermFirewallPolicyState<'Name, Missing>, value: string) : DataAzurermFirewallPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermFirewallPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy#id-1">DataAzurermFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/firewall_policy#timeouts-1">DataAzurermFirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicyTimeouts) : DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermFirewallPolicyState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermFirewallPolicyState<Present, Present>) : azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicy =
            let config = azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermFirewallPolicy: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermFirewallPolicyState<_, _>) : azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicy =
            Unchecked.defaultof<azurerm.DataAzurermFirewallPolicy.DataAzurermFirewallPolicy>
