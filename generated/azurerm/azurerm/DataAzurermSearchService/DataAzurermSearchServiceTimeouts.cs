using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSearchService
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSearchService.DataAzurermSearchServiceTimeouts")]
    public class DataAzurermSearchServiceTimeouts : azurerm.DataAzurermSearchService.IDataAzurermSearchServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/search_service#read DataAzurermSearchService#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
