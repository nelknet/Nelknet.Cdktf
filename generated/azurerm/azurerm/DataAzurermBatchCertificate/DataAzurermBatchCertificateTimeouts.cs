using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchCertificate
{
    [JsiiByValue(fqn: "azurerm.dataAzurermBatchCertificate.DataAzurermBatchCertificateTimeouts")]
    public class DataAzurermBatchCertificateTimeouts : azurerm.DataAzurermBatchCertificate.IDataAzurermBatchCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#read DataAzurermBatchCertificate#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
