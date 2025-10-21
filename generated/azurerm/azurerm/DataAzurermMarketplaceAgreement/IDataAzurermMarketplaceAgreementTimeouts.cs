using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMarketplaceAgreement
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMarketplaceAgreementTimeouts), fullyQualifiedName: "azurerm.dataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreementTimeouts")]
    public interface IDataAzurermMarketplaceAgreementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#read DataAzurermMarketplaceAgreement#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMarketplaceAgreementTimeouts), fullyQualifiedName: "azurerm.dataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreementTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMarketplaceAgreement.IDataAzurermMarketplaceAgreementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#read DataAzurermMarketplaceAgreement#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
