namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId> = { assignments: ResizeArray<azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration">azurerm_frontdoor_custom_https_configuration</a>.
    /// </summary>
    type FrontdoorCustomHttpsConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : FrontdoorCustomHttpsConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorCustomHttpsConfigurationState<Missing, Missing>)

        member _.Zero(()) : FrontdoorCustomHttpsConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorCustomHttpsConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#custom_https_provisioning_enabled-1">FrontdoorCustomHttpsConfiguration#custom_https_provisioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "custom_https_provisioning_enabled">]
        member _.CustomHttpsProvisioningEnabled(state: FrontdoorCustomHttpsConfigurationState<Missing, 'FrontendEndpointId>, value: bool) : FrontdoorCustomHttpsConfigurationState<Present, 'FrontendEndpointId> =
            state.assignments.Add(fun config -> config.CustomHttpsProvisioningEnabled <- value)
            ({ assignments = state.assignments } : FrontdoorCustomHttpsConfigurationState<Present, 'FrontendEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#custom_https_provisioning_enabled-1">FrontdoorCustomHttpsConfiguration#custom_https_provisioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "custom_https_provisioning_enabled">]
        member _.CustomHttpsProvisioningEnabled(state: FrontdoorCustomHttpsConfigurationState<Missing, 'FrontendEndpointId>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorCustomHttpsConfigurationState<Present, 'FrontendEndpointId> =
            state.assignments.Add(fun config -> config.CustomHttpsProvisioningEnabled <- value)
            ({ assignments = state.assignments } : FrontdoorCustomHttpsConfigurationState<Present, 'FrontendEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#frontend_endpoint_id-1">FrontdoorCustomHttpsConfiguration#frontend_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "frontend_endpoint_id">]
        member _.FrontendEndpointId(state: FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, Missing>, value: string) : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, Present> =
            state.assignments.Add(fun config -> config.FrontendEndpointId <- value)
            ({ assignments = state.assignments } : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, Present>)

        /// <summary>
        /// custom_https_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#custom_https_configuration-1">FrontdoorCustomHttpsConfiguration#custom_https_configuration</a>
        /// </summary>
        [<CustomOperation "custom_https_configuration">]
        member _.CustomHttpsConfiguration(state: FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId>, value: azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfiguration) : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId> =
            state.assignments.Add(fun config -> config.CustomHttpsConfiguration <- value)
            state : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#id-1">FrontdoorCustomHttpsConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId>, value: string) : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#timeouts-1">FrontdoorCustomHttpsConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId>, value: azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationTimeouts) : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FrontdoorCustomHttpsConfigurationState<'CustomHttpsProvisioningEnabled, 'FrontendEndpointId>

        member _.Run(state: FrontdoorCustomHttpsConfigurationState<Present, Present>) : azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfiguration =
            let config = azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.frontdoorCustomHttpsConfiguration: missing required arguments. Must call: custom_https_provisioning_enabled, frontend_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: FrontdoorCustomHttpsConfigurationState<_, _>) : azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfiguration =
            Unchecked.defaultof<azurerm.FrontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfiguration>
