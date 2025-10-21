using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogicAppStandard
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLogicAppStandard.DataAzurermLogicAppStandardTimeouts")]
    public class DataAzurermLogicAppStandardTimeouts : azurerm.DataAzurermLogicAppStandard.IDataAzurermLogicAppStandardTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_standard#read DataAzurermLogicAppStandard#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
