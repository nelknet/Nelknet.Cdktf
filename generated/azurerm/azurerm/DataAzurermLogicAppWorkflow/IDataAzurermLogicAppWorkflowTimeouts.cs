using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogicAppWorkflow
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLogicAppWorkflowTimeouts), fullyQualifiedName: "azurerm.dataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflowTimeouts")]
    public interface IDataAzurermLogicAppWorkflowTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#read DataAzurermLogicAppWorkflow#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLogicAppWorkflowTimeouts), fullyQualifiedName: "azurerm.dataAzurermLogicAppWorkflow.DataAzurermLogicAppWorkflowTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLogicAppWorkflow.IDataAzurermLogicAppWorkflowTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_workflow#read DataAzurermLogicAppWorkflow#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
