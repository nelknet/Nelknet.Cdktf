using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkDataNetwork
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkDataNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetworkTimeouts")]
    public interface IDataAzurermMobileNetworkDataNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#read DataAzurermMobileNetworkDataNetwork#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkDataNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkDataNetwork.DataAzurermMobileNetworkDataNetworkTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetworkDataNetwork.IDataAzurermMobileNetworkDataNetworkTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_data_network#read DataAzurermMobileNetworkDataNetwork#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
