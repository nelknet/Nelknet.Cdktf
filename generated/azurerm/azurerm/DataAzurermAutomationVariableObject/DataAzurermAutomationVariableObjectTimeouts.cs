using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariableObject
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAutomationVariableObject.DataAzurermAutomationVariableObjectTimeouts")]
    public class DataAzurermAutomationVariableObjectTimeouts : azurerm.DataAzurermAutomationVariableObject.IDataAzurermAutomationVariableObjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#read DataAzurermAutomationVariableObject#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
