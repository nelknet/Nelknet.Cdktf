using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWebPubsub
{
    [JsiiInterface(nativeType: typeof(IDataAzurermWebPubsubTimeouts), fullyQualifiedName: "azurerm.dataAzurermWebPubsub.DataAzurermWebPubsubTimeouts")]
    public interface IDataAzurermWebPubsubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_pubsub#read DataAzurermWebPubsub#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermWebPubsubTimeouts), fullyQualifiedName: "azurerm.dataAzurermWebPubsub.DataAzurermWebPubsubTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermWebPubsub.IDataAzurermWebPubsubTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_pubsub#read DataAzurermWebPubsub#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
