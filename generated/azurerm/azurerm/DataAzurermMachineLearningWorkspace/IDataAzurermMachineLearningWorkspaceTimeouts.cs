using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMachineLearningWorkspace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMachineLearningWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspaceTimeouts")]
    public interface IDataAzurermMachineLearningWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#read DataAzurermMachineLearningWorkspace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMachineLearningWorkspaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMachineLearningWorkspace.DataAzurermMachineLearningWorkspaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMachineLearningWorkspace.IDataAzurermMachineLearningWorkspaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/machine_learning_workspace#read DataAzurermMachineLearningWorkspace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
