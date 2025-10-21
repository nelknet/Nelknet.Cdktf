namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FunctionAppActiveSlotState<'SlotId> = { assignments: ResizeArray<azurerm.FunctionAppActiveSlot.FunctionAppActiveSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_active_slot">azurerm_function_app_active_slot</a>.
    /// </summary>
    type FunctionAppActiveSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : FunctionAppActiveSlotState<Missing> =
            ({ assignments = ResizeArray() } : FunctionAppActiveSlotState<Missing>)

        member _.Zero(()) : FunctionAppActiveSlotState<Missing> =
            ({ assignments = ResizeArray() } : FunctionAppActiveSlotState<Missing>)

        /// <summary>
        /// The ID of the Slot to swap with `Production`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_active_slot#slot_id-1">FunctionAppActiveSlot#slot_id</a>
        /// </summary>
        [<CustomOperation "slot_id">]
        member _.SlotId(state: FunctionAppActiveSlotState<Missing>, value: string) : FunctionAppActiveSlotState<Present> =
            state.assignments.Add(fun config -> config.SlotId <- value)
            ({ assignments = state.assignments } : FunctionAppActiveSlotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_active_slot#id-1">FunctionAppActiveSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FunctionAppActiveSlotState<'SlotId>, value: string) : FunctionAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FunctionAppActiveSlotState<'SlotId>

        /// <summary>
        /// The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_active_slot#overwrite_network_config-1">FunctionAppActiveSlot#overwrite_network_config</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overwrite_network_config">]
        member _.OverwriteNetworkConfig(state: FunctionAppActiveSlotState<'SlotId>, value: bool) : FunctionAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.OverwriteNetworkConfig <- value)
            state : FunctionAppActiveSlotState<'SlotId>

        /// <summary>
        /// The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_active_slot#overwrite_network_config-1">FunctionAppActiveSlot#overwrite_network_config</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overwrite_network_config">]
        member _.OverwriteNetworkConfig(state: FunctionAppActiveSlotState<'SlotId>, value: HashiCorp.Cdktf.IResolvable) : FunctionAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.OverwriteNetworkConfig <- value)
            state : FunctionAppActiveSlotState<'SlotId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_active_slot#timeouts-1">FunctionAppActiveSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FunctionAppActiveSlotState<'SlotId>, value: azurerm.FunctionAppActiveSlot.FunctionAppActiveSlotTimeouts) : FunctionAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FunctionAppActiveSlotState<'SlotId>

        member _.Run(state: FunctionAppActiveSlotState<Present>) : azurerm.FunctionAppActiveSlot.FunctionAppActiveSlot =
            let config = azurerm.FunctionAppActiveSlot.FunctionAppActiveSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.FunctionAppActiveSlot.FunctionAppActiveSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.functionAppActiveSlot: missing required arguments. Must call: slot_id.", 9999, IsError = true)>]
        member _.Run(_: FunctionAppActiveSlotState<_>) : azurerm.FunctionAppActiveSlot.FunctionAppActiveSlot =
            Unchecked.defaultof<azurerm.FunctionAppActiveSlot.FunctionAppActiveSlot>
