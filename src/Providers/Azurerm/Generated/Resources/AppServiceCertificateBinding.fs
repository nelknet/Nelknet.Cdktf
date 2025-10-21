namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState> = { assignments: ResizeArray<azurerm.AppServiceCertificateBinding.AppServiceCertificateBindingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_binding">azurerm_app_service_certificate_binding</a>.
    /// </summary>
    type AppServiceCertificateBindingBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceCertificateBindingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCertificateBindingState<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceCertificateBindingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCertificateBindingState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_binding#certificate_id-1">AppServiceCertificateBinding#certificate_id</a>.
        /// </summary>
        [<CustomOperation "certificate_id">]
        member _.CertificateId(state: AppServiceCertificateBindingState<Missing, 'HostnameBindingId, 'SslState>, value: string) : AppServiceCertificateBindingState<Present, 'HostnameBindingId, 'SslState> =
            state.assignments.Add(fun config -> config.CertificateId <- value)
            ({ assignments = state.assignments } : AppServiceCertificateBindingState<Present, 'HostnameBindingId, 'SslState>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_binding#hostname_binding_id-1">AppServiceCertificateBinding#hostname_binding_id</a>.
        /// </summary>
        [<CustomOperation "hostname_binding_id">]
        member _.HostnameBindingId(state: AppServiceCertificateBindingState<'CertificateId, Missing, 'SslState>, value: string) : AppServiceCertificateBindingState<'CertificateId, Present, 'SslState> =
            state.assignments.Add(fun config -> config.HostnameBindingId <- value)
            ({ assignments = state.assignments } : AppServiceCertificateBindingState<'CertificateId, Present, 'SslState>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_binding#ssl_state-1">AppServiceCertificateBinding#ssl_state</a>.
        /// </summary>
        [<CustomOperation "ssl_state">]
        member _.SslState(state: AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, Missing>, value: string) : AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, Present> =
            state.assignments.Add(fun config -> config.SslState <- value)
            ({ assignments = state.assignments } : AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_binding#id-1">AppServiceCertificateBinding#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState>, value: string) : AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_certificate_binding#timeouts-1">AppServiceCertificateBinding#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState>, value: azurerm.AppServiceCertificateBinding.AppServiceCertificateBindingTimeouts) : AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceCertificateBindingState<'CertificateId, 'HostnameBindingId, 'SslState>

        member _.Run(state: AppServiceCertificateBindingState<Present, Present, Present>) : azurerm.AppServiceCertificateBinding.AppServiceCertificateBinding =
            let config = azurerm.AppServiceCertificateBinding.AppServiceCertificateBindingConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceCertificateBinding.AppServiceCertificateBinding(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceCertificateBinding: missing required arguments. Must call: certificate_id, hostname_binding_id, ssl_state.", 9999, IsError = true)>]
        member _.Run(_: AppServiceCertificateBindingState<_, _, _>) : azurerm.AppServiceCertificateBinding.AppServiceCertificateBinding =
            Unchecked.defaultof<azurerm.AppServiceCertificateBinding.AppServiceCertificateBinding>
