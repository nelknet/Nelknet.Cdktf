namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> = { assignments: ResizeArray<azurerm.VirtualDesktopHostPool.VirtualDesktopHostPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool">azurerm_virtual_desktop_host_pool</a>.
    /// </summary>
    type VirtualDesktopHostPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopHostPoolState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopHostPoolState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualDesktopHostPoolState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopHostPoolState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#load_balancer_type-1">VirtualDesktopHostPool#load_balancer_type</a>.
        /// </summary>
        [<CustomOperation "load_balancer_type">]
        member _.LoadBalancerType(state: VirtualDesktopHostPoolState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<Present, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.LoadBalancerType <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolState<Present, 'Location, 'Name, 'ResourceGroupName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#location-1">VirtualDesktopHostPool#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualDesktopHostPoolState<'LoadBalancerType, Missing, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, Present, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolState<'LoadBalancerType, Present, 'Name, 'ResourceGroupName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#name-1">VirtualDesktopHostPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, Missing, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, Present, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, Present, 'ResourceGroupName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#resource_group_name-1">VirtualDesktopHostPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, Missing, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#type-1">VirtualDesktopHostPool#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#custom_rdp_properties-1">VirtualDesktopHostPool#custom_rdp_properties</a>.
        /// </summary>
        [<CustomOperation "custom_rdp_properties">]
        member _.CustomRdpProperties(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.CustomRdpProperties <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#description-1">VirtualDesktopHostPool#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#friendly_name-1">VirtualDesktopHostPool#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#id-1">VirtualDesktopHostPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#maximum_sessions_allowed-1">VirtualDesktopHostPool#maximum_sessions_allowed</a>.
        /// </summary>
        [<CustomOperation "maximum_sessions_allowed">]
        member _.MaximumSessionsAllowed(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: double) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.MaximumSessionsAllowed <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#personal_desktop_assignment_type-1">VirtualDesktopHostPool#personal_desktop_assignment_type</a>.
        /// </summary>
        [<CustomOperation "personal_desktop_assignment_type">]
        member _.PersonalDesktopAssignmentType(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.PersonalDesktopAssignmentType <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Preferred App Group type to display. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#preferred_app_group_type-1">VirtualDesktopHostPool#preferred_app_group_type</a>
        /// </summary>
        [<CustomOperation "preferred_app_group_type">]
        member _.PreferredAppGroupType(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.PreferredAppGroupType <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#public_network_access-1">VirtualDesktopHostPool#public_network_access</a>.
        /// </summary>
        [<CustomOperation "public_network_access">]
        member _.PublicNetworkAccess(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.PublicNetworkAccess <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// scheduled_agent_updates block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#scheduled_agent_updates-1">VirtualDesktopHostPool#scheduled_agent_updates</a>
        /// </summary>
        [<CustomOperation "scheduled_agent_updates">]
        member _.ScheduledAgentUpdates(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: azurerm.VirtualDesktopHostPool.VirtualDesktopHostPoolScheduledAgentUpdates) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.ScheduledAgentUpdates <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#start_vm_on_connect-1">VirtualDesktopHostPool#start_vm_on_connect</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "start_vm_on_connect">]
        member _.StartVmOnConnect(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: bool) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.StartVmOnConnect <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#start_vm_on_connect-1">VirtualDesktopHostPool#start_vm_on_connect</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "start_vm_on_connect">]
        member _.StartVmOnConnect(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.StartVmOnConnect <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#tags-1">VirtualDesktopHostPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: seq<string * string>) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#timeouts-1">VirtualDesktopHostPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: azurerm.VirtualDesktopHostPool.VirtualDesktopHostPoolTimeouts) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#validate_environment-1">VirtualDesktopHostPool#validate_environment</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "validate_environment">]
        member _.ValidateEnvironment(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: bool) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.ValidateEnvironment <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#validate_environment-1">VirtualDesktopHostPool#validate_environment</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "validate_environment">]
        member _.ValidateEnvironment(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.ValidateEnvironment <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#vm_template-1">VirtualDesktopHostPool#vm_template</a>.
        /// </summary>
        [<CustomOperation "vm_template">]
        member _.VmTemplate(state: VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>, value: string) : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type> =
            state.assignments.Add(fun config -> config.VmTemplate <- value)
            state : VirtualDesktopHostPoolState<'LoadBalancerType, 'Location, 'Name, 'ResourceGroupName, 'Type>

        member _.Run(state: VirtualDesktopHostPoolState<Present, Present, Present, Present, Present>) : azurerm.VirtualDesktopHostPool.VirtualDesktopHostPool =
            let config = azurerm.VirtualDesktopHostPool.VirtualDesktopHostPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopHostPool.VirtualDesktopHostPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopHostPool: missing required arguments. Must call: load_balancer_type, location, name, resource_group_name, type.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopHostPoolState<_, _, _, _, _>) : azurerm.VirtualDesktopHostPool.VirtualDesktopHostPool =
            Unchecked.defaultof<azurerm.VirtualDesktopHostPool.VirtualDesktopHostPool>
