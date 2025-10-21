using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSharedImageVersion
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSharedImageVersion.DataAzurermSharedImageVersionTimeouts")]
    public class DataAzurermSharedImageVersionTimeouts : azurerm.DataAzurermSharedImageVersion.IDataAzurermSharedImageVersionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#read DataAzurermSharedImageVersion#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
