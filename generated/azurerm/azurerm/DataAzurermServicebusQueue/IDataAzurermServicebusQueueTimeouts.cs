using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusQueue
{
    [JsiiInterface(nativeType: typeof(IDataAzurermServicebusQueueTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusQueue.DataAzurermServicebusQueueTimeouts")]
    public interface IDataAzurermServicebusQueueTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#read DataAzurermServicebusQueue#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermServicebusQueueTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusQueue.DataAzurermServicebusQueueTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermServicebusQueue.IDataAzurermServicebusQueueTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue#read DataAzurermServicebusQueue#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
