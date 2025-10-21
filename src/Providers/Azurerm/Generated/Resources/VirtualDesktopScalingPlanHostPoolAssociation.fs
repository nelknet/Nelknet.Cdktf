namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId> = { assignments: ResizeArray<azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association">azurerm_virtual_desktop_scaling_plan_host_pool_association</a>.
    /// </summary>
    type VirtualDesktopScalingPlanHostPoolAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopScalingPlanHostPoolAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopScalingPlanHostPoolAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : VirtualDesktopScalingPlanHostPoolAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopScalingPlanHostPoolAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#enabled-1">VirtualDesktopScalingPlanHostPoolAssociation#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: VirtualDesktopScalingPlanHostPoolAssociationState<Missing, 'HostPoolId, 'ScalingPlanId>, value: bool) : VirtualDesktopScalingPlanHostPoolAssociationState<Present, 'HostPoolId, 'ScalingPlanId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanHostPoolAssociationState<Present, 'HostPoolId, 'ScalingPlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#enabled-1">VirtualDesktopScalingPlanHostPoolAssociation#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: VirtualDesktopScalingPlanHostPoolAssociationState<Missing, 'HostPoolId, 'ScalingPlanId>, value: HashiCorp.Cdktf.IResolvable) : VirtualDesktopScalingPlanHostPoolAssociationState<Present, 'HostPoolId, 'ScalingPlanId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanHostPoolAssociationState<Present, 'HostPoolId, 'ScalingPlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#host_pool_id-1">VirtualDesktopScalingPlanHostPoolAssociation#host_pool_id</a>.
        /// </summary>
        [<CustomOperation "host_pool_id">]
        member _.HostPoolId(state: VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, Missing, 'ScalingPlanId>, value: string) : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, Present, 'ScalingPlanId> =
            state.assignments.Add(fun config -> config.HostPoolId <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, Present, 'ScalingPlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#scaling_plan_id-1">VirtualDesktopScalingPlanHostPoolAssociation#scaling_plan_id</a>.
        /// </summary>
        [<CustomOperation "scaling_plan_id">]
        member _.ScalingPlanId(state: VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, Missing>, value: string) : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, Present> =
            state.assignments.Add(fun config -> config.ScalingPlanId <- value)
            ({ assignments = state.assignments } : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#id-1">VirtualDesktopScalingPlanHostPoolAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId>, value: string) : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#timeouts-1">VirtualDesktopScalingPlanHostPoolAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId>, value: azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationTimeouts) : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopScalingPlanHostPoolAssociationState<'Enabled, 'HostPoolId, 'ScalingPlanId>

        member _.Run(state: VirtualDesktopScalingPlanHostPoolAssociationState<Present, Present, Present>) : azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation =
            let config = azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopScalingPlanHostPoolAssociation: missing required arguments. Must call: enabled, host_pool_id, scaling_plan_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopScalingPlanHostPoolAssociationState<_, _, _>) : azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation =
            Unchecked.defaultof<azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation>
