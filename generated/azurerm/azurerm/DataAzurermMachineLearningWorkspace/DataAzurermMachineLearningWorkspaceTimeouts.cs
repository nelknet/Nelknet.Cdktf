using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMachineLearningWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspaceTimeouts")]
    public class DataAzurermMachineLearningWorkspaceTimeouts : azurerm.DataAzurermMachineLearningWorkspace.IDataAzurermMachineLearningWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#read DataAzurermMachineLearningWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
