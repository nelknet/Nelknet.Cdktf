using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHealthcareDicomService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermHealthcareDicomService.DataAzurermHealthcareDicomServiceTimeouts")]
    public class DataAzurermHealthcareDicomServiceTimeouts : azurerm.DataAzurermHealthcareDicomService.IDataAzurermHealthcareDicomServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_dicom_service#read DataAzurermHealthcareDicomService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
