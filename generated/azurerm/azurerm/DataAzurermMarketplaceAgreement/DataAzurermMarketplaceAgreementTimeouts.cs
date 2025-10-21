using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMarketplaceAgreement
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMarketplaceAgreement.DataAzurermMarketplaceAgreementTimeouts")]
    public class DataAzurermMarketplaceAgreementTimeouts : azurerm.DataAzurermMarketplaceAgreement.IDataAzurermMarketplaceAgreementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/marketplace_agreement#read DataAzurermMarketplaceAgreement#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
