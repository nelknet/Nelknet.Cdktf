namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DedicatedHostGroup.DedicatedHostGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group">azurerm_dedicated_host_group</a>.
    /// </summary>
    type DedicatedHostGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DedicatedHostGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DedicatedHostGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DedicatedHostGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DedicatedHostGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#location-1">DedicatedHostGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DedicatedHostGroupState<Missing, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : DedicatedHostGroupState<Present, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DedicatedHostGroupState<Present, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#name-1">DedicatedHostGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DedicatedHostGroupState<'Location, Missing, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : DedicatedHostGroupState<'Location, Present, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DedicatedHostGroupState<'Location, Present, 'PlatformFaultDomainCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#platform_fault_domain_count-1">DedicatedHostGroup#platform_fault_domain_count</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain_count">]
        member _.PlatformFaultDomainCount(state: DedicatedHostGroupState<'Location, 'Name, Missing, 'ResourceGroupName>, value: double) : DedicatedHostGroupState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PlatformFaultDomainCount <- value)
            ({ assignments = state.assignments } : DedicatedHostGroupState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#resource_group_name-1">DedicatedHostGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, Missing>, value: string) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#automatic_placement_enabled-1">DedicatedHostGroup#automatic_placement_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_placement_enabled">]
        member _.AutomaticPlacementEnabled(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: bool) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticPlacementEnabled <- value)
            state : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#automatic_placement_enabled-1">DedicatedHostGroup#automatic_placement_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_placement_enabled">]
        member _.AutomaticPlacementEnabled(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticPlacementEnabled <- value)
            state : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#id-1">DedicatedHostGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#tags-1">DedicatedHostGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: seq<string * string>) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#timeouts-1">DedicatedHostGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: azurerm.DedicatedHostGroup.DedicatedHostGroupTimeouts) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host_group#zone-1">DedicatedHostGroup#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>, value: string) : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : DedicatedHostGroupState<'Location, 'Name, 'PlatformFaultDomainCount, 'ResourceGroupName>

        member _.Run(state: DedicatedHostGroupState<Present, Present, Present, Present>) : azurerm.DedicatedHostGroup.DedicatedHostGroup =
            let config = azurerm.DedicatedHostGroup.DedicatedHostGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DedicatedHostGroup.DedicatedHostGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dedicatedHostGroup: missing required arguments. Must call: location, name, platform_fault_domain_count, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DedicatedHostGroupState<_, _, _, _>) : azurerm.DedicatedHostGroup.DedicatedHostGroup =
            Unchecked.defaultof<azurerm.DedicatedHostGroup.DedicatedHostGroup>
