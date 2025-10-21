namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId> = { assignments: ResizeArray<azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_virtual_network_swift_connection">azurerm_app_service_virtual_network_swift_connection</a>.
    /// </summary>
    type AppServiceVirtualNetworkSwiftConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceVirtualNetworkSwiftConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceVirtualNetworkSwiftConnectionState<Missing, Missing>)

        member _.Zero(()) : AppServiceVirtualNetworkSwiftConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceVirtualNetworkSwiftConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_virtual_network_swift_connection#app_service_id-1">AppServiceVirtualNetworkSwiftConnection#app_service_id</a>.
        /// </summary>
        [<CustomOperation "app_service_id">]
        member _.AppServiceId(state: AppServiceVirtualNetworkSwiftConnectionState<Missing, 'SubnetId>, value: string) : AppServiceVirtualNetworkSwiftConnectionState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.AppServiceId <- value)
            ({ assignments = state.assignments } : AppServiceVirtualNetworkSwiftConnectionState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_virtual_network_swift_connection#subnet_id-1">AppServiceVirtualNetworkSwiftConnection#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, Missing>, value: string) : AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_virtual_network_swift_connection#id-1">AppServiceVirtualNetworkSwiftConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId>, value: string) : AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_virtual_network_swift_connection#timeouts-1">AppServiceVirtualNetworkSwiftConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId>, value: azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnectionTimeouts) : AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceVirtualNetworkSwiftConnectionState<'AppServiceId, 'SubnetId>

        member _.Run(state: AppServiceVirtualNetworkSwiftConnectionState<Present, Present>) : azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnection =
            let config = azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceVirtualNetworkSwiftConnection: missing required arguments. Must call: app_service_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceVirtualNetworkSwiftConnectionState<_, _>) : azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnection =
            Unchecked.defaultof<azurerm.AppServiceVirtualNetworkSwiftConnection.AppServiceVirtualNetworkSwiftConnection>
