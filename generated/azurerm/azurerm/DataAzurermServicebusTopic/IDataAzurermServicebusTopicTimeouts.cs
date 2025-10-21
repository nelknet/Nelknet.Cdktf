using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusTopic
{
    [JsiiInterface(nativeType: typeof(IDataAzurermServicebusTopicTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusTopic.DataAzurermServicebusTopicTimeouts")]
    public interface IDataAzurermServicebusTopicTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#read DataAzurermServicebusTopic#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermServicebusTopicTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusTopic.DataAzurermServicebusTopicTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermServicebusTopic.IDataAzurermServicebusTopicTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic#read DataAzurermServicebusTopic#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
