namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> = { assignments: ResizeArray<azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration">azurerm_api_management_gateway_host_name_configuration</a>.
    /// </summary>
    type ApiManagementGatewayHostNameConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayHostNameConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#api_management_id-1">ApiManagementGatewayHostNameConfiguration#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementGatewayHostNameConfigurationState<Missing, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: string) : ApiManagementGatewayHostNameConfigurationState<Present, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayHostNameConfigurationState<Present, 'CertificateId, 'GatewayName, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#certificate_id-1">ApiManagementGatewayHostNameConfiguration#certificate_id</a>.
        /// </summary>
        [<CustomOperation "certificate_id">]
        member _.CertificateId(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, Missing, 'GatewayName, 'HostName, 'Name>, value: string) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, Present, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.CertificateId <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, Present, 'GatewayName, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#gateway_name-1">ApiManagementGatewayHostNameConfiguration#gateway_name</a>.
        /// </summary>
        [<CustomOperation "gateway_name">]
        member _.GatewayName(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, Missing, 'HostName, 'Name>, value: string) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, Present, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.GatewayName <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, Present, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#host_name-1">ApiManagementGatewayHostNameConfiguration#host_name</a>.
        /// </summary>
        [<CustomOperation "host_name">]
        member _.HostName(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, Missing, 'Name>, value: string) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, Present, 'Name> =
            state.assignments.Add(fun config -> config.HostName <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#name-1">ApiManagementGatewayHostNameConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, Missing>, value: string) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#http2_enabled-1">ApiManagementGatewayHostNameConfiguration#http2_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "http2_enabled">]
        member _.Http2Enabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: bool) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Http2Enabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#http2_enabled-1">ApiManagementGatewayHostNameConfiguration#http2_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "http2_enabled">]
        member _.Http2Enabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Http2Enabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#id-1">ApiManagementGatewayHostNameConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: string) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#request_client_certificate_enabled-1">ApiManagementGatewayHostNameConfiguration#request_client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "request_client_certificate_enabled">]
        member _.RequestClientCertificateEnabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: bool) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.RequestClientCertificateEnabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#request_client_certificate_enabled-1">ApiManagementGatewayHostNameConfiguration#request_client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "request_client_certificate_enabled">]
        member _.RequestClientCertificateEnabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.RequestClientCertificateEnabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#timeouts-1">ApiManagementGatewayHostNameConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfigurationTimeouts) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#tls10_enabled-1">ApiManagementGatewayHostNameConfiguration#tls10_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls10_enabled">]
        member _.Tls10Enabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: bool) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Tls10Enabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#tls10_enabled-1">ApiManagementGatewayHostNameConfiguration#tls10_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls10_enabled">]
        member _.Tls10Enabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Tls10Enabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#tls11_enabled-1">ApiManagementGatewayHostNameConfiguration#tls11_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls11_enabled">]
        member _.Tls11Enabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: bool) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Tls11Enabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_host_name_configuration#tls11_enabled-1">ApiManagementGatewayHostNameConfiguration#tls11_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls11_enabled">]
        member _.Tls11Enabled(state: ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Tls11Enabled <- value)
            state : ApiManagementGatewayHostNameConfigurationState<'ApiManagementId, 'CertificateId, 'GatewayName, 'HostName, 'Name>

        member _.Run(state: ApiManagementGatewayHostNameConfigurationState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfiguration =
            let config = azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGatewayHostNameConfiguration: missing required arguments. Must call: api_management_id, certificate_id, gateway_name, host_name, name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGatewayHostNameConfigurationState<_, _, _, _, _>) : azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfiguration =
            Unchecked.defaultof<azurerm.ApiManagementGatewayHostNameConfiguration.ApiManagementGatewayHostNameConfiguration>
