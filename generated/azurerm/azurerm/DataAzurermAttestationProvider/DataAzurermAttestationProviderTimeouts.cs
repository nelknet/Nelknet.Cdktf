using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAttestationProvider
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAttestationProvider.DataAzurermAttestationProviderTimeouts")]
    public class DataAzurermAttestationProviderTimeouts : azurerm.DataAzurermAttestationProvider.IDataAzurermAttestationProviderTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/attestation_provider#read DataAzurermAttestationProvider#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
