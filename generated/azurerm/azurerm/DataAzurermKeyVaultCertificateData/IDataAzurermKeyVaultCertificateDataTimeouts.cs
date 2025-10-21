using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultCertificateData
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKeyVaultCertificateDataTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateDataTimeouts")]
    public interface IDataAzurermKeyVaultCertificateDataTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#read DataAzurermKeyVaultCertificateData#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKeyVaultCertificateDataTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateDataTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKeyVaultCertificateData.IDataAzurermKeyVaultCertificateDataTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#read DataAzurermKeyVaultCertificateData#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
