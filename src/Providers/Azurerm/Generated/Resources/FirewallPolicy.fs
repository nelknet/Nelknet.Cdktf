namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.FirewallPolicy.FirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy">azurerm_firewall_policy</a>.
    /// </summary>
    type FirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : FirewallPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#location-1">FirewallPolicy#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: FirewallPolicyState<Missing, 'Name, 'ResourceGroupName>, value: string) : FirewallPolicyState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : FirewallPolicyState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#name-1">FirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallPolicyState<'Location, Missing, 'ResourceGroupName>, value: string) : FirewallPolicyState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallPolicyState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#resource_group_name-1">FirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FirewallPolicyState<'Location, 'Name, Missing>, value: string) : FirewallPolicyState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FirewallPolicyState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#auto_learn_private_ranges_enabled-1">FirewallPolicy#auto_learn_private_ranges_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_learn_private_ranges_enabled">]
        member _.AutoLearnPrivateRangesEnabled(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: bool) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoLearnPrivateRangesEnabled <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#auto_learn_private_ranges_enabled-1">FirewallPolicy#auto_learn_private_ranges_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_learn_private_ranges_enabled">]
        member _.AutoLearnPrivateRangesEnabled(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoLearnPrivateRangesEnabled <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#base_policy_id-1">FirewallPolicy#base_policy_id</a>.
        /// </summary>
        [<CustomOperation "base_policy_id">]
        member _.BasePolicyId(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: string) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BasePolicyId <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// dns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#dns-1">FirewallPolicy#dns</a>
        /// </summary>
        [<CustomOperation "dns">]
        member _.Dns(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyDns) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Dns <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// explicit_proxy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#explicit_proxy-1">FirewallPolicy#explicit_proxy</a>
        /// </summary>
        [<CustomOperation "explicit_proxy">]
        member _.ExplicitProxy(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyExplicitProxy) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExplicitProxy <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#id-1">FirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: string) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#identity-1">FirewallPolicy#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyIdentity) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// insights block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#insights-1">FirewallPolicy#insights</a>
        /// </summary>
        [<CustomOperation "insights">]
        member _.Insights(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyInsights) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Insights <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// intrusion_detection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#intrusion_detection-1">FirewallPolicy#intrusion_detection</a>
        /// </summary>
        [<CustomOperation "intrusion_detection">]
        member _.IntrusionDetection(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyIntrusionDetection) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntrusionDetection <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#private_ip_ranges-1">FirewallPolicy#private_ip_ranges</a>.
        /// </summary>
        [<CustomOperation "private_ip_ranges">]
        member _.PrivateIpRanges(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateIpRanges <- (value |> Seq.toArray))
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#sku-1">FirewallPolicy#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: string) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#sql_redirect_allowed-1">FirewallPolicy#sql_redirect_allowed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sql_redirect_allowed">]
        member _.SqlRedirectAllowed(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: bool) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SqlRedirectAllowed <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#sql_redirect_allowed-1">FirewallPolicy#sql_redirect_allowed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sql_redirect_allowed">]
        member _.SqlRedirectAllowed(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SqlRedirectAllowed <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#tags-1">FirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// threat_intelligence_allowlist block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#threat_intelligence_allowlist-1">FirewallPolicy#threat_intelligence_allowlist</a>
        /// </summary>
        [<CustomOperation "threat_intelligence_allowlist">]
        member _.ThreatIntelligenceAllowlist(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStruct) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ThreatIntelligenceAllowlist <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#threat_intelligence_mode-1">FirewallPolicy#threat_intelligence_mode</a>.
        /// </summary>
        [<CustomOperation "threat_intelligence_mode">]
        member _.ThreatIntelligenceMode(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: string) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ThreatIntelligenceMode <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#timeouts-1">FirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyTimeouts) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// tls_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#tls_certificate-1">FirewallPolicy#tls_certificate</a>
        /// </summary>
        [<CustomOperation "tls_certificate">]
        member _.TlsCertificate(state: FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.FirewallPolicy.FirewallPolicyTlsCertificate) : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TlsCertificate <- value)
            state : FirewallPolicyState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: FirewallPolicyState<Present, Present, Present>) : azurerm.FirewallPolicy.FirewallPolicy =
            let config = azurerm.FirewallPolicy.FirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.FirewallPolicy.FirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.firewallPolicy: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: FirewallPolicyState<_, _, _>) : azurerm.FirewallPolicy.FirewallPolicy =
            Unchecked.defaultof<azurerm.FirewallPolicy.FirewallPolicy>
