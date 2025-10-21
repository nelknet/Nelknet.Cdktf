using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariables
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAutomationVariablesTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeouts")]
    public interface IDataAzurermAutomationVariablesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#read DataAzurermAutomationVariables#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAutomationVariablesTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAutomationVariables.IDataAzurermAutomationVariablesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#read DataAzurermAutomationVariables#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
