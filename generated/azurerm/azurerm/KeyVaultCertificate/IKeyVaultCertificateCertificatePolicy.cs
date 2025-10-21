using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificatePolicy), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicy")]
    public interface IKeyVaultCertificateCertificatePolicy
    {
        /// <summary>issuer_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#issuer_parameters KeyVaultCertificate#issuer_parameters}
        /// </remarks>
        [JsiiProperty(name: "issuerParameters", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParameters\"}")]
        azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters IssuerParameters
        {
            get;
        }

        /// <summary>key_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#key_properties KeyVaultCertificate#key_properties}
        /// </remarks>
        [JsiiProperty(name: "keyProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties\"}")]
        azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties KeyProperties
        {
            get;
        }

        /// <summary>secret_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#secret_properties KeyVaultCertificate#secret_properties}
        /// </remarks>
        [JsiiProperty(name: "secretProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties\"}")]
        azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties SecretProperties
        {
            get;
        }

        /// <summary>lifetime_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#lifetime_action KeyVaultCertificate#lifetime_action}
        /// </remarks>
        [JsiiProperty(name: "lifetimeAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LifetimeAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>x509_certificate_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#x509_certificate_properties KeyVaultCertificate#x509_certificate_properties}
        /// </remarks>
        [JsiiProperty(name: "x509CertificateProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificateProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties? X509CertificateProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificatePolicy), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>issuer_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#issuer_parameters KeyVaultCertificate#issuer_parameters}
            /// </remarks>
            [JsiiProperty(name: "issuerParameters", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyIssuerParameters\"}")]
            public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters IssuerParameters
            {
                get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyIssuerParameters>()!;
            }

            /// <summary>key_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#key_properties KeyVaultCertificate#key_properties}
            /// </remarks>
            [JsiiProperty(name: "keyProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyKeyProperties\"}")]
            public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties KeyProperties
            {
                get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyKeyProperties>()!;
            }

            /// <summary>secret_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#secret_properties KeyVaultCertificate#secret_properties}
            /// </remarks>
            [JsiiProperty(name: "secretProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties\"}")]
            public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties SecretProperties
            {
                get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties>()!;
            }

            /// <summary>lifetime_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#lifetime_action KeyVaultCertificate#lifetime_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifetimeAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LifetimeAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>x509_certificate_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#x509_certificate_properties KeyVaultCertificate#x509_certificate_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "x509CertificateProperties", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificateProperties\"}", isOptional: true)]
            public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties? X509CertificateProperties
            {
                get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificateProperties?>();
            }
        }
    }
}
