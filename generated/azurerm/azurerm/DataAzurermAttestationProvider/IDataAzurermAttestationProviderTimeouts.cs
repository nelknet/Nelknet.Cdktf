using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAttestationProvider
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAttestationProviderTimeouts), fullyQualifiedName: "azurerm.dataAzurermAttestationProvider.DataAzurermAttestationProviderTimeouts")]
    public interface IDataAzurermAttestationProviderTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#read DataAzurermAttestationProvider#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAttestationProviderTimeouts), fullyQualifiedName: "azurerm.dataAzurermAttestationProvider.DataAzurermAttestationProviderTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAttestationProvider.IDataAzurermAttestationProviderTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#read DataAzurermAttestationProvider#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
