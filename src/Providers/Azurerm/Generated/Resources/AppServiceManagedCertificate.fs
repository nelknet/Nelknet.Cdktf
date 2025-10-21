namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceManagedCertificateState<'CustomHostnameBindingId> = { assignments: ResizeArray<azurerm.AppServiceManagedCertificate.AppServiceManagedCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_managed_certificate">azurerm_app_service_managed_certificate</a>.
    /// </summary>
    type AppServiceManagedCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceManagedCertificateState<Missing> =
            ({ assignments = ResizeArray() } : AppServiceManagedCertificateState<Missing>)

        member _.Zero(()) : AppServiceManagedCertificateState<Missing> =
            ({ assignments = ResizeArray() } : AppServiceManagedCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_managed_certificate#custom_hostname_binding_id-1">AppServiceManagedCertificate#custom_hostname_binding_id</a>.
        /// </summary>
        [<CustomOperation "custom_hostname_binding_id">]
        member _.CustomHostnameBindingId(state: AppServiceManagedCertificateState<Missing>, value: string) : AppServiceManagedCertificateState<Present> =
            state.assignments.Add(fun config -> config.CustomHostnameBindingId <- value)
            ({ assignments = state.assignments } : AppServiceManagedCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_managed_certificate#id-1">AppServiceManagedCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceManagedCertificateState<'CustomHostnameBindingId>, value: string) : AppServiceManagedCertificateState<'CustomHostnameBindingId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceManagedCertificateState<'CustomHostnameBindingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_managed_certificate#tags-1">AppServiceManagedCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServiceManagedCertificateState<'CustomHostnameBindingId>, value: seq<string * string>) : AppServiceManagedCertificateState<'CustomHostnameBindingId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServiceManagedCertificateState<'CustomHostnameBindingId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_managed_certificate#timeouts-1">AppServiceManagedCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceManagedCertificateState<'CustomHostnameBindingId>, value: azurerm.AppServiceManagedCertificate.AppServiceManagedCertificateTimeouts) : AppServiceManagedCertificateState<'CustomHostnameBindingId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceManagedCertificateState<'CustomHostnameBindingId>

        member _.Run(state: AppServiceManagedCertificateState<Present>) : azurerm.AppServiceManagedCertificate.AppServiceManagedCertificate =
            let config = azurerm.AppServiceManagedCertificate.AppServiceManagedCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceManagedCertificate.AppServiceManagedCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceManagedCertificate: missing required arguments. Must call: custom_hostname_binding_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceManagedCertificateState<_>) : azurerm.AppServiceManagedCertificate.AppServiceManagedCertificate =
            Unchecked.defaultof<azurerm.AppServiceManagedCertificate.AppServiceManagedCertificate>
