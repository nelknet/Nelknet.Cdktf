using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApiManagementGroup.DataAzurermApiManagementGroupTimeouts")]
    public class DataAzurermApiManagementGroupTimeouts : azurerm.DataAzurermApiManagementGroup.IDataAzurermApiManagementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#read DataAzurermApiManagementGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
