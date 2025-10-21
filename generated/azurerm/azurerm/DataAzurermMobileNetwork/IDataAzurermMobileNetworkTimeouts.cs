using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetwork
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetwork.DataAzurermMobileNetworkTimeouts")]
    public interface IDataAzurermMobileNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network#read DataAzurermMobileNetwork#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetwork.DataAzurermMobileNetworkTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetwork.IDataAzurermMobileNetworkTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network#read DataAzurermMobileNetwork#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
