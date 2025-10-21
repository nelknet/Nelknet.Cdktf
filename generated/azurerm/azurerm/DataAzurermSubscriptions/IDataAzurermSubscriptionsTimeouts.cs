using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSubscriptions
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSubscriptionsTimeouts), fullyQualifiedName: "azurerm.dataAzurermSubscriptions.DataAzurermSubscriptionsTimeouts")]
    public interface IDataAzurermSubscriptionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions#read DataAzurermSubscriptions#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSubscriptionsTimeouts), fullyQualifiedName: "azurerm.dataAzurermSubscriptions.DataAzurermSubscriptionsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSubscriptions.IDataAzurermSubscriptionsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions#read DataAzurermSubscriptions#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
