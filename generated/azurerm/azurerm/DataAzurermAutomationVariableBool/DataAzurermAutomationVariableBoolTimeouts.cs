using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariableBool
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAutomationVariableBool.DataAzurermAutomationVariableBoolTimeouts")]
    public class DataAzurermAutomationVariableBoolTimeouts : azurerm.DataAzurermAutomationVariableBool.IDataAzurermAutomationVariableBoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_bool#read DataAzurermAutomationVariableBool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
