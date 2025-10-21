namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy">azurerm_cdn_frontdoor_firewall_policy</a>.
    /// </summary>
    type CdnFrontdoorFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorFirewallPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorFirewallPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorFirewallPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorFirewallPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#mode-1">CdnFrontdoorFirewallPolicy#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: CdnFrontdoorFirewallPolicyState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorFirewallPolicyState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Mode <- value)
            ({ assignments = state.assignments } : CdnFrontdoorFirewallPolicyState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#name-1">CdnFrontdoorFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorFirewallPolicyState<'Mode, Missing, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorFirewallPolicyState<'Mode, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorFirewallPolicyState<'Mode, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#resource_group_name-1">CdnFrontdoorFirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, Missing, 'SkuName>, value: string) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#sku_name-1">CdnFrontdoorFirewallPolicy#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, Missing>, value: string) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#custom_block_response_body-1">CdnFrontdoorFirewallPolicy#custom_block_response_body</a>.
        /// </summary>
        [<CustomOperation "custom_block_response_body">]
        member _.CustomBlockResponseBody(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomBlockResponseBody <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#custom_block_response_status_code-1">CdnFrontdoorFirewallPolicy#custom_block_response_status_code</a>.
        /// </summary>
        [<CustomOperation "custom_block_response_status_code">]
        member _.CustomBlockResponseStatusCode(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: double) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomBlockResponseStatusCode <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// custom_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#custom_rule-1">CdnFrontdoorFirewallPolicy#custom_rule</a> Accepts: azurerm.IResolvable | azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyCustomRule[]
        /// </summary>
        [<CustomOperation "custom_rule">]
        member _.CustomRule(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomRule <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#enabled-1">CdnFrontdoorFirewallPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#enabled-1">CdnFrontdoorFirewallPolicy#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#id-1">CdnFrontdoorFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// managed_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#managed_rule-1">CdnFrontdoorFirewallPolicy#managed_rule</a> Accepts: azurerm.IResolvable | azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyManagedRule[]
        /// </summary>
        [<CustomOperation "managed_rule">]
        member _.ManagedRule(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ManagedRule <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#redirect_url-1">CdnFrontdoorFirewallPolicy#redirect_url</a>.
        /// </summary>
        [<CustomOperation "redirect_url">]
        member _.RedirectUrl(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.RedirectUrl <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#request_body_check_enabled-1">CdnFrontdoorFirewallPolicy#request_body_check_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "request_body_check_enabled">]
        member _.RequestBodyCheckEnabled(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.RequestBodyCheckEnabled <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#request_body_check_enabled-1">CdnFrontdoorFirewallPolicy#request_body_check_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "request_body_check_enabled">]
        member _.RequestBodyCheckEnabled(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.RequestBodyCheckEnabled <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#tags-1">CdnFrontdoorFirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_firewall_policy#timeouts-1">CdnFrontdoorFirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyTimeouts) : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorFirewallPolicyState<'Mode, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: CdnFrontdoorFirewallPolicyState<Present, Present, Present, Present>) : azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicy =
            let config = azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorFirewallPolicy: missing required arguments. Must call: mode, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorFirewallPolicyState<_, _, _, _>) : azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicy =
            Unchecked.defaultof<azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicy>
