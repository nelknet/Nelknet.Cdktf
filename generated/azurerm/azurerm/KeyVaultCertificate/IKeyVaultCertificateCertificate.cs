using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificate), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificate")]
    public interface IKeyVaultCertificateCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#contents KeyVaultCertificate#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        string Contents
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#password KeyVaultCertificate#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificate), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#contents KeyVaultCertificate#contents}.</summary>
            [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
            public string Contents
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#password KeyVaultCertificate#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
