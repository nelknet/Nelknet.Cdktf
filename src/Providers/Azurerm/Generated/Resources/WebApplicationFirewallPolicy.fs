namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy">azurerm_web_application_firewall_policy</a>.
    /// </summary>
    type WebApplicationFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebApplicationFirewallPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebApplicationFirewallPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WebApplicationFirewallPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WebApplicationFirewallPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#location-1">WebApplicationFirewallPolicy#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: WebApplicationFirewallPolicyState<Missing, 'ManagedRules, 'Name, 'ResourceGroupName>, value: string) : WebApplicationFirewallPolicyState<Present, 'ManagedRules, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : WebApplicationFirewallPolicyState<Present, 'ManagedRules, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// managed_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#managed_rules-1">WebApplicationFirewallPolicy#managed_rules</a>
        /// </summary>
        [<CustomOperation "managed_rules">]
        member _.ManagedRules(state: WebApplicationFirewallPolicyState<'Location, Missing, 'Name, 'ResourceGroupName>, value: azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRules) : WebApplicationFirewallPolicyState<'Location, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedRules <- value)
            ({ assignments = state.assignments } : WebApplicationFirewallPolicyState<'Location, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#name-1">WebApplicationFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, Missing, 'ResourceGroupName>, value: string) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#resource_group_name-1">WebApplicationFirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, Missing>, value: string) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, Present>)

        /// <summary>
        /// custom_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#custom_rules-1">WebApplicationFirewallPolicy#custom_rules</a> Accepts: azurerm.IResolvable | azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicyCustomRules[]
        /// </summary>
        [<CustomOperation "custom_rules">]
        member _.CustomRules(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomRules <- value)
            state : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#id-1">WebApplicationFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>, value: string) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>

        /// <summary>
        /// policy_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#policy_settings-1">WebApplicationFirewallPolicy#policy_settings</a>
        /// </summary>
        [<CustomOperation "policy_settings">]
        member _.PolicySettings(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>, value: azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicyPolicySettings) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PolicySettings <- value)
            state : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#tags-1">WebApplicationFirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>, value: seq<string * string>) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#timeouts-1">WebApplicationFirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>, value: azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicyTimeouts) : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebApplicationFirewallPolicyState<'Location, 'ManagedRules, 'Name, 'ResourceGroupName>

        member _.Run(state: WebApplicationFirewallPolicyState<Present, Present, Present, Present>) : azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicy =
            let config = azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webApplicationFirewallPolicy: missing required arguments. Must call: location, managed_rules, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: WebApplicationFirewallPolicyState<_, _, _, _>) : azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicy =
            Unchecked.defaultof<azurerm.WebApplicationFirewallPolicy.WebApplicationFirewallPolicy>
