using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShareAccount
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDataShareAccount.DataAzurermDataShareAccountTimeouts")]
    public class DataAzurermDataShareAccountTimeouts : azurerm.DataAzurermDataShareAccount.IDataAzurermDataShareAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#read DataAzurermDataShareAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
