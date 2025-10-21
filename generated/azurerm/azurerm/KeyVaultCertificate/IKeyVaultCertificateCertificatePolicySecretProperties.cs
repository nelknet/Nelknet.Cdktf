using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificatePolicySecretProperties), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties")]
    public interface IKeyVaultCertificateCertificatePolicySecretProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#content_type KeyVaultCertificate#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        string ContentType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificatePolicySecretProperties), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicySecretProperties")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicySecretProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#content_type KeyVaultCertificate#content_type}.</summary>
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
