using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningWorkspace
{
    [JsiiInterface(nativeType: typeof(IMachineLearningWorkspaceManagedNetwork), fullyQualifiedName: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetwork")]
    public interface IMachineLearningWorkspaceManagedNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#isolation_mode MachineLearningWorkspace#isolation_mode}.</summary>
        [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IsolationMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMachineLearningWorkspaceManagedNetwork), fullyQualifiedName: "azurerm.machineLearningWorkspace.MachineLearningWorkspaceManagedNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.MachineLearningWorkspace.IMachineLearningWorkspaceManagedNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_workspace#isolation_mode MachineLearningWorkspace#isolation_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IsolationMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
