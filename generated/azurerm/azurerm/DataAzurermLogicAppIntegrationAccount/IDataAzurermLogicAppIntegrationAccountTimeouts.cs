using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogicAppIntegrationAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLogicAppIntegrationAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccountTimeouts")]
    public interface IDataAzurermLogicAppIntegrationAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account#read DataAzurermLogicAppIntegrationAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLogicAppIntegrationAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLogicAppIntegrationAccount.IDataAzurermLogicAppIntegrationAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account#read DataAzurermLogicAppIntegrationAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
