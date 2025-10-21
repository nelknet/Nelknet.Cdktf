using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    [JsiiByValue(fqn: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStore")]
    public class MachineLearningWorkspaceFeatureStore : azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#computer_spark_runtime_version MachineLearningWorkspace#computer_spark_runtime_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computerSparkRuntimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputerSparkRuntimeVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#offline_connection_name MachineLearningWorkspace#offline_connection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offlineConnectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OfflineConnectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#online_connection_name MachineLearningWorkspace#online_connection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onlineConnectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnlineConnectionName
        {
            get;
            set;
        }
    }
}
