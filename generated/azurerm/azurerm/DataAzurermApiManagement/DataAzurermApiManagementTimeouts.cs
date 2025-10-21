using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagement
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApiManagement.DataAzurermApiManagementTimeouts")]
    public class DataAzurermApiManagementTimeouts : azurerm.DataAzurermApiManagement.IDataAzurermApiManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#read DataAzurermApiManagement#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
