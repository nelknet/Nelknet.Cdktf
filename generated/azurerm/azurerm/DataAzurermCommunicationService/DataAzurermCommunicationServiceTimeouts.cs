using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCommunicationService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCommunicationService.DataAzurermCommunicationServiceTimeouts")]
    public class DataAzurermCommunicationServiceTimeouts : azurerm.DataAzurermCommunicationService.IDataAzurermCommunicationServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/communication_service#read DataAzurermCommunicationService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
