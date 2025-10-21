using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServiceCertificateOrder
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeouts")]
    public class DataAzurermAppServiceCertificateOrderTimeouts : azurerm.DataAzurermAppServiceCertificateOrder.IDataAzurermAppServiceCertificateOrderTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order#read DataAzurermAppServiceCertificateOrder#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
