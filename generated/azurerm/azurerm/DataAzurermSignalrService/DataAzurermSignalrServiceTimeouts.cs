using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSignalrService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSignalrService.DataAzurermSignalrServiceTimeouts")]
    public class DataAzurermSignalrServiceTimeouts : azurerm.DataAzurermSignalrService.IDataAzurermSignalrServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#read DataAzurermSignalrService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
