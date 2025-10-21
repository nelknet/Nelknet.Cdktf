namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> = { assignments: ResizeArray<azurerm.Firewall.FirewallConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall">azurerm_firewall</a>.
    /// </summary>
    type FirewallBuilder(logicalId: string) =
        member _.Yield(_: unit) : FirewallState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FirewallState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FirewallState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#location-1">Firewall#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: FirewallState<Missing, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: string) : FirewallState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : FirewallState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#name-1">Firewall#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FirewallState<'Location, Missing, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: string) : FirewallState<'Location, Present, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FirewallState<'Location, Present, 'ResourceGroupName, 'SkuName, 'SkuTier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#resource_group_name-1">Firewall#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FirewallState<'Location, 'Name, Missing, 'SkuName, 'SkuTier>, value: string) : FirewallState<'Location, 'Name, Present, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FirewallState<'Location, 'Name, Present, 'SkuName, 'SkuTier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#sku_name-1">Firewall#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: FirewallState<'Location, 'Name, 'ResourceGroupName, Missing, 'SkuTier>, value: string) : FirewallState<'Location, 'Name, 'ResourceGroupName, Present, 'SkuTier> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : FirewallState<'Location, 'Name, 'ResourceGroupName, Present, 'SkuTier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#sku_tier-1">Firewall#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing>, value: string) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            ({ assignments = state.assignments } : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#dns_proxy_enabled-1">Firewall#dns_proxy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_proxy_enabled">]
        member _.DnsProxyEnabled(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: bool) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.DnsProxyEnabled <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#dns_proxy_enabled-1">Firewall#dns_proxy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_proxy_enabled">]
        member _.DnsProxyEnabled(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: HashiCorp.Cdktf.IResolvable) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.DnsProxyEnabled <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#dns_servers-1">Firewall#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: seq<string>) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#firewall_policy_id-1">Firewall#firewall_policy_id</a>.
        /// </summary>
        [<CustomOperation "firewall_policy_id">]
        member _.FirewallPolicyId(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: string) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.FirewallPolicyId <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#id-1">Firewall#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: string) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#ip_configuration-1">Firewall#ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.Firewall.FirewallIpConfiguration[]
        /// </summary>
        [<CustomOperation "ip_configuration">]
        member _.IpConfiguration(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: HashiCorp.Cdktf.IResolvable) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.IpConfiguration <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// management_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#management_ip_configuration-1">Firewall#management_ip_configuration</a>
        /// </summary>
        [<CustomOperation "management_ip_configuration">]
        member _.ManagementIpConfiguration(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: azurerm.Firewall.FirewallManagementIpConfiguration) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.ManagementIpConfiguration <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#private_ip_ranges-1">Firewall#private_ip_ranges</a>.
        /// </summary>
        [<CustomOperation "private_ip_ranges">]
        member _.PrivateIpRanges(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: seq<string>) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.PrivateIpRanges <- (value |> Seq.toArray))
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#tags-1">Firewall#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: seq<string * string>) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#threat_intel_mode-1">Firewall#threat_intel_mode</a>.
        /// </summary>
        [<CustomOperation "threat_intel_mode">]
        member _.ThreatIntelMode(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: string) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.ThreatIntelMode <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#timeouts-1">Firewall#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: azurerm.Firewall.FirewallTimeouts) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// virtual_hub block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#virtual_hub-1">Firewall#virtual_hub</a>
        /// </summary>
        [<CustomOperation "virtual_hub">]
        member _.VirtualHub(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: azurerm.Firewall.FirewallVirtualHub) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.VirtualHub <- value)
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall#zones-1">Firewall#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>, value: seq<string>) : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : FirewallState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SkuTier>

        member _.Run(state: FirewallState<Present, Present, Present, Present, Present>) : azurerm.Firewall.Firewall =
            let config = azurerm.Firewall.FirewallConfig()
            for setter in state.assignments do
                setter config
            azurerm.Firewall.Firewall(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.firewall: missing required arguments. Must call: location, name, resource_group_name, sku_name, sku_tier.", 9999, IsError = true)>]
        member _.Run(_: FirewallState<_, _, _, _, _>) : azurerm.Firewall.Firewall =
            Unchecked.defaultof<azurerm.Firewall.Firewall>
