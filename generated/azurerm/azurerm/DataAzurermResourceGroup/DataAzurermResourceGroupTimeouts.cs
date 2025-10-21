using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermResourceGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermResourceGroup.DataAzurermResourceGroupTimeouts")]
    public class DataAzurermResourceGroupTimeouts : azurerm.DataAzurermResourceGroup.IDataAzurermResourceGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group#read DataAzurermResourceGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
