namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AvailabilitySet.AvailabilitySetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set">azurerm_availability_set</a>.
    /// </summary>
    type AvailabilitySetBuilder(logicalId: string) =
        member _.Yield(_: unit) : AvailabilitySetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AvailabilitySetState<Missing, Missing, Missing>)

        member _.Zero(()) : AvailabilitySetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AvailabilitySetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#location-1">AvailabilitySet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AvailabilitySetState<Missing, 'Name, 'ResourceGroupName>, value: string) : AvailabilitySetState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AvailabilitySetState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#name-1">AvailabilitySet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AvailabilitySetState<'Location, Missing, 'ResourceGroupName>, value: string) : AvailabilitySetState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AvailabilitySetState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#resource_group_name-1">AvailabilitySet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AvailabilitySetState<'Location, 'Name, Missing>, value: string) : AvailabilitySetState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AvailabilitySetState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#id-1">AvailabilitySet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: string) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#managed-1">AvailabilitySet#managed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed">]
        member _.Managed(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: bool) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Managed <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#managed-1">AvailabilitySet#managed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed">]
        member _.Managed(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Managed <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#platform_fault_domain_count-1">AvailabilitySet#platform_fault_domain_count</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain_count">]
        member _.PlatformFaultDomainCount(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: double) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PlatformFaultDomainCount <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#platform_update_domain_count-1">AvailabilitySet#platform_update_domain_count</a>.
        /// </summary>
        [<CustomOperation "platform_update_domain_count">]
        member _.PlatformUpdateDomainCount(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: double) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PlatformUpdateDomainCount <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#proximity_placement_group_id-1">AvailabilitySet#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: string) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#tags-1">AvailabilitySet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/availability_set#timeouts-1">AvailabilitySet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.AvailabilitySet.AvailabilitySetTimeouts) : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AvailabilitySetState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AvailabilitySetState<Present, Present, Present>) : azurerm.AvailabilitySet.AvailabilitySet =
            let config = azurerm.AvailabilitySet.AvailabilitySetConfig()
            for setter in state.assignments do
                setter config
            azurerm.AvailabilitySet.AvailabilitySet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.availabilitySet: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AvailabilitySetState<_, _, _>) : azurerm.AvailabilitySet.AvailabilitySet =
            Unchecked.defaultof<azurerm.AvailabilitySet.AvailabilitySet>
