using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementApiVersionSet
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSetTimeouts")]
    public class DataAzurermApiManagementApiVersionSetTimeouts : azurerm.DataAzurermApiManagementApiVersionSet.IDataAzurermApiManagementApiVersionSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set#read DataAzurermApiManagementApiVersionSet#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
