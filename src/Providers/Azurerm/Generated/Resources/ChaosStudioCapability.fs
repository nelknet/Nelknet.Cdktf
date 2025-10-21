namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId> = { assignments: ResizeArray<azurerm.ChaosStudioCapability.ChaosStudioCapabilityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_capability">azurerm_chaos_studio_capability</a>.
    /// </summary>
    type ChaosStudioCapabilityBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChaosStudioCapabilityState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChaosStudioCapabilityState<Missing, Missing>)

        member _.Zero(()) : ChaosStudioCapabilityState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChaosStudioCapabilityState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_capability#capability_type-1">ChaosStudioCapability#capability_type</a>.
        /// </summary>
        [<CustomOperation "capability_type">]
        member _.CapabilityType(state: ChaosStudioCapabilityState<Missing, 'ChaosStudioTargetId>, value: string) : ChaosStudioCapabilityState<Present, 'ChaosStudioTargetId> =
            state.assignments.Add(fun config -> config.CapabilityType <- value)
            ({ assignments = state.assignments } : ChaosStudioCapabilityState<Present, 'ChaosStudioTargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_capability#chaos_studio_target_id-1">ChaosStudioCapability#chaos_studio_target_id</a>.
        /// </summary>
        [<CustomOperation "chaos_studio_target_id">]
        member _.ChaosStudioTargetId(state: ChaosStudioCapabilityState<'CapabilityType, Missing>, value: string) : ChaosStudioCapabilityState<'CapabilityType, Present> =
            state.assignments.Add(fun config -> config.ChaosStudioTargetId <- value)
            ({ assignments = state.assignments } : ChaosStudioCapabilityState<'CapabilityType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_capability#id-1">ChaosStudioCapability#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId>, value: string) : ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_capability#timeouts-1">ChaosStudioCapability#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId>, value: azurerm.ChaosStudioCapability.ChaosStudioCapabilityTimeouts) : ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChaosStudioCapabilityState<'CapabilityType, 'ChaosStudioTargetId>

        member _.Run(state: ChaosStudioCapabilityState<Present, Present>) : azurerm.ChaosStudioCapability.ChaosStudioCapability =
            let config = azurerm.ChaosStudioCapability.ChaosStudioCapabilityConfig()
            for setter in state.assignments do
                setter config
            azurerm.ChaosStudioCapability.ChaosStudioCapability(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.chaosStudioCapability: missing required arguments. Must call: capability_type, chaos_studio_target_id.", 9999, IsError = true)>]
        member _.Run(_: ChaosStudioCapabilityState<_, _>) : azurerm.ChaosStudioCapability.ChaosStudioCapability =
            Unchecked.defaultof<azurerm.ChaosStudioCapability.ChaosStudioCapability>
