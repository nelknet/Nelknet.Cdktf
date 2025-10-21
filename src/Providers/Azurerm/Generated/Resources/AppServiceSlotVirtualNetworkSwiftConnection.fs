namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId> = { assignments: ResizeArray<azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection">azurerm_app_service_slot_virtual_network_swift_connection</a>.
    /// </summary>
    type AppServiceSlotVirtualNetworkSwiftConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceSlotVirtualNetworkSwiftConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSlotVirtualNetworkSwiftConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceSlotVirtualNetworkSwiftConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSlotVirtualNetworkSwiftConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#app_service_id-1">AppServiceSlotVirtualNetworkSwiftConnection#app_service_id</a>.
        /// </summary>
        [<CustomOperation "app_service_id">]
        member _.AppServiceId(state: AppServiceSlotVirtualNetworkSwiftConnectionState<Missing, 'SlotName, 'SubnetId>, value: string) : AppServiceSlotVirtualNetworkSwiftConnectionState<Present, 'SlotName, 'SubnetId> =
            state.assignments.Add(fun config -> config.AppServiceId <- value)
            ({ assignments = state.assignments } : AppServiceSlotVirtualNetworkSwiftConnectionState<Present, 'SlotName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#slot_name-1">AppServiceSlotVirtualNetworkSwiftConnection#slot_name</a>.
        /// </summary>
        [<CustomOperation "slot_name">]
        member _.SlotName(state: AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, Missing, 'SubnetId>, value: string) : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.SlotName <- value)
            ({ assignments = state.assignments } : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#subnet_id-1">AppServiceSlotVirtualNetworkSwiftConnection#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, Missing>, value: string) : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#id-1">AppServiceSlotVirtualNetworkSwiftConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId>, value: string) : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_virtual_network_swift_connection#timeouts-1">AppServiceSlotVirtualNetworkSwiftConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId>, value: azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionTimeouts) : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceSlotVirtualNetworkSwiftConnectionState<'AppServiceId, 'SlotName, 'SubnetId>

        member _.Run(state: AppServiceSlotVirtualNetworkSwiftConnectionState<Present, Present, Present>) : azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection =
            let config = azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceSlotVirtualNetworkSwiftConnection: missing required arguments. Must call: app_service_id, slot_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceSlotVirtualNetworkSwiftConnectionState<_, _, _>) : azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection =
            Unchecked.defaultof<azurerm.AppServiceSlotVirtualNetworkSwiftConnection.AppServiceSlotVirtualNetworkSwiftConnection>
