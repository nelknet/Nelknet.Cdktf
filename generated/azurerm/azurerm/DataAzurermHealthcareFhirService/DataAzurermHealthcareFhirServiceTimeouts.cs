using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHealthcareFhirService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermHealthcareFhirService.DataAzurermHealthcareFhirServiceTimeouts")]
    public class DataAzurermHealthcareFhirServiceTimeouts : azurerm.DataAzurermHealthcareFhirService.IDataAzurermHealthcareFhirServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#read DataAzurermHealthcareFhirService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
