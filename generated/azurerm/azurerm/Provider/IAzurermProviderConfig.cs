using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderConfig), fullyQualifiedName: "azurerm.provider.AzurermProviderConfig")]
    public interface IAzurermProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#alias AzurermProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#auxiliary_tenant_ids AzurermProvider#auxiliary_tenant_ids}.</summary>
        [JsiiProperty(name: "auxiliaryTenantIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AuxiliaryTenantIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate AzurermProvider#client_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate_password AzurermProvider#client_certificate_password}
        /// </remarks>
        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificatePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate_path AzurermProvider#client_certificate_path}
        /// </remarks>
        [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificatePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Client ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_id AzurermProvider#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a file containing the Client ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_id_file_path AzurermProvider#client_id_file_path}
        /// </remarks>
        [JsiiProperty(name: "clientIdFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientIdFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_secret AzurermProvider#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a file containing the Client Secret which should be used.</summary>
        /// <remarks>
        /// For use When authenticating as a Service Principal using a Client Secret.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_secret_file_path AzurermProvider#client_secret_file_path}
        /// </remarks>
        [JsiiProperty(name: "clientSecretFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecretFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>This will disable the x-ms-correlation-request-id header.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_correlation_request_id AzurermProvider#disable_correlation_request_id}
        /// </remarks>
        [JsiiProperty(name: "disableCorrelationRequestId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableCorrelationRequestId
        {
            get
            {
                return null;
            }
        }

        /// <summary>This will disable the Terraform Partner ID which is used if a custom `partner_id` isn't specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_terraform_partner_id AzurermProvider#disable_terraform_partner_id}
        /// </remarks>
        [JsiiProperty(name: "disableTerraformPartnerId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableTerraformPartnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Cloud Environment which should be used.</summary>
        /// <remarks>
        /// Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when <c>metadata_host</c> is specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#environment AzurermProvider#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#features AzurermProvider#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#metadata_host AzurermProvider#metadata_host}
        /// </remarks>
        [JsiiProperty(name: "metadataHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetadataHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#msi_endpoint AzurermProvider#msi_endpoint}
        /// </remarks>
        [JsiiProperty(name: "msiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MsiEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The bearer token for the request to the OIDC provider.</summary>
        /// <remarks>
        /// For use when authenticating as a Service Principal using OpenID Connect.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_request_token AzurermProvider#oidc_request_token}
        /// </remarks>
        [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcRequestToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL for the OIDC provider from which to request an ID token.</summary>
        /// <remarks>
        /// For use when authenticating as a Service Principal using OpenID Connect.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_request_url AzurermProvider#oidc_request_url}
        /// </remarks>
        [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcRequestUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_token AzurermProvider#oidc_token}
        /// </remarks>
        [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_token_file_path AzurermProvider#oidc_token_file_path}
        /// </remarks>
        [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcTokenFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#partner_id AzurermProvider#partner_id}
        /// </remarks>
        [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The set of Resource Providers which should be automatically registered for the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_provider_registrations AzurermProvider#resource_provider_registrations}
        /// </remarks>
        [JsiiProperty(name: "resourceProviderRegistrations", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceProviderRegistrations
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_providers_to_register AzurermProvider#resource_providers_to_register}
        /// </remarks>
        [JsiiProperty(name: "resourceProvidersToRegister", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceProvidersToRegister
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they're not already registered?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#skip_provider_registration AzurermProvider#skip_provider_registration}
        /// </remarks>
        [JsiiProperty(name: "skipProviderRegistration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipProviderRegistration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#storage_use_azuread AzurermProvider#storage_use_azuread}
        /// </remarks>
        [JsiiProperty(name: "storageUseAzuread", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageUseAzuread
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Subscription ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#subscription_id AzurermProvider#subscription_id}
        /// </remarks>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Tenant ID which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#tenant_id AzurermProvider#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow Azure AKS Workload Identity to be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_aks_workload_identity AzurermProvider#use_aks_workload_identity}
        /// </remarks>
        [JsiiProperty(name: "useAksWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseAksWorkloadIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow Azure CLI to be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_cli AzurermProvider#use_cli}
        /// </remarks>
        [JsiiProperty(name: "useCli", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCli
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow Managed Service Identity to be used for Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_msi AzurermProvider#use_msi}
        /// </remarks>
        [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseMsi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow OpenID Connect to be used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_oidc AzurermProvider#use_oidc}
        /// </remarks>
        [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseOidc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderConfig), fullyQualifiedName: "azurerm.provider.AzurermProviderConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#alias AzurermProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#auxiliary_tenant_ids AzurermProvider#auxiliary_tenant_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auxiliaryTenantIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AuxiliaryTenantIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate AzurermProvider#client_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate_password AzurermProvider#client_certificate_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_certificate_path AzurermProvider#client_certificate_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Client ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_id AzurermProvider#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a file containing the Client ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_id_file_path AzurermProvider#client_id_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientIdFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientIdFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_secret AzurermProvider#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a file containing the Client Secret which should be used.</summary>
            /// <remarks>
            /// For use When authenticating as a Service Principal using a Client Secret.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#client_secret_file_path AzurermProvider#client_secret_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecretFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecretFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This will disable the x-ms-correlation-request-id header.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_correlation_request_id AzurermProvider#disable_correlation_request_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableCorrelationRequestId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableCorrelationRequestId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>This will disable the Terraform Partner ID which is used if a custom `partner_id` isn't specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#disable_terraform_partner_id AzurermProvider#disable_terraform_partner_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableTerraformPartnerId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableTerraformPartnerId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Cloud Environment which should be used.</summary>
            /// <remarks>
            /// Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when <c>metadata_host</c> is specified.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#environment AzurermProvider#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#features AzurermProvider#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Features
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Hostname which should be used for the Azure Metadata Service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#metadata_host AzurermProvider#metadata_host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadataHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetadataHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#msi_endpoint AzurermProvider#msi_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "msiEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MsiEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The bearer token for the request to the OIDC provider.</summary>
            /// <remarks>
            /// For use when authenticating as a Service Principal using OpenID Connect.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_request_token AzurermProvider#oidc_request_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcRequestToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL for the OIDC provider from which to request an ID token.</summary>
            /// <remarks>
            /// For use when authenticating as a Service Principal using OpenID Connect.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_request_url AzurermProvider#oidc_request_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcRequestUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_token AzurermProvider#oidc_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#oidc_token_file_path AzurermProvider#oidc_token_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcTokenFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#partner_id AzurermProvider#partner_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The set of Resource Providers which should be automatically registered for the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_provider_registrations AzurermProvider#resource_provider_registrations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceProviderRegistrations", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceProviderRegistrations
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_providers_to_register AzurermProvider#resource_providers_to_register}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceProvidersToRegister", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceProvidersToRegister
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they're not already registered?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#skip_provider_registration AzurermProvider#skip_provider_registration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipProviderRegistration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipProviderRegistration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs?</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#storage_use_azuread AzurermProvider#storage_use_azuread}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageUseAzuread", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StorageUseAzuread
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The Subscription ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#subscription_id AzurermProvider#subscription_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Tenant ID which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#tenant_id AzurermProvider#tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allow Azure AKS Workload Identity to be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_aks_workload_identity AzurermProvider#use_aks_workload_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useAksWorkloadIdentity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseAksWorkloadIdentity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow Azure CLI to be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_cli AzurermProvider#use_cli}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useCli", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseCli
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow Managed Service Identity to be used for Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_msi AzurermProvider#use_msi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseMsi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow OpenID Connect to be used for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#use_oidc AzurermProvider#use_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseOidc
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
