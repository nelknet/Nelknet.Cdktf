namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy">azurerm_cdn_frontdoor_firewall_policy</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorFirewallPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorFirewallPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy#name-1">DataAzurermCdnFrontdoorFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorFirewallPolicyState<Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorFirewallPolicyState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorFirewallPolicyState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy#resource_group_name-1">DataAzurermCdnFrontdoorFirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorFirewallPolicyState<'Name, Missing>, value: string) : DataAzurermCdnFrontdoorFirewallPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorFirewallPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy#id-1">DataAzurermCdnFrontdoorFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_firewall_policy#timeouts-1">DataAzurermCdnFrontdoorFirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicyTimeouts) : DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorFirewallPolicyState<Present, Present>) : azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicy =
            let config = azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorFirewallPolicy: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorFirewallPolicyState<_, _>) : azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicy =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorFirewallPolicy.DataAzurermCdnFrontdoorFirewallPolicy>
