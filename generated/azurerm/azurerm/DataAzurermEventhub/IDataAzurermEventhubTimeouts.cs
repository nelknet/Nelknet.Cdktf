using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventhub
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventhubTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventhub.DataAzurermEventhubTimeouts")]
    public interface IDataAzurermEventhubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub#read DataAzurermEventhub#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventhubTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventhub.DataAzurermEventhubTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventhub.IDataAzurermEventhubTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub#read DataAzurermEventhub#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
