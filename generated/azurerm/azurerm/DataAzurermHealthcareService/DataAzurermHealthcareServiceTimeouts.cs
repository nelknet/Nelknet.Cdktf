using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHealthcareService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermHealthcareService.DataAzurermHealthcareServiceTimeouts")]
    public class DataAzurermHealthcareServiceTimeouts : azurerm.DataAzurermHealthcareService.IDataAzurermHealthcareServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#read DataAzurermHealthcareService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
