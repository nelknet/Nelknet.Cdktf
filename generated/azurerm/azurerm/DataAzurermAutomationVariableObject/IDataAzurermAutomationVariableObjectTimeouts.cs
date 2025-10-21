using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariableObject
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAutomationVariableObjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationVariableObject.DataAzurermAutomationVariableObjectTimeouts")]
    public interface IDataAzurermAutomationVariableObjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#read DataAzurermAutomationVariableObject#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAutomationVariableObjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationVariableObject.DataAzurermAutomationVariableObjectTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAutomationVariableObject.IDataAzurermAutomationVariableObjectTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variable_object#read DataAzurermAutomationVariableObject#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
