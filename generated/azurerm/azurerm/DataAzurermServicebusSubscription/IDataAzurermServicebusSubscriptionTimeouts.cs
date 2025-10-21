using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusSubscription
{
    [JsiiInterface(nativeType: typeof(IDataAzurermServicebusSubscriptionTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusSubscription.DataAzurermServicebusSubscriptionTimeouts")]
    public interface IDataAzurermServicebusSubscriptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#read DataAzurermServicebusSubscription#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermServicebusSubscriptionTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusSubscription.DataAzurermServicebusSubscriptionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermServicebusSubscription.IDataAzurermServicebusSubscriptionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#read DataAzurermServicebusSubscription#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
