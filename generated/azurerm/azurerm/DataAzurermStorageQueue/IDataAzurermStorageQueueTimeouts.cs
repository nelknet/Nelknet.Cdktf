using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageQueue
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageQueueTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageQueue.DataAzurermStorageQueueTimeouts")]
    public interface IDataAzurermStorageQueueTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#read DataAzurermStorageQueue#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageQueueTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageQueue.DataAzurermStorageQueueTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageQueue.IDataAzurermStorageQueueTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_queue#read DataAzurermStorageQueue#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
