using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementUser
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApiManagementUser.DataAzurermApiManagementUserTimeouts")]
    public class DataAzurermApiManagementUserTimeouts : azurerm.DataAzurermApiManagementUser.IDataAzurermApiManagementUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user#read DataAzurermApiManagementUser#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
