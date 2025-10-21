namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname> = { assignments: ResizeArray<azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBindingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding">azurerm_app_service_slot_custom_hostname_binding</a>.
    /// </summary>
    type AppServiceSlotCustomHostnameBindingBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceSlotCustomHostnameBindingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSlotCustomHostnameBindingState<Missing, Missing>)

        member _.Zero(()) : AppServiceSlotCustomHostnameBindingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSlotCustomHostnameBindingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding#app_service_slot_id-1">AppServiceSlotCustomHostnameBinding#app_service_slot_id</a>.
        /// </summary>
        [<CustomOperation "app_service_slot_id">]
        member _.AppServiceSlotId(state: AppServiceSlotCustomHostnameBindingState<Missing, 'Hostname>, value: string) : AppServiceSlotCustomHostnameBindingState<Present, 'Hostname> =
            state.assignments.Add(fun config -> config.AppServiceSlotId <- value)
            ({ assignments = state.assignments } : AppServiceSlotCustomHostnameBindingState<Present, 'Hostname>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding#hostname-1">AppServiceSlotCustomHostnameBinding#hostname</a>.
        /// </summary>
        [<CustomOperation "hostname">]
        member _.Hostname(state: AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, Missing>, value: string) : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, Present> =
            state.assignments.Add(fun config -> config.Hostname <- value)
            ({ assignments = state.assignments } : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding#id-1">AppServiceSlotCustomHostnameBinding#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>, value: string) : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding#ssl_state-1">AppServiceSlotCustomHostnameBinding#ssl_state</a>.
        /// </summary>
        [<CustomOperation "ssl_state">]
        member _.SslState(state: AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>, value: string) : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname> =
            state.assignments.Add(fun config -> config.SslState <- value)
            state : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding#thumbprint-1">AppServiceSlotCustomHostnameBinding#thumbprint</a>.
        /// </summary>
        [<CustomOperation "thumbprint">]
        member _.Thumbprint(state: AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>, value: string) : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname> =
            state.assignments.Add(fun config -> config.Thumbprint <- value)
            state : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot_custom_hostname_binding#timeouts-1">AppServiceSlotCustomHostnameBinding#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>, value: azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBindingTimeouts) : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceSlotCustomHostnameBindingState<'AppServiceSlotId, 'Hostname>

        member _.Run(state: AppServiceSlotCustomHostnameBindingState<Present, Present>) : azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBinding =
            let config = azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBindingConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBinding(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceSlotCustomHostnameBinding: missing required arguments. Must call: app_service_slot_id, hostname.", 9999, IsError = true)>]
        member _.Run(_: AppServiceSlotCustomHostnameBindingState<_, _>) : azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBinding =
            Unchecked.defaultof<azurerm.AppServiceSlotCustomHostnameBinding.AppServiceSlotCustomHostnameBinding>
