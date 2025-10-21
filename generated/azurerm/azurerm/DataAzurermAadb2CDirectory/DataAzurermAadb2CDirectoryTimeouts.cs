using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAadb2CDirectory
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAadb2CDirectory.DataAzurermAadb2CDirectoryTimeouts")]
    public class DataAzurermAadb2CDirectoryTimeouts : azurerm.DataAzurermAadb2CDirectory.IDataAzurermAadb2CDirectoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#read DataAzurermAadb2CDirectory#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
