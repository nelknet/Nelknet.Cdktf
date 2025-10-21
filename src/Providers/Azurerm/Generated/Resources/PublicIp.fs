namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PublicIp.PublicIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip">azurerm_public_ip</a>.
    /// </summary>
    type PublicIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : PublicIpState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PublicIpState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PublicIpState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PublicIpState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#allocation_method-1">PublicIp#allocation_method</a>.
        /// </summary>
        [<CustomOperation "allocation_method">]
        member _.AllocationMethod(state: PublicIpState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllocationMethod <- value)
            ({ assignments = state.assignments } : PublicIpState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#location-1">PublicIp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PublicIpState<'AllocationMethod, Missing, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PublicIpState<'AllocationMethod, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#name-1">PublicIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PublicIpState<'AllocationMethod, 'Location, Missing, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PublicIpState<'AllocationMethod, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#resource_group_name-1">PublicIp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PublicIpState<'AllocationMethod, 'Location, 'Name, Missing>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PublicIpState<'AllocationMethod, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#ddos_protection_mode-1">PublicIp#ddos_protection_mode</a>.
        /// </summary>
        [<CustomOperation "ddos_protection_mode">]
        member _.DdosProtectionMode(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DdosProtectionMode <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#ddos_protection_plan_id-1">PublicIp#ddos_protection_plan_id</a>.
        /// </summary>
        [<CustomOperation "ddos_protection_plan_id">]
        member _.DdosProtectionPlanId(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DdosProtectionPlanId <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#domain_name_label-1">PublicIp#domain_name_label</a>.
        /// </summary>
        [<CustomOperation "domain_name_label">]
        member _.DomainNameLabel(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DomainNameLabel <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#edge_zone-1">PublicIp#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#id-1">PublicIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#idle_timeout_in_minutes-1">PublicIp#idle_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_timeout_in_minutes">]
        member _.IdleTimeoutInMinutes(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: double) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdleTimeoutInMinutes <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#ip_tags-1">PublicIp#ip_tags</a>.
        /// </summary>
        [<CustomOperation "ip_tags">]
        member _.IpTags(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpTags <- dict value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#ip_version-1">PublicIp#ip_version</a>.
        /// </summary>
        [<CustomOperation "ip_version">]
        member _.IpVersion(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpVersion <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#public_ip_prefix_id-1">PublicIp#public_ip_prefix_id</a>.
        /// </summary>
        [<CustomOperation "public_ip_prefix_id">]
        member _.PublicIpPrefixId(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicIpPrefixId <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#reverse_fqdn-1">PublicIp#reverse_fqdn</a>.
        /// </summary>
        [<CustomOperation "reverse_fqdn">]
        member _.ReverseFqdn(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ReverseFqdn <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#sku-1">PublicIp#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#sku_tier-1">PublicIp#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: string) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#tags-1">PublicIp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#timeouts-1">PublicIp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.PublicIp.PublicIpTimeouts) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/public_ip#zones-1">PublicIp#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : PublicIpState<'AllocationMethod, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: PublicIpState<Present, Present, Present, Present>) : azurerm.PublicIp.PublicIp =
            let config = azurerm.PublicIp.PublicIpConfig()
            for setter in state.assignments do
                setter config
            azurerm.PublicIp.PublicIp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.publicIp: missing required arguments. Must call: allocation_method, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PublicIpState<_, _, _, _>) : azurerm.PublicIp.PublicIp =
            Unchecked.defaultof<azurerm.PublicIp.PublicIp>
