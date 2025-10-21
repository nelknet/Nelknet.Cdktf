using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificatePolicyLifetimeAction), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction")]
    public interface IKeyVaultCertificateCertificatePolicyLifetimeAction
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#action KeyVaultCertificate#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction\"}")]
        azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction Action
        {
            get;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#trigger KeyVaultCertificate#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger\"}")]
        azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger Trigger
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificatePolicyLifetimeAction), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#action KeyVaultCertificate#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction\"}")]
            public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction Action
            {
                get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction>()!;
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#trigger KeyVaultCertificate#trigger}
            /// </remarks>
            [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger\"}")]
            public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger Trigger
            {
                get => GetInstanceProperty<azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger>()!;
            }
        }
    }
}
