using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSharedImage
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSharedImage.DataAzurermSharedImageTimeouts")]
    public class DataAzurermSharedImageTimeouts : azurerm.DataAzurermSharedImage.IDataAzurermSharedImageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image#read DataAzurermSharedImage#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
