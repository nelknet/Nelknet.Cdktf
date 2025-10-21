namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WebAppActiveSlotState<'SlotId> = { assignments: ResizeArray<azurerm.WebAppActiveSlot.WebAppActiveSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_active_slot">azurerm_web_app_active_slot</a>.
    /// </summary>
    type WebAppActiveSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : WebAppActiveSlotState<Missing> =
            ({ assignments = ResizeArray() } : WebAppActiveSlotState<Missing>)

        member _.Zero(()) : WebAppActiveSlotState<Missing> =
            ({ assignments = ResizeArray() } : WebAppActiveSlotState<Missing>)

        /// <summary>
        /// The ID of the Slot to swap with `Production`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_active_slot#slot_id-1">WebAppActiveSlot#slot_id</a>
        /// </summary>
        [<CustomOperation "slot_id">]
        member _.SlotId(state: WebAppActiveSlotState<Missing>, value: string) : WebAppActiveSlotState<Present> =
            state.assignments.Add(fun config -> config.SlotId <- value)
            ({ assignments = state.assignments } : WebAppActiveSlotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_active_slot#id-1">WebAppActiveSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WebAppActiveSlotState<'SlotId>, value: string) : WebAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WebAppActiveSlotState<'SlotId>

        /// <summary>
        /// The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_active_slot#overwrite_network_config-1">WebAppActiveSlot#overwrite_network_config</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overwrite_network_config">]
        member _.OverwriteNetworkConfig(state: WebAppActiveSlotState<'SlotId>, value: bool) : WebAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.OverwriteNetworkConfig <- value)
            state : WebAppActiveSlotState<'SlotId>

        /// <summary>
        /// The swap action should overwrite the Production slot's network configuration with the configuration from this slot. Defaults to `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_active_slot#overwrite_network_config-1">WebAppActiveSlot#overwrite_network_config</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "overwrite_network_config">]
        member _.OverwriteNetworkConfig(state: WebAppActiveSlotState<'SlotId>, value: HashiCorp.Cdktf.IResolvable) : WebAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.OverwriteNetworkConfig <- value)
            state : WebAppActiveSlotState<'SlotId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_app_active_slot#timeouts-1">WebAppActiveSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WebAppActiveSlotState<'SlotId>, value: azurerm.WebAppActiveSlot.WebAppActiveSlotTimeouts) : WebAppActiveSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WebAppActiveSlotState<'SlotId>

        member _.Run(state: WebAppActiveSlotState<Present>) : azurerm.WebAppActiveSlot.WebAppActiveSlot =
            let config = azurerm.WebAppActiveSlot.WebAppActiveSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.WebAppActiveSlot.WebAppActiveSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.webAppActiveSlot: missing required arguments. Must call: slot_id.", 9999, IsError = true)>]
        member _.Run(_: WebAppActiveSlotState<_>) : azurerm.WebAppActiveSlot.WebAppActiveSlot =
            Unchecked.defaultof<azurerm.WebAppActiveSlot.WebAppActiveSlot>
