using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicy")]
    public class KeyVaultCertificateCertificatePolicy : azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicy
    {
        /// <summary>issuer_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#issuer_parameters KeyVaultCertificate#issuer_parameters}
        /// </remarks>
        [JsiiProperty(name: "issuerParameters", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParameters\"}")]
        public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters IssuerParameters
        {
            get;
            set;
        }

        /// <summary>key_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#key_properties KeyVaultCertificate#key_properties}
        /// </remarks>
        [JsiiProperty(name: "keyProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties\"}")]
        public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties KeyProperties
        {
            get;
            set;
        }

        /// <summary>secret_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#secret_properties KeyVaultCertificate#secret_properties}
        /// </remarks>
        [JsiiProperty(name: "secretProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties\"}")]
        public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties SecretProperties
        {
            get;
            set;
        }

        private object? _lifetimeAction;

        /// <summary>lifetime_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#lifetime_action KeyVaultCertificate#lifetime_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifetimeAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LifetimeAction
        {
            get => _lifetimeAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lifetimeAction = value;
            }
        }

        /// <summary>x509_certificate_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#x509_certificate_properties KeyVaultCertificate#x509_certificate_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "x509CertificateProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificateProperties\"}", isOptional: true)]
        public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties? X509CertificateProperties
        {
            get;
            set;
        }
    }
}
