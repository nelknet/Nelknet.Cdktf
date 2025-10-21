using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMapsAccount
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMapsAccount.DataAzurermMapsAccountTimeouts")]
    public class DataAzurermMapsAccountTimeouts : azurerm.DataAzurermMapsAccount.IDataAzurermMapsAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#read DataAzurermMapsAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
