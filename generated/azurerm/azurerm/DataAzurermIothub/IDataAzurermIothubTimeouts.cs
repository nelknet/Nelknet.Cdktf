using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermIothub
{
    [JsiiInterface(nativeType: typeof(IDataAzurermIothubTimeouts), fullyQualifiedName: "azurerm.dataAzurermIothub.DataAzurermIothubTimeouts")]
    public interface IDataAzurermIothubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#read DataAzurermIothub#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermIothubTimeouts), fullyQualifiedName: "azurerm.dataAzurermIothub.DataAzurermIothubTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermIothub.IDataAzurermIothubTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#read DataAzurermIothub#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
