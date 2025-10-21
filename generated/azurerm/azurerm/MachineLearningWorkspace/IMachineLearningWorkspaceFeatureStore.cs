using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    [JsiiInterface(nativeType: typeof(IMachineLearningWorkspaceFeatureStore), fullyQualifiedName: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStore")]
    public interface IMachineLearningWorkspaceFeatureStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#computer_spark_runtime_version MachineLearningWorkspace#computer_spark_runtime_version}.</summary>
        [JsiiProperty(name: "computerSparkRuntimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputerSparkRuntimeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#offline_connection_name MachineLearningWorkspace#offline_connection_name}.</summary>
        [JsiiProperty(name: "offlineConnectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OfflineConnectionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#online_connection_name MachineLearningWorkspace#online_connection_name}.</summary>
        [JsiiProperty(name: "onlineConnectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnlineConnectionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMachineLearningWorkspaceFeatureStore), fullyQualifiedName: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceFeatureStore")]
        internal sealed class _Proxy : DeputyBase, azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceFeatureStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#computer_spark_runtime_version MachineLearningWorkspace#computer_spark_runtime_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computerSparkRuntimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputerSparkRuntimeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#offline_connection_name MachineLearningWorkspace#offline_connection_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "offlineConnectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OfflineConnectionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#online_connection_name MachineLearningWorkspace#online_connection_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onlineConnectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnlineConnectionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
