namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId> = { assignments: ResizeArray<azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfoConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool_registration_info">azurerm_virtual_desktop_host_pool_registration_info</a>.
    /// </summary>
    type VirtualDesktopHostPoolRegistrationInfoBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopHostPoolRegistrationInfoState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopHostPoolRegistrationInfoState<Missing, Missing>)

        member _.Zero(()) : VirtualDesktopHostPoolRegistrationInfoState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopHostPoolRegistrationInfoState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool_registration_info#expiration_date-1">VirtualDesktopHostPoolRegistrationInfo#expiration_date</a>.
        /// </summary>
        [<CustomOperation "expiration_date">]
        member _.ExpirationDate(state: VirtualDesktopHostPoolRegistrationInfoState<Missing, 'HostpoolId>, value: string) : VirtualDesktopHostPoolRegistrationInfoState<Present, 'HostpoolId> =
            state.assignments.Add(fun config -> config.ExpirationDate <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolRegistrationInfoState<Present, 'HostpoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool_registration_info#hostpool_id-1">VirtualDesktopHostPoolRegistrationInfo#hostpool_id</a>.
        /// </summary>
        [<CustomOperation "hostpool_id">]
        member _.HostpoolId(state: VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, Missing>, value: string) : VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, Present> =
            state.assignments.Add(fun config -> config.HostpoolId <- value)
            ({ assignments = state.assignments } : VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool_registration_info#id-1">VirtualDesktopHostPoolRegistrationInfo#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId>, value: string) : VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool_registration_info#timeouts-1">VirtualDesktopHostPoolRegistrationInfo#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId>, value: azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfoTimeouts) : VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopHostPoolRegistrationInfoState<'ExpirationDate, 'HostpoolId>

        member _.Run(state: VirtualDesktopHostPoolRegistrationInfoState<Present, Present>) : azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfo =
            let config = azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfoConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfo(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopHostPoolRegistrationInfo: missing required arguments. Must call: expiration_date, hostpool_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopHostPoolRegistrationInfoState<_, _>) : azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfo =
            Unchecked.defaultof<azurerm.VirtualDesktopHostPoolRegistrationInfo.VirtualDesktopHostPoolRegistrationInfo>
