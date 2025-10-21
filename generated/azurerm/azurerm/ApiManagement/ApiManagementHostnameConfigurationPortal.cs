using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagement.ApiManagementHostnameConfigurationPortal")]
    public class ApiManagementHostnameConfigurationPortal : azurerm.ApiManagement.IApiManagementHostnameConfigurationPortal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#host_name ApiManagement#host_name}.</summary>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public string HostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#certificate ApiManagement#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#key_vault_id ApiManagement#key_vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultId
        {
            get;
            set;
        }

        private object? _negotiateClientCertificate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#negotiate_client_certificate ApiManagement#negotiate_client_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "negotiateClientCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? NegotiateClientCertificate
        {
            get => _negotiateClientCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _negotiateClientCertificate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#ssl_keyvault_identity_client_id ApiManagement#ssl_keyvault_identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslKeyvaultIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslKeyvaultIdentityClientId
        {
            get;
            set;
        }
    }
}
