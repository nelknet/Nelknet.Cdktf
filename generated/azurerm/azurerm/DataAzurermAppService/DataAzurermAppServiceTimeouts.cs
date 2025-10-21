using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAppService.DataAzurermAppServiceTimeouts")]
    public class DataAzurermAppServiceTimeouts : azurerm.DataAzurermAppService.IDataAzurermAppServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service#read DataAzurermAppService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
