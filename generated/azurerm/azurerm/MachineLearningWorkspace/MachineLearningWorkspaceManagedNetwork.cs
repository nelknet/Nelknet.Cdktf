using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    [JsiiByValue(fqn: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetwork")]
    public class MachineLearningWorkspaceManagedNetwork : azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#isolation_mode MachineLearningWorkspace#isolation_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IsolationMode
        {
            get;
            set;
        }
    }
}
