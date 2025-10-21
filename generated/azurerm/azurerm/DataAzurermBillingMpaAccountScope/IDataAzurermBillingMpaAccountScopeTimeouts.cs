using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBillingMpaAccountScope
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBillingMpaAccountScopeTimeouts), fullyQualifiedName: "azurerm.dataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScopeTimeouts")]
    public interface IDataAzurermBillingMpaAccountScopeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#read DataAzurermBillingMpaAccountScope#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBillingMpaAccountScopeTimeouts), fullyQualifiedName: "azurerm.dataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScopeTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBillingMpaAccountScope.IDataAzurermBillingMpaAccountScopeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#read DataAzurermBillingMpaAccountScope#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
