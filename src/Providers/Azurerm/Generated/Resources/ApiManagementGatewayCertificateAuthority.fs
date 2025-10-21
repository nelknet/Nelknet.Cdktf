namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName> = { assignments: ResizeArray<azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthorityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority">azurerm_api_management_gateway_certificate_authority</a>.
    /// </summary>
    type ApiManagementGatewayCertificateAuthorityBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGatewayCertificateAuthorityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayCertificateAuthorityState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementGatewayCertificateAuthorityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGatewayCertificateAuthorityState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#api_management_id-1">ApiManagementGatewayCertificateAuthority#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementGatewayCertificateAuthorityState<Missing, 'CertificateName, 'GatewayName>, value: string) : ApiManagementGatewayCertificateAuthorityState<Present, 'CertificateName, 'GatewayName> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayCertificateAuthorityState<Present, 'CertificateName, 'GatewayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#certificate_name-1">ApiManagementGatewayCertificateAuthority#certificate_name</a>.
        /// </summary>
        [<CustomOperation "certificate_name">]
        member _.CertificateName(state: ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, Missing, 'GatewayName>, value: string) : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, Present, 'GatewayName> =
            state.assignments.Add(fun config -> config.CertificateName <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, Present, 'GatewayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#gateway_name-1">ApiManagementGatewayCertificateAuthority#gateway_name</a>.
        /// </summary>
        [<CustomOperation "gateway_name">]
        member _.GatewayName(state: ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, Missing>, value: string) : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, Present> =
            state.assignments.Add(fun config -> config.GatewayName <- value)
            ({ assignments = state.assignments } : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#id-1">ApiManagementGatewayCertificateAuthority#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>, value: string) : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#is_trusted-1">ApiManagementGatewayCertificateAuthority#is_trusted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_trusted">]
        member _.IsTrusted(state: ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>, value: bool) : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName> =
            state.assignments.Add(fun config -> config.IsTrusted <- value)
            state : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#is_trusted-1">ApiManagementGatewayCertificateAuthority#is_trusted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_trusted">]
        member _.IsTrusted(state: ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName> =
            state.assignments.Add(fun config -> config.IsTrusted <- value)
            state : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_gateway_certificate_authority#timeouts-1">ApiManagementGatewayCertificateAuthority#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>, value: azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthorityTimeouts) : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGatewayCertificateAuthorityState<'ApiManagementId, 'CertificateName, 'GatewayName>

        member _.Run(state: ApiManagementGatewayCertificateAuthorityState<Present, Present, Present>) : azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthority =
            let config = azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthorityConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthority(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGatewayCertificateAuthority: missing required arguments. Must call: api_management_id, certificate_name, gateway_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGatewayCertificateAuthorityState<_, _, _>) : azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthority =
            Unchecked.defaultof<azurerm.ApiManagementGatewayCertificateAuthority.ApiManagementGatewayCertificateAuthority>
