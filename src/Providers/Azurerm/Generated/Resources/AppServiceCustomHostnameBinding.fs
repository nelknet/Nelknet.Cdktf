namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBindingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding">azurerm_app_service_custom_hostname_binding</a>.
    /// </summary>
    type AppServiceCustomHostnameBindingBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceCustomHostnameBindingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCustomHostnameBindingState<Missing, Missing, Missing>)

        member _.Zero(()) : AppServiceCustomHostnameBindingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceCustomHostnameBindingState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#app_service_name-1">AppServiceCustomHostnameBinding#app_service_name</a>.
        /// </summary>
        [<CustomOperation "app_service_name">]
        member _.AppServiceName(state: AppServiceCustomHostnameBindingState<Missing, 'Hostname, 'ResourceGroupName>, value: string) : AppServiceCustomHostnameBindingState<Present, 'Hostname, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServiceName <- value)
            ({ assignments = state.assignments } : AppServiceCustomHostnameBindingState<Present, 'Hostname, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#hostname-1">AppServiceCustomHostnameBinding#hostname</a>.
        /// </summary>
        [<CustomOperation "hostname">]
        member _.Hostname(state: AppServiceCustomHostnameBindingState<'AppServiceName, Missing, 'ResourceGroupName>, value: string) : AppServiceCustomHostnameBindingState<'AppServiceName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Hostname <- value)
            ({ assignments = state.assignments } : AppServiceCustomHostnameBindingState<'AppServiceName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#resource_group_name-1">AppServiceCustomHostnameBinding#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, Missing>, value: string) : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#id-1">AppServiceCustomHostnameBinding#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>, value: string) : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#ssl_state-1">AppServiceCustomHostnameBinding#ssl_state</a>.
        /// </summary>
        [<CustomOperation "ssl_state">]
        member _.SslState(state: AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>, value: string) : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SslState <- value)
            state : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#thumbprint-1">AppServiceCustomHostnameBinding#thumbprint</a>.
        /// </summary>
        [<CustomOperation "thumbprint">]
        member _.Thumbprint(state: AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>, value: string) : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Thumbprint <- value)
            state : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_custom_hostname_binding#timeouts-1">AppServiceCustomHostnameBinding#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>, value: azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBindingTimeouts) : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceCustomHostnameBindingState<'AppServiceName, 'Hostname, 'ResourceGroupName>

        member _.Run(state: AppServiceCustomHostnameBindingState<Present, Present, Present>) : azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBinding =
            let config = azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBindingConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBinding(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceCustomHostnameBinding: missing required arguments. Must call: app_service_name, hostname, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServiceCustomHostnameBindingState<_, _, _>) : azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBinding =
            Unchecked.defaultof<azurerm.AppServiceCustomHostnameBinding.AppServiceCustomHostnameBinding>
