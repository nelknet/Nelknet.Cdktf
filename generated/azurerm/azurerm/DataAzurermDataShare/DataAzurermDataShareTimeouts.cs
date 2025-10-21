using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShare
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDataShare.DataAzurermDataShareTimeouts")]
    public class DataAzurermDataShareTimeouts : azurerm.DataAzurermDataShare.IDataAzurermDataShareTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#read DataAzurermDataShare#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
