namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy">azurerm_frontdoor_firewall_policy</a>.
    /// </summary>
    type FrontdoorFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : FrontdoorFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorFirewallPolicyState<Missing, Missing>)

        member _.Zero(()) : FrontdoorFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorFirewallPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#name-1">FrontdoorFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FrontdoorFirewallPolicyState<Missing, 'ResourceGroupName>, value: string) : FrontdoorFirewallPolicyState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FrontdoorFirewallPolicyState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#resource_group_name-1">FrontdoorFirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FrontdoorFirewallPolicyState<'Name, Missing>, value: string) : FrontdoorFirewallPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FrontdoorFirewallPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#custom_block_response_body-1">FrontdoorFirewallPolicy#custom_block_response_body</a>.
        /// </summary>
        [<CustomOperation "custom_block_response_body">]
        member _.CustomBlockResponseBody(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomBlockResponseBody <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#custom_block_response_status_code-1">FrontdoorFirewallPolicy#custom_block_response_status_code</a>.
        /// </summary>
        [<CustomOperation "custom_block_response_status_code">]
        member _.CustomBlockResponseStatusCode(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: double) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomBlockResponseStatusCode <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// custom_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#custom_rule-1">FrontdoorFirewallPolicy#custom_rule</a> Accepts: azurerm.IResolvable | azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicyCustomRule[]
        /// </summary>
        [<CustomOperation "custom_rule">]
        member _.CustomRule(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomRule <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#enabled-1">FrontdoorFirewallPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: bool) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#enabled-1">FrontdoorFirewallPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#id-1">FrontdoorFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// managed_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#managed_rule-1">FrontdoorFirewallPolicy#managed_rule</a> Accepts: azurerm.IResolvable | azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicyManagedRule[]
        /// </summary>
        [<CustomOperation "managed_rule">]
        member _.ManagedRule(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedRule <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#mode-1">FrontdoorFirewallPolicy#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#redirect_url-1">FrontdoorFirewallPolicy#redirect_url</a>.
        /// </summary>
        [<CustomOperation "redirect_url">]
        member _.RedirectUrl(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RedirectUrl <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#tags-1">FrontdoorFirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: seq<string * string>) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_firewall_policy#timeouts-1">FrontdoorFirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>, value: azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicyTimeouts) : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FrontdoorFirewallPolicyState<'Name, 'ResourceGroupName>

        member _.Run(state: FrontdoorFirewallPolicyState<Present, Present>) : azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicy =
            let config = azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.frontdoorFirewallPolicy: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: FrontdoorFirewallPolicyState<_, _>) : azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicy =
            Unchecked.defaultof<azurerm.FrontdoorFirewallPolicy.FrontdoorFirewallPolicy>
