using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridSystemTopic
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventgridSystemTopicTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopicTimeouts")]
    public interface IDataAzurermEventgridSystemTopicTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#read DataAzurermEventgridSystemTopic#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventgridSystemTopicTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopicTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventgridSystemTopic.IDataAzurermEventgridSystemTopicTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#read DataAzurermEventgridSystemTopic#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
