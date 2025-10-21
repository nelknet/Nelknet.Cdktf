namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AzurermProviderState = { assignments: ResizeArray<azurerm.Provider.AzurermProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs">azurerm</a>.
    /// </summary>
    type AzurermProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : AzurermProviderState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AzurermProviderState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Alias name. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#alias-1">AzurermProvider#alias</a>
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : AzurermProviderState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#auxiliary_tenant_ids-1">AzurermProvider#auxiliary_tenant_ids</a>.
        /// </summary>
        [<CustomOperation "auxiliary_tenant_ids">]
        member _.AuxiliaryTenantIds(state: AzurermProviderState, value: seq<string>) : AzurermProviderState =
            state.assignments.Add(fun config -> config.AuxiliaryTenantIds <- (value |> Seq.toArray))
            state : AzurermProviderState

        /// <summary>
        /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate-1">AzurermProvider#client_certificate</a>
        /// </summary>
        [<CustomOperation "client_certificate">]
        member _.ClientCertificate(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientCertificate <- value)
            state : AzurermProviderState

        /// <summary>
        /// The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate_password-1">AzurermProvider#client_certificate_password</a>
        /// </summary>
        [<CustomOperation "client_certificate_password">]
        member _.ClientCertificatePassword(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientCertificatePassword <- value)
            state : AzurermProviderState

        /// <summary>
        /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate_path-1">AzurermProvider#client_certificate_path</a>
        /// </summary>
        [<CustomOperation "client_certificate_path">]
        member _.ClientCertificatePath(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientCertificatePath <- value)
            state : AzurermProviderState

        /// <summary>
        /// The Client ID which should be used. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_id-1">AzurermProvider#client_id</a>
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientId <- value)
            state : AzurermProviderState

        /// <summary>
        /// The path to a file containing the Client ID which should be used. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_id_file_path-1">AzurermProvider#client_id_file_path</a>
        /// </summary>
        [<CustomOperation "client_id_file_path">]
        member _.ClientIdFilePath(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientIdFilePath <- value)
            state : AzurermProviderState

        /// <summary>
        /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_secret-1">AzurermProvider#client_secret</a>
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            state : AzurermProviderState

        /// <summary>
        /// The path to a file containing the Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_secret_file_path-1">AzurermProvider#client_secret_file_path</a>
        /// </summary>
        [<CustomOperation "client_secret_file_path">]
        member _.ClientSecretFilePath(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ClientSecretFilePath <- value)
            state : AzurermProviderState

        /// <summary>
        /// This will disable the x-ms-correlation-request-id header. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_correlation_request_id-1">AzurermProvider#disable_correlation_request_id</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_correlation_request_id">]
        member _.DisableCorrelationRequestId(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.DisableCorrelationRequestId <- value)
            state : AzurermProviderState

        /// <summary>
        /// This will disable the x-ms-correlation-request-id header. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_correlation_request_id-1">AzurermProvider#disable_correlation_request_id</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_correlation_request_id">]
        member _.DisableCorrelationRequestId(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.DisableCorrelationRequestId <- value)
            state : AzurermProviderState

        /// <summary>
        /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn't specified. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_terraform_partner_id-1">AzurermProvider#disable_terraform_partner_id</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_terraform_partner_id">]
        member _.DisableTerraformPartnerId(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.DisableTerraformPartnerId <- value)
            state : AzurermProviderState

        /// <summary>
        /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn't specified. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_terraform_partner_id-1">AzurermProvider#disable_terraform_partner_id</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_terraform_partner_id">]
        member _.DisableTerraformPartnerId(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.DisableTerraformPartnerId <- value)
            state : AzurermProviderState

        /// <summary>
        /// The Cloud Environment which should be used. Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when `metadata_host` is specified. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#environment-1">AzurermProvider#environment</a>
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.Environment <- value)
            state : AzurermProviderState

        /// <summary>
        /// features block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#features-1">AzurermProvider#features</a> Accepts: azurerm.IResolvable | azurerm.Provider.AzurermProviderFeatures[]
        /// </summary>
        [<CustomOperation "features">]
        member _.Features(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.Features <- value)
            state : AzurermProviderState

        /// <summary>
        /// The Hostname which should be used for the Azure Metadata Service. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#metadata_host-1">AzurermProvider#metadata_host</a>
        /// </summary>
        [<CustomOperation "metadata_host">]
        member _.MetadataHost(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.MetadataHost <- value)
            state : AzurermProviderState

        /// <summary>
        /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#msi_endpoint-1">AzurermProvider#msi_endpoint</a>
        /// </summary>
        [<CustomOperation "msi_endpoint">]
        member _.MsiEndpoint(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.MsiEndpoint <- value)
            state : AzurermProviderState

        /// <summary>
        /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_request_token-1">AzurermProvider#oidc_request_token</a>
        /// </summary>
        [<CustomOperation "oidc_request_token">]
        member _.OidcRequestToken(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.OidcRequestToken <- value)
            state : AzurermProviderState

        /// <summary>
        /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_request_url-1">AzurermProvider#oidc_request_url</a>
        /// </summary>
        [<CustomOperation "oidc_request_url">]
        member _.OidcRequestUrl(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.OidcRequestUrl <- value)
            state : AzurermProviderState

        /// <summary>
        /// The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_token-1">AzurermProvider#oidc_token</a>
        /// </summary>
        [<CustomOperation "oidc_token">]
        member _.OidcToken(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.OidcToken <- value)
            state : AzurermProviderState

        /// <summary>
        /// The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_token_file_path-1">AzurermProvider#oidc_token_file_path</a>
        /// </summary>
        [<CustomOperation "oidc_token_file_path">]
        member _.OidcTokenFilePath(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.OidcTokenFilePath <- value)
            state : AzurermProviderState

        /// <summary>
        /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#partner_id-1">AzurermProvider#partner_id</a>
        /// </summary>
        [<CustomOperation "partner_id">]
        member _.PartnerId(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.PartnerId <- value)
            state : AzurermProviderState

        /// <summary>
        /// The set of Resource Providers which should be automatically registered for the subscription. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_provider_registrations-1">AzurermProvider#resource_provider_registrations</a>
        /// </summary>
        [<CustomOperation "resource_provider_registrations">]
        member _.ResourceProviderRegistrations(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ResourceProviderRegistrations <- value)
            state : AzurermProviderState

        /// <summary>
        /// A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_providers_to_register-1">AzurermProvider#resource_providers_to_register</a>
        /// </summary>
        [<CustomOperation "resource_providers_to_register">]
        member _.ResourceProvidersToRegister(state: AzurermProviderState, value: seq<string>) : AzurermProviderState =
            state.assignments.Add(fun config -> config.ResourceProvidersToRegister <- (value |> Seq.toArray))
            state : AzurermProviderState

        /// <summary>
        /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they're not already registered? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#skip_provider_registration-1">AzurermProvider#skip_provider_registration</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_provider_registration">]
        member _.SkipProviderRegistration(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.SkipProviderRegistration <- value)
            state : AzurermProviderState

        /// <summary>
        /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they're not already registered? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#skip_provider_registration-1">AzurermProvider#skip_provider_registration</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_provider_registration">]
        member _.SkipProviderRegistration(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.SkipProviderRegistration <- value)
            state : AzurermProviderState

        /// <summary>
        /// Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#storage_use_azuread-1">AzurermProvider#storage_use_azuread</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_use_azuread">]
        member _.StorageUseAzuread(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.StorageUseAzuread <- value)
            state : AzurermProviderState

        /// <summary>
        /// Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs? Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#storage_use_azuread-1">AzurermProvider#storage_use_azuread</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "storage_use_azuread">]
        member _.StorageUseAzuread(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.StorageUseAzuread <- value)
            state : AzurermProviderState

        /// <summary>
        /// The Subscription ID which should be used. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#subscription_id-1">AzurermProvider#subscription_id</a>
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : AzurermProviderState

        /// <summary>
        /// The Tenant ID which should be used. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#tenant_id-1">AzurermProvider#tenant_id</a>
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: AzurermProviderState, value: string) : AzurermProviderState =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow Azure AKS Workload Identity to be used for Authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_aks_workload_identity-1">AzurermProvider#use_aks_workload_identity</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_aks_workload_identity">]
        member _.UseAksWorkloadIdentity(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseAksWorkloadIdentity <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow Azure AKS Workload Identity to be used for Authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_aks_workload_identity-1">AzurermProvider#use_aks_workload_identity</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_aks_workload_identity">]
        member _.UseAksWorkloadIdentity(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseAksWorkloadIdentity <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow Azure CLI to be used for Authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_cli-1">AzurermProvider#use_cli</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_cli">]
        member _.UseCli(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseCli <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow Azure CLI to be used for Authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_cli-1">AzurermProvider#use_cli</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_cli">]
        member _.UseCli(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseCli <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow Managed Service Identity to be used for Authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_msi-1">AzurermProvider#use_msi</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_msi">]
        member _.UseMsi(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseMsi <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow Managed Service Identity to be used for Authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_msi-1">AzurermProvider#use_msi</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_msi">]
        member _.UseMsi(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseMsi <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow OpenID Connect to be used for authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_oidc-1">AzurermProvider#use_oidc</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_oidc">]
        member _.UseOidc(state: AzurermProviderState, value: bool) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseOidc <- value)
            state : AzurermProviderState

        /// <summary>
        /// Allow OpenID Connect to be used for authentication. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_oidc-1">AzurermProvider#use_oidc</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_oidc">]
        member _.UseOidc(state: AzurermProviderState, value: HashiCorp.Cdktf.IResolvable) : AzurermProviderState =
            state.assignments.Add(fun config -> config.UseOidc <- value)
            state : AzurermProviderState

        member _.Run(state: AzurermProviderState) : azurerm.Provider.AzurermProvider =
            let config = azurerm.Provider.AzurermProviderConfig()
            for setter in state.assignments do
                setter config
            azurerm.Provider.AzurermProvider(StackContext.get (), logicalId, config)
