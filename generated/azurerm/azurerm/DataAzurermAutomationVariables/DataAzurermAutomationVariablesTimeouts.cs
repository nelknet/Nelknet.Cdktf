using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariables
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeouts")]
    public class DataAzurermAutomationVariablesTimeouts : azurerm.DataAzurermAutomationVariables.IDataAzurermAutomationVariablesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#read DataAzurermAutomationVariables#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
