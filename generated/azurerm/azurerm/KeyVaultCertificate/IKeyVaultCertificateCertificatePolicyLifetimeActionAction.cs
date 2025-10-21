using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificatePolicyLifetimeActionAction), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction")]
    public interface IKeyVaultCertificateCertificatePolicyLifetimeActionAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#action_type KeyVaultCertificate#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificatePolicyLifetimeActionAction), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#action_type KeyVaultCertificate#action_type}.</summary>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
