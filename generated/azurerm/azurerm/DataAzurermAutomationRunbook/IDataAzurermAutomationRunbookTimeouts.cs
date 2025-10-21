using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationRunbook
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAutomationRunbookTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationRunbook.DataAzurermAutomationRunbookTimeouts")]
    public interface IDataAzurermAutomationRunbookTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#read DataAzurermAutomationRunbook#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAutomationRunbookTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationRunbook.DataAzurermAutomationRunbookTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAutomationRunbook.IDataAzurermAutomationRunbookTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_runbook#read DataAzurermAutomationRunbook#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
