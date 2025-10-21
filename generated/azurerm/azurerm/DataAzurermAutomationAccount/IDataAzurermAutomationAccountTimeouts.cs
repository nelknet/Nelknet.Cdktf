using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAutomationAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationAccount.DataAzurermAutomationAccountTimeouts")]
    public interface IDataAzurermAutomationAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account#read DataAzurermAutomationAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAutomationAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermAutomationAccount.DataAzurermAutomationAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAutomationAccount.IDataAzurermAutomationAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account#read DataAzurermAutomationAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
