using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariableString
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAutomationVariableString.DataAzurermAutomationVariableStringTimeouts")]
    public class DataAzurermAutomationVariableStringTimeouts : azurerm.DataAzurermAutomationVariableString.IDataAzurermAutomationVariableStringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_string#read DataAzurermAutomationVariableString#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
