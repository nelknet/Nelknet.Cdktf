using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogicAppWorkflow
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflowTimeouts")]
    public class DataAzurermLogicAppWorkflowTimeouts : azurerm.DataAzurermLogicAppWorkflow.IDataAzurermLogicAppWorkflowTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#read DataAzurermLogicAppWorkflow#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
