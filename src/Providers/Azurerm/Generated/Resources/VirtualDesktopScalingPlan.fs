namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> = { assignments: ResizeArray<azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan">azurerm_virtual_desktop_scaling_plan</a>.
    /// </summary>
    type VirtualDesktopScalingPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopScalingPlanState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopScalingPlanState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualDesktopScalingPlanState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopScalingPlanState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#location-1">VirtualDesktopScalingPlan#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualDesktopScalingPlanState<Missing, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<Present, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanState<Present, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#name-1">VirtualDesktopScalingPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualDesktopScalingPlanState<'Location, Missing, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<'Location, Present, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanState<'Location, Present, 'ResourceGroupName, 'Schedule, 'TimeZone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#resource_group_name-1">VirtualDesktopScalingPlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualDesktopScalingPlanState<'Location, 'Name, Missing, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<'Location, 'Name, Present, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanState<'Location, 'Name, Present, 'Schedule, 'TimeZone>)

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#schedule-1">VirtualDesktopScalingPlan#schedule</a> Accepts: azurerm.IResolvable | azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlanSchedule[]
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, Missing, 'TimeZone>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, Present, 'TimeZone> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, Present, 'TimeZone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#time_zone-1">VirtualDesktopScalingPlan#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, Missing>, value: string) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, Present> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#description-1">VirtualDesktopScalingPlan#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#exclusion_tag-1">VirtualDesktopScalingPlan#exclusion_tag</a>.
        /// </summary>
        [<CustomOperation "exclusion_tag">]
        member _.ExclusionTag(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.ExclusionTag <- value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#friendly_name-1">VirtualDesktopScalingPlan#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        /// <summary>
        /// host_pool block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#host_pool-1">VirtualDesktopScalingPlan#host_pool</a> Accepts: azurerm.IResolvable | azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlanHostPool[]
        /// </summary>
        [<CustomOperation "host_pool">]
        member _.HostPool(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.HostPool <- value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#id-1">VirtualDesktopScalingPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: string) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#tags-1">VirtualDesktopScalingPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: seq<string * string>) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#timeouts-1">VirtualDesktopScalingPlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>, value: azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlanTimeouts) : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopScalingPlanState<'Location, 'Name, 'ResourceGroupName, 'Schedule, 'TimeZone>

        member _.Run(state: VirtualDesktopScalingPlanState<Present, Present, Present, Present, Present>) : azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlan =
            let config = azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopScalingPlan: missing required arguments. Must call: location, name, resource_group_name, schedule, time_zone.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopScalingPlanState<_, _, _, _, _>) : azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlan =
            Unchecked.defaultof<azurerm.VirtualDesktopScalingPlan.VirtualDesktopScalingPlan>
